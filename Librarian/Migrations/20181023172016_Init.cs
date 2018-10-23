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
                name: "Rental",
                columns: table => new
                {
                    RentalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RentalDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental", x => x.RentalID);
                });

            migrationBuilder.InsertData(
                table: "Rental",
                columns: new[] { "RentalID", "RentalDate", "ReturnDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 10, 23, 19, 20, 16, 644, DateTimeKind.Local), new DateTime(2018, 10, 23, 19, 20, 16, 647, DateTimeKind.Local) },
                    { 2, new DateTime(2018, 10, 23, 19, 20, 16, 647, DateTimeKind.Local), new DateTime(2018, 10, 23, 19, 20, 16, 647, DateTimeKind.Local) },
                    { 3, new DateTime(2018, 10, 23, 19, 20, 16, 647, DateTimeKind.Local), new DateTime(2018, 10, 23, 19, 20, 16, 647, DateTimeKind.Local) },
                    { 4, new DateTime(2018, 10, 23, 19, 20, 16, 647, DateTimeKind.Local), new DateTime(2018, 10, 23, 19, 20, 16, 647, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rental");
        }
    }
}
