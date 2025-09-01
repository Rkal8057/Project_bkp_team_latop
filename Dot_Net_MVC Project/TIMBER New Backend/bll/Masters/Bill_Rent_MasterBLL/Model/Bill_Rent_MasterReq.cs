using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class Bill_Rent_MasterReq
    {
        public long? id { get; set; }

        public DateTime? bill_date { get; set; }
        public DateTime? bill_upto { get; set; }
        public DateTime? bill_from { get; set; }
        public DateTime? bill_to { get; set; }
        public string? bill_text { get; set; }
        public string? itemname { get; set; }
        public decimal? open_stock { get; set; }
        public decimal? iss_stock { get; set; }
        public decimal? rec_stock { get; set; }
        public decimal? close_stock { get; set; }
        public long? days { get; set; }
        public long? numbers { get; set; }
        public decimal? amt_number_wise { get; set; }
        public decimal? rent_rate { get; set; }
        public decimal? amt { get; set; }
        public decimal? vat_cst { get; set; }
        public decimal? vat_per { get; set; }
        public decimal? tax_amt { get; set; }
        public decimal? rounded_off_amt { get; set; }
        public decimal? amt_after_vat_cst { get; set; }
        public decimal? cartage_amt { get; set; }
        public long? trip_nos { get; set; }
        public decimal? misc_charges { get; set; }
        public string? misc_charges_detail { get; set; }
        public decimal? gross_amt { get; set; }
        public DateTime? outstanding_amt_date { get; set; }
        public decimal? outstanding_amt { get; set; }
        public decimal? payment_rec_in_period { get; set; }
        public decimal? amount_due { get; set; }
        public string? amt_in_words { get; set; }
        public decimal? breakage_amt { get; set; }
        public decimal? missing_amt { get; set; }
        public string? add1 { get; set; }
        public string? add2 { get; set; }
        public string? add3 { get; set; }
        public string? add4 { get; set; }
        public string? bill_from_2 { get; set; }
        public string? bill_to_2 { get; set; }
        public DateTime? bill_date_2 { get; set; }
        public string? bill_no { get; set; }
        public string? final_y_n { get; set; }
        public string? invoice_type { get; set; }
        public string? billing_on_pp_pc_rmt { get; set; }
        public string? agr_uni_code { get; set; }
        public string? agr_code { get; set; }
        public string? agr_name { get; set; }
        public decimal? item_balance { get; set; }
        public decimal? total_item_balance { get; set; }
        public string? billno { get; set; }
        public string? challanno { get; set; }
        public string? sale_type { get; set; }
        public string? auto_matic_billno { get; set; }
        public decimal? igst_per { get; set; }
        public decimal? igst_amt { get; set; }
        public decimal? sgst_per { get; set; }
        public decimal? sgst_amt { get; set; }
        public decimal? cgst_per { get; set; }
        public decimal? cgst_amt { get; set; }
        public string? gst_type { get; set; }
        public string? b_hsn_code { get; set; }
        public string? state_code { get; set; }
        public string? state_name { get; set; }
        public string? p_gstno { get; set; }
        public decimal? tax_code { get;set; }
    }
}
