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

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Edit : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Model model = new Model();

        protected async override Task OnParametersSetAsync()
        {
            model = await _client.GetFromJsonAsync<Model>($"{Endpoints.ModelsEndpoint}/{id}");
        }

        async Task EditModel()
        {
            await _client.PutAsJsonAsync($"{Endpoints.ModelsEndpoint}/{id}", model);
            _navManager.NavigateTo("/models/");
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
