using Todo.ViewModels;

namespace Todo;

public partial class MainPage : ContentPage
{
	//public MainPage()
	//{
	//	InitializeComponent();
	//	// Add the binding context for the page
	//	BindingContext = new MainViewModel();
	//}

    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        // Add the binding context for the page
        BindingContext = vm;
    }
}


