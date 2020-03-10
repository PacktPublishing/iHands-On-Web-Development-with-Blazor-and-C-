using BasicServiceDependencyInjection.Repositories;
using System;

namespace BasicServiceDependencyInjection.Services
{
    public class BookAuthoringService : IBookAuthoringService
    {
        private readonly IBookAuthoringRepository bookAuthoringRepository;

        public BookAuthoringService(IBookAuthoringRepository bookAuthoringRepository)
        {
            this.bookAuthoringRepository = bookAuthoringRepository ?? throw new ArgumentNullException(nameof(bookAuthoringRepository));
        }

        public string GetBookTitle()
        {
            return this.bookAuthoringRepository.GetBookTitle();
        }

        public string GetAuthorName() => this.bookAuthoringRepository.GetAuthorName();
    }
}