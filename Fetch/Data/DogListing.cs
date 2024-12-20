using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FetchApp.Data
{
    public class DogListing
    {
        [Key]  // Marks this as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //DB will generate the key
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? Breed { get; set; }
        public string? ImagePath { get; set; }
        public string? Description { get; set; }
    }
}
