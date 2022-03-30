using GDLibrary.Api.Domain.Model;

namespace GDLibrary.Api.Domain.Services.FindRequest
{
    public class FindRequestResult : Result
    {
        public Request? Request { get; }

        protected FindRequestResult()
        {
            
        }

        public FindRequestResult(Request? request)
        {
            Request = request;
        }
    }
}
