using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fetch.Models;

namespace Users
{
    public class FetchContext : DbContext
    {
        public FetchContext (DbContextOptions<FetchContext> options)
            : base(options)
        {
        }

        public DbSet<Fetch.Models.User> User { get; set; } = default!;
    }
}
