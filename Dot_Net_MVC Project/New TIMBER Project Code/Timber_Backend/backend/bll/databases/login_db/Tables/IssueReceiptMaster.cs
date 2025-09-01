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

    public class IssueReceiptMaster
    {
        [Key]
        [Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("billno_automatic", Order = 1)]
        public long? billno_automatic { get; set; }

        [Column("pcode", Order = 2)]
        public long? pcode { get; set; }

        [Column("pname", Order = 3)]
        public string? pname { get; set; }

        [Column("pname_short_code", Order = 4)]
        public string? pname_short_code { get; set; }

        [Column("agr_code_old", Order = 5)]
        public string? agr_code_old { get; set; }

        [Column("agr_no_old", Order = 6)]
        public string? agr_no_old { get; set; }

        [Column("client_type", Order = 7)]
        public string? client_type { get; set; }

        [Column("item_code", Order = 8)]
        public string? item_code { get; set; }

        [Column("item_short_name", Order = 9)]
        public string? item_short_name { get; set; }

        [Column("item_name", Order = 10)]
        public string? item_name { get; set; }

        [Column("item_group_code", Order = 11)]
        public long? item_group_code { get; set; }

        [Column("item_group_name", Order = 12)]
        public string? item_group_name { get; set; }



        [Column("bill_date", Order = 13)]
        public DateTime? bill_date { get; set; }

        [Column("challanno", Order = 14, TypeName = "text")]
        public string? challanno { get; set; }

        [Column("issue_qty", Order = 15)]
        public double? issue_qty { get; set; }

        [Column("recv_qty", Order = 16)]
        public double? recv_qty { get; set; }

        [Column("irflag", Order = 17)]
        public string? irflag { get; set; }

        [Column("billfr", Order = 18)]
        public DateTime? billfr { get; set; }

        [Column("billto", Order = 19)]
        public DateTime? billto { get; set; }

        [Column("rent_rate", Order = 20)]
        public double? rent_rate { get; set; }

        [Column("broken_amt", Order = 21)]
        public double? broken_amt { get; set; }

        [Column("frshop", Order = 22)]
        public double? frshop { get; set; }

        [Column("froffice", Order = 23)]
        public double? froffice { get; set; }

        [Column("brok_qty", Order = 24)]
        public double? brok_qty { get; set; }

        [Column("brok_rate", Order = 25)]
        public double? brok_rate { get; set; }

        [Column("miss_flag", Order = 26)]
        public string? miss_flag { get; set; }

        [Column("misc_ac_code", Order = 27)]
        public string? misc_ac_code { get; set; }

        [Column("misc_exp_total", Order = 28)]
        public double? misc_exp_total { get; set; }

        [Column("cartcode", Order = 29)]
        public string? cartcode { get; set; }

        [Column("cart_amt", Order = 30)]
        public double? cart_amt { get; set; }

        [Column("remark_note", Order = 31)]
        public string? remark_note { get; set; }

        [Column("prnnarr", Order = 32)]
        public string? prnnarr { get; set; }

        [Column("stkvalue", Order = 33)]
        public double? stkvalue { get; set; }

        [Column("misc1", Order = 34)]
        public double? misc1 { get; set; }

        [Column("misc2", Order = 35)]
        public double? misc2 { get; set; }

        [Column("misc3", Order = 36)]
        public double? misc3 { get; set; }

        [Column("misc4", Order = 37)]
        public double? misc4 { get; set; }

        [Column("misc5", Order = 38)]
        public double? misc5 { get; set; }

        [Column("misc6", Order = 39)]
        public double? misc6 { get; set; }

        [Column("sno", Order = 40)]
        public long? sno { get; set; }

        [Column("contact_prs_ph", Order = 41)]
        public string? contact_prs_ph { get; set; }

        [Column("transporter_name", Order = 42)]
        public string? transporter_name { get; set; }

        [Column("gr_no", Order = 43)]
        public string? gr_no { get; set; }

        [Column("vehicleno", Order = 44)]
        public string? vehicleno { get; set; }

        [Column("driver_name", Order = 45)]
        public string? driver_name { get; set; }

        [Column("dl_no", Order = 46)]
        public string? dl_no { get; set; }

        [Column("permit_no", Order = 47)]
        public string? permit_no { get; set; }

        [Column("contact_prs_ph_no", Order = 48)]
        public string? contact_prs_ph_no { get; set; }

        [Column("apx_weight", Order = 49)]
        public double? apx_weight { get; set; }

        [Column("apx_value", Order = 50)]
        public string? apx_value { get; set; }

        [Column("bill_enter_date", Order = 51)]
        public DateTime? bill_enter_date { get; set; }


        [Column("trip_no", Order = 52)]
        public long? trip_no { get; set; }


        [Column("bill_amt", Order = 53 )]
        public double? bill_amt { get; set; }

        [Column("rec_type", Order = 54)]
        public string? rec_type { get; set; }

        [Column("tnx_type", Order = 55)]
        public string? tnx_type { get; set; }

        [Column("unit_name", Order = 56)]
        public string? unit_name { get; set; }

        [Column("itemtype", Order = 57)]
        public string? itemtype { get; set; }

        [Column("tax_code", Order = 58)]
        public long? tax_code { get; set; }

        [Column("tax_name", Order = 59)]
        public string? tax_name { get; set; }

        [Column("tax_per", Order = 60)]
        public double? tax_per { get; set; }

        [Column("tax_amt", Order = 61)]
        public double? tax_amt { get; set; }

        [Column("dis_per", Order = 62)]
        public double? dis_per { get; set; }

        [Column("dis_amt", Order = 63)]
        public double? dis_amt { get; set; }

        [Column("gross_amt", Order = 64)]
        public double? gross_amt { get; set; }

        [Column("tot_qty", Order = 65)]
        public double? tot_qty { get; set; }

        [Column("add_off_site", Order = 66)]
        public string? add_off_site { get; set; }

        [Column("hsn_code", Order = 67)]
        public string? hsn_code { get; set; }

        [Column("gst_type", Order = 68)]
        public string? gst_type { get; set; }

        [Column("state_code", Order = 69)]
        public string? state_code { get; set; }

        [Column("tax_yn", Order = 70)]
        public string? tax_yn { get; set; }

        [Column("igst_per", Order = 71)]
        public double? igst_per { get; set; }

        [Column("igst_amt", Order = 72)]
        public double? igst_amt { get; set; }

        [Column("sgst_per", Order = 73)]
        public double? sgst_per { get; set; }

        [Column("sgst_amt", Order = 74)]
        public double? sgst_amt { get; set; }

        [Column("cgst_per", Order = 75)]
        public double? cgst_per { get; set; }

        [Column("cgst_amt", Order = 76)]
        public double? cgst_amt { get; set; }

        [Column("reverse_charge", Order = 77)]
        public string? reverse_charge { get; set; }

        [Column("electronic_ref_no", Order = 78)]
        public string? electronic_ref_no { get; set; }

        [Column("ref_2", Order = 79)]
        public string? ref_2 { get; set; }

        [Column("weight_of_one_pcs", Order = 80)]
        public double? weight_of_one_pcs { get; set; }

        [Column("tot_weight_of_pcs", Order = 81)]
        public double? tot_weight_of_pcs { get; set; }

        [Column("manual_billno", Order = 82)]
        public string? manual_billno { get; set; }

        [Column("ordno", Order = 83)]
        public string? ordno { get; set; }

        [Column("ord_date", Order = 84)]
        public string? ord_date { get; set; }

        [Column("trx_code", Order = 85)]
        public double? trx_code { get; set; }

        [Column("trx_name", Order = 86)]
        public string? trx_name { get; set; }

        [Column("pkg", Order = 87)]
        public string? pkg { get; set; }

        [Column("c_form", Order = 88)]
        public string? c_form { get; set; }

        [Column("net_amt", Order = 89)]
        public double? net_amt { get; set; }

        [Column("tot_amt", Order = 90)]
        public double? tot_amt { get; set; }

        [Column("transporter_code", Order = 91)]
        public string? transporter_code { get; set; }

        [Column("fraight", Order = 92)]
        public string? fraight { get; set; }

        [Column("contact_prs", Order = 93)]
        public string? contact_prs { get; set; }

        [Column("site_add", Order = 94)]
        public string? site_add { get; set; }

        [Column("todo", Order = 95)]
        public string? todo { get; set; }

        [Column("amt_in_wor", Order = 96)]
        public string? amt_in_wor { get; set; }

        [Column("duedate", Order = 97)]
        public string? duedate { get; set; }

        [Column("round_off_yn", Order = 98)]
        public string? round_off_yn { get; set; }

        [Column("round_off_amt", Order = 99)]
        public double? round_off_amt { get; set; }

        [Column("station_name", Order = 100)]
        public string? station_name { get; set; }

        [Column("qty_kg", Order = 101)]
        public double? qty_kg { get; set; }

        [Column("tot_kg", Order = 102)]
        public double? tot_kg { get; set; }

        [Column("add1", Order = 103)]
        public string? add1 { get; set; }

        [Column("add2", Order = 104)]
        public string? add2 { get; set; }

        [Column("add3_location", Order = 105)]
        public string? add3_location { get; set; }

        [Column("add4_city", Order = 106)]
        public string? add4_city { get; set; }

        [Column("add5_state", Order = 107)]
        public string? add5_state { get; set; }

        [Column("add6_pincode", Order = 108)]
        public string? add6_pincode { get; set; }

        [Column("add7_state_code", Order = 109)]
        public string? add7_state_code { get; set; }

        [Column("country_name", Order = 110)]
        public string? country_name { get; set; }

        [Column("addr_type", Order = 111)]
        public string? addr_type { get; set; }

        [Column("addr_gst_type", Order = 112)]
        public string? addr_gst_type { get; set; }

        [Column("gstno", Order = 113)]
        public string? gstno { get; set; }

        [Column("rent_on_type", Order = 114)]
        public string? rent_on_type { get; set; }

        [Column("opening_qty", Order = 115)]
        public double? opening_qty { get; set; }

        [Column("issued_bal_on_chal_date", Order = 116)]
        public double? issued_bal_on_chal_date { get; set; }

        [Column("unique_number", Order = 117, TypeName = "text")]
        public string? unique_number { get; set; }

        [Column("delete_at", Order = 118, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("contact_prs_whts_no", Order = 119)]
        public string? contact_prs_whts_no { get; set; }

        [Column("irflag_detail", Order = 120)]
        public string? irflag_detail { get; set; }






        [Column("cart_po_date", Order = 121, TypeName = "datetime")]
        public DateTime? cart_po_date { get; set; }

        [Column("cart_po_number", Order = 122, TypeName = "text")]
       
        public string? cart_po_number { get; set; }

        [Column("cart_transport_name", Order = 123, TypeName = "text")]
        public string? cart_transport_name { get; set; }

        [Column("cart_fraight_topay_paid", Order = 124, TypeName = "text")]
        public string? cart_fraight_topay_paid { get; set; }

        [Column("cart_amt_transporter", Order = 125, TypeName = "float")]
        public double? cart_amt_transporter { get; set; }

        [Column("cart_per_tax_transporter", Order = 126, TypeName = "float")]
        public double? cart_per_tax_transporter { get; set; }

        [Column("cart_amt_with_gst_transporter", Order = 127, TypeName = "float")]
        public double? cart_amt_with_gst_transporter { get; set; }

        [Column("cart_amt_final", Order = 128, TypeName = "float")]
        public double? cart_amt_final { get; set; }

        [Column("cart_tcs_yn", Order = 129, TypeName = "text")]
        public string? cart_tcs_yn { get; set; }

        [Column("station", Order = 130, TypeName = "text")]
        public string? station { get; set; }


        [Column("roundoff_yn", Order = 131, TypeName = "text")]
        public string? roundoff_yn { get; set; }

        [Column("roundoff_amount", Order = 132, TypeName = "decimal(18, 6)")]
        public double? roundoff_amount { get; set; }

        [Column("cart_tcs_value", Order = 133, TypeName = "decimal(18, 6)")]
        public double? cart_tcs_value { get; set; }

        [Column("cart_tax_amount_transporter", Order = 134, TypeName = "decimal(18, 6)")]
        public double? cart_tax_amount_transporter { get; set; }


        [Column("cart_amt_maintain_yn", Order = 135, TypeName = "text")]
        public string? cart_amt_maintain_yn { get; set; }

        [Column("cart_transporter_cartage", Order = 136, TypeName = "text")]
        public string? cart_transporter_cartage { get; set; }

        [Column("cart_tcs_percentage", Order = 137, TypeName = "decimal(18,2)")]
        public double? cart_tcs_percentage { get; set; }

        [Column("final_amount", Order = 138, TypeName = "decimal(18,2)")]
        public double? final_amount { get; set; }

        [Column("old_software_code_ya_id", Order = 139, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }


        [Column("created_at", Order = 140, TypeName = "datetime")]
        public DateTime? created_at { get; set; } 

        [Column("updated_at", Order = 141, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } 


        public ICollection<IssueReceiptTransDetail>? IssueReceiptTransDetail { get; set; }
        public ICollection<IssueReceiptMiscTransDetail>? IssueReceiptMiscTransDetail { get; set; }
        public ICollection<IssueReceiptBreakageTransDetail>? IssueReceiptBreakageTransDetail { get; set; }

        public ICollection<Challan_Single_Item_Master>? Challan_Single_Item_Master { get; set; }

        public ICollection<IssueItemExtraDetail>? IssueItemExtraDetail { get; set; }
        public ICollection<IssueReceiptTransWarrantyDetail>? IssueReceiptTransWarrantyDetail { get; set; }


    }
}
