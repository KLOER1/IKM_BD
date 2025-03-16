using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class CreateAuthor
    {
        [Required(ErrorMessage = "Введите псевдиним автора")]
        [MinLength(1, ErrorMessage = "Длина не должна быть равна нулю")]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";
    }
}
