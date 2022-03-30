using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Data
{
    public class FindRequestById : IFindRequestById
    {
        private readonly BooksContext booksContext;

        public FindRequestById(BooksContext booksContext)
        {
            this.booksContext = booksContext;
        }

        public Request? Execute(int id)
        {
            return booksContext.Requests.SingleOrDefault(x => x.Active && x.Id == id);
        }
    }
}
