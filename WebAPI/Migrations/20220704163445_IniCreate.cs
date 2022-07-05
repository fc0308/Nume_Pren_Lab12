using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace WebAPI.Migrations
{
    public partial class IniCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
          
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<float>(nullable: true),
                    Month = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
