using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Data
{
    public class UpdateRequest : IUpdateRequest
    {
        private readonly BooksContext context;

        public UpdateRequest(BooksContext context)
        {
            this.context = context;
        }

        public void Execute(Request request)
        {
            context.SaveChanges();
        }
    }
}
