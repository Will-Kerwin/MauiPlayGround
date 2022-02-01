using TestMauiShell.Pages;

namespace TestMauiShell;

public partial class App : Application
{
	public App(AppShell shell)
	{
        InitializeComponent();

		MainPage = shell;

		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
		Routing.RegisterRoute(nameof(CounterPage), typeof(CounterPage));
	}
}
