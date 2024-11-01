﻿using Beon.MyBeon.Middleware.DataStores;
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
	IVehicleViewService vehicleViewService = provider.GetRequiredService<IVehicleViewService>();
    ITollFeeService tollFeeService = provider.GetRequiredService<ITollFeeService>();

    var httpClient = new HttpClient();
    httpClient.BaseAddress = new Uri("http://10.130.145.11:1190");

    var result = await authenticationService.Authenticate(httpClient, "Admin", "1673");
    if (result.IsSuccess)
	{
		httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.Data.Token);

		var vehicleResult = await vehicleViewService.GetObjects(httpClient, "?$top=1");

	}

}