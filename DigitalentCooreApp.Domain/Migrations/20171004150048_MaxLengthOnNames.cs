using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DigitalentCoreApp.Domain.Migrations
{
    public partial class MaxLengthOnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsultantSkills_Consultant_ConsultantID",
                table: "ConsultantSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsultantSkills_Skills_SkillID",
                table: "ConsultantSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Consultant_ConsultantID",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConsultantSkills",
                table: "ConsultantSkills");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "Skill");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photo");

            migrationBuilder.RenameTable(
                name: "ConsultantSkills",
                newName: "ConsultantSkill");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_ConsultantID",
                table: "Photo",
                newName: "IX_Photo_ConsultantID");

            migrationBuilder.RenameIndex(
                name: "IX_ConsultantSkills_SkillID",
                table: "ConsultantSkill",
                newName: "IX_ConsultantSkill_SkillID");

            migrationBuilder.RenameIndex(
                name: "IX_ConsultantSkills_ConsultantID",
                table: "ConsultantSkill",
                newName: "IX_ConsultantSkill_ConsultantID");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Consultant",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Consultant",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skill",
                table: "Skill",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photo",
                table: "Photo",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConsultantSkill",
                table: "ConsultantSkill",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultantSkill_Consultant_ConsultantID",
                table: "ConsultantSkill",
                column: "ConsultantID",
                principalTable: "Consultant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultantSkill_Skill_SkillID",
                table: "ConsultantSkill",
                column: "SkillID",
                principalTable: "Skill",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Consultant_ConsultantID",
                table: "Photo",
                column: "ConsultantID",
                principalTable: "Consultant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsultantSkill_Consultant_ConsultantID",
                table: "ConsultantSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsultantSkill_Skill_SkillID",
                table: "ConsultantSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Consultant_ConsultantID",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skill",
                table: "Skill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photo",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConsultantSkill",
                table: "ConsultantSkill");

            migrationBuilder.RenameTable(
                name: "Skill",
                newName: "Skills");

            migrationBuilder.RenameTable(
                name: "Photo",
                newName: "Photos");

            migrationBuilder.RenameTable(
                name: "ConsultantSkill",
                newName: "ConsultantSkills");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_ConsultantID",
                table: "Photos",
                newName: "IX_Photos_ConsultantID");

            migrationBuilder.RenameIndex(
                name: "IX_ConsultantSkill_SkillID",
                table: "ConsultantSkills",
                newName: "IX_ConsultantSkills_SkillID");

            migrationBuilder.RenameIndex(
                name: "IX_ConsultantSkill_ConsultantID",
                table: "ConsultantSkills",
                newName: "IX_ConsultantSkills_ConsultantID");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Consultant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Consultant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConsultantSkills",
                table: "ConsultantSkills",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultantSkills_Consultant_ConsultantID",
                table: "ConsultantSkills",
                column: "ConsultantID",
                principalTable: "Consultant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultantSkills_Skills_SkillID",
                table: "ConsultantSkills",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Consultant_ConsultantID",
                table: "Photos",
                column: "ConsultantID",
                principalTable: "Consultant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
