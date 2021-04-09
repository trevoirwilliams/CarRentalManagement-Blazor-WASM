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
    public partial class Index : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Customer> Customers;

        protected async override Task OnInitializedAsync()
        {
            Customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoints.CustomersEndpoint}");
        }

        async Task Delete(int customerId)
        {
            var customer = Customers.First(q => q.Id == customerId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.TaxId}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.CustomersEndpoint}/{customerId}");
                await OnInitializedAsync();
            }

        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
