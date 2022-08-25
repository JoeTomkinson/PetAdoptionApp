using Android.Graphics.Fonts;
using PetAdoptionApp.ViewModels;
using static Android.Print.PrintAttributes;
using static Android.Provider.MediaStore.Audio;
using static Java.Util.Jar.Attributes;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Google.Crypto.Tink.Prf;
using PetAdoptionApp.Helpers;

namespace PetAdoptionApp;

public partial class PetsMainPage : ContentPage
{
    readonly PetsMainViewModel ViewModel;

    public PetsMainPage(PetsMainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = ViewModel = viewModel;
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(sender is Entry entry)
        {
            if (!string.IsNullOrEmpty(entry.Text))
            {
                ViewModel.FilteredPets = ViewModel.AdoptablePets.Where(x => x.PetType.Species.ToLower() == ViewModel.SelectedPetType.Name.ToLower()).ToList();
                ViewModel.RaisePropertyChanged(nameof(ViewModel.FilteredPets));
                return;
            }
            ViewModel.FilteredPets = ViewModel.AdoptablePets.Where(x => x.PetName.ToLower().Contains(entry.Text.ToLower())).ToList();
            ViewModel.RaisePropertyChanged(nameof(ViewModel.FilteredPets));
        }
    }
}