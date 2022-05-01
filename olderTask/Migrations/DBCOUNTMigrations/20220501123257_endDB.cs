using Microsoft.EntityFrameworkCore.Migrations;

namespace olderTask.Migrations.DBCOUNTMigrations
{
    public partial class endDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mangerdetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mangerdetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Orderid = table.Column<int>(type: "int", nullable: true),
                    Paindsid = table.Column<int>(type: "int", nullable: true),
                    email = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mangerdetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_mangerdetails_Order_Orderid",
                        column: x => x.Orderid,
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mangerdetails_Painds_Paindsid",
                        column: x => x.Paindsid,
                        principalTable: "Painds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mangerdetails_Orderid",
                table: "mangerdetails",
                column: "Orderid");

            migrationBuilder.CreateIndex(
                name: "IX_mangerdetails_Paindsid",
                table: "mangerdetails",
                column: "Paindsid");
        }
    }
}
