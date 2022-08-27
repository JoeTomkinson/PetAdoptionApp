using PetAdoptionApp.ViewModels;

namespace PetAdoptionApp.Views;

public partial class MaintenancePage : ContentPage
{
    readonly MaintenanceViewModel ViewModel;

    public MaintenancePage(MaintenanceViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = ViewModel = viewModel;
    }
}