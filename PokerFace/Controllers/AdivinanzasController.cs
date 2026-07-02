using Microsoft.AspNetCore.Mvc;

namespace Pokerface.Controllers;

[ApiController]
[Route("[controller]")]
public class AdivinanzasController : ControllerBase
{
    private static readonly string[] Adivinanzas = new[]
    {
        "Blanco por dentro, verde por fuera. Si quieres que te lo diga, espera. (La pera)",
        "Oro parece, plata no es. ¿Qué es? (El plátano)",
        "En la noche soy redonda, en el día no se me ve. ¿Qué soy? (La luna)",
        "Tiene dientes y no come, tiene cabeza y no es persona. ¿Qué es? (El ajo)",
        "Cuanto más le quitas, más grande se hace. ¿Qué es? (Un agujero)",
        "Vuela sin alas, llora sin ojos. ¿Qué es? (La nube)",
        "Adivina adivinador, ¿qué cosa es que cuanto más se lava más sucia está? (El agua)",
        "Tiene corona y no es rey, tiene espinas y no es pez. ¿Qué es? (La piña)",
        "Camina y no tiene pies, corre y no tiene piernas. ¿Qué es? (El viento)",
        "Tiene agujas y no cose, tiene números y no cuenta. ¿Qué es? (El reloj)"
    };

    [HttpGet]
    public IActionResult Get()
    {
        var random = Random.Shared;
        var adivinanza = Adivinanzas[random.Next(Adivinanzas.Length)];

        return Ok(new
        {
            mensaje = "🧠 ¡Adivina, adivinador!",
            adivinanza = adivinanza
        });
    }
}