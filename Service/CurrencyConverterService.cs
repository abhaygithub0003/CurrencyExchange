namespace CurrencyExchange.Service
{
    public class CurrencyConverterService
    {
        private readonly ExchangeRateService _exchangeRateService;

        public CurrencyConverterService(ExchangeRateService exchangeRateService)
        {
            _exchangeRateService = exchangeRateService;
        }

        public async Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency)
        {
            var rate = await _exchangeRateService.GetExchangeRateAsync(fromCurrency, toCurrency);
            return amount * rate;
        }
    }
    }

