using Microsoft.AspNetCore.Mvc;

namespace Versionamento_API.Controllers.V2
{
    [ApiVersion("2")]
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpPost()]
        public IActionResult Teste()
            => Ok("VERSÃO 2");

        [HttpPost("AoVivo")]
        public IActionResult TesteAoVivo()
           => Ok("VERSÃO 2 AoVivo");
    }
}
