namespace BasicServiceDependencyInjection.Repositories
{
    public interface IBookAuthoringRepository
    {
        string GetBookTitle();

        string GetAuthorName();
    }
}