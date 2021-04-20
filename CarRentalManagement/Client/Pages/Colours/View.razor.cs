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
using CarRentalManagement.Client.Contracts;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class View
    {
        [Inject] IHttpRepository<Colour> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public int id { get; set; }
        Colour colour = new Colour();

        protected async override Task OnParametersSetAsync()
        {
            colour = await _client.Get(Endpoints.ColoursEndpoint, id);
        }
        
    }
}
