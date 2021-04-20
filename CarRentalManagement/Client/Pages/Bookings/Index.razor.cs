using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index : IDisposable
    {
        private List<Booking> Bookings;
        [Inject] IHttpRepository<Booking> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Bookings = await _client.GetAll($"{Endpoints.BookingsEndpoint}");
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.InvokeVoidAsync("AddDataTable", "#bookingsTable");
        }

        public void Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#bookingsTable");
        }

        async Task Delete(int bookingsId)
        {
            var bookings = Bookings.First(q => q.Id == bookingsId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {bookings.Customer.TaxId}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.BookingsEndpoint, bookingsId);
                await OnInitializedAsync();
            }

        }
    }
}
