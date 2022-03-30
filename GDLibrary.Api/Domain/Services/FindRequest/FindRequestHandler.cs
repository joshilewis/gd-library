using GDLibrary.Api.Domain.Model;
using GDLibrary.Api.Domain.Queries;

namespace GDLibrary.Api.Domain.Services.FindRequest
{
    public class FindRequestHandler
    {
        private readonly IGetActiveRequestByBookId getActiveRequestByBookId;

        public FindRequestHandler(IGetActiveRequestByBookId getActiveRequestByBookId)
        {
            this.getActiveRequestByBookId = getActiveRequestByBookId;
        }

        public Result Execute(FindRequestQuery query)
        {
            return new FindRequestResult(getActiveRequestByBookId.Execute(query.RequestId));
        }
    }
}
