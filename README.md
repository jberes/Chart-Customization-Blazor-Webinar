# Chart Customization Blazor Webinar

Data sources use in this sample:

* https://excel2json.io/api/share/2d14c082-f49d-4e33-6a1c-08da3961564a - Pre-aggregated list of Country / Orders from Northwind database

* https://excel2json.io/api/share/a488e87b-9bc0-49e3-6c99-08da1411ad26 - Non-aggregated Sales by Category / Product from Northwind database

The BasicChart sample uses these property settings on the IgbCategoryChart

```html
<div class="column-layout group">
    <IgbCategoryChart 
		    DataSource="ordersByCountryOrdersByCountryAggregate" 
        ChartType="CategoryChartType.Line"
        Brushes="#79D7F2"
        MarkerAutomaticBehavior="MarkerAutomaticBehavior.Square"
        XAxisTitleTextStyle="Bold"
        YAxisTitleTextStyle="Bold"
        FinalValueAnnotationsVisible="true"        
        AutoMarginAndAngleUpdateMode="AutoMarginsAndAngleUpdateMode.SizeChanging"
        ShouldConsiderAutoRotationForInitialLabels="true"
        CrosshairsAnnotationEnabled="true"
        CrosshairsDisplayMode="CrosshairsDisplayMode.Both"
        CrosshairsSnapToData="true"
        InitialSorts="Orders asc"
        IsTransitionInEnabled="true"
        HighlightingMode="SeriesHighlightingMode.FadeOthersSpecific"
        YAxisLabelLocation="YAxisLabelLocation.OutsideRight"
        ChartTitle="Orders by Country" 
        XAxisTitle="Country" 
        YAxisTitle="Order Count" 
        SeriesPointerDown="SeriesClicked"
        ComputedPlotAreaMarginMode="ComputedPlotAreaMarginMode.Series" 
        class="category-chart" basic-chart-scope>        
    </IgbCategoryChart>
```

To trap the SeriesPointerDown:
```c#
    private void SeriesClicked(IgbDomainChartSeriesPointerEventArgs args){
        var x = (ChartCustomizationWebinar.OrdersByCountry.OrdersByCountryAggregateType)args.Item;
        header = x.Country;
        value = x.Orders.Value;
    }
```

The AggregateChart sample uses these property settings on the IgbCategoryChart
```html
    <IgbCategoryChart 
        ChartTitle="Sales by Product"
        DataSource=salesByProductSales 
        IncludedProperties=@(new string[] { "CategoryName", "ProductSales" })
        InitialGroups="CategoryName"
        InitialSummaries="sum(ProductSales) as ProductSales"
        GroupSorts="ProductSales asc"
        IsTransitionInEnabled="true"
        TransitionInSpeedType="TransitionInSpeedType.Random"
        CrosshairsSnapToData="true"
        ChartType="CategoryChartType.Column"
        CrosshairsDisplayMode="CrosshairsDisplayMode.Both"
        IsCategoryHighlightingEnabled="true"
        HighlightingMode="SeriesHighlightingMode.FadeOthersSpecific"
        IsSeriesHighlightingEnabled="true"
        FinalValueAnnotationsVisible="true"
        AutoMarginAndAngleUpdateMode="AutoMarginsAndAngleUpdateMode.SizeChanging"
        ShouldConsiderAutoRotationForInitialLabels="true"
        class="category-chart" aggregate-chart-scope>
    </IgbCategoryChart>
```
    
## Run in Visual Studio 2022

- open the project in **Visual Studio 2022**

- press **Start** (**F5**)


## Run in VS Code

NOTE: Running the app requires [.NET 6.0](https://dotnet.microsoft.com/en-us/download) to be installed.

- open this folder in **VS Code**

- open a terminal window

- use this command to run:
```dotnet run```

- wait for message:
**Now listening on: https://localhost:7228 and http://localhost:5072**

- open **https://localhost:7228 OR http://localhost:5072** in your browser

  _Ports are configured by "applicationUrl" specified in launch.Settings.json file and could be subject to change._


## Resources

- [Documentation and Samples](https://www.infragistics.com/products/ignite-ui-blazor/blazor/components/general-getting-started)
- [Infragistics NuGet Feed](https://www.infragistics.com/products/ignite-ui-blazor/blazor/components/general-nuget-feed)
- [Razor Syntax](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-6.0#razor-syntax)
