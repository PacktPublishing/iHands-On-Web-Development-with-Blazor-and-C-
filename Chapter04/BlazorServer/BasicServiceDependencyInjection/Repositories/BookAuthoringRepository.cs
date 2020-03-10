namespace BasicServiceDependencyInjection.Repositories
{
    public class BookAuthoringRepository : IBookAuthoringRepository
    {
        private string bookTitle;
        private string author;

        public BookAuthoringRepository()
        {
            this.bookTitle = "Hands-on Blazor";
            this.author = "Adrien Torris";
        }

        public string GetBookTitle() => this.bookTitle;

        public string GetAuthorName() => this.author;
    }
}