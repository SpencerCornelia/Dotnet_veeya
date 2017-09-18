using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veeya.Models
{
    [Table("Investors")]
    public class Investor
    {
        public int id { get; set; }
        
        [Required]
        [StringLength(255)]        
        public string First_Name { get; set; }

    }
}