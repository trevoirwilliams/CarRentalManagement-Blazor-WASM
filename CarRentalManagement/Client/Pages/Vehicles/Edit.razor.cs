using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Edit : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Vehicle vehicle = new Vehicle();

        protected async override Task OnParametersSetAsync()
        {
            vehicle = await _client.GetFromJsonAsync<Vehicle>($"{Endpoints.VehiclesEndpoint}/{id}");
        }

        async Task EditVehicle()
        {
            await _client.PutAsJsonAsync($"{Endpoints.VehiclesEndpoint}/{id}", vehicle);
            _navManager.NavigateTo("/vehicles/");
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
