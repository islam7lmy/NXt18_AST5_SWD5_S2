using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRealtionShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                schema: "dbo",
                table: "DepartmentInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentInfo_ManagerId",
                schema: "dbo",
                table: "DepartmentInfo",
                column: "ManagerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentInfo_Employees_ManagerId",
                schema: "dbo",
                table: "DepartmentInfo",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_DepartmentInfo_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId",
                principalSchema: "dbo",
                principalTable: "DepartmentInfo",
                principalColumn: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentInfo_Employees_ManagerId",
                schema: "dbo",
                table: "DepartmentInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_DepartmentInfo_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentInfo_ManagerId",
                schema: "dbo",
                table: "DepartmentInfo");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                schema: "dbo",
                table: "DepartmentInfo");
        }
    }
}
