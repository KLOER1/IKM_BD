using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class UpdateAuthor
    {
        [ValidateNever]
        public int Id { get; set; }

        [Range(0,int.MaxValue, ErrorMessage = "Укажители количество слушателей")]
        public int Listners { get; set; }

        [Required(ErrorMessage = "Введите псевдиним автора")]
        [MinLength(1, ErrorMessage = "Длина не должна быть равна нулю")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Введите описание")]
        [MinLength(1, ErrorMessage = "Длина не должна быть равна нулю")]
        public string Description { get; set; } = null!;

        public UpdateAuthor() { }

        public UpdateAuthor(int Id) 
        {
            this.Id = Id;
        }
    }
}
