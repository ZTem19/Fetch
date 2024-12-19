using System.ComponentModel.DataAnnotations;

namespace FetchApp.Data
{
    public class Listing
    {
        public int Id { get; set; }

        public string? Name { get; set; }


        private class Dog { 
            public string? Name { get; set; }
        
            public string? Breed { get; set; }

            [DataType(DataType.MultilineText)]
            public string? Description { get; set; }
        }

    }
}
