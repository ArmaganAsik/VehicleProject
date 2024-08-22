using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boats",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boats", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wheels = table.Column<byte>(type: "tinyint", nullable: true),
                    HeadLight = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "ID", "Color", "CreatedDate", "DeletedDate", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6793), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azure", 1 },
                    { 2, 3, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6797), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bavaria ", 1 },
                    { 3, 2, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6798), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeanneau", 1 },
                    { 4, 3, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6799), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "J Boats", 1 },
                    { 5, 1, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6801), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nautorswan", 1 },
                    { 6, 4, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6804), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salona", 1 }
                });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "ID", "Color", "CreatedDate", "DeletedDate", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6733), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neoplan", 1 },
                    { 2, 2, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6736), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Man", 1 },
                    { 3, 1, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6738), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tourismo", 1 },
                    { 4, 3, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6739), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travego", 1 },
                    { 5, 2, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6740), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maraton", 1 },
                    { 6, 1, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6743), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Safir", 1 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "ID", "Color", "CreatedDate", "DeletedDate", "HeadLight", "ModifiedDate", "Name", "Status", "Wheels" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6575), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW 320i", 1, (byte)4 },
                    { 2, 1, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6589), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Citroen C3", 1, (byte)4 },
                    { 3, 4, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6591), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dacia Logan", 1, (byte)4 },
                    { 4, 4, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6592), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fiat Egea", 1, (byte)4 },
                    { 5, 4, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6594), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ford Focus", 1, (byte)4 },
                    { 6, 3, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6599), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honda Civic", 1, (byte)4 },
                    { 7, 2, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6601), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercedes CLA", 1, (byte)4 },
                    { 8, 2, new DateTime(2024, 8, 22, 8, 35, 14, 557, DateTimeKind.Utc).AddTicks(6602), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Opel Corsa", 1, (byte)4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boats");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
