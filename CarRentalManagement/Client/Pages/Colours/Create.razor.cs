using CarRentalManagement.Client.Services;
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

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Colour colour = new Colour();

        private async Task CreateColour()
        {
            _interceptor.MonitorEvent();
            await _client.PostAsJsonAsync(Endpoints.ColoursEndpoint, colour);
            _navManager.NavigateTo("/colours/");
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
