namespace BasicDependencyInjectionWithDependencyInversion.Services
{
    public interface IBookAuthoringService
    {
        string GetBookTitle();

        string GetAuthorName();
    }
}