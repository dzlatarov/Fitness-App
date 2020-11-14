using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitness_App.Persistence.Migrations
{
    public partial class AddLastNamePropertyToApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "LastName",
            //    table: "AspNetUsers",
            //    nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
