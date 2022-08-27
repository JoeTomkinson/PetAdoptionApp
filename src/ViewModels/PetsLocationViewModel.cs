using PetAdoptionApp.Contracts.Services;
using PetAdoptionApp.Models;
using PetAdoptionApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptionApp.ViewModels
{
    internal class PetsLocationViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IDialogService _dialogService;

        public Command NavigateCommand => new(async () => await _navigationService.NavigateToPage<PetsMainPage>());

        public Command CloseCommand => new(async () => await _navigationService.NavigateBack());

        public Pet Pet { get; private set; }

        public PetsLocationViewModel(INavigationService navigationService, IDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;
        }


    }
}