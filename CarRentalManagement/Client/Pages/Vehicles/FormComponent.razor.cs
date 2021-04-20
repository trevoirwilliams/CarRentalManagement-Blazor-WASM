using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class FormComponent
    {
        private IList<Make> Makes;
        private IList<Model> Models;
        private IList<Colour> Colours;
        string UploadFileWarning;

        protected async override Task OnInitializedAsync()
        {
            Models = await _clientModels.GetAll(Endpoints.ModelsEndpoint);
            Colours = await _clientColors.GetAll(Endpoints.ColoursEndpoint);
            Makes = await _clientMakes.GetAll(Endpoints.MakesEndpoint);
        }

        private async void HandleFileSelection(InputFileChangeEventArgs e)
        {
            var file = e.File;
            if (file != null)
            {
                var ext = System.IO.Path.GetExtension(file.Name);
                if (ext.ToLower().Contains("jpg")
                    || ext.ToLower().Contains("png")
                    || ext.ToLower().Contains("jpeg"))
                {
                    var picId = Guid.NewGuid().ToString().Replace("-", "");
                    vehicle.ImageName = $"{picId}{ext}";
                    vehicle.Image = new byte[file.Size];
                    await file.OpenReadStream().ReadAsync(vehicle.Image);
                    UploadFileWarning = string.Empty;
                }
                else
                {
                    UploadFileWarning = "Please select a valid image file (*.jpg | *.png)";
                }
            }
        }

        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public Vehicle vehicle { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Inject] IHttpRepository<Make> _clientMakes { get; set; }
        [Inject] IHttpRepository<Colour> _clientColors { get; set; }
        [Inject] IHttpRepository<Model> _clientModels { get; set; }
    }
}
