using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GDLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        [HttpGet]
        public void Index()
        {

        }
    }
}
