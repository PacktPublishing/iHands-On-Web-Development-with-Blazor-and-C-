namespace BasicDependencyInjectionWithDependencyInversion.Services
{
    public class BookAuthoringService : IBookAuthoringService
    {
        private string bookTitle;
        private string authorName;

        public BookAuthoringService()
        {
            
        }

        public void Initialize()
        {
            this.authorName = "Adrien Torris";
            this.bookTitle = "Hands-on Blazor";
        }

        public string GetBookTitle() => this.bookTitle;

        public string GetAuthorName() => this.authorName;
    }
}