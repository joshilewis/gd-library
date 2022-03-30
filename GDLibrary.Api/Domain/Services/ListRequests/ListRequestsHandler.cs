using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Domain.Services.ListRequests
{
    public class ListRequestsHandler
    {
        private readonly IListActiveRequests listActiveRequests;

        public ListRequestsHandler(IListActiveRequests listActiveRequests)
        {
            this.listActiveRequests = listActiveRequests;
        }

        public ListRequestsResult Execute(ListRequestsQuery query)
        {
            var activeRequests = listActiveRequests.Execute();
            return new ListRequestsResult(activeRequests);
        }
    }
}
