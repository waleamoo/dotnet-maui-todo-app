namespace Todo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		 // Register the detail page
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
	}
}

