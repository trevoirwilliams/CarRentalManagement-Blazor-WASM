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

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Index 
    {
       [Inject] IHttpRepository<Customer> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Customer> Customers;

        protected async override Task OnInitializedAsync()
        {
            Customers = await _client.GetAll(Endpoints.CustomersEndpoint);
        }

        async Task Delete(int customerId)
        {
            var customer = Customers.First(q => q.Id == customerId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.TaxId}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.CustomersEndpoint, customerId);
                await OnInitializedAsync();
            }

        }
       
    }
}
