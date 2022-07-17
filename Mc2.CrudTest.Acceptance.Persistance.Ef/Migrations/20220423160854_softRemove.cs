using Microsoft.EntityFrameworkCore.Migrations;

namespace Mc2.CrudTest.Acceptance.Persistance.Ef.Migrations
{
    public partial class softRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "customers");
        }
    }
}
