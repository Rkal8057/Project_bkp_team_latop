using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Login.Migrations
{
    public partial class jfjfjffswsww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    case_financed_item = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Finance_Amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    case_Duration_Value = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    case_Duration_Type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Instalments = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Montly_Amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Total_Amt_Due = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Total_Cost = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_ADVANCE_REQ = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_TOTAL_ADV_REQ = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Due_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Case_Payment_By = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Chq_NO = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Case_Remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Interest_type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_F_O_CHARGE = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Total_hp = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_X = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Rate_of_Interest = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_hp = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Extra_Inst = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Instalments_By = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Finance_Amt_2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Pending_Amt = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_end_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Case_Manual_Lg = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Dealer_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Curr_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Case_Case_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Case_stage = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Ac_Close = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Ac_Close_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Case_Block_YN = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseMaster", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CaseHireMaster",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Hire_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_SWH_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Resi_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Ph_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Company_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Off_Ph_Nos = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Off_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Ph_No2 = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Post = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Profession = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Area = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Location = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hire_Whatsapp_Phone = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseHireMaster", x => x.id);
                    table.ForeignKey(
                        name: "FK_CaseHireMaster_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EMIDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    emi_PaymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    emi_Monthly_Amount = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emi_Interest_Amount = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emi_Monthly_Interest_Amount = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emi_Status = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMIDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_EMIDetail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExtraDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    extra_Registration_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Hirer_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Item_Type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Manufacturer = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Model_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Year_of_Registration = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_RC_Given = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_RC_Taken_By = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Chassis_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Engine_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_NOC_Made = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Taken_By = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Addhaar_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Pan_Card_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_DL_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_Case_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extra_RC_Given_Date = table.Column<DateTime>(type: "date", nullable: true),
                    extra_Date = table.Column<DateTime>(type: "date", nullable: true),
                    extra_Date_Taken_By = table.Column<DateTime>(type: "date", nullable: true),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_ExtraDetail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Guarantor1Detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    guarantor1_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_SWH_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Resi_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Phones_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Campany_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Off_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor1_Off_Phone_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantor1Detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_Guarantor1Detail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Guarantor2Detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    guarantor2_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_SWH_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Resi_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Phones_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Campany_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Off_Address = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guarantor2_Off_Phone_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantor2Detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_Guarantor2Detail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RecieptDetail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    receipt_System_Bill_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Case_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Instalment_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Due_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_Deposit_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_Receipt_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Receipt_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_Party_Name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Due_Amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_No_of_Inst_of_Int = table.Column<long>(type: "bigint", nullable: true),
                    receipt_Rec_Amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_By_Cash_Bank = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Cheque_No = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Chq_Deposit = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Bank_Chgs_Amt = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Late_Bounse = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Remark = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Current_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_A_c_Close = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Close_Date = table.Column<DateTime>(type: "date", nullable: true),
                    receipt_Case_Type = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Pric1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Hp1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Pric2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Hp2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Chq_Bounce = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    receipt_Bank_Chgs_Amt_Rec = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    receipt_Late_Boun_Rec = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecieptDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_RecieptDetail_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UploadDocument",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    upload_document_name = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    upload_document_path = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Case_Master_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadDocument", x => x.id);
                    table.ForeignKey(
                        name: "FK_UploadDocument_CaseMaster_Case_Master_id",
                        column: x => x.Case_Master_id,
                        principalTable: "CaseMaster",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CaseHireMaster_Case_Master_id",
                table: "CaseHireMaster",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_EMIDetail_Case_Master_id",
                table: "EMIDetail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraDetail_Case_Master_id",
                table: "ExtraDetail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantor1Detail_Case_Master_id",
                table: "Guarantor1Detail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantor2Detail_Case_Master_id",
                table: "Guarantor2Detail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_RecieptDetail_Case_Master_id",
                table: "RecieptDetail",
                column: "Case_Master_id");

            migrationBuilder.CreateIndex(
                name: "IX_UploadDocument_Case_Master_id",
                table: "UploadDocument",
                column: "Case_Master_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseHireMaster");

            migrationBuilder.DropTable(
                name: "EMIDetail");

            migrationBuilder.DropTable(
                name: "ExtraDetail");

            migrationBuilder.DropTable(
                name: "Guarantor1Detail");

            migrationBuilder.DropTable(
                name: "Guarantor2Detail");

            migrationBuilder.DropTable(
                name: "RecieptDetail");

            migrationBuilder.DropTable(
                name: "UploadDocument");

            migrationBuilder.DropTable(
                name: "CaseMaster");
        }
    }
}
