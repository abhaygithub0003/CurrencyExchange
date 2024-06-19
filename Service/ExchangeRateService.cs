using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

public class ExchangeRateService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public ExchangeRateService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
    {
        var baseUrl = _configuration["ExchangeRateAPI:BaseUrl"];
        var apiKey = _configuration["ExchangeRateAPI:ApiKey"];
        var url = $"{baseUrl}/{fromCurrency}?access_key={apiKey}";

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        dynamic data = JsonConvert.DeserializeObject(json);
        var rate = (decimal)data.rates[toCurrency];

        return rate;
    }
}
