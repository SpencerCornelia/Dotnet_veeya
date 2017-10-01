using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Veeya.Models;

namespace Veeya.Controllers.Resources
{
    public class PropertyResource
    {
        public int PropertyId { get; set; }
        [Required]
        [StringLength(255)]
        public string AddressName { get; set; }
        [Required]
        public string WholesalerId { get; set; }
      
    }
}