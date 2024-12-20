using Microsoft.EntityFrameworkCore;

namespace FetchApp.Data
{
    public class DogService  /* hard coded because there's no database for dogs yet */
    {
        public static readonly List<DogListing> Dogs = new List<DogListing>
        {
            new DogListing { Id=0, Name = "Cameron", Age = "4 years", Breed = "Goldendoodle", ImagePath = "../../Assets/dogModels/modelCameron.jpg", Description="A cheerful 4-year-old Goldendoodle with a love for playtime and snuggles."},
            new DogListing { Id=1, Name = "Gibbs", Age = "6 years", Breed = "Labradoodle", ImagePath = "../../Assets/dogModels/modelGibbs.jpg", Description="A wise and friendly 6-year-old Labradoodle who enjoys long walks and belly rubs." },
            new DogListing { Id=2, Name = "Yang Tze", Age = "5 years", Breed = "Shih-Tzu Mix", ImagePath = "../../Assets/dogModels/modelYang.jpg", Description="This 5-year-old Shih-Tzu Mix is a bundle of charm with a calm and loving personality." },
            new DogListing { Id=3, Name = "Gigi", Age = "2 years", Breed = "French Bulldog", ImagePath = "../../Assets/dogModels/modelGigi.jpg", Description="A spunky 2-year-old French Bulldog who’s full of energy and affection." },
            new DogListing { Id=4, Name = "Randy", Age = "7 years", Breed = "Chihuahua Mix", ImagePath = "../../Assets/dogModels/modelRandy.jpg", Description="A 7-year-old Chihuahua Mix with a big personality and a loyal heart." },
            new DogListing { Id=5, Name = "Pixie", Age = "3 years", Breed = "Shiba Mix", ImagePath = "../../Assets/dogModels/modelPixie.jpg", Description="This 3-year-old Shiba Mix is adventurous, playful, and loves a good chase." },
            new DogListing { Id=6, Name = "Pip", Age = "4 months", Breed = "Husky Mix", ImagePath = "../../Assets/dogModels/modelPip.jpg", Description="A curious 4-month-old Husky Mix, full of energy and ready to explore the world." },
            new DogListing { Id=7, Name = "Tank", Age = "4 Years", Breed = "Black Lab", ImagePath = "../../Assets/dogModels/modelTank.jpg", Description="A strong and loyal 4-year-old Black Lab who’s always ready for an adventure." },


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


        public static void addToContext(FetchAppContext context)
        {
            resetContext(context);

            foreach(DogListing _dog in Dogs)
            {
                var dog = new DogListing();
                dog.Name = _dog.Name;
                dog.Age = _dog.Age;
                dog.Breed = _dog.Breed;
                dog.ImagePath = _dog.ImagePath;
                dog.Description = _dog.Description;


                context.DogListing.Add(dog);

                var dogentry = context.Entry(dog);
                if(dogentry.State != EntityState.Added)
                {
                    throw new Exception("Dog not added");
                }

            }
            context.SaveChanges();
        }

        private static void resetContext(FetchAppContext context)
        {
            var toRemove = context.DogListing;
            foreach (var dog in toRemove)
            {
                context.DogListing.Remove(dog);
            }
            context.SaveChanges();
        }
    }
}
