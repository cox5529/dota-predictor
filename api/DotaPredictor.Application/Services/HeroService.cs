using System.Text.Json;
using DotaPredictor.DataBuilder.Exceptions;
using DotaPredictor.DataBuilder.Interfaces;
using DotaPredictor.DataBuilder.Models;
using DotaPredictor.DataBuilder.Settings;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace DotaPredictor.DataBuilder.Services;

public class HeroService : IHeroService
{
    private readonly HttpClient _client;
    private readonly IMemoryCache _cache;
    private readonly IOptions<HeroSettings> _settings;

    public HeroService(HttpClient client, IMemoryCache cache, IOptions<HeroSettings> settings)
    {
        _client = client;
        _cache = cache;
        _settings = settings;
    }

    /// <inheritdoc />
    public async Task<Dictionary<int, string>> GetHeroMapAsync(CancellationToken cancel = default)
    {
        var heroes = await GetHeroesAsync(cancel);
        return heroes.ToDictionary(x => x.Id, x => x.LocalizedName);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<HeroResponse>> GetHeroesAsync(CancellationToken cancel = default)
    {
        return await _cache.GetOrCreateAsync(
                   "dota_heroes",
                   async (entry) =>
                   {
                       entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(1);
                       var json = await _client.GetStringAsync("https://api.opendota.com/api/heroStats", cancel);
                       var heroes = JsonConvert.DeserializeObject<List<HeroResponse>>(json);
                       if (heroes == null)
                       {
                           throw new BadGatewayException();
                       }

                       foreach (var hero in heroes)
                       {
                           hero.Img = _settings.Value.CdnBaseUrl + hero.Img;
                           hero.Icon = _settings.Value.CdnBaseUrl + hero.Icon;
                       }
                       
                       return heroes;
                   })
            ?? throw new BadGatewayException();
    }
}
