using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moghtareb.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateCityGovernurate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GovernurateId",
                table: "City",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_GovernurateId",
                table: "City",
                column: "GovernurateId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Governurate_GovernurateId",
                table: "City",
                column: "GovernurateId",
                principalTable: "Governurate",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Governurate_GovernurateId",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_GovernurateId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "GovernurateId",
                table: "City");
        }
    }
}
