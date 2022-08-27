using PetAdoptionApp.Contracts.Abstracts;
using PetAdoptionApp.Contracts.Services;
using PetAdoptionApp.Models;
using PetAdoptionApp.Static;
using PetAdoptionApp.ViewModels.Base;
using PetAdoptionApp.Views;

namespace PetAdoptionApp.ViewModels
{
    public class PetsMainViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        readonly BasePetService _basePetService;

        readonly Microsoft.Maui.Graphics.Color _primaryColourString;
        readonly Microsoft.Maui.Graphics.Color _tertiaryColourString;

        private PetSelector _petSelector;

        public Command NavigateToSearchPage => new(async () => await _navigationService.NavigateToPage<PetsMainPage>());

        public Command NavigateToFavouritesPage => new(async () => await _navigationService.NavigateToPage<FavouritePetsPage>());

        public Command NavigateToPetDetailsPage => new(async () => await _navigationService.NavigateToPage<PetsMainPage>());

        public Command NavigateToProfilePage => new(async () => await _navigationService.NavigateToPage<MaintenancePage>());

        public Command PetSelected => new(async (s) => await OnPetSelected(s));

        public Command SetPetType => new((s) =>
        {
            if (s is Button btn)
            {
                SelectedPetType = new PetSelector() { Name = btn.Text };
                SetButtonColours(btn.Text);
                RaisePropertyChanged(nameof(SelectedPetType));
            };
        });

        public static List<PetSelector> PetTypes
        {
            get
            {
                return new() { new() { Name = "Dog" }, new() { Name = "Cat" }, new() { Name = "Rabbit" }, new() { Name = "Alpaca" } };
            }
        }

        public List<Pet> AdoptablePets { get; set; }

        public List<Pet> FilteredPets { get; set; }

        public PetSelector SelectedPetType
        {
            get
            {
                return _petSelector;
            }
            set
            {
                _petSelector = value;
                FilteredPets = AdoptablePets.Where(x => x.PetType.Species.ToLower() == value.Name.ToLower()).ToList();
                RaisePropertyChanged("FilteredPets");
                RaisePropertyChanged("SelectedPetType");
            }
        }

        public Color ButtonDogColour { get; set; }

        public Color ButtonCatColour { get; set; }

        public Color ButtonRabbitColour { get; set; }

        public Color ButtonAlpacaColour { get; set; }

        public PetsMainViewModel(INavigationService navigationService, BasePetService basePetService)
        {
            _navigationService = navigationService;
            _basePetService = basePetService;
            _basePetService.LoadPetData(AppData.Pets);
            AdoptablePets = _basePetService.GetAllPets();

            // set initial filter
            FilteredPets = AdoptablePets.Where(x => x.PetType.Species.ToLower() == "dog").ToList();
            RaisePropertyChanged(nameof(FilteredPets));

            _primaryColourString = App.ColourDictionary["Primary"] as Microsoft.Maui.Graphics.Color;
            _tertiaryColourString = App.ColourDictionary["Tertiary"] as Microsoft.Maui.Graphics.Color;

            // set initial colours
            ButtonDogColour = _primaryColourString;
            ButtonCatColour = _tertiaryColourString;
            ButtonRabbitColour = _tertiaryColourString;
            ButtonAlpacaColour = _tertiaryColourString;

            RaisePropertyChanged(nameof(ButtonDogColour));
            RaisePropertyChanged(nameof(ButtonCatColour));
            RaisePropertyChanged(nameof(ButtonRabbitColour));
            RaisePropertyChanged(nameof(ButtonAlpacaColour));
        }

        private void SetButtonColours(string buttonText)
        {
            switch (buttonText.ToLower())
            {
                case "dog":
                    ButtonDogColour = _primaryColourString;
                    ButtonCatColour = _tertiaryColourString;
                    ButtonRabbitColour = _tertiaryColourString;
                    ButtonAlpacaColour = _tertiaryColourString;
                    break;
                case "cat":
                    ButtonDogColour = _tertiaryColourString;
                    ButtonCatColour = _primaryColourString;
                    ButtonRabbitColour = _tertiaryColourString;
                    ButtonAlpacaColour = _tertiaryColourString;
                    break;
                case "rabbit":
                    ButtonDogColour = _tertiaryColourString;
                    ButtonCatColour = _tertiaryColourString;
                    ButtonRabbitColour = _primaryColourString;
                    ButtonAlpacaColour = _tertiaryColourString;
                    break;
                case "alpaca":
                    ButtonDogColour = _tertiaryColourString;
                    ButtonCatColour = _tertiaryColourString;
                    ButtonRabbitColour = _tertiaryColourString;
                    ButtonAlpacaColour = _primaryColourString;
                    break;
            }

            RaisePropertyChanged(nameof(ButtonDogColour));
            RaisePropertyChanged(nameof(ButtonCatColour));
            RaisePropertyChanged(nameof(ButtonRabbitColour));
            RaisePropertyChanged(nameof(ButtonAlpacaColour));
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