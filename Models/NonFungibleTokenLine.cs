using System.ComponentModel.DataAnnotations.Schema;

namespace MyNFTTracker.Models
{
    public class NonFungibleTokenLine
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(9, 8)")] public decimal BuyingPrice { get; set; }
        public DateTime BuyingDate { get; set; }
        public bool Sold { get; set; }
        [Column(TypeName = "decimal(9, 8)")] public decimal? SellingPrice { get; set; }
        public DateTime? SellingDate { get; set; }
        public string? UsedTool { get; set; }
        public bool Simulation { get; set; } = false;
        public string? Comment { get; set; }
        public NonFungibleToken NonFungibleToken { get; set; } = null!;
        public AppUser User { get; set; } = null!;
    }
}
