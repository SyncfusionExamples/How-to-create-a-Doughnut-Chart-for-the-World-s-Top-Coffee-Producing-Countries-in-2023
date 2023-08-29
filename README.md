# Creating a Doughnut Chart for the World’s Top Coffee Producing Countries in 2023.


This sample demonstrates how to create a Doughnut Chart for the World’s Top Coffee Producing Countries in 2023.

## Doughnut chart

Doughnut chart is used to show the relationship between parts of data and whole data. To render a [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) in circular chart, create an instance of the DoughnutSeries and add it to the Series collection property of [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html).

## Customize the doughnut chart

we customize the doughnut segment color, border, and width and group the data points less than the specific value using the [PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes), [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Stroke), [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StrokeWidth), and [GroupTo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html#Syncfusion_Maui_Charts_PieSeries_GroupTo) properties, respectively.

We can also modify the start and end positions of a segment in the chart using the [StartAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StartAngle) and [EndAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_EndAngle) properties.

## Customize the CenterView

 Any view can be added to the center of the doughnut chart using the [CenterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterView) property of [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html). The view placed in the center of the doughnut chart is useful for sharing additional information about the doughnut chart. The binding context of the CenterView will be the respective doughnut series. 

 Using the [CenterHoleSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterHoleSize), we can protect the view in the doughnut center from overlapping with the series

![Updated-DoughnutChartOutput](https://github.com/SyncfusionExamples/How-to-create-a-Doughnut-Chart-for-the-World-s-Top-Coffee-Producing-Countries-in-2020/assets/105482474/068bf3cd-7d72-4caf-ae24-fb3f0b2988b9)

For a step by step procedure, refer to the [World's Top Coffee-Producing Countries](https://www.syncfusion.com/blogs/post/dotnet-maui-doughnut-chart-visualize-coffee-production.aspx).

