using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veeya.Models
{
    public class Wholesaler
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string First_Name { get; set; }
        
        public ICollection<Property> Properties { get; set; }

        public ICollection<Investor> Investors { get; set; }

        public Wholesaler() 
        {
            Properties = new Collection<Property>();
            Investors = new Collection<Investor>();
        }
    }
}