using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string userId { get; set; }
        public string name { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        public int dayPlanLenght { get; set; }
        public int createAt { get; set; }
        public bool isPublic { get; set; }
        public int nutritionId { get; set; }

    }
}
