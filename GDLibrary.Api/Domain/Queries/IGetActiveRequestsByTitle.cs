using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Queries
{
    public interface IGetActiveRequestsByTitle
    {
        IEnumerable<Request> Execute(string title);
    }
}
