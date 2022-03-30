using GDLibrary.Api.Domain;
using GDLibrary.Api.Domain.Services.DeleteARequest;
using GDLibrary.Api.Domain.Services.ListRequests;
using GDLibrary.Api.Domain.Services.RequestABook;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GDLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly RequestABookHandler requestABookHandler;
        private readonly DeleteRequestHandler deleteRequestHandler;
        private readonly ListRequestsHandler listRequestsHandler;

        public RequestsController(RequestABookHandler requestABookHandler, DeleteRequestHandler deleteRequestHandler, ListRequestsHandler listRequestsHandler)
        {
            this.requestABookHandler = requestABookHandler;
            this.deleteRequestHandler = deleteRequestHandler;
            this.listRequestsHandler = listRequestsHandler;
        }

        [HttpGet]
        public Result Index()
        {
            return listRequestsHandler.Execute(new ListRequestsQuery());
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
