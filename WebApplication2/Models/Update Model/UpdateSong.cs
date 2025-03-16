using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class UpdateSong
    {
        [ValidateNever]
        public int IdSong { get; set; }

        [Required]
        public int IdAlbum { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Укажители количество прослушиваний")]
        public int Auditions { get; set; }

        [Required(ErrorMessage = "Введите название песни")]
        [MinLength(1, ErrorMessage = "Длина не должна быть равна нулю")]
        public string Title { get; set; } = null!;

        [ValidateNever]
        public short Duration { get; set; }

        [ValidateNever]
        public string? Explicit { get; set; }

        public UpdateSong() { }

        public UpdateSong(int Id)
        {
            this.IdSong = Id;
        }
    }
}
