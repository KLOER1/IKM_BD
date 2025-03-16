using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class CreateAlbum
    {
        [Required(ErrorMessage = "Введите название альбома")]
        [MinLength(1, ErrorMessage = "Длина не должна быть равна нулю")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Введите дату релиза")]
        [DateValidationModel(ErrorMessage = "Введите существующую дату")]
        public string ReleaseDate { get; set; } = null!;
    }
}
