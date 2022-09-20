using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Infra.Migrations
{
    public partial class alteradoclasseworktask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Services_ServiceIdService",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ServiceIdService",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ServiceIdService",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "PriceService",
                table: "Services",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "NameService",
                table: "Services",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DescriptionService",
                table: "Services",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "IdService",
                table: "Services",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "IdClient",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdClient",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Services",
                newName: "PriceService");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Services",
                newName: "NameService");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Services",
                newName: "DescriptionService");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Services",
                newName: "IdService");

            migrationBuilder.AddColumn<int>(
                name: "ServiceIdService",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ServiceIdService",
                table: "Tasks",
                column: "ServiceIdService");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Services_ServiceIdService",
                table: "Tasks",
                column: "ServiceIdService",
                principalTable: "Services",
                principalColumn: "IdService",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
