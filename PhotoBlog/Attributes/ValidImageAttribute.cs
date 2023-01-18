using System.ComponentModel.DataAnnotations;

namespace PhotoBlog.Attributes
{
    public class ValidImageAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            IFormFile? photo = value as IFormFile;

            if (photo == null)
                return ValidationResult.Success;

            if (!photo.ContentType.StartsWith("image/"))
                return new ValidationResult("Invalid image format");
            else if (photo.Length > 1 * 1024 * 1024)
                return new ValidationResult("Max file size must be 1MB.");

            return ValidationResult.Success;
        }
    }
}
