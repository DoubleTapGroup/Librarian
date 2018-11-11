using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Librarian.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ISBN = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    AuthorId = table.Column<int>(nullable: false),
                    PublisherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rental",
                columns: table => new
                {
                    RentalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RentalDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: true),
                    BookId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental", x => x.RentalId);
                    table.ForeignKey(
                        name: "FK_Rental_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rental_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 1, "Isaac Asimov" },
                    { 15, "Robert Alvis" },
                    { 14, "George Travis" },
                    { 13, "Michael Philips" },
                    { 12, "Max Brooks" },
                    { 10, "Richard Matheson" },
                    { 9, "Valentino Rossi" },
                    { 11, "Michael Loran" },
                    { 7, "Albert Einstein" },
                    { 6, "George Lucas" },
                    { 5, "Dan Hampton" },
                    { 4, "Dmitry Glukhovsky" },
                    { 3, "Bob Ross" },
                    { 2, "Neil DeGrasse Tyson" },
                    { 8, "Keanu Reeves" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[,]
                {
                    { 10, "Open Door Publishing" },
                    { 15, "Round Publishing" },
                    { 14, "Mars Publishing" },
                    { 13, "Ocean Publishing Company" },
                    { 12, "(BLS) Blue Sky Publishing" },
                    { 11, "Historical Publishing" },
                    { 9, "(MGP) MotoGP Publishing" },
                    { 7, "Hometown Publishing Company" },
                    { 6, "Green Glass Publishing" },
                    { 5, "(AVL) Aviation Lovers" },
                    { 4, "(RBA) Russian Books Art" },
                    { 3, "Painting Society" },
                    { 2, "(HOS) High Octane Society" },
                    { 1, "BigEarth Publishing Company" },
                    { 8, "(PHC) Philosophical Publishing Company" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 13, "Hollow Avenue 34a", "SarahEnger@outlook.com", "Sarah", "Enger", "325-225-701" },
                    { 12, "Diamond Avenue 87", "VNick21@yahoo.com", "Nick", "Valentine", null },
                    { 11, "Brock Avenue 10b", "William34@yahoo.com", "William", "Terrens", null },
                    { 10, "Guiness Square 3", "MAmanda2@outlook.com", "Amanda", "Miller", null },
                    { 9, "Central Avenue 45a", "GeorgeY@yahoo.com", "George", "Yellow", "992-255-260" },
                    { 8, "Madison Square 260 3a", "PB22@gmail.com", "Phoebe", "Bertram", "555-119-653" },
                    { 4, "Brock Avenue 4c", "Susan29@gmail.com", "Susan", "Finte", null },
                    { 6, "Hollow Avenue 34", "MLon@outlook.com", "Michael", "Lonig", null },
                    { 5, "Madison Square 301", "CGeller@yahoo.com", "Carol", "Geller", "501-105-228" },
                    { 3, "Mint Hills 25a", "RTom31@outlook.com", "Tom", "Rogers", "681-442-990" },
                    { 2, "Madison Square 255 3b", "amanda55@yahoo.com", "Amanda", "Stevens", "555-234-523" },
                    { 1, "Midgar Garden 24b", "john.slavinsky@yahoo.com", "John", "Slavinsky", null },
                    { 7, "Green Hills 02c", "ECarter@gmail.com", "Ethan", "Carter", "773-093-442" },
                    { 14, "Central Avenue 24a", "Rose99@yahoo.com", "Rose", "Kinner", null }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AuthorId", "ISBN", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 1, 2, "IBS-1024-691", 1, "Physics for people in the hurry" },
                    { 2, 1, "IBS-512-1324", 2, "Autonomous Mind" },
                    { 7, 12, "IBS-753-8246", 2, "World War Z" },
                    { 3, 3, "IBS-648-4923", 3, "The Joy of Painting" },
                    { 4, 4, "IBS-235-3478", 4, "Metro 2033" },
                    { 6, 6, "IBS-834-0153", 6, "Art of Filing" },
                    { 10, 8, "IBS-072-1043", 6, "Open Mind" },
                    { 13, 13, "IBS-559-2455", 6, "Human Behaviour" },
                    { 9, 10, "IBS-386-9942", 7, "I Am Legend" },
                    { 8, 9, "IBS-215-7345", 9, "What If I Had Never Tried" },
                    { 11, 14, "IBS-930-0052", 11, "World War I" },
                    { 5, 5, "IBS-164-1847", 12, "Viper. F-16 Pilot" },
                    { 14, 15, "IBS-286-2001", 12, "2000 - A new age" },
                    { 12, 7, "IBS-435-2954", 13, "Theory of Relativity" }
                });

            migrationBuilder.InsertData(
                table: "Rental",
                columns: new[] { "RentalId", "BookId", "RentalDate", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2018, 11, 11, 16, 43, 22, 482, DateTimeKind.Local), null, 2 },
                    { 5, 1, new DateTime(2017, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, 1, new DateTime(2018, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2018, 11, 11, 16, 43, 22, 485, DateTimeKind.Local), null, 1 },
                    { 4, 2, new DateTime(2018, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 6, 2, new DateTime(2017, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, 7, new DateTime(2018, 11, 11, 16, 43, 22, 485, DateTimeKind.Local), null, 5 },
                    { 13, 4, new DateTime(2018, 11, 11, 16, 43, 22, 485, DateTimeKind.Local), null, 8 },
                    { 15, 4, new DateTime(2018, 11, 11, 16, 43, 22, 485, DateTimeKind.Local), null, 12 },
                    { 11, 13, new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, 9, new DateTime(2017, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 10, 11, new DateTime(2018, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 3, 14, new DateTime(2018, 11, 11, 16, 43, 22, 485, DateTimeKind.Local), null, 10 },
                    { 8, 14, new DateTime(2018, 11, 11, 16, 43, 22, 485, DateTimeKind.Local), null, 8 },
                    { 14, 12, new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_BookId",
                table: "Rental",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_UserId",
                table: "Rental",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rental");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Publisher");
        }
    }
}
