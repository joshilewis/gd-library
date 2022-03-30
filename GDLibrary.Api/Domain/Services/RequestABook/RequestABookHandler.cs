using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Domain.Services.RequestABook
{
    public class RequestABookHandler
    {
        private readonly IGetBookByTitle getBookByTitle;

        public RequestABookHandler(IGetBookByTitle getBookByTitle)
        {
            this.getBookByTitle = getBookByTitle;
        }

        public Result Execute(RequestABookCommand command)
        {
            Book? book = getBookByTitle.Execute(command.Title);
            if (book == null)
            {
                return new Result($"No book with title {command.Title} found.");
            }

            return null;
        }
    }

    public interface IGetRequestByTitle
    {
        Request Execute(string title);
    }
}
