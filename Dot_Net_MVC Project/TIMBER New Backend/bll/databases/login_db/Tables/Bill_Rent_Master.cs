using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class Bill_Rent_Master
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
         public long id { get; set; }

        [Column("bill_date", Order = 2, TypeName = "datetime")]
        public DateTime? bill_date { get; set; }

        [Column("bill_upto", Order = 3, TypeName = "datetime")]
        public DateTime? bill_upto { get; set; }

        [Column("bill_from", Order = 4, TypeName = "datetime")]
        public DateTime? bill_from { get; set; }

        [Column("bill_to", Order = 5, TypeName = "datetime")]
        public DateTime? bill_to { get; set; }

        [Column("bill_text", Order = 6, TypeName = "text")]
        public string? bill_text { get; set; }

        [Column("itemname", Order = 7, TypeName = "text")]
        public string? itemname { get; set; }

        [Column("open_stock", Order = 8, TypeName = "decimal(18, 2)")]
        public decimal? open_stock { get; set; }

        [Column("iss_stock", Order = 9, TypeName = "decimal(18, 2)")]
        public decimal? iss_stock { get; set; }

        [Column("rec_stock", Order = 10, TypeName = "decimal(18, 2)")]
        public decimal? rec_stock { get; set; }

        [Column("close_stock", Order = 11, TypeName = "decimal(18, 2)")]
        public decimal? close_stock { get; set; }

        [Column("days", Order = 12, TypeName = "bigint")]
         public long? days { get; set; }

        [Column("numbers", Order = 13, TypeName = "bigint")]
         public long? numbers { get; set; }

        [Column("amt_number_wise", Order = 14, TypeName = "decimal(18, 2)")]
        public decimal? amt_number_wise { get; set; }

        [Column("rent_rate", Order = 15, TypeName = "decimal(18, 2)")]
        public decimal? rent_rate { get; set; }

        [Column("amt", Order = 16, TypeName = "decimal(18, 2)")]
        public decimal? amt { get; set; }

        [Column("vat_cst", Order = 17, TypeName = "decimal(18, 2)")]
        public decimal? vat_cst { get; set; }

        [Column("vat_per", Order = 18, TypeName = "decimal(18, 2)")]
        public decimal? vat_per { get; set; }

        [Column("tax_amt", Order = 19, TypeName = "decimal(18, 2)")]
        public decimal? tax_amt { get; set; }

        [Column("rounded_off_amt", Order = 20, TypeName = "decimal(18, 2)")]
        public decimal? rounded_off_amt { get; set; }

        [Column("amt_after_vat_cst", Order = 21, TypeName = "decimal(18, 2)")]
        public decimal? amt_after_vat_cst { get; set; }

        [Column("cartage_amt", Order = 22, TypeName = "decimal(18, 2)")]
        public decimal? cartage_amt { get; set; }

        [Column("trip_nos", Order = 23, TypeName = "bigint")]
         public long? trip_nos { get; set; }

        [Column("misc_charges", Order = 24, TypeName = "decimal(18, 2)")]
        public decimal? misc_charges { get; set; }

        [Column("misc_charges_detail", Order = 25, TypeName = "text")]
        public string? misc_charges_detail { get; set; }

        [Column("gross_amt", Order = 26, TypeName = "decimal(18, 2)")]
        public decimal? gross_amt { get; set; }

        [Column("outstanding_amt_date", Order = 27, TypeName = "datetime")]
        public DateTime? outstanding_amt_date { get; set; }

        [Column("outstanding_amt", Order = 28, TypeName = "decimal(18, 2)")]
        public decimal? outstanding_amt { get; set; }

        [Column("payment_rec_in_period", Order = 29, TypeName = "decimal(18, 2)")]
        public decimal? payment_rec_in_period { get; set; }

        [Column("amount_due", Order = 30, TypeName = "decimal(18, 2)")]
        public decimal? amount_due { get; set; }

        [Column("amt_in_words", Order = 31, TypeName = "text")]
        public string? amt_in_words { get; set; }

        [Column("breakage_amt", Order = 32, TypeName = "decimal(18, 2)")]
        public decimal? breakage_amt { get; set; }

        [Column("missing_amt", Order = 33, TypeName = "decimal(18, 2)")]
        public decimal? missing_amt { get; set; }

        [Column("add1", Order = 34, TypeName = "text")]
        public string? add1 { get; set; }

        [Column("add2", Order = 35, TypeName = "text")]
        public string? add2 { get; set; }

        [Column("add3", Order = 36, TypeName = "text")]
        public string? add3 { get; set; }

        [Column("add4", Order = 37, TypeName = "text")]
        public string? add4 { get; set; }

        [Column("bill_from_2", Order = 38, TypeName = "text")]
        public string? bill_from_2 { get; set; }

        [Column("bill_to_2", Order = 39, TypeName = "text")]
        public string? bill_to_2 { get; set; }

        [Column("bill_date_2", Order = 40, TypeName = "datetime")]
        public DateTime? bill_date_2 { get; set; }

        [Column("bill_no", Order = 41, TypeName = "text")]
        public string? bill_no { get; set; }

        [Column("final_y_n", Order = 42, TypeName = "text")]
        public string? final_y_n { get; set; }

        [Column("invoice_type", Order = 43, TypeName = "text")]
        public string? invoice_type { get; set; }

        [Column("billing_on_pp_pc_rmt", Order = 44, TypeName = "text")]
        public string? billing_on_pp_pc_rmt { get; set; }

        [Column("agr_uni_code", Order = 45, TypeName = "text")]
        public string? agr_uni_code { get; set; }

        [Column("agr_code", Order = 46, TypeName = "text")]
        public string? agr_code { get; set; }

        [Column("agr_name", Order = 47, TypeName = "text")]
        public string? agr_name { get; set; }

        [Column("item_balance", Order = 48, TypeName = "decimal(18, 2)")]
        public decimal? item_balance { get; set; }

        [Column("total_item_balance", Order = 49, TypeName = "decimal(18, 2)")]
        public decimal? total_item_balance { get; set; }

        [Column("billno", Order = 50, TypeName = "text")]
        public string? billno { get; set; }

        [Column("challanno", Order = 51, TypeName = "text")]
        public string? challanno { get; set; }

        [Column("sale_type", Order = 52, TypeName = "text")]
        public string? sale_type { get; set; }

        [Column("auto_matic_billno", Order = 53, TypeName = "text")]
        public string? auto_matic_billno { get; set; }

        [Column("igst_per", Order = 54, TypeName = "decimal(18, 2)")]
        public decimal? igst_per { get; set; }

        [Column("igst_amt", Order = 55, TypeName = "decimal(18, 2)")]
        public decimal? igst_amt { get; set; }

        [Column("sgst_per", Order = 56, TypeName = "decimal(18, 2)")]
        public decimal? sgst_per { get; set; }

        [Column("sgst_amt", Order = 57, TypeName = "decimal(18, 2)")]
        public decimal? sgst_amt { get; set; }

        [Column("cgst_per", Order = 58, TypeName = "decimal(18, 2)")]
        public decimal? cgst_per { get; set; }

        [Column("cgst_amt", Order = 59, TypeName = "decimal(18, 2)")]
        public decimal? cgst_amt { get; set; }

        [Column("gst_type", Order = 60, TypeName = "text")]
        public string? gst_type { get; set; }

        [Column("b_hsn_code", Order = 61, TypeName ="text")]
        public string? b_hsn_code { get; set; }

        [Column("state_code", Order =62 , TypeName = "text")]
        public string? state_code { get; set; }

        [Column("state_name", Order =63 , TypeName =" text")]
        public string? state_name { get; set; }

        [Column("p_gstno", Order =64 , TypeName = "text")]
        public string? p_gstno { get; set; }

        [Column("delete", Order = 65, TypeName = "bigint")]
        public long? delete { get; set; } = 0;

        [Column("created_at", Order = 66, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 67, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;
    }
}
