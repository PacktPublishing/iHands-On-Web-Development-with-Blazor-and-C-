namespace BasicDependencyInjection.Services
{
    public class BookAuthoringService
    {
        public BookAuthoringService()
        {

        }

        public string GetBookTitle() => "Hands-on Blazor";

        public string GetAuthorName() => "Adrien Torris";
    }
}