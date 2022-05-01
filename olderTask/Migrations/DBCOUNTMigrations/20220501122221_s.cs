using Microsoft.EntityFrameworkCore.Migrations;

namespace olderTask.Migrations.DBCOUNTMigrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mangerdetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<int>(nullable: false),
                    email = table.Column<int>(nullable: false),
                    Orderid = table.Column<int>(nullable: true),
                    Paindsid = table.Column<int>(nullable: true)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mangerdetails");
        }
    }
}
