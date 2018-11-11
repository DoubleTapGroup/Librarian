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
<<<<<<< HEAD
				}
			);
=======
				},
                new Author
                {
                    AuthorId = 3,
                    Name = "Bob Ross"
                },
                new Author
                {
                    AuthorId = 4,
                    Name = "Dmitry Glukhovsky"
                },
                new Author
                {
                    AuthorId = 5,
                    Name = "Dan Hampton"
                },
                new Author
                {
                    AuthorId = 6,
                    Name = "George Lucas"
                },
                new Author
                {
                    AuthorId = 7,
                    Name = "Albert Einstein"
                },
                new Author
                {
                    AuthorId = 8,
                    Name = "Keanu Reeves"
                },
                new Author
                {
                    AuthorId = 9,
                    Name = "Valentino Rossi"
                },
                new Author
                {
                    AuthorId = 10,
                    Name = "Richard Matheson"
                },
                new Author
                {
                    AuthorId = 11,
                    Name = "Michael Loran"
                },
                new Author
                {
                    AuthorId = 12,
                    Name = "Max Brooks"
                },
                new Author
                {
                    AuthorId = 13,
                    Name = "Michael Philips"
                },
                new Author
                {
                    AuthorId = 14,
                    Name = "George Travis"
                },
                new Author
                {
                    AuthorId = 15,
                    Name = "Robert Alvis"
                }
            );
>>>>>>> Back-end

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
<<<<<<< HEAD
				}
			);
=======
				},
                new Publisher
                {
                    PublisherId = 3,
                    Name = "Painting Society"
                },
                new Publisher
                {
                    PublisherId = 4,
                    Name = "(RBA) Russian Books Art"
                },
                new Publisher
                {
                    PublisherId = 5,
                    Name = "(AVL) Aviation Lovers"
                },
                new Publisher
                {
                    PublisherId = 6,
                    Name = "Green Glass Publishing"
                },
                new Publisher
                {
                    PublisherId = 7,
                    Name = "Hometown Publishing Company"
                },
                new Publisher
                {
                    PublisherId = 8,
                    Name = "(PHC) Philosophical Publishing Company"
                },
                new Publisher
                {
                    PublisherId = 9,
                    Name = "(MGP) MotoGP Publishing"
                },
                new Publisher
                {
                    PublisherId = 10,
                    Name = "Open Door Publishing"
                },
                new Publisher
                {
                    PublisherId = 11,
                    Name = "Historical Publishing"
                },
                new Publisher
                {
                    PublisherId = 12,
                    Name = "(BLS) Blue Sky Publishing"
                },
                new Publisher
                {
                    PublisherId = 13,
                    Name = "Ocean Publishing Company"
                },
                new Publisher
                {
                    PublisherId = 14,
                    Name = "Mars Publishing"
                },
                new Publisher
                {
                    PublisherId = 15,
                    Name = "Round Publishing"
                }
            );
>>>>>>> Back-end


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
<<<<<<< HEAD
				}
			);
=======
				},
                new Book
                {
                    BookId = 3,
                    ISBN = "IBS-648-4923",
                    Title = "The Joy of Painting",
                    AuthorId = 3,
                    PublisherId = 3,
                },
                new Book
                {
                    BookId = 4,
                    ISBN = "IBS-235-3478",
                    Title = "Metro 2033",
                    AuthorId = 4,
                    PublisherId = 4,
                },
                new Book
                {
                    BookId = 5,
                    ISBN = "IBS-164-1847",
                    Title = "Viper. F-16 Pilot",
                    AuthorId = 5,
                    PublisherId = 12,
                },
                new Book
                {
                    BookId = 6,
                    ISBN = "IBS-834-0153",
                    Title = "Art of Filing",
                    AuthorId = 6,
                    PublisherId = 6,
                },
                new Book
                {
                    BookId = 7,
                    ISBN = "IBS-753-8246",
                    Title = "World War Z",
                    AuthorId = 12,
                    PublisherId = 2,
                },
                new Book
                {
                    BookId = 8,
                    ISBN = "IBS-215-7345",
                    Title = "What If I Had Never Tried",
                    AuthorId = 9,
                    PublisherId = 9,
                },
                new Book
                {
                    BookId = 9,
                    ISBN = "IBS-386-9942",
                    Title = "I Am Legend",
                    AuthorId = 10,
                    PublisherId = 7,
                },
                new Book
                {
                    BookId = 10,
                    ISBN = "IBS-072-1043",
                    Title = "Open Mind",
                    AuthorId = 8,
                    PublisherId = 6,
                },
                new Book
                {
                    BookId = 11,
                    ISBN = "IBS-930-0052",
                    Title = "World War I",
                    AuthorId = 14,
                    PublisherId = 11,
                },
                new Book
                {
                    BookId = 12,
                    ISBN = "IBS-435-2954",
                    Title = "Theory of Relativity",
                    AuthorId = 7,
                    PublisherId = 13,
                },
                new Book
                {
                    BookId = 13,
                    ISBN = "IBS-559-2455",
                    Title = "Human Behaviour",
                    AuthorId = 13,
                    PublisherId = 6,
                },
                new Book
                {
                    BookId = 14,
                    ISBN = "IBS-286-2001",
                    Title = "2000 - A new age",
                    AuthorId = 15,
                    PublisherId = 12,
                }
            );
