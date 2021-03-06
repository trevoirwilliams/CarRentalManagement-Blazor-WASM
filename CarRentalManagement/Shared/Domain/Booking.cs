using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}