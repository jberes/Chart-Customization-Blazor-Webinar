using System.Net.Http.Json;

namespace ChartCustomizationBlazorWebinar.OrdersByCountry
{
    public class OrdersByCountryService
    {
        private readonly HttpClient http;

        public OrdersByCountryService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<OrdersByCountryAggregateType[]?> GetOrdersByCountryAggregate()
        {
            return await this.http.GetFromJsonAsync<OrdersByCountryAggregateType[]>("https://excel2json.io/api/share/2d14c082-f49d-4e33-6a1c-08da3961564a");
        }
    }
}