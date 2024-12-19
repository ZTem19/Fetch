namespace FetchApp.Data
{
    public class DogService  /* hard coded because there's no database for dogs yet */
    {
        public List<Dog> GetDogs()
        {
            return new List<Dog>
        {
            new Dog { Name = "Cameron", Age = "4 years", Breed = "Goldendoodle", ImageUrl = "../../Assets/dogModels/modelCameron.jpg" },
            new Dog { Name = "Gibbs", Age = "2 years", Breed = "Labradoodle", ImageUrl = "../../Assets/dogModels/modelGibbs.jpg" },
            new Dog { Name = "Randy", Age = "3 years", Breed = "Chihuahua Mix", ImageUrl = "../../Assets/dogModels/modelRandy.jpg" },
            new Dog { Name = "Pixie", Age = "3 years", Breed = "Shiba Mix", ImageUrl = "../../Assets/dogModels/modelPixie.jpg" },


        };
        }
    }

    public class Dog   /* ju */
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Breed { get; set; }
        public string ImageUrl { get; set; }
    }

}
