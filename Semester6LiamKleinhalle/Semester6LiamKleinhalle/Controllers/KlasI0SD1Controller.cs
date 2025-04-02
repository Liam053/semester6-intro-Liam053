using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Policy = "KlasI0SD1")]
public class KlasI0SD1Controller : Controller
{
    public IActionResult KlasSD1()
    {
        // Gegevens voor de klaspagina
        return View();
    }
}
