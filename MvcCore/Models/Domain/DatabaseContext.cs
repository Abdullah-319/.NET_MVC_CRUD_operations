﻿using Microsoft.EntityFrameworkCore;

namespace MvcCore.Models.Domain
{
     public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts)
        {
            
        }

        public DbSet<Person> Person { get; set; }
    }
}
