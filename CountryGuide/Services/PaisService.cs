using CountryGuide.Models;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace CountryGuide.Services
{
    public class PaisService
    {
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _cache;

        public PaisService(HttpClient httpClient, IMemoryCache cache)
        {
            _httpClient = httpClient;
            _cache = cache;
        }

        public async Task<Pais?> ObterPaisAsync(string nome)
        {
            string cacheKey = $"pais_{nome}";

            if(_cache.TryGetValue(cacheKey, out Pais paisCache))
            {
                return paisCache;
            }

            string url = $"https://restcountries.com/v3.1/name/{nome}";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();

            var paises = JsonSerializer.Deserialize<List<Pais>>(json);
            var pais = paises.FirstOrDefault();

            if (pais == null)
            {
                return null;
            }

            _cache.Set(cacheKey, pais, TimeSpan.FromMinutes(10));

            return pais;
        }
    }
}
