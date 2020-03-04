namespace BasicDependencyInjectionWithDependencyInversion.Services
{
    public interface IBookAuthoringService
    {
        void Initialize();

        string GetBookTitle();

        string GetAuthorName();
    }
}