namespace BasicDependencyInjectionWithDependencyInversion.Services
{
    public class BookAuthoringService : IBookAuthoringService
    {
        public BookAuthoringService()
        {

        }

        public string GetBookTitle() => "Hands-on Blazor";

        public string GetAuthorName() => "Adrien Torris";
    }
}