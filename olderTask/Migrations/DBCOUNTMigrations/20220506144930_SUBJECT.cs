using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace olderTask.Migrations.DBCOUNTMigrations
{
    public partial class SUBJECT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Olders_OLDERSId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Olders_OLDERSid",
                table: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Olders");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_OLDERSid",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_OLDERSId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "OLDERSid",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "OLDERSId",
                table: "OrderDetail");

            migrationBuilder.AddColumn<int>(
                name: "Subjectid",
                table: "ShoppingCartItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "OrderDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_Subjectid",
                table: "ShoppingCartItems",
                column: "Subjectid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_SubjectId",
                table: "OrderDetail",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Subjects_SubjectId",
                table: "OrderDetail",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Subjects_Subjectid",
                table: "ShoppingCartItems",
                column: "Subjectid",
                principalTable: "Subjects",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Subjects_SubjectId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Subjects_Subjectid",
                table: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_Subjectid",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_SubjectId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Subjectid",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "OrderDetail");

            migrationBuilder.AddColumn<int>(
                name: "OLDERSid",
                table: "ShoppingCartItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OLDERSId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Olders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olders", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_OLDERSid",
                table: "ShoppingCartItems",
                column: "OLDERSid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OLDERSId",
                table: "OrderDetail",
                column: "OLDERSId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Olders_OLDERSId",
                table: "OrderDetail",
                column: "OLDERSId",
                principalTable: "Olders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Olders_OLDERSid",
                table: "ShoppingCartItems",
                column: "OLDERSid",
                principalTable: "Olders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
