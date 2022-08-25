using PetAdoptionApp.Contracts.Services;
using PetAdoptionApp.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PetAdoptionApp.Contracts.Abstracts
{
    public abstract class BasePetService : IPetService, INotifyPropertyChanged
    {
        public List<Pet> AdoptablePets { get ; set; }
        public virtual void RaisePropertyChanged([CallerMemberName] string property = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public abstract void LoadPetData(List<Pet> adoptablePets);
        public abstract List<Pet> GetPetsByType(PetType petType);
        public abstract Pet GetPetbyType(PetType petType);
        public abstract List<Pet> GetAllPets();
        public event PropertyChangedEventHandler PropertyChanged;
    }
}