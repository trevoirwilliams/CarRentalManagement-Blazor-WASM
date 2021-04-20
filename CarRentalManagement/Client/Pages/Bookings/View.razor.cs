using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class View
    {
        [Parameter] public int id { get; set; }
        [Inject] IHttpRepository<Booking> _client { get; set; }

        Booking booking = new Booking();

        protected async override Task OnParametersSetAsync()
        {
            booking = await _client.Get(Endpoints.BookingsEndpoint, id);
        }
    }
}
