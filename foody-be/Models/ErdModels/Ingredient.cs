using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("Ingredient")]
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int ingredientTypeId { get; set; }
        public int nutritionId { get; set; }
        public string name { get; set; }
        [Column(TypeName = "text")]
        public string image {  get; set; }
        public bool isLiquid { get; set; }
        [ForeignKey("ingredientTypeId")]
        public virtual IngredientType IngredientType { get; set;}
        [ForeignKey("nutritionId")]
        public virtual Nutrition Nutrition { get; set; }
        public virtual ICollection<Recipe> Recipe { get; set; }
    }
}
