using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Librarian.Models
{
    public class RentalsContext : DbContext
    {
        public RentalsContext (DbContextOptions<RentalsContext> options)
            : base(options)
        {
        }

        public DbSet<Librarian.Models.Rental> Rental { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rental>().HasData(
                new { RentalID = 1, RentalDate = DateTime.Now, ReturnDate = DateTime.Now },
                new { RentalID = 2, RentalDate = DateTime.Now, ReturnDate = DateTime.Now },
                new { RentalID = 3, RentalDate = DateTime.Now, ReturnDate = DateTime.Now },
                new { RentalID = 4, RentalDate = DateTime.Now, ReturnDate = DateTime.Now });
        }
    }
}
