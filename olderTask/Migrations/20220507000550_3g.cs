using Microsoft.EntityFrameworkCore.Migrations;

namespace olderTask.Migrations
{
    public partial class _3g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Subjects_SubjectId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Subjects_Subjectid",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "Subjectid",
                table: "Subjects",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Subjectid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Subjects_SubjectId",
                table: "OrderDetail",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Subjectid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Subjects_Subjectid",
                table: "ShoppingCartItems",
                column: "Subjectid",
                principalTable: "Subjects",
                principalColumn: "Subjectid",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Subjectid",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "id");

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
    }
}
