using PetAdoptionApp.Contracts.Abstracts;
using PetAdoptionApp.Models;

namespace PetAdoptionApp.Services
{
    internal class PetService : BasePetService
    {
        public PetService()
        {

        }

        public override List<Pet> GetAllPets()
        {
            return AdoptablePets;
        }

        public override Pet GetPetbyType(PetType petType)
        {
            throw new NotImplementedException();
        }

        public override List<Pet> GetPetsByType(PetType petType)
        {
            throw new NotImplementedException();
        }

        public override void LoadPetData(List<Pet> adoptablePets)
        {
            AdoptablePets = adoptablePets;
        }
    }
}