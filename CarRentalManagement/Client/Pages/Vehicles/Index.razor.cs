using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using CarRentalManagement.Client.Contracts;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index 
    {
       [Inject] IHttpRepository<Vehicle> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Vehicle> Vehicles;
        protected async override Task OnInitializedAsync()
        {
            Vehicles = await _client.GetAll($"{Endpoints.VehiclesEndpoint}");
        }

        async Task Delete(int vehicleId)
        {
            var vehicle = Vehicles.First(q => q.Id == vehicleId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {vehicle.Vin}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.VehiclesEndpoint, vehicleId);
                await OnInitializedAsync();
            }
        }
       
    }
}
