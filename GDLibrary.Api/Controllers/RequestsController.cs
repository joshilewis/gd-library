using GDLibrary.Api.Domain;
using GDLibrary.Api.Domain.Services.DeleteARequest;
using GDLibrary.Api.Domain.Services.FindRequest;
using GDLibrary.Api.Domain.Services.ListRequests;
using GDLibrary.Api.Domain.Services.RequestABook;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GDLibrary.Api.Controllers
{
    [Route("api/request")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly RequestABookHandler requestABookHandler;
        private readonly DeleteRequestHandler deleteRequestHandler;
        private readonly ListRequestsHandler listRequestsHandler;
        private readonly FindRequestHandler findRequestHandler;

        public RequestsController(RequestABookHandler requestABookHandler, DeleteRequestHandler deleteRequestHandler, 
            ListRequestsHandler listRequestsHandler, FindRequestHandler findRequestHandler)
        {
            this.requestABookHandler = requestABookHandler;
            this.deleteRequestHandler = deleteRequestHandler;
            this.listRequestsHandler = listRequestsHandler;
            this.findRequestHandler = findRequestHandler;
        }

        [HttpGet]
        public Result Index()
        {
            return listRequestsHandler.Execute(new ListRequestsQuery());
        }

        [HttpGet, Route("{requestId}")]
        public Result GetRequest(int requestId)
        {
            return findRequestHandler.Execute(new FindRequestQuery(requestId));
        }

        [HttpPost]
        public Result RequestABook(RequestABookCommand command)
        {
            return requestABookHandler.Execute(command);
        }

        [HttpDelete]
        public void DeleteARequest(DeleteRequestCommand command)
        {
            deleteRequestHandler.Execute(command);
        }
    }
}
