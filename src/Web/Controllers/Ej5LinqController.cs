using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5LinqController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> Get([FromQuery] List<int> numbers)
        {

            var n = numbers.Where(n => n > 20).ToList();

            var result = n
                .Select(n => $"Numero: {n} - Cuadrado: {n * n}")
                .ToList();

            return Ok(result);
        }
    }
}
