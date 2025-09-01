using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Item_Trn
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("pcode", Order = 2, TypeName = "bigint(10)")]
       public long? pcode { get; set; }

       [Column("pname", Order = 3, TypeName = "varchar(250)")]
       public string? pname { get; set; }

       [Column("itemcode", Order = 4, TypeName = "bigint(10)")]
       public long? itemcode { get; set; }

       [Column("itemname", Order = 5, TypeName = "varchar(250)")]
       public string? itemname { get; set; }

       [Column("against_bill_no", Order = 6, TypeName = "varchar(250)")]
       public string? against_bill_no { get; set; }

       [Column("auto_bill_nos", Order = 7, TypeName = "bigint(10)")]
       public long? auto_bill_nos { get; set; }

       [Column("group_code", Order = 8, TypeName = "bigint(10)")]
       public long? group_code { get; set; }

       [Column("group_name", Order = 9, TypeName = "varchar(250)")]
       public string? group_name { get; set; }

       [Column("billno", Order = 10, TypeName = "varchar(250)")]
       public string? billno { get; set; }

       [Column("bill_date", Order = 11, TypeName = "datetime")]
       public DateTime? bill_date { get; set; }

       [Column("bill_time", Order = 12, TypeName = "datetime")]
       public DateTime? bill_time { get; set; }

       [Column("iss_qty", Order = 13, TypeName = "double(18,3)")]
       public long? iss_qty { get; set; }

       [Column("rec_qty", Order = 14, TypeName = "double(18,3)")]
       public long? rec_qty { get; set; }

       [Column("qty_trn", Order = 15, TypeName = "double(18,3)")]
       public long? qty_trn { get; set; }

       [Column("rate_trn", Order = 16, TypeName = "double(18,3)")]
       public long? rate_trn { get; set; }

       [Column("amt_trn", Order = 17, TypeName = "double(18,3)")]
       public long? amt_trn { get; set; }

       [Column("sub_tot1", Order = 18, TypeName = "double(18,3)")]
       public long? sub_tot1 { get; set; }

       [Column("dis_per", Order = 19, TypeName = "double(18,3)")]
       public long? dis_per { get; set; }

       [Column("dis_amt", Order = 20, TypeName = "double(18,3)")]
       public long? dis_amt { get; set; }

       [Column("gross_tot1", Order = 21, TypeName = "double(18,3)")]
       public long? gross_tot1 { get; set; }

       [Column("tax_code", Order = 22, TypeName = "double(18,3)")]
       public long? tax_code { get; set; }

       [Column("tax_name", Order = 23, TypeName = "varchar(250)")]
       public string? tax_name { get; set; }

       [Column("taxper", Order = 24, TypeName = "double(18,3)")]
       public long? taxper { get; set; }

       [Column("tax_amt", Order = 25, TypeName = "double(18,3)")]
       public long? tax_amt { get; set; }

       [Column("net_amt", Order = 26, TypeName = "double(18,3)")]
       public long? net_amt { get; set; }

       [Column("tot_qty", Order = 27, TypeName = "double(18,3)")]
       public long? tot_qty { get; set; }

       [Column("rec_type", Order = 28, TypeName = "varchar(250)")]
       public string? rec_type { get; set; }

       [Column("ir_flag", Order = 29, TypeName = "varchar(250)")]
       public string? ir_flag { get; set; }

       [Column("vou_type", Order = 30, TypeName = "varchar(250)")]
       public string? vou_type { get; set; }

       [Column("ref_1", Order = 31, TypeName = "varchar(250)")]
       public string? ref_1 { get; set; }

       [Column("qty_remark", Order = 32, TypeName = "varchar(250)")]
       public string? qty_remark { get; set; }

       [Column("bill_date_time", Order = 33, TypeName = "datetime")]
       public DateTime? bill_date_time { get; set; }

       [Column("username", Order = 34, TypeName = "varchar(250)")]
       public string? username { get; set; }

       [Column("nag_qty", Order = 35, TypeName = "double(18,3)")]
       public long? nag_qty { get; set; }

       [Column("bag_qty", Order = 36, TypeName = "double(18,3)")]
       public long? bag_qty { get; set; }

       [Column("loose_qty", Order = 37, TypeName = "double(18,3)")]
       public long? loose_qty { get; set; }

       [Column("packing_type", Order = 38, TypeName = "varchar(50)")]
       public string? packing_type { get; set; }

       [Column("cartage_amt", Order = 39, TypeName = "double(18,3)")]
       public long? cartage_amt { get; set; }

       [Column("delivery_date", Order = 40, TypeName = "varchar(50)")]
       public string? delivery_date { get; set; }

       [Column("form_yn", Order = 41, TypeName = "varchar(50)")]
       public string? form_yn { get; set; }

       [Column("form_no", Order = 42, TypeName = "varchar(50)")]
       public string? form_no { get; set; }

       [Column("form_type", Order = 43, TypeName = "varchar(50)")]
       public string? form_type { get; set; }

       [Column("bt_amt", Order = 44, TypeName = "double(18,3)")]
       public long? bt_amt { get; set; }

       [Column("veh_no", Order = 45, TypeName = "varchar(250)")]
       public string? veh_no { get; set; }

       [Column("station_name", Order = 46, TypeName = "varchar(250)")]
       public string? station_name { get; set; }

       [Column("transport_name", Order = 47, TypeName = "varchar(250)")]
       public string? transport_name { get; set; }

       [Column("gr_rr_no", Order = 48, TypeName = "varchar(250)")]
       public string? gr_rr_no { get; set; }

       [Column("fraight", Order = 49, TypeName = "varchar(250)")]
       public string? fraight { get; set; }

       [Column("ordno", Order = 50, TypeName = "varchar(50)")]
       public string? ordno { get; set; }

       [Column("ord_date", Order = 51, TypeName = "varchar(20)")]
       public string? ord_date { get; set; }

       [Column("ch_no", Order = 52, TypeName = "varchar(100)")]
       public string? ch_no { get; set; }

       [Column("ch_date", Order = 53, TypeName = "varchar(100)")]
       public string? ch_date { get; set; }

       [Column("pkg_wgt", Order = 54, TypeName = "varchar(100)")]
       public string? pkg_wgt { get; set; }

       [Column("rnd_off_amt", Order = 55, TypeName = "double(18,3)")]
       public long? rnd_off_amt { get; set; }

       [Column("dis_per_2", Order = 56, TypeName = "double(18,3)")]
       public long? dis_per_2 { get; set; }

       [Column("dis_amt_2", Order = 57, TypeName = "double(18,3)")]
       public long? dis_amt_2 { get; set; }

       [Column("all_dis_tot", Order = 58, TypeName = "double(18,3)")]
       public long? all_dis_tot { get; set; }

       [Column("hsn_code", Order = 59, TypeName = "varchar(50)")]
       public string? hsn_code { get; set; }

       [Column("gst_type", Order = 60, TypeName = "varchar(50)")]
       public string? gst_type { get; set; }

       [Column("state_code", Order = 61, TypeName = "varchar(50)")]
       public string? state_code { get; set; }

       [Column("cartage_per", Order = 62, TypeName = "double(18,3)")]
       public long? cartage_per { get; set; }

       [Column("igst_per", Order = 63, TypeName = "double(18,3)")]
       public long? igst_per { get; set; }

       [Column("igst_amt", Order = 64, TypeName = "double(18,3)")]
       public long? igst_amt { get; set; }

       [Column("sgst_per", Order = 65, TypeName = "double(18,3)")]
       public long? sgst_per { get; set; }

       [Column("sgst_amt", Order = 66, TypeName = "double(18,3)")]
       public long? sgst_amt { get; set; }

       [Column("cgst_per", Order = 67, TypeName = "double(18,3)")]
       public long? cgst_per { get; set; }

       [Column("cgst_amt", Order = 68, TypeName = "double(18,3)")]
       public long? cgst_amt { get; set; }

       [Column("reverse_charge", Order = 69, TypeName = "varchar(50)")]
       public string? reverse_charge { get; set; }

       [Column("electronic_ref_no", Order = 70, TypeName = "varchar(50)")]
       public string? electronic_ref_no { get; set; }

       [Column("bill_no_numric", Order = 71, TypeName = "double(18,3)")]
       public long? bill_no_numric { get; set; }

       [Column("sub_tot_1st_trn", Order = 72, TypeName = "double(18,3)")]
       public long? sub_tot_1st_trn { get; set; }

       [Column("dis_per_1st", Order = 73, TypeName = "double(18,3)")]
       public long? dis_per_1st { get; set; }

       [Column("dis_amt_1st", Order = 74, TypeName = "double(18,3)")]
       public long? dis_amt_1st { get; set; }

       [Column("dis_amt_1st_tot", Order = 75, TypeName = "double(18,3)")]
       public long? dis_amt_1st_tot { get; set; }

       [Column("rate_after_dis_1st", Order = 76, TypeName = "double(18,3)")]
       public long? rate_after_dis_1st { get; set; }

       [Column("sub_tot_2nd_trn", Order = 77, TypeName = "double(18,3)")]
       public long? sub_tot_2nd_trn { get; set; }

       [Column("dis_per_2nd", Order = 78, TypeName = "double(18,3)")]
       public long? dis_per_2nd { get; set; }

       [Column("dis_amt_2nd", Order = 79, TypeName = "double(18,3)")]
       public long? dis_amt_2nd { get; set; }

       [Column("dis_amt_2nd_tot", Order = 80, TypeName = "double(18,3)")]
       public long? dis_amt_2nd_tot { get; set; }

       [Column("rate_after_dis_2nd", Order = 81, TypeName = "double(18,3)")]
       public long? rate_after_dis_2nd { get; set; }

       [Column("sub_tot_3rd_trn", Order = 82, TypeName = "double(18,3)")]
       public long? sub_tot_3rd_trn { get; set; }

       [Column("f_rate_trn", Order = 83, TypeName = "double(18,3)")]
       public long? f_rate_trn { get; set; }

       [Column("gst_per_trn", Order = 84, TypeName = "double(18,3)")]
       public long? gst_per_trn { get; set; }

       [Column("gst_amt_on_f_rate_trn", Order = 85, TypeName = "double(18,3)")]
       public long? gst_amt_on_f_rate_trn { get; set; }

       [Column("gst_amt_tot_trn", Order = 86, TypeName = "double(18,3)")]
       public long? gst_amt_tot_trn { get; set; }

       [Column("rate_after_gst", Order = 87, TypeName = "double(18,3)")]
       public long? rate_after_gst { get; set; }

   }
}
