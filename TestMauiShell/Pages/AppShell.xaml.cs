using TestMauiShell.ViewModels;

namespace TestMauiShell.Pages;

public partial class AppShell : Shell
{
	public AppShell(ShellViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}