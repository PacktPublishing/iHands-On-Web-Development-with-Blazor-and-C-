namespace BasicForm.Model
{
    using System.ComponentModel.DataAnnotations;

    public enum BookType
    {
        [Display(Name = "Printed book")]
        Printed = 1,
        [Display(Name = "e-Book")]
        Ebook = 2,
        [Display(Name = "Printed & e-Book")]
        Both = 3
    }
}