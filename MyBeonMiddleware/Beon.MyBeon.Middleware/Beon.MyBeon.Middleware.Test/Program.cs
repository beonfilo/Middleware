using Beon.MyBeon.Middleware.DataStores;
using Beon.MyBeon.Middleware.DTOs;
using Beon.MyBeon.Middleware.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;

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
        services.AddTransient<IVehicleViewService,VehicleViewDataStore>();
        services.AddTransient<IMaintenanceDemandService, MaintenanceDemandDataStore>();
        services.AddTransient<ITollFeeService, TollFeeDataStore>();
		services.AddTransient<IVehicleViewService, VehicleViewDataStore>();
		services.AddTransient<IVehicleUserService, VehicleUserDataStore>();






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
	IVehicleUserService vehicleViewService = provider.GetRequiredService<IVehicleUserService>();
    ITollFeeService tollFeeService = provider.GetRequiredService<ITollFeeService>();

    var httpClient = new HttpClient();
    httpClient.BaseAddress = new Uri("http://10.130.145.11:1190");

    var result = await authenticationService.Authenticate(httpClient, "Admin", "1673");
    if (result.IsSuccess)
	{
		httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.Data.Token);

		VehicleUserInsertModel vehicleUserInsertModel = new VehicleUserInsertModel();
        vehicleUserInsertModel.Name = "test";
        vehicleUserInsertModel.Lastname = "test";
        vehicleUserInsertModel.Address = "test adres";
        vehicleUserInsertModel.AuthorizedPerson = null;
        
		var vehicleResult = await vehicleViewService.InsertObject(httpClient, vehicleUserInsertModel);
        if (vehicleResult.IsSuccess)
        {
            Console.Write(vehicleResult.Data);
        }

	}

}

public class VehicleUserInsertModel
{
	public Guid Vehicle { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Lastname { get; set; } = string.Empty;
	public string Position { get; set; } = string.Empty;
	public string Telephone { get; set; } = string.Empty;
	public string OtherTelephone { get; set; } = string.Empty;
	public string EMail { get; set; } = string.Empty;
	public string? TCKN { get; set; }
	public string Address { get; set; } = string.Empty;
	public string? AuthorizedPerson { get; set; }
	public Guid Country { get; set; }
	public Guid City { get; set; }
	public Guid County { get; set; }
	public Guid Customer { get; set; }
}
