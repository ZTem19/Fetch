namespace FetchApp.Data
{
    public class DogService  /* hard coded because there's no database for dogs yet */
    {
        public static readonly List<DogListing> Dogs = new List<DogListing>
        {
            new DogListing { Name = "Cameron", Age = "4 years", Breed = "Goldendoodle", ImagePath = "../../Assets/dogModels/modelCameron.jpg" },
            new DogListing { Name = "Gibbs", Age = "6 years", Breed = "Labradoodle", ImagePath = "../../Assets/dogModels/modelGibbs.jpg" },
            new DogListing { Name = "Yang Tze", Age = "5 years", Breed = "Shih-Tzu Mix", ImagePath = "../../Assets/dogModels/modelYang.jpg" },
            new DogListing { Name = "Gigi", Age = "2 years", Breed = "French Bulldog", ImagePath = "../../Assets/dogModels/modelGigi.jpg" },
            new DogListing { Name = "Randy", Age = "7 years", Breed = "Chihuahua Mix", ImagePath = "../../Assets/dogModels/modelRandy.jpg" },
            new DogListing { Name = "Pixie", Age = "3 years", Breed = "Shiba Mix", ImagePath = "../../Assets/dogModels/modelPixie.jpg" },
            new DogListing { Name = "Pip", Age = "4 months", Breed = "Husky Mix", ImagePath = "../../Assets/dogModels/modelPip.jpg" },
            new DogListing { Name = "Tank", Age = "4 Years", Breed = "Black Lab", ImagePath = "../../Assets/dogModels/modelTank.jpg" },


        };

        public List<DogListing> GetDogs()
        {
            return Dogs;
        }

        public List<DogListing> GetRandomDogs(int count)
        {
            var random = new Random();
            var randomizedDogs = new List<DogListing>(Dogs);
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
}
