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

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Create 
    {
        [Inject] IHttpRepository<Make> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Make make = new Make();

        private async Task CreateMake()
        {
            await _client.Create(Endpoints.MakesEndpoint, make);
            _navManager.NavigateTo("/makes/");
        }
        
    }
}
