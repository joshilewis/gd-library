using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Data;

public class GetActiveRequestsByTitle : IGetActiveRequestsByTitle
{
    private readonly BooksContext context;

    public GetActiveRequestsByTitle(BooksContext context)
    {
        this.context = context;
    }

    public IEnumerable<Request> Execute(string title)
    {
        return context.Requests.Where(x => x.Active);
    }
}