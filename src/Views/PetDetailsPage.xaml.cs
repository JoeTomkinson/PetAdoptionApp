using PetAdoptionApp.ViewModels;

namespace PetAdoptionApp.Views;

public partial class PetDetailsPage : ContentPage
{
    readonly PetDetailsViewModel ViewModel;

    public PetDetailsPage(PetDetailsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = ViewModel = viewModel;
    }
}