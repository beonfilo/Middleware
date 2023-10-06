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
        services.AddTransient<IContractService, ContractDataStore>();
        services.AddTransient<IContractTransactionService, ContractTransactionDataStore>();
        services.AddTransient<IContractTransactionVehicleService, ContractTransactionVehicleDataStore>();
        services.AddTransient<ICountyService, CountyDataStore>();
        services.AddTransient<ICustomerContactService,CustomerContactDataStore>();
        services.AddTransient<IDepartmentService, DepartmentDataStore>();
        services.AddTransient<IPositionService, PositionDataStore>();

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
    httpClient.BaseAddress = new Uri("http://10.130.145.11:1189");

    var result = await authenticationService.Authenticate(httpClient, "Admin", "1673");
    if (result.IsSuccess)
    {
        Guid id = new Guid("f6c53ae1-599e-4211-8e0a-41b23e795c5d");
        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.Data.Token);
        var customer = await customerService.GetObject(httpClient, id);
    }
   

    Console.WriteLine(result.Data.Token);
}