>>>>>>> Back-end

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
<<<<<<< HEAD
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
=======
				},
                new User
                {
                    UserId = 3,
                    FirstName = "Tom",
                    LastName = "Rogers",
                    PhoneNumber = "681-442-990",
                    Email = "RTom31@outlook.com",
                    Address = "Mint Hills 25a"
                },
                new User
                {
                    UserId = 4,
                    FirstName = "Susan",
                    LastName = "Finte",
                    PhoneNumber = null,
                    Email = "Susan29@gmail.com",
                    Address = "Brock Avenue 4c"
                },
                new User
                {
                    UserId = 5,
                    FirstName = "Carol",
                    LastName = "Geller",
                    PhoneNumber = "501-105-228",
                    Email = "CGeller@yahoo.com",
                    Address = "Madison Square 301"
                },
                new User
                {
                    UserId = 6,
                    FirstName = "Michael",
                    LastName = "Lonig",
                    PhoneNumber = null,
                    Email = "MLon@outlook.com",
                    Address = "Hollow Avenue 34"
                },
                new User
                {
                    UserId = 7,
                    FirstName = "Ethan",
                    LastName = "Carter",
                    PhoneNumber = "773-093-442",
                    Email = "ECarter@gmail.com",
                    Address = "Green Hills 02c"
                },
                new User
                {
                    UserId = 8,
                    FirstName = "Phoebe",
                    LastName = "Bertram",
                    PhoneNumber = "555-119-653",
                    Email = "PB22@gmail.com",
                    Address = "Madison Square 260 3a"
                },
                new User
                {
                    UserId = 9,
                    FirstName = "George",
                    LastName = "Yellow",
                    PhoneNumber = "992-255-260",
                    Email = "GeorgeY@yahoo.com",
                    Address = "Central Avenue 45a"
                },
                new User
                {
                    UserId = 10,
                    FirstName = "Amanda",
                    LastName = "Miller",
                    PhoneNumber = null,
                    Email = "MAmanda2@outlook.com",
                    Address = "Guiness Square 3"
                },
                new User
                {
                    UserId = 11,
                    FirstName = "William",
                    LastName = "Terrens",
                    PhoneNumber = null,
                    Email = "William34@yahoo.com",
                    Address = "Brock Avenue 10b"
                },
                new User
                {
                    UserId = 12,
                    FirstName = "Nick",
                    LastName = "Valentine",
                    PhoneNumber = null,
                    Email = "VNick21@yahoo.com",
                    Address = "Diamond Avenue 87"
                },
                new User
                {
                    UserId = 13,
                    FirstName = "Sarah",
                    LastName = "Enger",
                    PhoneNumber = "325-225-701",
                    Email = "SarahEnger@outlook.com",
                    Address = "Hollow Avenue 34a"
                },
                new User
                {
                    UserId = 14,
                    FirstName = "Rose",
                    LastName = "Kinner",
                    PhoneNumber = null,
                    Email = "Rose99@yahoo.com",
                    Address = "Central Avenue 24a"
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
                },
                new Rental
                {
                    RentalId = 3,
                    RentalDate = DateTime.Now,
                    ReturnDate = null,
                    BookId = 14,
                    UserId = 10
                },
                new Rental
                {
                    RentalId = 4,
                    RentalDate = new DateTime(2018, 01, 4),
                    ReturnDate = null,
                    BookId = 2,
                    UserId = 1
                },
                new Rental
                {
                    RentalId = 5,
                    RentalDate = new DateTime(2017, 04, 01),
                    ReturnDate = new DateTime(2017, 05, 10),
                    BookId = 1,
                    UserId = 4
                },
                new Rental
                {
                    RentalId = 6,
                    RentalDate = new DateTime(2017, 08, 20),
                    ReturnDate = new DateTime(2017, 09, 15),
                    BookId = 2,
                    UserId = 1
                },
                new Rental
                {
                    RentalId = 7,
                    RentalDate = new DateTime(2017, 01, 04),
                    ReturnDate = new DateTime(2017, 03, 05),
                    BookId = 9,
                    UserId = 13
                },
                new Rental
                {
                    RentalId = 8,
                    RentalDate = DateTime.Now,
                    ReturnDate = null,
                    BookId = 14,
                    UserId = 8
                },
                new Rental
                {
                    RentalId = 9,
                    RentalDate = new DateTime(2018, 01, 14),
                    ReturnDate = new DateTime(2018, 03, 07),
                    BookId = 1,
                    UserId = 1
                },
                new Rental
                {
                    RentalId = 10,
                    RentalDate = new DateTime(2018, 04, 25),
                    ReturnDate = new DateTime(2018, 05, 15),
                    BookId = 11,
                    UserId = 9
                },
                new Rental
                {
                    RentalId = 11,
                    RentalDate = new DateTime(2018, 06, 19),
                    ReturnDate = new DateTime(2018, 07, 28),
                    BookId = 13,
                    UserId = 3
                },
                new Rental
                {
                    RentalId = 12,
                    RentalDate = DateTime.Now,
                    ReturnDate = null,
                    BookId = 7,
                    UserId = 5
                },
                new Rental
                {
                    RentalId = 13,
                    RentalDate = DateTime.Now,
                    ReturnDate = null,
                    BookId = 4,
                    UserId = 8
                },
                new Rental
                {
                    RentalId = 14,
                    RentalDate = new DateTime(2018, 09, 02),
                    ReturnDate = new DateTime(2018, 10, 14),
                    BookId = 12,
                    UserId = 11
                },
                new Rental
                {
                    RentalId = 15,
                    RentalDate = DateTime.Now,
                    ReturnDate = null,
                    BookId = 4,
                    UserId = 12
                }
            );
>>>>>>> Back-end
		}
    }
}
