using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttendanceSystem.Migrations
{
    public partial class ClassStudentJoinEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudent_Classes_ClassesId",
                table: "ClassStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudent_Students_StudentsId",
                table: "ClassStudent");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "ClassStudent",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "ClassStudent",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassStudent_StudentsId",
                table: "ClassStudent",
                newName: "IX_ClassStudent_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudent_Classes_ClassId",
                table: "ClassStudent",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudent_Students_StudentId",
                table: "ClassStudent",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudent_Classes_ClassId",
                table: "ClassStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudent_Students_StudentId",
                table: "ClassStudent");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "ClassStudent",
                newName: "StudentsId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "ClassStudent",
                newName: "ClassesId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassStudent_StudentId",
                table: "ClassStudent",
                newName: "IX_ClassStudent_StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudent_Classes_ClassesId",
                table: "ClassStudent",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudent_Students_StudentsId",
                table: "ClassStudent",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
