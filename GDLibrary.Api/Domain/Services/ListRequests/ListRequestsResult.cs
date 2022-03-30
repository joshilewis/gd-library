using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Services.ListRequests
{
    public class ListRequestsResult : Result
    {
        public IEnumerable<Request> Requests { get; }

        public ListRequestsResult(IEnumerable<Request> requests)
        {
            Requests = requests;
        }

    }
}
