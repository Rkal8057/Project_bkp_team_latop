using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class v102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "comp_api_baseurl",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "comp_email_alias_name",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "comp_email_for_otp",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "comp_email_port",
                table: "System_Records",
                type: "bigint(10)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 138);

            migrationBuilder.AddColumn<string>(
                name: "comp_email_security",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "comp_email_server",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "comp_email_username",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "comp_login_otp_type",
                table: "System_Records",
                type: "varchar(50)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:ColumnOrder", 142);

            migrationBuilder.AddColumn<string>(
                name: "comp_otp_email_pass",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_on",
                table: "System_Records",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 146);

            migrationBuilder.AddColumn<string>(
                name: "sms_base_url",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "sms_provider_gsmid",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "sms_provider_peid",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "sms_provider_user_id",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "sms_provider_user_pass",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "sms_unicode",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_on",
                table: "System_Records",
                type: "datetime",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 147);

            migrationBuilder.AddColumn<string>(
                name: "user_email",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "user_mobile",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "user_name",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "vendor_code",
                table: "System_Records",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sms_Msg_Master",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(10) auto_increment", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<long>(type: "bigint(10)", nullable: true),
                    comp_name = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    client_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vendor_code = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sms_purpose = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_email = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delete_status = table.Column<long>(type: "bigint", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_mobile = table.Column<long>(type: "bigint(10)", nullable: true),
                    sms_msg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sms_temp_id = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sms_Msg_Master", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sms_Msg_Master");

            migrationBuilder.DropColumn(
                name: "comp_api_baseurl",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "comp_email_alias_name",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "comp_email_for_otp",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "comp_email_port",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "comp_email_security",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "comp_email_server",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "comp_email_username",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "comp_login_otp_type",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "comp_otp_email_pass",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "created_on",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "sms_base_url",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "sms_provider_gsmid",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "sms_provider_peid",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "sms_provider_user_id",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "sms_provider_user_pass",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "sms_unicode",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "updated_on",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "user_email",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "user_mobile",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "user_name",
                table: "System_Records");

            migrationBuilder.DropColumn(
                name: "vendor_code",
                table: "System_Records");
        }
    }
}
