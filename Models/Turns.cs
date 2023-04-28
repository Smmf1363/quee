using System.ComponentModel.DataAnnotations;

namespace smmf8quee.Models
{
    public class Turns
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? turnTaker { get; set; }
        [Required]
        public DateTime appointmentTime { get; set; } = DateTime.Now;
        public string? description { get; set; }
    }
}
