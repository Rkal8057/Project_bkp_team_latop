using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("item_trn")] 
       
   public class Item_Trn
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("item_trn_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? item_trn_auto_id { get; set; }

       [Column("pcode", Order = 3, TypeName = "bigint(10)")]
       public long? pcode { get; set; }

       [Column("pname", Order = 4, TypeName = "varchar(50)")]
       public string? pname { get; set; }

       [Column("s_no", Order = 5, TypeName = "bigint(10)")]
       public long? s_no { get; set; }

       [Column("itemcode", Order = 6, TypeName = "bigint(10)")]
       public long? itemcode { get; set; }

       [Column("itemname", Order = 7, TypeName = "varchar(50)")]
       public string? itemname { get; set; }

       [Column("against_bill_no", Order = 8, TypeName = "varchar(50)")]
       public string? against_bill_no { get; set; }

       [Column("auto_bill_nos", Order = 9, TypeName = "bigint(10)")]
       public long? auto_bill_nos { get; set; }

       [Column("group_code", Order = 10, TypeName = "bigint(10)")]
       public long? group_code { get; set; }

       [Column("group_name", Order = 11, TypeName = "varchar(50)")]
       public string? group_name { get; set; }

       [Column("billno", Order = 12, TypeName = "varchar(50)")]
       public string? billno { get; set; }

       [Column("bill_date", Order = 13, TypeName = "datetime")]
       public DateTime? bill_date { get; set; }

       [Column("bill_time", Order = 14, TypeName = "datetime")]
       public DateTime? bill_time { get; set; }

       [Column("iss_qty", Order = 15, TypeName = "double(18,3)")]
       public long? iss_qty { get; set; }

       [Column("rec_qty", Order = 16, TypeName = "double(18,3)")]
       public long? rec_qty { get; set; }

       [Column("qty_trn", Order = 17, TypeName = "double(18,3)")]
       public long? qty_trn { get; set; }

       [Column("rate_trn", Order = 18, TypeName = "double(18,3)")]
       public long? rate_trn { get; set; }

       [Column("amt_trn", Order = 19, TypeName = "double(18,3)")]
       public long? amt_trn { get; set; }

       [Column("sub_tot1", Order = 20, TypeName = "double(18,3)")]
       public long? sub_tot1 { get; set; }

       [Column("dis_per", Order = 21, TypeName = "double(18,3)")]
       public long? dis_per { get; set; }

       [Column("dis_amt", Order = 22, TypeName = "double(18,3)")]
       public long? dis_amt { get; set; }

       [Column("gross_tot1", Order = 23, TypeName = "double(18,3)")]
       public long? gross_tot1 { get; set; }

       [Column("tax_code", Order = 24, TypeName = "double(18,3)")]
       public long? tax_code { get; set; }

       [Column("tax_name", Order = 25, TypeName = "varchar(50)")]
       public string? tax_name { get; set; }

       [Column("taxper", Order = 26, TypeName = "double(18,3)")]
       public long? taxper { get; set; }

       [Column("tax_amt", Order = 27, TypeName = "double(18,3)")]
       public long? tax_amt { get; set; }

       [Column("net_amt", Order = 28, TypeName = "double(18,3)")]
       public long? net_amt { get; set; }

       [Column("tot_qty", Order = 29, TypeName = "double(18,3)")]
       public long? tot_qty { get; set; }

       [Column("rec_type", Order = 30, TypeName = "varchar(50)")]
       public string? rec_type { get; set; }

       [Column("ir_flag", Order = 31, TypeName = "varchar(50)")]
       public string? ir_flag { get; set; }

       [Column("vou_type", Order = 32, TypeName = "varchar(50)")]
       public string? vou_type { get; set; }

       [Column("ref_1", Order = 33, TypeName = "varchar(50)")]
       public string? ref_1 { get; set; }

       [Column("qty_remark", Order = 34, TypeName = "varchar(50)")]
       public string? qty_remark { get; set; }

       [Column("bill_date_time", Order = 35, TypeName = "datetime")]
       public DateTime? bill_date_time { get; set; }

       [Column("username", Order = 36, TypeName = "varchar(50)")]
       public string? username { get; set; }

       [Column("nag_qty", Order = 37, TypeName = "double(18,3)")]
       public long? nag_qty { get; set; }

       [Column("bag_qty", Order = 38, TypeName = "double(18,3)")]
       public long? bag_qty { get; set; }

       [Column("loose_qty", Order = 39, TypeName = "double(18,3)")]
       public long? loose_qty { get; set; }

       [Column("packing_type", Order = 40, TypeName = "varchar(50)")]
       public string? packing_type { get; set; }

       [Column("cartage_amt", Order = 41, TypeName = "bigint(10)")]
       public long? cartage_amt { get; set; }

       [Column("delivery_date", Order = 42, TypeName = "varchar(50)")]
       public string? delivery_date { get; set; }

       [Column("form_yn", Order = 43, TypeName = "varchar(50)")]
       public string? form_yn { get; set; }

       [Column("form_no", Order = 44, TypeName = "varchar(50)")]
       public string? form_no { get; set; }

       [Column("form_type", Order = 45, TypeName = "varchar(50)")]
       public string? form_type { get; set; }

       [Column("bt_amt", Order = 46, TypeName = "double(18,3)")]
       public long? bt_amt { get; set; }

       [Column("veh_no", Order = 47, TypeName = "varchar(50)")]
       public string? veh_no { get; set; }

       [Column("station_name", Order = 48, TypeName = "varchar(50)")]
       public string? station_name { get; set; }

       [Column("transport_name", Order = 49, TypeName = "varchar(50)")]
       public string? transport_name { get; set; }

       [Column("gr_rr_no", Order = 50, TypeName = "varchar(50)")]
       public string? gr_rr_no { get; set; }

       [Column("fraight", Order = 51, TypeName = "varchar(50)")]
       public string? fraight { get; set; }

       [Column("ordno", Order = 52, TypeName = "varchar(50)")]
       public string? ordno { get; set; }

       [Column("ord_date", Order = 53, TypeName = "varchar(50)")]
       public string? ord_date { get; set; }

       [Column("ch_no", Order = 54, TypeName = "varchar(50)")]
       public string? ch_no { get; set; }

       [Column("ch_date", Order = 55, TypeName = "varchar(50)")]
       public string? ch_date { get; set; }

       [Column("pkg_wgt", Order = 56, TypeName = "varchar(50)")]
       public string? pkg_wgt { get; set; }

       [Column("rnd_off_amt", Order = 57, TypeName = "double(18,3)")]
       public long? rnd_off_amt { get; set; }

       [Column("dis_per_2", Order = 58, TypeName = "double(18,3)")]
       public long? dis_per_2 { get; set; }

       [Column("dis_amt_2", Order = 59, TypeName = "double(18,3)")]
       public long? dis_amt_2 { get; set; }

       [Column("all_dis_tot", Order = 60, TypeName = "double(18,3)")]
       public long? all_dis_tot { get; set; }

       [Column("hsn_code", Order = 61, TypeName = "varchar(50)")]
       public string? hsn_code { get; set; }

       [Column("gst_type", Order = 62, TypeName = "varchar(50)")]
       public string? gst_type { get; set; }

       [Column("state_code", Order = 63, TypeName = "varchar(50)")]
       public string? state_code { get; set; }

       [Column("cartage_per", Order = 64, TypeName = "double(18,3)")]
       public long? cartage_per { get; set; }

       [Column("igst_per", Order = 65, TypeName = "double(18,3)")]
       public long? igst_per { get; set; }

       [Column("igst_amt", Order = 66, TypeName = "double(18,3)")]
       public long? igst_amt { get; set; }

       [Column("sgst_per", Order = 67, TypeName = "double(18,3)")]
       public long? sgst_per { get; set; }

       [Column("sgst_amt", Order = 68, TypeName = "double(18,3)")]
       public long? sgst_amt { get; set; }

       [Column("cgst_per", Order = 69, TypeName = "double(18,3)")]
       public long? cgst_per { get; set; }

       [Column("cgst_amt", Order = 70, TypeName = "double(18,3)")]
       public long? cgst_amt { get; set; }

       [Column("reverse_charge", Order = 71, TypeName = "varchar(50)")]
       public string? reverse_charge { get; set; }

       [Column("electronic_ref_no", Order = 72, TypeName = "varchar(50)")]
       public string? electronic_ref_no { get; set; }

       [Column("ref_2", Order = 73, TypeName = "varchar(50)")]
       public string? ref_2 { get; set; }

       [Column("amt_1st_trn", Order = 74, TypeName = "double(18,3)")]
       public long? amt_1st_trn { get; set; }

       [Column("dis_per_1st", Order = 75, TypeName = "double(18,3)")]
       public long? dis_per_1st { get; set; }

       [Column("dis_amt_1st", Order = 76, TypeName = "double(18,3)")]
       public long? dis_amt_1st { get; set; }

       [Column("dis_amt_1st_tot", Order = 77, TypeName = "double(18,3)")]
       public long? dis_amt_1st_tot { get; set; }

       [Column("rate_after_dis_1st", Order = 78, TypeName = "double(18,3)")]
       public long? rate_after_dis_1st { get; set; }

       [Column("amt_2st_trn", Order = 79, TypeName = "double(18,3)")]
       public long? amt_2st_trn { get; set; }

       [Column("dis_per_2nd", Order = 80, TypeName = "double(18,3)")]
       public long? dis_per_2nd { get; set; }

       [Column("dis_amt_2nd", Order = 81, TypeName = "double(18,3)")]
       public long? dis_amt_2nd { get; set; }

       [Column("dis_amt_2nd_tot", Order = 82, TypeName = "double(18,3)")]
       public long? dis_amt_2nd_tot { get; set; }

       [Column("rate_after_dis_2nd", Order = 83, TypeName = "double(18,3)")]
       public long? rate_after_dis_2nd { get; set; }

       [Column("amt_3rd_trn", Order = 84, TypeName = "double(18,3)")]
       public long? amt_3rd_trn { get; set; }

       [Column("tax_per_trn", Order = 85, TypeName = "double(18,3)")]
       public long? tax_per_trn { get; set; }

       [Column("tax_amt_on_f_rate_trn", Order = 86, TypeName = "double(18,3)")]
       public long? tax_amt_on_f_rate_trn { get; set; }

       [Column("tax_amt_tot_trn", Order = 87, TypeName = "double(18,3)")]
       public long? tax_amt_tot_trn { get; set; }

       [Column("rate_after_tax", Order = 88, TypeName = "double(18,3)")]
       public long? rate_after_tax { get; set; }

       [Column("dadd1", Order = 89, TypeName = "varchar(100)")]
       public string? dadd1 { get; set; }

       [Column("dadd2", Order = 90, TypeName = "varchar(100)")]
       public string? dadd2 { get; set; }

       [Column("dadd3", Order = 91, TypeName = "varchar(100)")]
       public string? dadd3 { get; set; }

       [Column("dadd4", Order = 92, TypeName = "varchar(100)")]
       public string? dadd4 { get; set; }

       [Column("dadd5", Order = 93, TypeName = "varchar(100)")]
       public string? dadd5 { get; set; }

       [Column("dadd6", Order = 94, TypeName = "varchar(100)")]
       public string? dadd6 { get; set; }

       [Column("dadd7", Order = 95, TypeName = "varchar(100)")]
       public string? dadd7 { get; set; }

       [Column("dadd8", Order = 96, TypeName = "varchar(100)")]
       public string? dadd8 { get; set; }

       [Column("dadd9", Order = 97, TypeName = "varchar(100)")]
       public string? dadd9 { get; set; }

       [Column("dlandline_phno", Order = 98, TypeName = "varchar(30)")]
       public string? dlandline_phno { get; set; }

       [Column("dmobile_phno", Order = 99, TypeName = "varchar(30)")]
       public string? dmobile_phno { get; set; }

       [Column("dgstin_no", Order = 100, TypeName = "varchar(20)")]
       public string? dgstin_no { get; set; }

       [Column("manual_bill_no", Order = 101, TypeName = "varchar(100)")]
       public string? manual_bill_no { get; set; }

       [Column("due_date", Order = 102, TypeName = "varchar(100)")]
       public string? due_date { get; set; }

       [Column("consum_qty", Order = 103, TypeName = "double(18,3)")]
       public long? consum_qty { get; set; }

       [Column("avg_qty", Order = 104, TypeName = "double(18,3)")]
       public long? avg_qty { get; set; }

       [Column("rate_one_pc", Order = 105, TypeName = "double(18,3)")]
       public long? rate_one_pc { get; set; }

       [Column("other_exp_name", Order = 106, TypeName = "varchar(100)")]
       public string? other_exp_name { get; set; }

       [Column("other_exp_amt", Order = 107, TypeName = "double(18,3)")]
       public long? other_exp_amt { get; set; }

       [Column("rnd_off_add_less", Order = 108, TypeName = "varchar(10)")]
       public string? rnd_off_add_less { get; set; }

       [Column("comp_sno", Order = 109, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 110, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 111, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 112, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

   }
}
