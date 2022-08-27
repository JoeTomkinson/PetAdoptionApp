using PetAdoptionApp.Contracts.Services;
using PetAdoptionApp.ViewModels.Base;
using PetAdoptionApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptionApp.ViewModels
{
    public class MaintenanceViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IDialogService _dialogService;

        public Command NavigateToFavourites => new(async () => await _navigationService.NavigateToPage<FavouritePetsPage>());

        public Command NavigateBack => new(async () => await _navigationService.NavigateBack());

        public Command NavigateToProfile => new(async () => await _navigationService.NavigateToPage<MaintenancePage>());

        public MaintenanceViewModel(INavigationService navigationService, IDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;
        }
    }
}