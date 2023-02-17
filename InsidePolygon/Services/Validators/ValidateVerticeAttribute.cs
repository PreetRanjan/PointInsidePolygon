using InsidePolygon.Models;
using System.ComponentModel.DataAnnotations;

namespace InsidePolygon.Services.Validators
{

    public class ValidateVerticeAttribute : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var polygon = value as Point[];
            if (polygon == null)
            {
                return new ValidationResult("Please specify a valid polygon");
            }
            return polygon.Length < 3 ? new ValidationResult("Polygon should have 3 or more vertices.") : ValidationResult.Success;
        }
    }
}
