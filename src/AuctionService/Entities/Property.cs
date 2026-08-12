namespace AuctionService.Entities
{
    public class Property
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public string State { get; set; }

        public string City { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public decimal StartingPrice { get; set; }

        public decimal AreaSqFt { get; set; }
         
        public Guid Auctionid { get; set; }

        public Auction? Auction { get; set; }
    }
}
