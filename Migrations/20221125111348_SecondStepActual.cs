using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFHelloWorld.Migrations
{
    /// <inheritdoc />
    public partial class SecondStepActual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Product (Name, Description) VALUES ('Product 1', 'Product 1 description')");
            migrationBuilder.Sql("INSERT INTO Product (Name, Description) VALUES ('Product 2', 'Product 2 description')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE Product WHERE Name = 'Product 1'");
            migrationBuilder.Sql("DELETE Product WHERE Name = 'Product 2'");
        }
    }
}
