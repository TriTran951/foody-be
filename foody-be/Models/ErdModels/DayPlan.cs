﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foody_be.Models.ErdModels
{
    [Table("DayPlan")]
    public class DayPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int order { get; set; }
        public int planId { get; set; }
        public int mealPlanLenght { get; set; }
        public int nutritionId { get; set; }

    }
}
