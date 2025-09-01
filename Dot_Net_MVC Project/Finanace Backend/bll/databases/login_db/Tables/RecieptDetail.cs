using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class RecieptDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long? id { get; set; }

        [Column("receipt_System_Bill_No", Order = 2, TypeName = "text")]
        public string? receipt_System_Bill_No { get; set; }

        [Column("receipt_Case_No", Order = 3, TypeName = "text")]
        public string? receipt_Case_No { get; set; }

        [Column("receipt_Instalment_No", Order = 4, TypeName = "text")]
        public string? receipt_Instalment_No { get; set; }

        [Column("receipt_Due_Date", Order = 5, TypeName = "date")]
        public DateTime? receipt_Due_Date { get; set; }

        [Column("receipt_Deposit_Date", Order = 6, TypeName = "date")]
        public DateTime? receipt_Deposit_Date { get; set; }

        [Column("receipt_Receipt_No", Order = 7, TypeName = "text")]
        public string? receipt_Receipt_No { get; set; }

        [Column("receipt_Receipt_Date", Order = 8, TypeName = "date")]
        public DateTime? receipt_Receipt_Date { get; set; }

        [Column("receipt_Party_Name", Order = 9, TypeName = "text")]
        public string? receipt_Party_Name { get; set; }

        [Column("receipt_Due_Amt", Order = 10, TypeName = "decimal(18, 2)")]
        public decimal? receipt_Due_Amt { get; set; }

        [Column("receipt_No_of_Inst_of_Int", Order = 11, TypeName = "bigint")]
        public long? receipt_No_of_Inst_of_Int { get; set; } 

        [Column("receipt_Rec_Amt", Order = 12, TypeName = "decimal(18, 2)")]
        public decimal? receipt_Rec_Amt { get; set; }

        [Column("receipt_By_Cash_Bank", Order = 13, TypeName = "text")]
        public string? receipt_By_Cash_Bank { get; set; }

        [Column("receipt_Cheque_No", Order = 14, TypeName = "text")]
        public string? receipt_Cheque_No { get; set; }

        [Column("receipt_Chq_Deposit", Order = 15 , TypeName ="text")]
        public string? receipt_Chq_Deposit { get; set; }

        [Column("receipt_Bank_Chgs_Amt", Order = 16, TypeName = "decimal(18, 2)")]
        public decimal? receipt_Bank_Chgs_Amt { get; set; }

        [Column("receipt_Late_Bounse", Order = 17, TypeName = "text")]
        public string? receipt_Late_Bounse { get; set; }

        [Column("receipt_Remark", Order = 18, TypeName = "text")]
        public string? receipt_Remark { get; set; }

        [Column("receipt_Current_Date", Order = 19, TypeName = "date")]
        public DateTime? receipt_Current_Date { get; set; } 

        [Column("receipt_A_c_Close", Order = 20, TypeName = "text")]
        public string? receipt_A_c_Close { get; set; }

        [Column("receipt_Close_Date", Order = 21, TypeName = "date")]
        public DateTime? receipt_Close_Date { get; set; }

        [Column("receipt_Case_Type", Order = 22, TypeName = "text")]
        public string? receipt_Case_Type { get; set; }

        [Column("receipt_Pric1", Order = 23, TypeName = "decimal(18, 2)")]
        public decimal? receipt_Pric1 { get; set; }

        [Column("receipt_Hp1", Order = 24, TypeName = "decimal(18, 2)")]
        public decimal? receipt_Hp1 { get; set; }

        [Column("receipt_Pric2", Order = 25, TypeName = "decimal(18, 2)")]
        public decimal? receipt_Pric2 { get; set; }

        [Column("receipt_Hp2", Order = 26, TypeName = "decimal(18, 2)")]
        public decimal? receipt_Hp2 { get; set; }

        [Column("Chq_Bounce", Order = 27, TypeName = "text")]
        public string? Chq_Bounce { get; set; }

        [Column("receipt_Bank_Chgs_Amt_Rec", Order = 28, TypeName = "decimal(18, 2)")]
        public decimal? receipt_Bank_Chgs_Amt_Rec { get; set; }

        [Column("receipt_Late_Boun_Rec", Order = 29, TypeName = "text")]
        public string? receipt_Late_Boun_Rec { get; set; }

        [ForeignKey("CaseMaster"), Column("Case_Master_id", Order = 30, TypeName = "bigint")]
        public long? Case_Master_id { get; set; }
        public virtual CaseMaster? CaseMaster { get; set; }
    }
}
