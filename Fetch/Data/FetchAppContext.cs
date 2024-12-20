using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FetchApp.Data
{
    public class FetchAppContext : DbContext
    {
        public FetchAppContext (DbContextOptions<FetchAppContext> options)
            : base(options)
        { 
        }

        public DbSet<FetchApp.Data.DogListing> DogListing { get; set; } = default!;
    }
}
