using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("/api/[controller]")]
[ApiController]

public class Ej5Controlller : ControllerBase
{
    [HttpGet]

    public ActionResult Get(string day)
    {

        try
        {
            string dayCompare = day.ToLower().Trim();

            List<string> Weekend = ["sabado", "domingo"];

            List<string> Week = ["lunes", "martes", "miercoles", "jueves", "viernes"];

            if (Weekend.Contains(dayCompare))
            {
                return Ok("Es fin de semana");
            }
            else if (Week.Contains(dayCompare))
            {
                return Ok("NO es fin de semana");
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, "el dia ingresado no es valido");
            }
        }
        catch (System.Exception)
        {

            return StatusCode(StatusCodes.Status500InternalServerError, "error interno");
        }
    }
}