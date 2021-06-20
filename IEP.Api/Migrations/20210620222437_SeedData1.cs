using Microsoft.EntityFrameworkCore.Migrations;

namespace IEP.Api.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientInspector");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Inspector",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inspector_ClientId",
                table: "Inspector",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspector_Client_ClientId",
                table: "Inspector",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspector_Client_ClientId",
                table: "Inspector");

            migrationBuilder.DropIndex(
                name: "IX_Inspector_ClientId",
                table: "Inspector");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Inspector");

            migrationBuilder.CreateTable(
                name: "ClientInspector",
                columns: table => new
                {
                    ClientsId = table.Column<int>(type: "int", nullable: false),
                    InspectorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientInspector", x => new { x.ClientsId, x.InspectorsId });
                    table.ForeignKey(
                        name: "FK_ClientInspector_Client_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientInspector_Inspector_InspectorsId",
                        column: x => x.InspectorsId,
                        principalTable: "Inspector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientInspector_InspectorsId",
                table: "ClientInspector",
                column: "InspectorsId");
        }
    }
}
