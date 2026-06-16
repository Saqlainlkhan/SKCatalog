using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SKCatalog.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SKClasses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    Department = table.Column<string>(type: "TEXT", nullable: false),
                    Credit = table.Column<int>(type: "INTEGER", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKClasses", x => x.CourseId);
                });

            migrationBuilder.InsertData(
                table: "SKClasses",
                columns: new[] { "CourseId", "Capacity", "Credit", "Department", "Name", "Number" },
                values: new object[,]
                {
                    { 1, 20, 3, "Computer Science", "Internet Programming", "CPSC-8720-02" },
                    { 2, 25, 3, "Computer Science", "Database Systems", "CPSC-6710-01" },
                    { 3, 30, 3, "Health Informatica", "Health Data Management", "HINF-6100-01" },
                    { 4, 35, 4, "Match", "Calculus I", "MATH-2211-01" },
                    { 5, 24, 4, "Chemistry", "Organic Chemistry", "CHEM-3300-02" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SKClasses");
        }
    }
}
