using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class v103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "user_mobile",
                table: "User_Detail",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint(10)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "left_side_user_id",
                table: "User_Detail",
                type: "bigint(10)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 34);

            migrationBuilder.AddColumn<string>(
                name: "left_side_user_mobile",
                table: "User_Detail",
                type: "varchar(20)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 36);

            migrationBuilder.AddColumn<long>(
                name: "right_side_user_id",
                table: "User_Detail",
                type: "bigint(10)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 35);

            migrationBuilder.AddColumn<string>(
                name: "right_side_user_mobile",
                table: "User_Detail",
                type: "varchar(20)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 37);

            migrationBuilder.AddColumn<string>(
                name: "sponsored_by_user_name",
                table: "User_Detail",
                type: "varchar(50)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 40);

            migrationBuilder.AddColumn<long>(
                name: "sponsored_user_id",
                table: "User_Detail",
                type: "bigint(10)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 32);

            migrationBuilder.AddColumn<string>(
                name: "sponsored_user_mobile",
                table: "User_Detail",
                type: "varchar(20)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 33);

            migrationBuilder.AddColumn<long>(
                name: "under_user_id",
                table: "User_Detail",
                type: "bigint(10)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 38);

            migrationBuilder.AddColumn<string>(
                name: "under_user_mobile",
                table: "User_Detail",
                type: "varchar(20)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 39);

            migrationBuilder.AddColumn<long>(
                name: "user_created_by_id",
                table: "User_Detail",
                type: "bigint(10)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 31);

            migrationBuilder.AddColumn<string>(
                name: "user_created_by_name",
                table: "User_Detail",
                type: "varchar(100)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 30);

            migrationBuilder.AddColumn<string>(
                name: "user_creation_mode",
                table: "User_Detail",
                type: "varchar(10)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 29);

            migrationBuilder.AddColumn<string>(
                name: "user_email_verified_yn",
                table: "User_Detail",
                type: "varchar(10)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 26);

            migrationBuilder.AddColumn<string>(
                name: "user_pan_verified_yn",
                table: "User_Detail",
                type: "varchar(10)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 28);

            migrationBuilder.AddColumn<string>(
                name: "user_phn_verified_yn",
                table: "User_Detail",
                type: "varchar(10)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 27);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "left_side_user_id",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "left_side_user_mobile",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "right_side_user_id",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "right_side_user_mobile",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "sponsored_by_user_name",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "sponsored_user_id",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "sponsored_user_mobile",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "under_user_id",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "under_user_mobile",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "user_created_by_id",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "user_created_by_name",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "user_creation_mode",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "user_email_verified_yn",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "user_pan_verified_yn",
                table: "User_Detail");

            migrationBuilder.DropColumn(
                name: "user_phn_verified_yn",
                table: "User_Detail");

            migrationBuilder.AlterColumn<long>(
                name: "user_mobile",
                table: "User_Detail",
                type: "bigint(10)",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
