using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Todo.ViewModels
{
	[QueryProperty("Text", "Text")]
	public partial class DetailViewModel : ObservableObject
	{
		[ObservableProperty]
		string text;

		public DetailViewModel()
		{
		}

		[RelayCommand]
		async Task GoBack()
		{
			await Shell.Current.GoToAsync(".."); // await Shell.Current.GoToAsync("../monkey"); // await Shell.Current.GoToAsync("../../");
        }


	}
}

