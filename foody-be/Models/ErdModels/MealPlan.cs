using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("MealPlan")]
    public class MealPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int order { get; set; }
        public int dayPlanId { get; set; }
        public int startTime { get; set; }
        public int nutritionId { get; set; }
        public Nutrition nutrition { get; set; }
    }
}
