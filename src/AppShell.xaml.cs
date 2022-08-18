using Android.OS;
using Android.Views;

namespace PetAdoptionApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("PetsPage", typeof(PetsMain));
    }
}
