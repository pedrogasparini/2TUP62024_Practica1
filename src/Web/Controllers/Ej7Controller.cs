using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("api/[controller]")]
[ApiController]

public class Ej7Controller : ControllerBase {
    [HttpGet]

    public ActionResult<List<int>> Get(int inicio, int fin) {
        
        if (fin - inicio >= 1000){
            return BadRequest("la diferencia entre inicio y fin debe ser menor a 1000.");
        }
        
        List<int> Numbers = [];

        for (int i = inicio; i <= fin; i++)
        {
            Numbers.Add(i);
        }

        return Ok(Numbers);
    }
}