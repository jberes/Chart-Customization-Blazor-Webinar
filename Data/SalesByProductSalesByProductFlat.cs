//namespace ChartCustomizationBlazorWebinar.Data.SalesByProduct; // Razor won't recognize third level namespace
namespace ChartCustomizationBlazorWebinar.SalesByProduct;

public class SalesByProductFlatType
{
    public double? CategoryID { get; set; }
    public string? CategoryName { get; set; }
    public string? ProductName { get; set; }
    public double? ProductSales { get; set; }
}
