using Microsoft.AspNetCore.Mvc;

namespace Bienvenute.Controllers;

[ApiController]
[Route("[controller]")]
public class BienvenidaController : ControllerBase
{
    private static readonly string[] DatosSaludos = new[]
    {
        "En Japón, inclinarse es la forma tradicional de saludar. La profundidad de la inclinación indica el nivel de respeto.",
        "En la India, el saludo tradicional es 'Namaste', con las palmas juntas y una ligera inclinación de cabeza.",
        "En Nueva Zelanda, los maoríes saludan con el 'hongi', presionando nariz con nariz y compartiendo el aliento de vida.",
        "En Tailandia, el saludo es el 'wai', con las palmas juntas a la altura del pecho y una inclinación de cabeza.",
        "En Francia, es costumbre dar dos besos en las mejillas al saludar, aunque el número varía según la región.",
        "En Rusia, los hombres suelen darse un fuerte apretón de manos mientras se miran directamente a los ojos.",
        "En México, un saludo cálido incluye un abrazo y palmadas en la espalda entre personas cercanas.",
        "En Arabia Saudita, los hombres se saludan tocando nariz con nariz después de un apretón de manos.",
        "En Italia, los saludos suelen ir acompañados de un beso en cada mejilla y un fuerte contacto visual.",
        "En Groenlandia, el saludo tradicional 'kunik' consiste en frotar la nariz y el labio superior contra la mejilla."
    };

    [HttpGet]
    public IActionResult Get()
    {
        var random = Random.Shared;
        var dato = DatosSaludos[random.Next(DatosSaludos.Length)];

        return Ok(new
        {
            mensaje = "¡Bienvenido! Aquí tienes un dato curioso sobre saludos en el mundo:",
            datoCurioso = dato
        });
    }
}