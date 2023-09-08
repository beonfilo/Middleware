using Beon.MyBeon.Middleware.DataStores;
using Beon.MyBeon.Middleware.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net.Http;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //services.AddSingleton<IHttpClientFactory>();
        services.AddTransient<IAuthenticationService,AuthenticationDataStore>();
        services.AddTransient<ICustomerService,CustomerDataStore>();



    })
    .Build();

ExemplifyServiceLifetime(host.Services);

await host.RunAsync();
static async void ExemplifyServiceLifetime(IServiceProvider hostProvider)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    
    IAuthenticationService authenticationService = provider.GetRequiredService<IAuthenticationService>();
    ICustomerService customerService = provider.GetRequiredService<ICustomerService>();

    var httpClient =new HttpClient();
    httpClient.BaseAddress = new Uri("http://5.250.254.202:1196");

    var result = await authenticationService.Authenticate(httpClient, "Admin", "1673");
    if (result.IsSuccess)
    {
        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.Data.Token);
        var customer = await customerService.GetObjects(httpClient);
    }
   

    Console.WriteLine(result.Data.Token);
}