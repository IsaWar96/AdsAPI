using Microsoft.AspNetCore.Mvc;
using Api.Models;

namespace Api.Controllers;

[ApiController]
[Route("api/ad")]
public class AdsController : ControllerBase
{
    [HttpGet("{lon}/{lat}")]
    public IActionResult GetAd(double lon, double lat)
    {
        // Malmö
        if (lat < 57.0)
        {
            return Ok(new Ad
            {
                Title = "Malmö FF",
                Description = "Malmös nya matchtröja!!",
                ImgUrl = "ads/malmoff.jpg",
                HtmlUrl = "ads/malmoff.html"
            });
        }
        // Stockholm
        else if (lat >= 57.0 && lat < 60.0)
        {
            return Ok(new Ad
            {
                Title = "Stockholm Energi",
                Description = "VÄLJ RÄTT EL I STOCKHOLM!",
                ImgUrl = "ads/Stockholmenergi.jpg",
                HtmlUrl = "ads/stockholmenergi.html"
            });
        }
        // Norrland
        else
        {
            return Ok(new Ad
            {
                Title = "Norrlands Guld",
                Description = "Var dig själv för en stund.",
                ImgUrl = "ads/Norrlands_Guld.jpg",
                HtmlUrl = "ads/norrlandsguld.html"
            });
        }
    }
}