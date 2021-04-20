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

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Index 
    {
       [Inject] IHttpRepository<Make> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Make> Makes;

        protected async override Task OnInitializedAsync()
        {
            Makes = await _client.GetAll(Endpoints.MakesEndpoint);
        }

        async Task Delete(int makeId)
        {
            var make = Makes.First(q => q.Id == makeId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {make.Name}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.MakesEndpoint,makeId);
                await OnInitializedAsync();
            }

        }
       
    }
}
