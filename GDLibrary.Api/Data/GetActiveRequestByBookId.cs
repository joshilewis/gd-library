using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Data
{
    public class GetActiveRequestByBookId : IGetActiveRequestByBookId
    {
        private readonly BooksContext booksContext;

        public GetActiveRequestByBookId(BooksContext booksContext)
        {
            this.booksContext = booksContext;
        }

        public Request? Execute(int id)
        {
            return booksContext.Requests.SingleOrDefault(x => x.Active && x.Book.Id == id);
        }
    }
}
