namespace PetAdoptionApp.Models
{
    public class PetSelector
    {
        public string Name { get; set; }
    }

    public class PetType
    {
        public string Species { get; set; }

        public string Breed { get; set; }
    }

    public class Pet
    {
        public PetType PetType { get; set; }
        public string PetName { get; set; }
        public string PetLocation { get; set; }
        public string PetDescription { get; set; }
        public int PetAge { get; set; }
        public string PetImageSource { get; set; }
        public string ColorHex { get; set; }
    }
}