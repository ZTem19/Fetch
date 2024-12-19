namespace FetchApp.Data
{
    public class DogService
    {
        public List<Dog> GetDogs()
        {
            return new List<Dog>
        {
            new Dog { Name = "Cameron", Age = "4 years", Breed = "Goldendoodle", ImageUrl = "../../Assets/dogModels/modelCameron.jpg" },
            new Dog { Name = "Pixie", Age = "3 years", Breed = "Shiba Mix", ImageUrl = "../../Assets/dogModels/modelPixie.jpg" },
            new Dog { Name = "Randy", Age = "3 years", Breed = "Chihuahua Mix", ImageUrl = "../../Assets/dogModels/Randy.jpg" },
            new Dog { Name = "Gibbs", Age = "2 years", Breed = "Labradoodle", ImageUrl = "../../Assets/dogModels/Gibbs.jpg" },

        };
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Breed { get; set; }
        public string ImageUrl { get; set; }
    }

}
