using System.Net.Http.Json;

namespace ChartCustomizationBlazorWebinar.SalesByProduct
{
    public class SalesByProductService
    {
        private readonly HttpClient http;

        public SalesByProductService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<SalesByProductFlatType[]?> GetSalesByProductFlat()
        {
            return await this.http.GetFromJsonAsync<SalesByProductFlatType[]>("https://excel2json.io/api/share/a488e87b-9bc0-49e3-6c99-08da1411ad26");
        }
    }
}