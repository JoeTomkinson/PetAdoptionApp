using PetAdoptionApp.Models;

namespace PetAdoptionApp.Static
{
    public class AppData
    {
        private static readonly List<Pet> pets = new()
        {
            new Pet()
            {
                PetAge = 1,
                PetDescription = "",
                PetImageSource = "Dog1.png",
                PetLocation = "London",
                PetName = "Scotch",
                PetType = new PetType(){ Species = "Dog", Breed = "" },
                ColorHex = "#FF9AA2"
            },
            new Pet()
            {
                PetAge = 4,
                PetDescription = "",
                PetImageSource = "Dog2.png",
                PetLocation = "Stafford",
                PetName = "Prince",
                PetType = new PetType(){Species = "Dog", Breed = "" },
                ColorHex = "#FFB7B2"
            },
new Pet()
            {
                PetAge = 2,
                PetDescription = "",
                PetImageSource = "Dog3.png",
                PetLocation = "Kent",
                PetName = "Yammie",
                PetType = new PetType(){Species = "Dog", Breed = "" },
                ColorHex = "#FFDAC1"
            },
new Pet()
            {
                PetAge = 8,
                PetDescription = "",
                PetImageSource = "Dog4.png",
                PetLocation = "Inverness",
                PetName = "Blue",
                PetType = new PetType(){ Species = "Dog", Breed = ""},
                ColorHex = "#E2F0CB"
            },
new Pet()
            {
                PetAge = 5,
                PetDescription = "",
                PetImageSource = "cat1.png",
                PetLocation = "Cambridge",
                PetName = "Daiquiri",
                PetType = new PetType(){ Species = "Cat", Breed = ""},
                ColorHex = "#B5EAD7"
            },
new Pet()
            {
                PetAge = 1,
                PetDescription = "",
                PetImageSource = "cat2.png",
                PetLocation = "Oxford",
                PetName = "Jannali",
                PetType = new PetType(){Species = "Cat", Breed = "" },
                ColorHex = "#C7CEEA"
            },
new Pet()
            {
                PetAge = 1,
                PetDescription = "",
                PetImageSource = "cat3.png",
                PetLocation = "Devon",
                PetName = "Maximus",
                PetType = new PetType(){Species = "Cat", Breed = "" },
                ColorHex = "#B5EAD7"
            },
new Pet()
            {
                PetAge = 7,
                PetDescription = "",
                PetImageSource = "cat4.png",
                PetLocation = "Manchester",
                PetName = "Yeska",
                PetType = new PetType(){Species = "Cat", Breed = "" },
                ColorHex = "#E2F0CB"
            },
new Pet()
            {
                PetAge = 11,
                PetDescription = "",
                PetImageSource = "rabbit1.png",
                PetLocation = "Brighton",
                PetName = "Marley",
                PetType = new PetType(){Species = "Rabbit", Breed = "" },
                ColorHex = "#FFDAC1"
            },
new Pet()
            {
                PetAge = 3,
                PetDescription = "",
                PetImageSource = "rabbit2.png",
                PetLocation = "Derby",
                PetName = "Theo",
                PetType = new PetType(){Species = "Rabbit", Breed = "" },
                ColorHex = "#FFB7B2"
            },
new Pet()
            {
                PetAge = 8,
                PetDescription = "",
                PetImageSource = "rabbit3.png",
                PetLocation = "Blackpool",
                PetName = "Paco",
                PetType = new PetType(){Species = "Rabbit", Breed = "" },
                ColorHex = "#FF9AA2"
            },
new Pet()
            {
                PetAge = 6,
                PetDescription = "",
                PetImageSource = "rabbit4.png",
                PetLocation = "Liverpool",
                PetName = "Kapone",
                PetType = new PetType(){Species = "Rabbit", Breed = "" },
                ColorHex = "FFB7B2"
            },
new Pet()
            {
                PetAge = 9,
                PetDescription = "",
                PetImageSource = "alpaca1.png",
                PetLocation = "Leeds",
                PetName = "Wacky",
                PetType = new PetType(){ Species = "Alpaca", Breed = ""},
                ColorHex = "#FFDAC1"
            },
new Pet()
            {
                PetAge = 2,
                PetDescription = "",
                PetImageSource = "alpaca2.png",
                PetLocation = "Winsor",
                PetName = "Stuart",
                PetType = new PetType(){Species = "Alpaca", Breed = "" },
                ColorHex = "#E2F0CB"
            },
new Pet()
            {
                PetAge = 4,
                PetDescription = "",
                PetImageSource = "alpaca3.png",
                PetLocation = "Southampton",
                PetName = "Van",
                PetType = new PetType(){Species = "Alpaca", Breed = "" },
                ColorHex = "#C7CEEA"
            },

        };
        public static List<Pet> Pets = pets;
    }
}