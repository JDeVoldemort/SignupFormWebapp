using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using C_Website.Models;

namespace C_Website.Data
{
    public class C_WebsiteContext : DbContext
    {
        public C_WebsiteContext (DbContextOptions<C_WebsiteContext> options)
            : base(options)
        {
        }
        /*public DbSet<Person> Person { get; set; }*/
/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
        }*/
        public DbSet<Person> Person { get; set; } = default!;
    }
}
