//namespace ChartCustomizationBlazorWebinar.Data.OrdersByCountry; // Razor won't recognize third level namespace
namespace ChartCustomizationBlazorWebinar.OrdersByCountry;

public class OrdersByCountryAggregateType
{
    public string? Country { get; set; }
    public double? Orders { get; set; }
}
