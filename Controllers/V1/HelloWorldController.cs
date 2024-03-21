using Microsoft.AspNetCore.Mvc;

namespace Versionamento_API.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpPost()]
        public IActionResult Teste()
            => Ok("VERSÃO 1");
    }
}
