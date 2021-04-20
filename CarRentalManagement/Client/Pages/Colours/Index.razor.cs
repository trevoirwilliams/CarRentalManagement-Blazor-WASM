using CarRentalManagement.Client.Contracts;
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
    public partial class Index
    {
        [Inject] IHttpRepository<Colour> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Colour> Colours;

        protected async override Task OnInitializedAsync()
        {
            Colours = await _client.GetAll(Endpoints.ColoursEndpoint);
        }

        async Task Delete(int colourId)
        {
            var colour = Colours.First(q => q.Id == colourId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {colour.Name}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.ColoursEndpoint, colourId);
                await OnInitializedAsync();
            }

        }

    }
}
