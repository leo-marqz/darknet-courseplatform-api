
namespace DarkNetCoursePlatform.Domain.Models
{
    public class Price : BaseEntity
    {
        public string Name { get; set; } // e.g. "Standard", "Premium"
        public decimal CurrentPrice { get; set; } // Regular price
        public decimal PromotionalPrice { get; set; } // Discounted price
    }
}