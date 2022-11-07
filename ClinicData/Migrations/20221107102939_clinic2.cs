using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicData.Migrations
{
    public partial class clinic2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "otherStaffs",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Phone = table.Column<string>(type: "char(12)", nullable: true),
                    Address = table.Column<string>(type: "varchar(30)", nullable: true),
                    Designation = table.Column<string>(type: "varchar(15)", nullable: false),
                    Gender = table.Column<string>(type: "char(1)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Highest_Qualification = table.Column<string>(type: "varchar(20)", nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_otherStaffs", x => x.StaffID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "otherStaffs");
        }
    }
}
