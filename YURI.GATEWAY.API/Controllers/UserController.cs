using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YURI.GATEWAY.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {



        [HttpGet]
        public ActionResult<string> Get()
        {
            var clave = "xxx";
            return Ok(clave);
        }

    }
}
