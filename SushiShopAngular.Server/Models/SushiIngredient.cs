using System.ComponentModel.DataAnnotations;

namespace SushiShopAngular.Server.Models
{
    public class SushiIngredient
    {
        public int SushiId { get; set; }
        public int IngredientId { get; set; }
        public int Amount { get; set; }
        public virtual Sushi? Sushi { get; set; }
        public virtual Ingredient? Ingredient { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
