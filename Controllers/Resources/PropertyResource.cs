namespace Veeya.Controllers.Resources
{
    public class PropertyResource
    {
        public int PropertyId { get; set; }
        public string AddressName { get; set; }
        public WholesalerResource Wholesaler { get; set; }
        // Mosth removed ModelId in the example
        //public int WholesalerId { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int PurchasePrice { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int RehabCostMin { get; set; }
        public int RehabCostMax { get; set; }
        public int AfterRepairValue { get; set; }
        public int AverageRent { get; set; }
        public int SquareFootage { get; set; }
        public string PropertyType { get; set; }
        public int YearBuilt { get; set; }
    }
}