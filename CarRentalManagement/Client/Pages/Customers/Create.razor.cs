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

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }
        Customer customer = new Customer();

        private async Task CreateCustomer()
        {
            await _client.PostAsJsonAsync(Endpoints.CustomersEndpoint, customer);
            _navManager.NavigateTo("/customers/");
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
