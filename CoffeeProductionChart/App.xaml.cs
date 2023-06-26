using Syncfusion.Maui.Charts;
using System.Globalization;
using System.Resources;

namespace CoffeeProductionChart;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
        var ResXPath = "CoffeeProductionChart.Resources.SfCircularChart";
        SfCartesianChartResources.ResourceManager = new ResourceManager(ResXPath, Application.Current.GetType().Assembly);
        MainPage = new MainPage();
	}
}
