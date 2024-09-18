using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6LinqController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<string>> Get([FromQuery] List<string> words) 
        {
            foreach (var word in words)
            {
                if (word == null)
                {
                    return BadRequest("Palabra invalida/vacia.");
                }
            }

            var w = words.Select(w => w.Replace( "ia", "*")).ToList();

            return Ok(w);
        }
    }
}

