using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Veeya.Controllers.Resources
{
    public class InvestorResource
    {
        public int InvestorId { get; set; }
        
        [Required]
        [StringLength(255)]         
        public string First_Name { get; set; }

        [Required]
        [StringLength(255)]         
        public string Last_Name { get; set; }

        [Required]
        public string Email_Address { get; set; }
       
        [Required]
        public string Phone_Number { get; set; }

        public ICollection<WholesalerResource> Wholesalers { get; set; }

        public InvestorResource()
        {
            Wholesalers = new Collection<WholesalerResource>();
        }
    }
}