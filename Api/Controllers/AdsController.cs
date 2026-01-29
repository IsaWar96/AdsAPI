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
                Description = "Malmös nya maychtröja!!",
                ImgUrl = "http://localhost:5112/ads/malmoff.jpg",
                HtmlUrl = "http://localhost:5112/malmoff.html"
            });
        }
        // Stockholm
        else if (lat >= 57.0 && lat < 60.0)
        {
            return Ok(new Ad
            {
                Title = "Stockholm Energi",
                Description = "Stockholm suger... ut koldioxid ur atmosfären.",
                ImgUrl = "http://localhost:5112/ads/Stockholmenergi.jpg",
                HtmlUrl = "http://localhost:5112/stockholmenergi.html"
            });
        }
        // Norrland
        else
        {
            return Ok(new Ad
            {
                Title = "Norrlands Guld",
                Description = "Var dig själv för en stund.",
                ImgUrl = "http://localhost:5112/ads/Norrlands_Guld.jpg",
                HtmlUrl = "http://localhost:5112/norrlandsguld.html"
            });
        }
    }
}