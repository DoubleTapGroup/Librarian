﻿// <auto-generated />
using System;
using Librarian.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Librarian.Migrations
{
    [DbContext(typeof(LibrarianContext))]
    partial class LibrarianContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Librarian.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorID");

                    b.Property<string>("ISBN");

                    b.Property<int>("PublisherID");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Book");

                    b.HasData(
                        new { ID = 1, AuthorID = 1, ISBN = "1111111111111", PublisherID = 1, Title = "Cooking for dummies" },
                        new { ID = 2, AuthorID = 2, ISBN = "2222222222222", PublisherID = 2, Title = "Programming for dummies" },
                        new { ID = 3, AuthorID = 3, ISBN = "3333333333333", PublisherID = 3, Title = "Engineering for dummies" },
                        new { ID = 4, AuthorID = 4, ISBN = "4444444444444", PublisherID = 4, Title = "Dummies for dummies" }
                    );
                });

            modelBuilder.Entity("Librarian.Models.Rental", b =>
                {
                    b.Property<int>("RentalID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RentalDate");

                    b.Property<DateTime>("ReturnDate");

                    b.HasKey("RentalID");

                    b.ToTable("Rental");

                    b.HasData(
                        new { RentalID = 1, RentalDate = new DateTime(2012, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { RentalID = 2, RentalDate = new DateTime(2015, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { RentalID = 3, RentalDate = new DateTime(2030, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { RentalID = 4, RentalDate = new DateTime(2017, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                    );
                });

            modelBuilder.Entity("Librarian.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("Email");

                    b.Property<string>("FisrtName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("UserID");

                    b.ToTable("User");

                    b.HasData(
                        new { UserID = 1, Adress = "test1", Email = "1@gmail.com", FisrtName = "Bob", LastName = "Johnson", PhoneNumber = "1234567890" },
                        new { UserID = 2, Adress = "test2", Email = "2@gmail.com", FisrtName = "John", LastName = "Bobson", PhoneNumber = "0987654321" },
                        new { UserID = 3, Adress = "test3", Email = "3@gmail.com", FisrtName = "Tom", LastName = "Johnson", PhoneNumber = "1238904567" },
                        new { UserID = 4, Adress = "test4", Email = "4@gmail.com", FisrtName = "John", LastName = "Tomson", PhoneNumber = "0983217654" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
