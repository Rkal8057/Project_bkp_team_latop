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
    public class CaseMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("case_financed_item", Order = 1, TypeName = "text")]
        public string? case_financed_item { get; set; }

        [Column("Case_Finance_Amt", Order = 2, TypeName = "text")]
        public string? Case_Finance_Amt { get; set; }

        [Column("case_Duration_Value", Order = 3, TypeName = "text")]
        public string? case_Duration_Value { get; set; }

        [Column("case_Duration_Type", Order = 4, TypeName = "text")]
        public string? case_Duration_Type { get; set; }

        [Column("Case_Instalments", Order = 5, TypeName = "text")]
        public string? Case_Instalments { get; set; }

        [Column("Case_Montly_Amt", Order = 6, TypeName = "text")]
        public string? Case_Montly_Amt { get; set; }

        [Column("Case_Total_Amt_Due", Order = 7, TypeName = "text")]
        public string? Case_Total_Amt_Due { get; set; }

        [Column("Case_Total_Cost", Order = 8, TypeName = "text")]
        public string? Case_Total_Cost { get; set; }

        [Column("Case_ADVANCE_REQ", Order = 9, TypeName = "text")]
        public string? Case_ADVANCE_REQ { get; set; }

        [Column("Case_TOTAL_ADV_REQ", Order = 10, TypeName = "text")]
        public string? Case_TOTAL_ADV_REQ { get; set; }

        [Column("Case_Due_Date", Order = 11, TypeName = "date")]
        public DateTime? Case_Due_Date { get; set; }

        [Column("Case_Payment_By", Order = 12, TypeName = "text")]
        public string? Case_Payment_By { get; set; }

        [Column("Case_Chq_NO", Order = 13, TypeName = "text")]
        public string? Case_Chq_NO { get; set; }

        [Column("Case_Case_Remark", Order = 14, TypeName = "text")]
        public string? Case_Case_Remark { get; set; }

        [Column("Case_Interest_type", Order = 15, TypeName = "text")]
        public string? Case_Interest_type { get; set; }

        [Column("Case_F_O_CHARGE", Order = 16, TypeName = "text")]
        public string? Case_F_O_CHARGE { get; set; }

        [Column("Case_Total_hp", Order = 17, TypeName = "text")]
        public string? Case_Total_hp { get; set; }

        [Column("Case_X", Order = 18, TypeName = "text")]
        public string? Case_X { get; set; }

        [Column("Case_Rate_of_Interest", Order = 19, TypeName = "text")]
        public string? Case_Rate_of_Interest { get; set; }

        [Column("Case_hp", Order = 20, TypeName = "text")]
        public string? Case_hp { get; set; }

        [Column("Case_Extra_Inst", Order = 21, TypeName = "text")]
        public string? Case_Extra_Inst { get; set; }

        [Column("Case_Instalments_By", Order = 22, TypeName = "text")]
        public string? Case_Instalments_By { get; set; }

        [Column("Case_Finance_Amt_2", Order = 23, TypeName = "text")]
        public string? Case_Finance_Amt_2 { get; set; }

        [Column("Case_Pending_Amt", Order = 24, TypeName = "text")]
        public string? Case_Pending_Amt { get; set; }

        [Column("Case_end_Date", Order = 25, TypeName = "date")]
        public DateTime? Case_end_Date { get; set; }

        [Column("Case_Manual_Lg", Order = 26, TypeName = "text")]
        public string? Case_Manual_Lg { get; set; }

        [Column("Case_Dealer_Name", Order = 27, TypeName = "text")]
        public string? Case_Dealer_Name { get; set; }

        [Column("Case_Curr_Date", Order = 28, TypeName = "date")]
        public DateTime? Case_Curr_Date { get; set; }

        [Column("Case_Case_No", Order = 29, TypeName = "text")]
        public string? Case_Case_No { get; set; }

        [Column("Case_Case_stage", Order = 30, TypeName = "text")]
        public string? Case_Case_stage { get; set; }

        [Column("Case_Ac_Close", Order = 31, TypeName = "text")]
        public string? Case_Ac_Close { get; set; }

        [Column("Case_Ac_Close_Date", Order = 32, TypeName = "date")]
        public DateTime? Case_Ac_Close_Date { get; set; }

        [Column("Case_Block_YN", Order = 33, TypeName = "text")]
        public string? Case_Block_YN { get; set; }

        public ICollection<CaseHireMaster> CaseHireMaster { get; set; }
        public ICollection<Guarantor1Detail> Guarantor1Detail { get; set; }
        public ICollection<Guarantor2Detail> Guarantor2Detail { get; set; }
        public ICollection<RecieptDetail> RecieptDetail { get; set; }
        public ICollection<ExtraDetail> ExtraDetail { get; set; }
        public ICollection<EMIDetail> EMIDetail { get; set; }
        public ICollection<UploadDocument> UploadDocument { get; set; }

    }
}
