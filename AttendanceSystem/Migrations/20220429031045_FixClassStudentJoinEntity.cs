using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttendanceSystem.Migrations
{
    public partial class FixClassStudentJoinEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassStudent",
                table: "ClassStudent");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ClassStudent",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassStudent",
                table: "ClassStudent",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudent_ClassId",
                table: "ClassStudent",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassStudent",
                table: "ClassStudent");

            migrationBuilder.DropIndex(
                name: "IX_ClassStudent_ClassId",
                table: "ClassStudent");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ClassStudent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassStudent",
                table: "ClassStudent",
                columns: new[] { "ClassId", "StudentId" });
        }
    }
}
