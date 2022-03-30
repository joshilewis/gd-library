using GDLibrary.Api.Domain;
using GDLibrary.Api.Domain.Services.DeleteARequest;
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

        public RequestsController(RequestABookHandler requestABookHandler, DeleteRequestHandler deleteRequestHandler)
        {
            this.requestABookHandler = requestABookHandler;
            this.deleteRequestHandler = deleteRequestHandler;
        }

        [HttpGet]
        public void Index()
        {

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
