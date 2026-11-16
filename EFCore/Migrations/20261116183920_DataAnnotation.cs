using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "EmployeesInfo",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                schema: "dbo",
                table: "EmployeesInfo",
                newName: "UniqueKey");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "EmployeesInfo",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesInfo",
                schema: "dbo",
                table: "EmployeesInfo",
                column: "UniqueKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesInfo",
                schema: "dbo",
                table: "EmployeesInfo");

            migrationBuilder.RenameTable(
                name: "EmployeesInfo",
                schema: "dbo",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "UniqueKey",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");
        }
    }
}
