using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Data
{
    public class GetBookByTitle : IGetBookByTitle
    {
        private readonly BooksContext context;

        public GetBookByTitle(BooksContext context)
        {
            this.context = context;
        }

        public Book? Execute(string title)
        {
            return context.Books.SingleOrDefault(x => x.Title == title);
        }
    }
}
