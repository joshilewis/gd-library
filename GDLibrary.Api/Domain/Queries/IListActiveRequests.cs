using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Queries;

public interface IListActiveRequests
{
    IEnumerable<Request> Execute();
}