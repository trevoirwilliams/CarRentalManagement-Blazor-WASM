using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using CarRentalManagement.Client.Contracts;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Edit 
    {
       [Inject] IHttpRepository<Vehicle> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Vehicle vehicle = new Vehicle();

        protected async override Task OnParametersSetAsync()
        {
            vehicle = await _client.Get(Endpoints.VehiclesEndpoint,id);
        }

        async Task EditVehicle()
        {
            await _client.Update(Endpoints.VehiclesEndpoint, vehicle,id);
            _navManager.NavigateTo("/vehicles/");
        }
      
    }
}
