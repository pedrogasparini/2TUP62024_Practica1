using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4LinqController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<int>> Get([FromQuery] List<int> numbers)
        {

            var n = numbers.OrderByDescending(n => n)
                         .Take(5)
                         .ToList();



            return Ok(n);

        }
    }
}
