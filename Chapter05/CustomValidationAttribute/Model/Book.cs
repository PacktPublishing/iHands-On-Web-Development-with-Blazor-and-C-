namespace CustomValidationAttribute.Model
{
    public class Book
    {
        [PacktPublishingBookTitle]
        public string Title { get; set; }
        
        [PacktPublishingBookTitleWithoutMessage(ErrorMessage = "The format of the title isn't valid")]
        public string Title2 { get; set; }

        public Book()
        { }
    }
}