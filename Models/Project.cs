using System.ComponentModel.DataAnnotations.Schema;

namespace MyNFTTracker.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Image { get; set; } = null!;
        public string? Twitter { get; set; }
        public string? Discord { get; set; }
        public string? Website { get; set; }
        [Column(TypeName = "decimal(9, 8)")] public decimal? FloorPrice { get; set; }
        public int? ListedCount { get; set; }
        [Column(TypeName = "decimal(9, 8)")] public decimal? AvgPrice24HrListedCount { get; set; }
        [Column(TypeName = "decimal(9, 8)")] public decimal? VolumeAll { get; set; }
        public string? StakingLink { get; set; }
        public string? WlTokenLink { get; set; }
        public string? TokenLink { get; set; }
        public DateTime CreationDate { get; set; }
        public List<NonFungibleToken>? NonFungibleTokens { get; set; }
        public List<OtherToken>? OtherTokens { get; set; }
    }
}
