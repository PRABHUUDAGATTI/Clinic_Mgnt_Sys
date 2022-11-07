using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicData.Migrations
{
    public partial class clinic11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    DeptNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "varchar(20)", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.DeptNo);
                });

            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Phone = table.Column<string>(type: "char(12)", nullable: true),
                    Address = table.Column<string>(type: "varchar(40)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "char(1)", nullable: false),
                    Deptno = table.Column<int>(type: "int", nullable: false),
                    Charges_Per_Visit = table.Column<float>(type: "real", nullable: false),
                    MonthlySalary = table.Column<float>(type: "real", nullable: false),
                    ReputeIndex = table.Column<float>(type: "real", nullable: false),
                    Patient_Treated = table.Column<int>(type: "int", nullable: false),
                    Qualification = table.Column<string>(type: "varchar(50)", nullable: false),
                    Specialization = table.Column<string>(type: "varchar(50)", nullable: true),
                    Work_Experience = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.DoctorID);
                    table.ForeignKey(
                        name: "FK_doctors_departments_Deptno",
                        column: x => x.Deptno,
                        principalTable: "departments",
                        principalColumn: "DeptNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_doctors_LoginTable_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "LoginTable",
                        principalColumn: "LoginID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_doctors_Deptno",
                table: "doctors",
                column: "Deptno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
