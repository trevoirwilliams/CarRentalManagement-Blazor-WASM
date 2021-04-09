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

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Edit : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Colour colour = new Colour();

        protected async override Task OnParametersSetAsync()
        {
            colour = await _client.GetFromJsonAsync<Colour>($"{Endpoints.ColoursEndpoint}/{id}");
        }

        async Task EditColour()
        {
            await _client.PutAsJsonAsync($"{Endpoints.ColoursEndpoint}/{id}", colour);
            _navManager.NavigateTo("/colours/");
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }

    }
}
