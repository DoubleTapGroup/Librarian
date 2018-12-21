﻿// <auto-generated />
using System;
using Librarian.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Librarian.Migrations
{
    [DbContext(typeof(LibrarianContext))]
    [Migration("20181204222343_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Librarian.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new { AuthorId = 1, Name = "Isaac Asimov" },
                        new { AuthorId = 2, Name = "Neil DeGrasse Tyson" },
                        new { AuthorId = 3, Name = "Bob Ross" },
                        new { AuthorId = 4, Name = "Dmitry Glukhovsky" },
                        new { AuthorId = 5, Name = "Dan Hampton" },
                        new { AuthorId = 6, Name = "George Lucas" },
                        new { AuthorId = 7, Name = "Albert Einstein" },
                        new { AuthorId = 8, Name = "Keanu Reeves" },
                        new { AuthorId = 9, Name = "Valentino Rossi" },
                        new { AuthorId = 10, Name = "Richard Matheson" },
                        new { AuthorId = 11, Name = "Michael Loran" },
                        new { AuthorId = 12, Name = "Max Brooks" },
                        new { AuthorId = 13, Name = "Michael Philips" },
                        new { AuthorId = 14, Name = "George Travis" },
                        new { AuthorId = 15, Name = "Robert Alvis" }
                    );
                });

            modelBuilder.Entity("Librarian.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<string>("ISBN");

                    b.Property<int>("PublisherId");

                    b.Property<string>("Title");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Book");

                    b.HasData(
                        new { BookId = 1, AuthorId = 2, ISBN = "IBS-1024-691", PublisherId = 1, Title = "Physics for people in the hurry" },
                        new { BookId = 2, AuthorId = 1, ISBN = "IBS-512-1324", PublisherId = 2, Title = "Autonomous Mind" },
                        new { BookId = 3, AuthorId = 3, ISBN = "IBS-648-4923", PublisherId = 3, Title = "The Joy of Painting" },
                        new { BookId = 4, AuthorId = 4, ISBN = "IBS-235-3478", PublisherId = 4, Title = "Metro 2033" },
                        new { BookId = 5, AuthorId = 5, ISBN = "IBS-164-1847", PublisherId = 12, Title = "Viper. F-16 Pilot" },
                        new { BookId = 6, AuthorId = 6, ISBN = "IBS-834-0153", PublisherId = 6, Title = "Art of Filing" },
                        new { BookId = 7, AuthorId = 12, ISBN = "IBS-753-8246", PublisherId = 2, Title = "World War Z" },
                        new { BookId = 8, AuthorId = 9, ISBN = "IBS-215-7345", PublisherId = 9, Title = "What If I Had Never Tried" },
                        new { BookId = 9, AuthorId = 10, ISBN = "IBS-386-9942", PublisherId = 7, Title = "I Am Legend" },
                        new { BookId = 10, AuthorId = 8, ISBN = "IBS-072-1043", PublisherId = 6, Title = "Open Mind" },
                        new { BookId = 11, AuthorId = 14, ISBN = "IBS-930-0052", PublisherId = 11, Title = "World War I" },
                        new { BookId = 12, AuthorId = 7, ISBN = "IBS-435-2954", PublisherId = 13, Title = "Theory of Relativity" },
                        new { BookId = 13, AuthorId = 13, ISBN = "IBS-559-2455", PublisherId = 6, Title = "Human Behaviour" },
                        new { BookId = 14, AuthorId = 15, ISBN = "IBS-286-2001", PublisherId = 12, Title = "2000 - A new age" }
                    );
                });

            modelBuilder.Entity("Librarian.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("PublisherId");

                    b.ToTable("Publisher");

                    b.HasData(
                        new { PublisherId = 1, Name = "BigEarth Publishing Company" },
                        new { PublisherId = 2, Name = "(HOS) High Octane Society" },
                        new { PublisherId = 3, Name = "Painting Society" },
                        new { PublisherId = 4, Name = "(RBA) Russian Books Art" },
                        new { PublisherId = 5, Name = "(AVL) Aviation Lovers" },
                        new { PublisherId = 6, Name = "Green Glass Publishing" },
                        new { PublisherId = 7, Name = "Hometown Publishing Company" },
                        new { PublisherId = 8, Name = "(PHC) Philosophical Publishing Company" },
                        new { PublisherId = 9, Name = "(MGP) MotoGP Publishing" },
                        new { PublisherId = 10, Name = "Open Door Publishing" },
                        new { PublisherId = 11, Name = "Historical Publishing" },
                        new { PublisherId = 12, Name = "(BLS) Blue Sky Publishing" },
                        new { PublisherId = 13, Name = "Ocean Publishing Company" },
                        new { PublisherId = 14, Name = "Mars Publishing" },
                        new { PublisherId = 15, Name = "Round Publishing" }
                    );
                });

            modelBuilder.Entity("Librarian.Models.Rental", b =>
                {
                    b.Property<int>("RentalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<DateTime>("RentalDate");

                    b.Property<DateTime?>("ReturnDate");

                    b.Property<int>("UserId");

                    b.HasKey("RentalId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Rental");

                    b.HasData(
                        new { RentalId = 1, BookId = 1, RentalDate = new DateTime(2018, 12, 4, 23, 23, 42, 975, DateTimeKind.Local), UserId = 2 },
                        new { RentalId = 2, BookId = 2, RentalDate = new DateTime(2018, 12, 4, 23, 23, 42, 975, DateTimeKind.Local), UserId = 1 },
                        new { RentalId = 3, BookId = 14, RentalDate = new DateTime(2018, 12, 4, 23, 23, 42, 975, DateTimeKind.Local), UserId = 10 },
                        new { RentalId = 4, BookId = 2, RentalDate = new DateTime(2018, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = 1 },
                        new { RentalId = 5, BookId = 1, RentalDate = new DateTime(2017, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(2017, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = 4 },
                        new { RentalId = 6, BookId = 2, RentalDate = new DateTime(2017, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = 1 },
                        new { RentalId = 7, BookId = 9, RentalDate = new DateTime(2017, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(2017, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = 13 },
                        new { RentalId = 8, BookId = 14, RentalDate = new DateTime(2018, 12, 4, 23, 23, 42, 975, DateTimeKind.Local), UserId = 8 },
                        new { RentalId = 9, BookId = 1, RentalDate = new DateTime(2018, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(2018, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = 1 },
                        new { RentalId = 10, BookId = 11, RentalDate = new DateTime(2018, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = 9 },
                        new { RentalId = 11, BookId = 13, RentalDate = new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(2018, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = 3 },
                        new { RentalId = 12, BookId = 7, RentalDate = new DateTime(2018, 12, 4, 23, 23, 42, 975, DateTimeKind.Local), UserId = 5 },
                        new { RentalId = 13, BookId = 4, RentalDate = new DateTime(2018, 12, 4, 23, 23, 42, 975, DateTimeKind.Local), UserId = 8 },
                        new { RentalId = 14, BookId = 12, RentalDate = new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(2018, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), UserId = 11 },
                        new { RentalId = 15, BookId = 4, RentalDate = new DateTime(2018, 12, 4, 23, 23, 42, 975, DateTimeKind.Local), UserId = 12 }
                    );
                });

            modelBuilder.Entity("Librarian.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Rank");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new { UserId = 1, Address = "Midgar Garden 24b", Email = "john.slavinsky@yahoo.com", FirstName = "John", LastName = "Slavinsky" },
                        new { UserId = 2, Address = "Madison Square 255 3b", Email = "amanda55@yahoo.com", FirstName = "Amanda", LastName = "Stevens", PhoneNumber = "555-234-523" },
                        new { UserId = 3, Address = "Mint Hills 25a", Email = "RTom31@outlook.com", FirstName = "Tom", LastName = "Rogers", PhoneNumber = "681-442-990" },
                        new { UserId = 4, Address = "Brock Avenue 4c", Email = "Susan29@gmail.com", FirstName = "Susan", LastName = "Finte" },
                        new { UserId = 5, Address = "Madison Square 301", Email = "CGeller@yahoo.com", FirstName = "Carol", LastName = "Geller", PhoneNumber = "501-105-228" },
                        new { UserId = 6, Address = "Hollow Avenue 34", Email = "MLon@outlook.com", FirstName = "Michael", LastName = "Lonig" },
                        new { UserId = 7, Address = "Green Hills 02c", Email = "ECarter@gmail.com", FirstName = "Ethan", LastName = "Carter", PhoneNumber = "773-093-442" },
                        new { UserId = 8, Address = "Madison Square 260 3a", Email = "PB22@gmail.com", FirstName = "Phoebe", LastName = "Bertram", PhoneNumber = "555-119-653" },
                        new { UserId = 9, Address = "Central Avenue 45a", Email = "GeorgeY@yahoo.com", FirstName = "George", LastName = "Yellow", PhoneNumber = "992-255-260" },
                        new { UserId = 10, Address = "Guiness Square 3", Email = "MAmanda2@outlook.com", FirstName = "Amanda", LastName = "Miller" },
                        new { UserId = 11, Address = "Brock Avenue 10b", Email = "William34@yahoo.com", FirstName = "William", LastName = "Terrens" },
                        new { UserId = 12, Address = "Diamond Avenue 87", Email = "VNick21@yahoo.com", FirstName = "Nick", LastName = "Valentine" },
                        new { UserId = 13, Address = "Hollow Avenue 34a", Email = "SarahEnger@outlook.com", FirstName = "Sarah", LastName = "Enger", PhoneNumber = "325-225-701" },
                        new { UserId = 14, Address = "Central Avenue 24a", Email = "Rose99@yahoo.com", FirstName = "Rose", LastName = "Kinner" },
                        new { UserId = 15, Address = "Monolith Gener 2b", Email = "admin@librarian.com", FirstName = "Terry", LastName = "Adminsky", Password = "admin", Rank = "admin" }
                    );
                });

            modelBuilder.Entity("Librarian.Models.Book", b =>
                {
                    b.HasOne("Librarian.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Librarian.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Librarian.Models.Rental", b =>
                {
                    b.HasOne("Librarian.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Librarian.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}