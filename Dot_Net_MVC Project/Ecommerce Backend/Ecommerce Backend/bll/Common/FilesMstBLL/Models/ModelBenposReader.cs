using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
using Microsoft.AspNetCore.Http;

namespace RTA.Common.Models
{
    public class ModelBenposReader
    {
        public DateTime? Holding_Rpt_Date { get; set; }
        [NumberStyles(NumberStyles.Number | NumberStyles.AllowExponent)]
        public float Share_Qty { get; set; }
        
        [NumberStyles(NumberStyles.Number | NumberStyles.AllowExponent)]
        public float Share_Qty_Per { get; set; }
        public long? Qty_NSDL { get; set; }
        public long? Qty_CDSL { get; set; }
        public long? Qty_Phy { get; set; }
        public string? More_than_2L { get; set; }
        public string? More_than_1_percent { get; set; }
        public string? DPID { get; set; }
        public string? CL_ID { get; set; }
        public long? Lock_in_Qty { get; set; }
        public long? Pledged_Qty { get; set; }
        public long? Other_Then_Free { get; set; }
        public string? PHY_CDSL_NSDL { get; set; }
        public string? FSTNM { get; set; }
        public string? SNDNM { get; set; }
        public string? THDNM { get; set; }
        public string? Nomination_Name { get; set; }
        public string? Client_Type { get; set; }
        public string? PAN_NO { get; set; }
        public string? FNAME { get; set; }
        public long? STA { get; set; }
        public string? CITY { get; set; }
        public string? STATE { get; set; }
        public string? PINCODE { get; set; }
        public string? Bank_Ac_No { get; set; }
        public string? Bank_Name { get; set; }
        public string? MOBNO { get; set; }
        public string? P_PI_PN { get; set; }
        public string? EMAILID { get; set; }
        public string? Categroy_Codes { get; set; }
        public string? Category_Header_Detail { get; set; }
        public string? Category_Header { get; set; }
        public string? R31_Header { get; set; }
        public long? Rpt_Auto_ID { get; set; }

    }
}