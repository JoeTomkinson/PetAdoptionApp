using PetAdoptionApp.ViewModels;

namespace PetAdoptionApp;

public partial class MainPage : ContentPage
{
	readonly MainPageViewModel ViewModel;

	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = ViewModel = viewModel;
    }
}