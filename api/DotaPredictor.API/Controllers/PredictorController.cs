using DotaPredictor.DataBuilder.Interfaces;
using DotaPredictor.DataBuilder.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotaPredictor.API.Controllers;

[ApiController]
[Route("api/predictor")]
public class PredictorController : Controller
{
    private readonly IPredictorService _predictorService;

    public PredictorController(IPredictorService predictorService)
    {
        _predictorService = predictorService;
    }

    [HttpPost("")]
    [ProducesResponseType(typeof(IEnumerable<MatchPrediction>), 200)]
    public async Task<IActionResult> PredictHeroes(PredictionRequest request, CancellationToken cancel = default)
    {
        var result = await _predictorService.PredictHeroSuccesses(request.Allies, request.Enemies, cancel);
        return Ok(result);
    }
}
