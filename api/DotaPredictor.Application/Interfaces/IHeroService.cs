using DotaPredictor.DataBuilder.Models;

namespace DotaPredictor.DataBuilder.Interfaces;

public interface IHeroService
{
    Task<Dictionary<int, string>> GetHeroMapAsync(CancellationToken cancel = default);

    Task<IEnumerable<HeroResponse>> GetHeroesAsync(CancellationToken cancel = default);
}
