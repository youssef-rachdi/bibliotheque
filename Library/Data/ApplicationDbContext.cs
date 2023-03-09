
using FluentAssertions.Common;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using WebBooks.Models;

namespace Library.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var ConnectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(ConnectionString);


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


        public DbSet<Book> books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
    }
}
