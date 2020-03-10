namespace BasicDependencyInjectionUsingOwningComponentBase.Services
{
    public class BookService : IBookService
    {
        public BookService()
        {

        }
        
        public string GetTitle()
        {
            return "Hands-on Blazor";
        }
    }
}