namespace BasicForm.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        [Required]
        [MinLength(3), MaxLength(80)]
        public string Title { get; set; }

        [Required(ErrorMessage = "The publication date is required.")]
        [Display(Name = "Publication date", ShortName = "Pub. date")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        [Range(typeof(DateTime), "1/1/1980", "1/1/2021", ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public DateTime Published { get; set; } = DateTime.Now;

        [StringLength(240, ErrorMessage = "The description is too long (240 charachers).")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Enter a description about the book")]
        public string Description { get; set; }

        [Required]
        [Range(10, 1000, ErrorMessage = "The number of pages must be between {1} and {2}.")]
        public int PageCount { get; set; }

        [Display(Name = "Author's name")]
        [Required(ErrorMessage = "Please fill the name of the author.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,80}$")]
        public string AuthorName { get; set; }

        [Display(Name = "Price (in dollars)", ShortName = "Price")]
        [Required]
        [Range(5, 150, ErrorMessage = "The {0} must be between ${1} and ${2}.")]
        [DisplayFormat(DataFormatString="{0:C}", ApplyFormatInEditMode=true)]
        public double Price { get; set; }

        [Required]
        public string CategoryId { get; set; }

        // The required attribute is not very useful here because by default the value is 0 so it's not empty.
        // This attribute would be more useful with a nullable property but Blazor doesn't support properties of type Nullable<Enum> yet,
        // this feature request is tracked on the issue #13624 on GitHub: https://github.com/dotnet/aspnetcore/issues/13624
        [Required]
        public BookType BookType { get; set; } = BookType.Printed;

        public Language Language{ get; set; } = Language.English;

        public bool IsCurrentlyInReview { get; set; }

        public Book()
        { }
    }
}