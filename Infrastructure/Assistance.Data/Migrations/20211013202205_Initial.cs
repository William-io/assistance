using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assistance.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    LastName = table.Column<string>(type: "varchar(120)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(120)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(20)", nullable: false),
                    Password = table.Column<string>(type: "varchar(8)", nullable: false),
                    City = table.Column<string>(type: "varchar(40)", nullable: true),
                    State = table.Column<string>(type: "varchar(10)", nullable: true),
                    Genre = table.Column<string>(type: "varchar(10)", nullable: true),
                    Description = table.Column<string>(type: "varchar(120)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "City", "Cpf", "Date", "Description", "Email", "Genre", "LastName", "Name", "Password", "State" },
                values: new object[] { 1, 34, "Fortaleza", "05505505511", new DateTime(2021, 10, 13, 17, 22, 5, 507, DateTimeKind.Local).AddTicks(6586), "Dor na cabeça", "capuletos@live.com", "Masculino", "Vilela", "William", "1010", "CE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
