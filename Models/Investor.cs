using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veeya.Models
{
    [Table("Investors")]
    public class Investor
    {
        public int InvestorId { get; set; }
        public List<InvestorToWholesaler> InvestorToWholesalers { get; set; }
        
        [Required]
        [StringLength(255)] 
        public string First_Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Last_Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email_Address { get; set; }
       
        [Required]
        [Phone]
        public string Phone_Number { get; set; }

        public ICollection<Wholesaler> Wholesalers { get; set; }

        public Investor()
        {
            Wholesalers = new Collection<Wholesaler>();
        }

    }
}