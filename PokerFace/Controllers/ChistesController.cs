using Microsoft.AspNetCore.Mvc;

namespace Pokerface.Controllers;

[ApiController]
[Route("[controller]")]
public class ChistesController : ControllerBase
{
    private static readonly string[] Chistes = new[]
    {
        "¿Qué le dice un semáforo a otro? No me mires, me estoy cambiando.",
        "¿Cuál es el colmo de un electricista? Que su hijo sea un bombón.",
        "¿Qué hace una abeja en el gimnasio? ¡Zum-ba!",
        "¿Cómo se llama el campeón de buceo japonés? Tokofondo.",
        "¿Qué le dice un techo a otro? Techo de menos.",
        "¿Cuál es el animal más antiguo? La cebra, porque está en blanco y negro.",
        "¿Qué le dice un libro a otro? ¡Qué bien hueles!",
        "¿Cómo se dice pañuelo en japonés? Saka-moko.",
        "¿Qué le dice un jardinero a otro? Plantémonos.",
        "¿Cuál es el colmo de un cocinero? Que su mujer sea una hornaza."
    };

    [HttpGet]
    public IActionResult Get()
    {
        var random = Random.Shared;
        var chiste = Chistes[random.Next(Chistes.Length)];

        return Ok(new
        {
            mensaje = "🤡 ¡Toma este chiste medio agrio!",
            chiste = chiste
        });
    }
}