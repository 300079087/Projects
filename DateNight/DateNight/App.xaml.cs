using DateNight.Models;
namespace DateNight;

public partial class App : Application
{
	public static DataCalculator DateCalc;

	public App()
	{
		InitializeComponent();

		DateCalc = new DataCalculator();

		MainPage = new AppShell();

	}
}

