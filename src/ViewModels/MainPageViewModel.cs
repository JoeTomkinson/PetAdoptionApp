using PetAdoptionApp.Contracts.Services;
using PetAdoptionApp.ViewModels.Base;

namespace PetAdoptionApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        public Command NavigateCommand => new(async () => await _navigationService.NavigateToPage<PetsMainPage>());

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}