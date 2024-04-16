using foody_be.ConstValue;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks.Dataflow;

namespace foody_be.Models.ErdModels
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string uid {  get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public ActivityType activity {  get; set; }
        public string avatar { get; set; }
        [Column(TypeName = "text")]
        public string description { get; set; }
        public int createAt { get; set; }
        public StatusType status { get; set; }
    }
}
