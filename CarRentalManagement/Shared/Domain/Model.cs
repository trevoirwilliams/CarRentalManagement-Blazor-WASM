using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Model : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}
