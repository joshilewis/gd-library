using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Domain.Services.RequestABook
{
    public class RequestABookHandler
    {
        private readonly IGetBookByTitle getBookByTitle;
        private readonly IGetActiveRequestsByTitle getActiveRequestsByTitle;
        private readonly IAddRequest saveRequest;

        public RequestABookHandler(IGetBookByTitle getBookByTitle, IGetActiveRequestsByTitle getActiveRequestsByTitle, IAddRequest saveRequest)
        {
            this.getBookByTitle = getBookByTitle;
            this.getActiveRequestsByTitle = getActiveRequestsByTitle;
            this.saveRequest = saveRequest;
        }

        public Result Execute(RequestABookCommand command)
        {
            Book? book = getBookByTitle.Execute(command.Title);
            if (book == null)
            {
                return new Result($"No book with title {command.Title} found.");
            }

            IEnumerable<Request> activeRequests = getActiveRequestsByTitle.Execute(command.Title);
            if (activeRequests.Any())
            {
                return new RequestABookResult(book.Id, false, book.Title, DateTime.Now);
            }

            var newRequest = new Request(book, command.Email);
            saveRequest.Execute(newRequest);

            return new RequestABookResult(book.Id, true, book.Title, newRequest.TimeStamp);
        }
    }

}
