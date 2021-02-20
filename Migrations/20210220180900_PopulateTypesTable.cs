using Microsoft.EntityFrameworkCore.Migrations;

namespace Raktar.Migrations
{
    public partial class PopulateTypesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Types (Name) VALUES ('Clothes')");
            migrationBuilder.Sql("INSERT INTO Types (Name) VALUES ('Mobile phone accessories')");
            migrationBuilder.Sql("INSERT INTO Types (Name) VALUES ('Jewellery and watches')");
            migrationBuilder.Sql("INSERT INTO Types (Name) VALUES ('Home and kitchen')");
            migrationBuilder.Sql("INSERT INTO Types (Name) VALUES ('Toys')");
            migrationBuilder.Sql("INSERT INTO Types (Name) VALUES ('IT gadgets')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
