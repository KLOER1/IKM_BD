using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class CreateSong
    {
        [Required(ErrorMessage = "Введите название песни")]
        [MinLength(1, ErrorMessage = "Длина не должна быть равна нулю")]
        public string Title { get; set; } = null!;

        [Range(1, 32767, ErrorMessage = "Продолжительность должна быть в диапазоне [1; 65535]")]
        public short Duration { get; set; }

        public string Explicit { get; set; } = null!;

        public int IdAlbum { get; set; }
    }
}
