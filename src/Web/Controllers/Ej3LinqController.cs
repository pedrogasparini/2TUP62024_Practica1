using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> Get([FromQuery] List<string> words)
        {

            foreach (var word in words)
            {
                if (word == null)
                {
                    return BadRequest("Palabra vacia/invalida.");
                }
            }


            var w = words.Where(w => w.StartsWith("b") && w.EndsWith("r"))
                         .Select(w => w.ToUpper())
                         .ToList();



            return Ok(w);

        }
    }
}
