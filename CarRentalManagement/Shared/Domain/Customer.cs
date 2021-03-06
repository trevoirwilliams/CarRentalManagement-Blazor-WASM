using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "Enter Tax Id")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Tax Id does not meet length requirements")]
        public string TaxId { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}