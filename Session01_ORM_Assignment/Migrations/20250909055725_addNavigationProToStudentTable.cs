using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session01_ORM_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class addNavigationProToStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud_Course",
                columns: table => new
                {
                    stud_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Course", x => x.stud_ID);
                    table.ForeignKey(
                        name: "FK_Stud_Course_Course_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stud_Course_Students_studentID",
                        column: x => x.studentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_studentID",
                table: "Stud_Course",
                column: "studentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Course");
        }
    }
}
