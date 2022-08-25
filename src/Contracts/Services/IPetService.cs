using PetAdoptionApp.Models;

namespace PetAdoptionApp.Contracts.Services
{
    public interface IPetService
    {
        public List<Pet> AdoptablePets { get; set; }
        public void LoadPetData(List<Pet> adoptablePets);
        public List<Pet> GetPetsByType(PetType petType);
        public List<Pet> GetAllPets();
        public Pet GetPetbyType(PetType petType);
    }
}