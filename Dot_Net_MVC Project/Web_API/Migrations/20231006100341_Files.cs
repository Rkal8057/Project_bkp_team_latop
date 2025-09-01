using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API.Migrations
{
    /// <inheritdoc />
    public partial class Files : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_File_Users_userId",
                table: "File");

            migrationBuilder.RenameTable(
                name: "File",
                newName: "Files");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Files",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Files",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Files",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadDate",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadTime",
                table: "Files",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Files_userId",
                table: "Files",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Users_userId",
                table: "Files",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Users_userId",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_userId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "UploadDate",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "UploadTime",
                table: "Files");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "File");

            migrationBuilder.AddForeignKey(
                name: "FK_File_Users_userId",
                table: "File",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
