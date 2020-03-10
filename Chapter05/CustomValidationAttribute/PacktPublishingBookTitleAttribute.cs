using System;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationAttribute
{
    /// <summary>
    /// Custom attribute to validate a Packt Publishing book's title.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class PacktPublishingBookTitleAttribute : ValidationAttribute
    {
        public PacktPublishingBookTitleAttribute()
        { }

        private const string requiredTitlePart = "Packt Publishing: ";

        private const int maximumLength = 80;

        private string GetContentErrorMessage() =>
            $"The title of the book must start with '{requiredTitlePart}' and contains some text behind.";

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            if(value == null)
            {
return new ValidationResult("The title is required");
            }

            //var book = (Book)validationContext.ObjectInstance;
            string title = (string)value;

            if (string.IsNullOrWhiteSpace(title))
            {
                return new ValidationResult("The title is required");
            }

            if(!title.StartsWith(requiredTitlePart) || title == requiredTitlePart)
            {
                return new ValidationResult(GetContentErrorMessage());
            }

            if(title.Length <= requiredTitlePart.Length || title.Length > maximumLength)
            {
                return new ValidationResult($"The title must contains between {(requiredTitlePart.Length + 1)} and {maximumLength} characters");
            }

            return ValidationResult.Success;
        }
    }
}