using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication2.Models
{
    public class DateValidationModel : ValidationAttribute
    {
        public override bool IsValid(object? value) => DateOnly.TryParse(value as string, out _);
    }
}
