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
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Model model = new Model();

        private async Task CreateModel()
        {
            await _client.PostAsJsonAsync(Endpoints.ModelsEndpoint, model);
            _navManager.NavigateTo("/models/");
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
