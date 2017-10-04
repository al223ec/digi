using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DigitalentCoreApp.Domain.Migrations
{
    public partial class ComplexDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillLevel",
                table: "ConsultantSkill",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "ConsultantSkill");
        }
    }
}
