using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LinqController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<int>> Get([FromQuery]List<int> list)
        {
            List<int> list1 = list;

            if (list == null)
            {
                return BadRequest("Lista vacia");
            }

            var l = list.Where(x => x > 30 && x < 100).ToList();
            return Ok(l);


        }
    }
}
