using DotaPredictor.DataBuilder.Interfaces;
using DotaPredictor.DataBuilder.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotaPredictor.API.Controllers;

[ApiController]
[Route("api/hero")]
public class HeroController : Controller
{
    private readonly IHeroService _heroService;

    public HeroController(IHeroService heroService)
    {
        _heroService = heroService;
    }

    [HttpGet("")]
    [ProducesResponseType(typeof(IEnumerable<HeroResponse>), 200)]
    public async Task<IActionResult> GetHeroes(CancellationToken cancel = default)
    {
        var heroes = await _heroService.GetHeroesAsync(cancel);
        return Ok(heroes);
    }
}
