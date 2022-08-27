using Newtonsoft.Json;
using PetAdoptionApp.Contracts.Services;
using PetAdoptionApp.Models;
using PetAdoptionApp.ViewModels.Base;
using PetAdoptionApp.Views;

namespace PetAdoptionApp.ViewModels
{
    public class FavouritePetsViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IDialogService _dialogService;

        public Command NavigateBack => new(async () => await _navigationService.NavigateBack());

        public Command NavigateToProfilePage => new(async () => await _navigationService.NavigateToPage<MaintenancePage>());

        public Command PetSelected => new(async (s) => await OnPetSelected(s));

        public List<Pet> FavouritePets { get; set; }

        public FavouritePetsViewModel(INavigationService navigationService, IDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;

            // get user pet favs
            string serialisedPets = Preferences.Get("favourites", String.Empty);
            List<Pet> favouritePets = new List<Pet>();
            if (!string.IsNullOrEmpty(serialisedPets))
            {
                favouritePets = JsonConvert.DeserializeObject<List<Pet>>(serialisedPets);
            }

            FavouritePets = favouritePets;
            RaisePropertyChanged(nameof(FavouritePets));
        }

        public override Task OnNavigatedTo()
        {
            // get user pet favs
            string serialisedPets = Preferences.Get("favourites", String.Empty);
            List<Pet> favouritePets = new List<Pet>();
            if (!string.IsNullOrEmpty(serialisedPets))
            {
                favouritePets = JsonConvert.DeserializeObject<List<Pet>>(serialisedPets);
            }

            FavouritePets = favouritePets;

            RaisePropertyChanged(nameof(FavouritePets));

            return base.OnNavigatedTo();
        }

        private async Task OnPetSelected(object s)
        {
            if (s is CarouselView cv)
            {
                if (cv.CurrentItem is Pet pet)
                {
                    await _navigationService.NavigateToPage<PetDetailsPage>(pet);
                }
            }
        }
    }
}