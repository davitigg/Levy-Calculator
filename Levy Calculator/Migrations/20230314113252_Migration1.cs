using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Levy_Calculator.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YearCoefficients",
                columns: table => new
                {
                    Year = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coefficient = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearCoefficients", x => x.Year);
                });

            migrationBuilder.InsertData(
                table: "YearCoefficients",
                columns: new[] { "Year", "Coefficient" },
                values: new object[,]
                {
                    { 1965, 5.0 },
                    { 1966, 5.0 },
                    { 1967, 5.0 },
                    { 1968, 5.0 },
                    { 1969, 5.0 },
                    { 1970, 5.0 },
                    { 1971, 5.0 },
                    { 1972, 5.0 },
                    { 1973, 5.0 },
                    { 1974, 5.0 },
                    { 1975, 5.0 },
                    { 1976, 5.0 },
                    { 1977, 5.0 },
                    { 1978, 5.0 },
                    { 1979, 5.0 },
                    { 1980, 5.0 },
                    { 1981, 5.0 },
                    { 1982, 5.0 },
                    { 1983, 5.0 },
                    { 1984, 5.0 },
                    { 1985, 5.0 },
                    { 1986, 5.0 },
                    { 1987, 5.0 },
                    { 1988, 5.0 },
                    { 1989, 5.0 },
                    { 1990, 5.0 },
                    { 1991, 5.0 },
                    { 1992, 5.0 },
                    { 1993, 5.0 },
                    { 1994, 5.0 },
                    { 1995, 5.0 },
                    { 1996, 5.0 },
                    { 1997, 5.0 },
                    { 1998, 5.0 },
                    { 1999, 5.0 },
                    { 2000, 2.3999999999999999 },
                    { 2001, 2.5 },
                    { 2002, 2.7999999999999998 },
                    { 2003, 3.0 },
                    { 2004, 3.0 },
                    { 2005, 3.0 },
                    { 2006, 3.0 },
                    { 2007, 3.0 },
                    { 2008, 3.0 },
                    { 2009, 3.0 },
                    { 2010, 3.0 },
                    { 2011, 3.0 },
                    { 2012, 3.0 },
                    { 2013, 3.0 },
                    { 2014, 3.0 },
                    { 2015, 3.0 },
                    { 2016, 3.0 },
                    { 2017, 3.0 },
                    { 2018, 1.5 },
                    { 2019, 1.5 },
                    { 2020, 1.5 },
                    { 2021, 1.5 },
                    { 2022, 1.5 },
                    { 2023, 1.3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YearCoefficients");
        }
    }
}
