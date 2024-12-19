namespace FetchApp.Data
{
    public class DogService  /* hard coded because there's no database for dogs yet */
    {
        public static readonly List<Dog> Dogs = new List<Dog>
        {
            new Dog { Name = "Cameron", Age = "4 years", Breed = "Goldendoodle", ImageUrl = "../../Assets/dogModels/modelCameron.jpg" },
            new Dog { Name = "Gibbs", Age = "6 years", Breed = "Labradoodle", ImageUrl = "../../Assets/dogModels/modelGibbs.jpg" },
            new Dog { Name = "Yang Tze", Age = "5 years", Breed = "Shih-Tzu Mix", ImageUrl = "../../Assets/dogModels/modelYang.jpg" },
            new Dog { Name = "Gigi", Age = "2 years", Breed = "French Bulldog", ImageUrl = "../../Assets/dogModels/modelGigi.jpg" },
            new Dog { Name = "Randy", Age = "7 years", Breed = "Chihuahua Mix", ImageUrl = "../../Assets/dogModels/modelRandy.jpg" },
            new Dog { Name = "Pixie", Age = "3 years", Breed = "Shiba Mix", ImageUrl = "../../Assets/dogModels/modelPixie.jpg" },
            new Dog { Name = "Pip", Age = "4 months", Breed = "Husky Mix", ImageUrl = "../../Assets/dogModels/modelPip.jpg" },
            new Dog { Name = "Tank", Age = "4 Years", Breed = "Black Lab", ImageUrl = "../../Assets/dogModels/modelTank.jpg" },


        };

        public List<Dog> GetDogs()
        {
            return Dogs;
        }
        public List<Dog> GetRandomDogs(int count)
        {
            var random = new Random();
            var randomizedDogs = new List<Dog>(Dogs);
            int n = randomizedDogs.Count;

            //randomizer algo
            {
                n--;
                int k = random.Next(n + 1);
                var value = randomizedDogs[k];
                randomizedDogs[k] = randomizedDogs[n];
                randomizedDogs[n] = value;
            }

            return randomizedDogs.GetRange(0, Math.Min(count, randomizedDogs.Count));
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
