using Beon.MyBeon.Middleware.DataStores;
using Beon.MyBeon.Middleware.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json.Nodes;

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
        services.AddTransient<IApplicationUserService, ApplicationUserDataStore>();


    })
    .Build();

ExemplifyServiceLifetime(host.Services);

await host.RunAsync();
static async void ExemplifyServiceLifetime(IServiceProvider hostProvider)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    
    IAuthenticationService authenticationService = provider.GetRequiredService<IAuthenticationService>();
    IApplicationUserService applicationUserService = provider.GetRequiredService<IApplicationUserService>();

    var httpClient =new HttpClient();
    httpClient.BaseAddress = new Uri("http://10.130.145.11:1190");

    var result = await authenticationService.Authenticate(httpClient, "Admin", "1673");
    if (result.IsSuccess)
    {
        Guid id = new Guid("f6c53ae1-599e-4211-8e0a-41b23e795c5d");
        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.Data.Token);
        string json = @"
{
  ""FirstName"": ""Tayfun"",
  ""LastName"": ""Yaldız"",
  ""Telephone"": ""(555) 555-5555"",
  ""WebAddress"": ""https://example.com""
}";
        var postvalue = string.IsNullOrEmpty(json) ? null : JsonObject.Parse(json);
        Guid oid = new Guid("2f59056c-9606-42b3-b054-638c9cb81b3f");
        var response = await applicationUserService.PatchObject(httpClient, postvalue, oid);
        if (response.IsSuccess)
        {
            var user = await applicationUserService.GetObjects(httpClient, $"?$filter= Oid eq 2f59056c-9606-42b3-b054-638c9cb81b3f");
            Debug.Write(user.Data.FirstOrDefault().FirstName);
        }

    }
   

}