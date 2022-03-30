using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;
using Microsoft.EntityFrameworkCore;

namespace GDLibrary.Api.Data
{
    public class ListActiveRequests : IListActiveRequests
    {
        private readonly BooksContext context;

        public ListActiveRequests(BooksContext context)
        {
            this.context = context;
        }


        public IEnumerable<Request> Execute()
        {
            return context.Requests
                .Where(x => x.Active)
                .Include(x => x.Book)
                ;
        }
    }
}
