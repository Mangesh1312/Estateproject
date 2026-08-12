namespace AuctionService.Entities
{
    public class Auction
    {
        public Guid Id { get; set; }
        public decimal ReservePrice { get; set; }

        public decimal CurrentHighBid { get; set; }

        public decimal SoldAmount { get; set; }

        public string Seller { get; set; }

        public string? Winner { get; set; }


        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime AuctionEnd { get; set; }

        public AuctionStatus Status { get; set; }   

        public Property Property { get; set; }
    }
}
