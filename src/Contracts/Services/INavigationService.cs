using System.Threading.Tasks;

namespace PetAdoptionApp.Contracts.Services
{
    public interface INavigationService
    {
        Task NavigateBack();
        Task NavigateToPage<T>(object parameter = null) where T : Page;
    }
}