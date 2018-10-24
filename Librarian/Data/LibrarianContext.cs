using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Librarian.Models
{
    public class LibrarianContext : DbContext
    {
        public LibrarianContext (DbContextOptions<LibrarianContext> options)
            : base(options)
        {
        }

        public DbSet<Librarian.Models.Book> Book { get; set; }
		public DbSet<Librarian.Models.Rental> Rental { get; set; }
		public DbSet<Librarian.Models.User> User { get; set; }

        /// <summary>
        /// Creating seeds for tables in DB
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rental>().HasData(
                new Rental { RentalID = 1, RentalDate = new DateTime(2012, 03, 01) },
                new Rental { RentalID = 2, RentalDate = new DateTime(2015, 11, 05) },
                new Rental { RentalID = 3, RentalDate = new DateTime(2030, 05, 06) },
                new Rental { RentalID = 4, RentalDate = new DateTime(2017, 08, 03) });

            modelBuilder.Entity<Book>().HasData(
                new Book { ID = 1, ISBN = "1111111111111", Title = "Cooking for dummies", AuthorID = 1, PublisherID = 1 },
                new Book { ID = 2, ISBN = "2222222222222", Title = "Programming for dummies", AuthorID = 2, PublisherID = 2 },
                new Book { ID = 3, ISBN = "3333333333333", Title = "Engineering for dummies", AuthorID = 3, PublisherID = 3 },
                new Book { ID = 4, ISBN = "4444444444444", Title = "Dummies for dummies", AuthorID = 4, PublisherID = 4 });

            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, FisrtName = "Bob", LastName = "Johnson", PhoneNumber = "1234567890", Email = "1@gmail.com", Adress = "test1" },
                new User { UserID = 2, FisrtName = "John", LastName = "Bobson", PhoneNumber = "0987654321", Email = "2@gmail.com", Adress = "test2" },
                new User { UserID = 3, FisrtName = "Tom", LastName = "Johnson", PhoneNumber = "1238904567", Email = "3@gmail.com", Adress = "test3" },
                new User { UserID = 4, FisrtName = "John", LastName = "Tomson", PhoneNumber = "0983217654", Email = "4@gmail.com", Adress = "test4" });
        }
    }
}
