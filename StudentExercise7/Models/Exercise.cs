using System.ComponentModel.DataAnnotations;

namespace StudentExercise6.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Language { get; set; }
    }
}
