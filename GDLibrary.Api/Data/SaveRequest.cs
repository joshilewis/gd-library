using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Data
{
    public class SaveRequest : ISaveRequest
    {
        private readonly BooksContext context;

        public SaveRequest(BooksContext context)
        {
            this.context = context;
        }

        public void Execute(Request request)
        {
            context.Requests.Add(request);
            context.SaveChanges();
        }
    }
}
