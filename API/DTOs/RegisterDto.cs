using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(12)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}