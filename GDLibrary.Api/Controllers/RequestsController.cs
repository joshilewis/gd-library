using GDLibrary.Api.Domain;
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

        public RequestsController(RequestABookHandler requestABookHandler)
        {
            this.requestABookHandler = requestABookHandler;
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
    }
}
