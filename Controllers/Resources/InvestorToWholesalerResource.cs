using Veeya.Models;

namespace Veeya.Controllers.Resources
{
    public class InvestorToWholesalerResource
    {
        public int InvestorId { get; set; }
        public Investor Investor { get; set; }
        public int WholesalerId { get; set; }
        public Wholesaler Wholesaler { get; set; }
    }
}