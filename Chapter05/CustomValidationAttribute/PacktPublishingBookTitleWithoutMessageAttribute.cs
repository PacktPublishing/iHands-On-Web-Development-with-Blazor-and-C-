using System;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationAttribute
{
    /// <summary>
    /// Custom attribute to validate a Packt Publishing book's title.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class PacktPublishingBookTitleWithoutMessageAttribute : ValidationAttribute
    {
        public PacktPublishingBookTitleWithoutMessageAttribute()
        { }

        private const string requiredTitlePart = "Packt Publishing: ";

        private const int maximumLength = 80;

        private string GetContentErrorMessage() =>
            $"The title of the book must start with '{requiredTitlePart}' and contains some text behind.";

        public override bool IsValid(object value)
        {
            if(value == null)
            {
                return false;
            }

            //var book = (Book)validationContext.ObjectInstance;
            string title = (string)value;

            if (string.IsNullOrWhiteSpace(title))
            {
                return false;
            }

            if(!title.StartsWith(requiredTitlePart)
            || title == requiredTitlePart)
            {
                return false;
            }

            if(title.Length <= requiredTitlePart.Length || title.Length > maximumLength)
            {
                return false;
            }

            return true;
        }
    }
}