using System.ComponentModel.DataAnnotations;

namespace GDLibrary.Api.Domain.Services.FindRequest
{
    public class FindRequestQuery
    {
        [Required]
        public int RequestId { get; }

        public FindRequestQuery(int requestId)
        {
            RequestId = requestId;
        }
    }
}
