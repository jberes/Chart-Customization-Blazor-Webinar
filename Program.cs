using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IgniteUI.Blazor.Controls;
using ChartCustomizationBlazorWebinar;
using ChartCustomizationBlazorWebinar.OrdersByCountry;
using ChartCustomizationBlazorWebinar.SalesByProduct;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<OrdersByCountryService>();
builder.Services.AddScoped<SalesByProductService>();

RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgniteUI.Blazor.Controls.IgbNavbarModule),
        typeof(IgniteUI.Blazor.Controls.IgbNavDrawerModule),
        typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
        typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule)
    );
}