using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Librarian.Models;

namespace Librarian.Models
{
    public class LibrarianContext : DbContext
    {
        public LibrarianContext (DbContextOptions<LibrarianContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
		public DbSet<Rental> Rental { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<Author> Author { get; set; }
		public DbSet<Publisher> Publisher { get; set; }

		/// <summary>
		/// Creating seeds for tables in DB
		/// </summary>
		/// <param name="modelBuilder"></param>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Book>()
				.HasOne(r => r.Author);

			modelBuilder.Entity<Book>()
				.HasOne(r => r.Publisher);

			modelBuilder.Entity<Rental>()
				.HasOne(r => r.User);

			modelBuilder.Entity<Rental>()
				.HasOne(r => r.Book);

			modelBuilder.Entity<Author>().HasData(
				new Author
				{
					AuthorId = 1,
					Name = "Isaac Asimov"
				},
				new Author
				{
					AuthorId = 2,
					Name = "Neil DeGrasse Tyson"
				}
			);

			modelBuilder.Entity<Publisher>().HasData(
				new Publisher
				{
					PublisherId = 1,
					Name = "BigEarth Publishing Company"
				},
				new Publisher
				{
					PublisherId = 2,
					Name = "(HOS) High Octane Society"
				}
			);


			modelBuilder.Entity<Book>().HasData(
				new Book
				{
					BookId = 1,
					ISBN = "IBS-1024-691",
					Title = "Physics for people in the hurry",
					AuthorId = 2,
					PublisherId = 1,
				},
				new Book
				{
					BookId = 2,
					ISBN = "IBS-512-1324",
					Title = "Autonomous Mind",
					AuthorId = 1,
					PublisherId = 2,
				}
			);

			modelBuilder.Entity<User>().HasData(
				new User
				{
					UserId = 1,
					FirstName = "John",
					LastName = "Slavinsky",
					PhoneNumber = null,
					Email = "john.slavinsky@yahoo.com",
					Address = "Midgar Garden 24b"
				},
				new User
				{
					UserId = 2,
					FirstName = "Amanda",
					LastName = "Stevens",
					PhoneNumber = "555-234-523",
					Email = "amanda55@yahoo.com",
					Address = "Madison Square 255 3b"
				}
			);

			modelBuilder.Entity<Rental>().HasData(
				new Rental
				{
					RentalId = 1,
					RentalDate = DateTime.Now,
					ReturnDate = null,
					BookId = 1,
					UserId = 2
				},
				new Rental
				{
					RentalId = 2,
					RentalDate = DateTime.Now,
					ReturnDate = null,
					BookId = 2,
					UserId = 1
				}
			);
		}
    }
}
