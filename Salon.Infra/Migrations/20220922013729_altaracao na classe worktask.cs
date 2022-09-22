using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Infra.Migrations
{
    public partial class altaracaonaclasseworktask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Services_IdService",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_IdService",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ServiceId",
                table: "Tasks",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Services_ServiceId",
                table: "Tasks",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Services_ServiceId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ServiceId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Tasks");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_IdService",
                table: "Tasks",
                column: "IdService");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Services_IdService",
                table: "Tasks",
                column: "IdService",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
