using System.ComponentModel.DataAnnotations.Schema;

namespace MyNFTTracker.Models
{
    public class Balance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(9, 8)")] public decimal Amount { get; set; }
    }
}
