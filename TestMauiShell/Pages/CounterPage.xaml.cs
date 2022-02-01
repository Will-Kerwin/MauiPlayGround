namespace TestMauiShell.Pages;

public partial class CounterPage : ContentPage
{

	public CounterPage(CounterViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

