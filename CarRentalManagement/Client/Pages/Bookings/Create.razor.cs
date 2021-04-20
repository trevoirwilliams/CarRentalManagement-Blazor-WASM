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
    public partial class Create
    {
        [Inject] IHttpRepository<Booking> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Booking booking = new Booking
        {
            DateOut = DateTime.Now.Date
        };

        private async Task CreateBooking()
        {
            await _client.Create(Endpoints.BookingsEndpoint, booking);
            _navManager.NavigateTo("/bookings/");
        }
    }
}
