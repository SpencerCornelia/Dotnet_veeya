using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veeya.Models
{
    [Table("Investors")]
    public class Investor
    {
        // need to go back through the tutorial for moving Models to Controllers/Resources
        // enter into MappingProfile.cs as well
        public int id { get; set; }
        
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
    }
}