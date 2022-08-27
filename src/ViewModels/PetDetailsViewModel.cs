using Newtonsoft.Json;
using PetAdoptionApp.Contracts.Services;
using PetAdoptionApp.Models;
using PetAdoptionApp.ViewModels.Base;
using PetAdoptionApp.Views;

namespace PetAdoptionApp.ViewModels
{
    public class PetDetailsViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IDialogService _dialogService;

        public Command NavigateCommand => new(async () => await _navigationService.NavigateToPage<PetsMainPage>());

        public Command CloseCommand => new(async () => await _navigationService.NavigateBack());

        public Command LoveTapped => new(async () => await OnLoveTapped());

        public Command LocationTapped => new(async () => await OnLocationTapped());

        public Pet Pet { get; private set; }

        public bool Loved { get; set; }

        public string LovedIcon
        {
            get
            {
                if (Pet?.UserInteraction != null)
                {
                    var icon = Pet.UserInteraction.PetLoved ? "tap_love_tapped" : "tap_love";
                    return icon;
                }
                // return default
                return "tap_love";
            }
        }

        public PetDetailsViewModel(INavigationService navigationService, IDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;
        }

        private async Task OnLoveTapped()
        {
            if (Pet?.UserInteraction == null)
            {
                Pet.UserInteraction = new UserInteraction();
            }

            Pet.UserInteraction.PetLoved = !Pet.UserInteraction.PetLoved;
            RaisePropertyChanged(nameof(LovedIcon));

            // get user pet favs
            string serialisedPets = Preferences.Get("favourites", string.Empty);
            List<Pet> favouritePets = new List<Pet>();
            if (!string.IsNullOrEmpty(serialisedPets))
            {
                favouritePets = JsonConvert.DeserializeObject<List<Pet>>(serialisedPets);
            }

            if (Pet.UserInteraction.PetLoved == true)
            {
                favouritePets.Add(Pet);
                await _dialogService.MessageDialogAsync(App.Current.MainPage, "Favourite Chosen", "Wahey this little one has been added to your favourites list!");
            }
            else
            {
                var storedPet = favouritePets.Find(x => x.PetID == Pet.PetID);
                favouritePets.Remove(storedPet);
                await _dialogService.MessageDialogAsync(App.Current.MainPage, "Favourite Removed", "Awww this little one has been removed from your favourites list!");
            }

            // Set a string value:
            Preferences.Default.Set("favourites", JsonConvert.SerializeObject(favouritePets));
        }

        private async Task OnLocationTapped()
        {
            await _navigationService.NavigateToPage<PetsLocationPage>();
        }

        public override Task OnNavigatingTo(object parameter)
        {
            if (parameter is Pet pet)
            {
                Pet = pet;

                // get user pet favs
                string serialisedPets = Preferences.Get("favourites", string.Empty);
                List<Pet> favouritePets = new List<Pet>();
                if (!string.IsNullOrEmpty(serialisedPets))
                {
                    favouritePets = JsonConvert.DeserializeObject<List<Pet>>(serialisedPets);
                    if (favouritePets.Contains(Pet))
                    {
                        // replace the pet data if it's in our favourites
                        Pet = favouritePets.Where(x => x.PetID == Pet.PetID).FirstOrDefault();
                    }
                }

                RaisePropertyChanged(nameof(Pet));
                RaisePropertyChanged(nameof(LovedIcon));
            }
            return base.OnNavigatingTo(parameter);
        }
    }
}