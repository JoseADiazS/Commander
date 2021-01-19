using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command {

        [Key]
        public int Id { get; set; }
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Plataform { get; set; }

        //31:05
    }
}