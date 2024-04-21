using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("RecipeIngredient")]
    public class RecipeIngredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int recipeId { get; set; }
        public int ingredientId { get; set; }
        public int amount { get; set; }
        [ForeignKey("recipeId")]
        public virtual Recipe Recipe { get; set; }
        [ForeignKey("ingredientId")]
        public virtual Ingredient Ingredient { get; set; }
    }
}
