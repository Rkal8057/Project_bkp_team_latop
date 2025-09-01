using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ReceiptMasterReq
    {
        public string? receipt_System_Bill_No { get; set; }
        public string? receipt_Case_No { get; set; }
        public string? receipt_Instalment_No { get; set; }
        public DateTime? receipt_Due_Date { get; set; }
        public DateTime? receipt_Deposit_Date { get; set; }
        public string? receipt_Receipt_No { get; set; }
        public DateTime? receipt_Receipt_Date { get; set; }
        public string? receipt_Party_Name { get; set; }
        public decimal? receipt_Due_Amt { get; set; }
        public long? receipt_No_of_Inst_of_Int { get; set; } = 1;
        public decimal? receipt_Rec_Amt { get; set; }
        public string? receipt_By_Cash_Bank { get; set; }
        public string? receipt_Cheque_No { get; set; }
        public string? receipt_Chq_Deposit { get; set; }
        public decimal? receipt_Bank_Chgs_Amt { get; set; }
        public string? receipt_Late_Bounse { get; set; }
        public string? receipt_Remark { get; set; }
        public DateTime? receipt_Current_Date { get; set; }
        public string? receipt_A_c_Close { get; set; }
        public DateTime? receipt_Close_Date { get; set; }
        public string? receipt_Case_Type { get; set; }
        public decimal? receipt_Pric1 { get; set; }
        public decimal? receipt_Hp1 { get; set; }
        public decimal? receipt_Pric2 { get; set; }
        public decimal? receipt_Hp2 { get; set; }
        public string? Chq_Bounce { get; set; }
        public decimal? receipt_Bank_Chgs_Amt_Rec { get; set; }
        public string? receipt_Late_Boun_Rec { get; set; }
        public long? case_Master_id { get; set; }

    }
}
