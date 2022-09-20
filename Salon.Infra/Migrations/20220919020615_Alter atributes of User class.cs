using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Infra.Migrations
{
    public partial class AlteratributesofUserclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserIdUser",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "PasswordUser",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "NameUser",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "LoginUser",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserIdUser",
                table: "Tasks",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_UserIdUser",
                table: "Tasks",
                newName: "IX_Tasks_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "PasswordUser");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "NameUser");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "LoginUser");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "IdUser");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tasks",
                newName: "UserIdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                newName: "IX_Tasks_UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserIdUser",
                table: "Tasks",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
