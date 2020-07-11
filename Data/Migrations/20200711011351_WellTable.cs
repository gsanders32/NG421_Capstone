using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class WellTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "Wells",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DistrictNumber = table.Column<int>(nullable: true),
                    Elevation = table.Column<int>(nullable: true),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wells", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Wells",
                columns: new[] { "Id", "DistrictNumber", "Elevation", "Latitude", "Longitude" },
                values: new object[] { 1, 1111, 31111, 31.111111000000001, -101.11111099999999 });

            migrationBuilder.InsertData(
                table: "Wells",
                columns: new[] { "Id", "DistrictNumber", "Elevation", "Latitude", "Longitude" },
                values: new object[] { 2, 2222, 32222, 32.222222000000002, -102.222222 });

            migrationBuilder.InsertData(
                table: "Wells",
                columns: new[] { "Id", "DistrictNumber", "Elevation", "Latitude", "Longitude" },
                values: new object[] { 3, 3333, 33333, 33.333333000000003, -103.333333 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wells");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Jon", "Smith" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Bobby", "Miller" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 3, "Sarah", "Brooks" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Sam", "Smith" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Tom", "Miller" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 3, "Mary", "Brooks" });
        }
    }
}
