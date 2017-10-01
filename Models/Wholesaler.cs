using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veeya.Models
{
    [Table("Wholesalers")]
    public class Wholesaler
    {
        public int WholesalerId { get; set; }
        
        // here
        public virtual List<InvestorToWholesaler> InvestorToWholesalers { get; set; }

        [Required]
        [StringLength(255)]
        public string First_Name { get; set; }
        
        public ICollection<Property> Properties { get; set; }

        public ICollection<InvestorToWholesaler> Investors { get; } = new List<InvestorToWholesaler>();

        public Wholesaler() 
        {
            Properties = new Collection<Property>();
            Investors = new Collection<InvestorToWholesaler>();
        }
    }
}