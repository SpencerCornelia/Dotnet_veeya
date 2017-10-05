using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Veeya.Controllers.Resources
{
    public class WholesalerResource
    {
        public int WholesalerId { get; set; }
        [Required]
        [StringLength(255)]        
        public string First_Name { get; set; }
        
        public ICollection<SavePropertyResource> Properties { get; set; }

        public WholesalerResource() 
        {
            Properties = new Collection<SavePropertyResource>();
        }
    }
}