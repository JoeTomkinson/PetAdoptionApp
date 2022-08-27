using PetAdoptionApp.ViewModels;

namespace PetAdoptionApp.Views;

public partial class FavouritePetsPage : ContentPage
{
    readonly FavouritePetsViewModel ViewModel;

    public FavouritePetsPage(FavouritePetsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = ViewModel = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        if (ViewModel.FavouritePets.Count == 1)
        {
            cvPets.Loop = false;
        }
        else
        {
            cvPets.Loop = true;
        }
        base.OnNavigatedTo(args);
    }
}