using PetAdoptionApp.Models;

namespace PetAdoptionApp.Static
{
    public class AppData
    {
        private static readonly List<Pet> pets = new()
        {
            new Pet()
            {
                PetID = 23445464,
                PetAge = 1,
                PetDescription = "Meet Scotch, a mischievous American Hairless Terrier puppy who’s ready to take on the world. Scotch sports a brave personality and carries a beautiful white coat. In addition, Scotch will arrive pet friendly, good natured, and handled daily. We've poured ourselves into raising this little gem and promise you a puppy coming from parents of companionable and calm personalities. If you’re browsing puppies for sale in London, be sure to check out this charming little pup. We are experienced in shipping and can arrange details to get your puppy safely home if you’re not already in London. We take pride and joy in raising high quality dogs.",
                PetImageSource = "Dog1.png",
                PetLocation = "London",
                PetName = "Scotch",
                PetType = new PetType(){ Species = "Dog", Breed = "" },
                ColorHex = "#FF9AA2"
            },
            new Pet()
            {
                PetID = 234235435645,
                PetAge = 4,
                PetDescription = "Meet Prince, a loyal Dachshund puppy who’s ready to take on the world. Prince sports a sweet personality and carries a beautiful brindle coat. In addition, Prince will arrive healthy, child friendly, and family raised. We've poured ourselves into raising this little gem and promise you a puppy coming from parents of dashing and docile personalities. If you’re browsing puppies for sale in Stafford, be sure to check out this charming little pup. We are experienced in shipping and can arrange details to get your puppy safely home if you’re not already in Stafford. We take pride and joy in raising high quality dogs.",
                PetImageSource = "Dog2.png",
                PetLocation = "Stafford",
                PetName = "Prince",
                PetType = new PetType(){Species = "Dog", Breed = "" },
                ColorHex = "#FFB7B2"
            },
new Pet()
            {
                PetID = 2342547645,
                PetAge = 2,
                PetDescription = "Meet Yammie, a loyal Poodle puppy who’s ready to take on the world. Yammie sports a sweet personality and carries a beautiful white coat. In addition, Yammie will arrive healthy, child friendly, and family raised. We've poured ourselves into raising this little gem and promise you a puppy coming from parents of dashing and docile personalities. If you’re browsing puppies for sale in Kent, be sure to check out this charming little pup. We are experienced in shipping and can arrange details to get your puppy safely home if you’re not already in Kent. We take pride and joy in raising high quality dogs.",
                PetImageSource = "Dog3.png",
                PetLocation = "Kent",
                PetName = "Yammie",
                PetType = new PetType(){Species = "Dog", Breed = "" },
                ColorHex = "#FFDAC1"
            },
new Pet()
            {
                PetID = 56475879,
                PetAge = 8,
                PetDescription = "Meet Blue, a cute Corgi puppy who’s ready to take on the world. Blue sports a confident personality and carries a beautiful brown coat. In addition, Blue will arrive handled daily, child friendly, and cat friendly. We've poured ourselves into raising this little gem and promise you a puppy coming from parents of charming and clever personalities. If you’re browsing puppies for sale in Inverness, be sure to check out this charming little pup. We are experienced in shipping and can arrange details to get your puppy safely home if you’re not already in Inverness. We take pride and joy in raising high quality dogs.",
                PetImageSource = "Dog4.png",
                PetLocation = "Inverness",
                PetName = "Blue",
                PetType = new PetType(){ Species = "Dog", Breed = ""},
                ColorHex = "#E2F0CB"
            },
new Pet()
            {
                PetID = 98780978,
                PetAge = 5,
                PetDescription = "a short-furred lilac caramel sparbled tabby cat with blue-green eyes; with a bobbed tail, and is deaf, with a limp",
                PetImageSource = "cat1.png",
                PetLocation = "Cambridge",
                PetName = "Daiquiri",
                PetType = new PetType(){ Species = "Cat", Breed = ""},
                ColorHex = "#B5EAD7"
            },
new Pet()
            {
                PetID = 1231234543,
                PetAge = 1,
                PetDescription = "a medium-furred smoke cinnamon calico tom with white blaze with dichroic amber and green eyes; with a curly tail",
                PetImageSource = "cat2.png",
                PetLocation = "Oxford",
                PetName = "Jannali",
                PetType = new PetType(){Species = "Cat", Breed = "" },
                ColorHex = "#C7CEEA"
            },
new Pet()
            {
                PetID = 21576867,
                PetAge = 1,
                PetDescription = "a short-furred cinnamon tortoiseshell she-cat with white tipped tail with dichroic green and brown eyes; and is blind, with a kinked tail",
                PetImageSource = "cat3.png",
                PetLocation = "Devon",
                PetName = "Maximus",
                PetType = new PetType(){Species = "Cat", Breed = "" },
                ColorHex = "#B5EAD7"
            },
new Pet()
            {
                PetID = 32432423423,
                PetAge = 7,
                PetDescription = "a long-furred white she-cat with dichroic green and brown eyes; with large ears",
                PetImageSource = "cat4.png",
                PetLocation = "Manchester",
                PetName = "Yeska",
                PetType = new PetType(){Species = "Cat", Breed = "" },
                ColorHex = "#E2F0CB"
            },
new Pet()
            {
                PetID = 123432,
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
                PetID = 1231445,
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
                PetID = 220389,
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
                PetID = 23423425,
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
                PetID = 10223432,
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
                PetID = 3423,
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
                PetID = 2134324,
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