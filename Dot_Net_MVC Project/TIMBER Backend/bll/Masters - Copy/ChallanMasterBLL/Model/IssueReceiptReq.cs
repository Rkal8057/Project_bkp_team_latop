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
    public class IssueReceiptReq
    {
        public long? id { get; set; }
        public long? billno_automatic { get; set; }
        public long? pcode { get; set; }
        public string? pname { get; set; }
        public string? pname_short_code { get; set; }
        public string? agr_code_old { get; set; }
        public string? agr_no_old { get; set; }
        public string? client_type { get; set; }
        public string? item_code { get; set; }
        public string? item_short_name { get; set; }
        public string? item_name { get; set; }
        public long? item_group_code { get; set; }
        public string? item_group_name { get; set; }
        public DateTime? bill_date { get; set; }
        public string? challanno { get; set; }
        public double? issue_qty { get; set; }
        public double? recv_qty { get; set; }
        public string? irflag { get; set; }
        public DateTime? billfr { get; set; }
        public DateTime? billto { get; set; }
        public double? rent_rate { get; set; }
        public double? broken_amt { get; set; }
        public double? frshop { get; set; }
        public double? froffice { get; set; }
        public double? brok_qty { get; set; }
        public double? brok_rate { get; set; }
        public string? miss_flag { get; set; }
        public string? misc_ac_code { get; set; }
        public double? misc_exp_total { get; set; }
        public string? cartcode { get; set; }
        public double? cart_amt { get; set; }
        public string? remark_note { get; set; }
        public string? prnnarr { get; set; }
        public double? stkvalue { get; set; }
        public double? misc1 { get; set; }
        public double? misc2 { get; set; }
        public double? misc3 { get; set; }
        public double? misc4 { get; set; }
        public double? misc5 { get; set; }
        public double? misc6 { get; set; }
        public long? sno { get; set; }
        public string? contact_prs_ph { get; set; }
        public string? transporter_name { get; set; }
        public string? gr_no { get; set; }
        public string? vehicleno { get; set; }
        public string? driver_name { get; set; }
        public string? dl_no { get; set; }
        public string? permit_no { get; set; }
        public string? contact_prs_ph_no { get; set; }
        public long? apx_weight { get; set; }
        public string? apx_value { get; set; }
        public DateTime? bill_enter_date { get; set; }
        public long? trip_no { get; set; }
        public double? b1_rate { get; set; }
        public double? b1_qty { get; set; }
        public double? b1_amt { get; set; }
        public string? b1_narr { get; set; }
        public double? b2_rate { get; set; }
        public double? b2_qty { get; set; }
        public double? b2_amt { get; set; }
        public string? b2_narr { get; set; }
        public double? b3_rate { get; set; }
        public double? b3_qty { get; set; }
        public double? b3_amt { get; set; }
        public string? b3_narr { get; set; }
        public double? b4_rate { get; set; }
        public double? b4_qty { get; set; }
        public double? b4_amt { get; set; }
        public string? b4_narr { get; set; }
        public double? b5_rate { get; set; }
        public double? b5_qty { get; set; }
        public double? b5_amt { get; set; }
        public string? b5_narr { get; set; }
        public double? b6_rate { get; set; }
        public double? b6_qty { get; set; }
        public double? b6_amt { get; set; }
        public string? b6_narr { get; set; }
        public double? b7_rate { get; set; }
        public double? b7_qty { get; set; }
        public double? b7_amt { get; set; }
        public string? b7_narr { get; set; }
        public double? b8_rate { get; set; }
        public double? b8_qty { get; set; }
        public double? b8_amt { get; set; }
        public string? b8_narr { get; set; }
        public double? b9_rate { get; set; }
        public double? b9_qty { get; set; }
        public double? b9_amt { get; set; }
        public string? b9_narr { get; set; }
        public double? b10_rate { get; set; }
        public double? b10_qty { get; set; }
        public double? b10_amt { get; set; }
        public string? b10_narr { get; set; }
        public double? bill_amt { get; set; }
        public string? rec_type { get; set; }
        public string? tnx_type { get; set; }
        public string? unit_name { get; set; }
        public string? itemtype { get; set; }
        public long? tax_code { get; set; }
        public string? tax_name { get; set; }
        public double? tax_per { get; set; }
        public double? tax_amt { get; set; }
        public double? dis_per { get; set; }
        public double? dis_amt { get; set; }
        public double? gross_amt { get; set; }
        public double? tot_qty { get; set; }
        public string? add_off_site { get; set; }
        public string? hsn_code { get; set; }
        public string? gst_type { get; set; }
        public string? state_code { get; set; }
        public string? tax_yn { get; set; }
        public double? igst_per { get; set; }
        public double? igst_amt { get; set; }
        public double? sgst_per { get; set; }
        public double? sgst_amt { get; set; }
        public double? cgst_per { get; set; }
        public double? cgst_amt { get; set; }
        public string? reverse_charge { get; set; }
        public string? electronic_ref_no { get; set; }
        public string? ref_2 { get; set; }
        public double? weight_of_one_pcs { get; set; }
        public double? tot_weight_of_pcs { get; set; }
        public string? manual_billno { get; set; }
        public string? ordno { get; set; }
        public string? ord_date { get; set; }
        public double? trx_code { get; set; }
        public string? trx_name { get; set; }
        public string? pkg { get; set; }
        public string? c_form { get; set; }
        public double? net_amt { get; set; }
        public double? tot_amt { get; set; }
        public string? transporter_code { get; set; }
        public string? fraight { get; set; }
        public string? contact_prs { get; set; }
        public string? site_add { get; set; }
        public string? todo { get; set; }
        public string? amt_in_wor { get; set; }
        public string? duedate { get; set; }
        public string? round_off_yn { get; set; }
        public double? round_off_amt { get; set; }
        public string? station_name { get; set; }
        public double? qty_kg { get; set; }
        public double? tot_kg { get; set; }
        public string? add1 { get; set; }
        public string? add2 { get; set; }
        public string? add3_location { get; set; }
        public string? add4_city { get; set; }
        public string? add5_state { get; set; }
        public string? add6_pincode { get; set; }
        public string? add7_state_code { get; set; }
        public string? country_name { get; set; }
        public string? addr_type { get; set; }
        public string? addr_gst_type { get; set; }
        public string? gstno { get; set; }
        public string? rent_on_type { get; set; }
        public double? opening_qty { get; set; }
        public double? issued_bal_on_chal_date { get; set; }

        public string? unique_number { get; set; }
        


        public List<ChallanTrnKey>? ChallanTrnKey { get; set; }
        public List<ChallanMiscTranxKey> ? ChallanMiscTranxKey { get; set; }
        public List<ChallanBreakageTransKey> ? ChallanBreakageTransKey { get; set; }

        public List<RemoveChallanBreakageTransKey>? RemoveChallanBreakageTransKey { get; set; }

        public List<RemoveChallanMiscTransKey>? RemoveChallanMiscTransKey { get; set; }




    }


    public class ChallanTrnKey
    {

        public long id { get; set; }

        public long? challan_master_id { get; set; }

        public long? pcode { get; set; }

        public string? pname { get; set; }

        public long? item_code { get; set; }

        public string? item_short_name { get; set; }

        public string? item_name { get; set; }

        public long? item_group_code { get; set; }

        public string? item_group_name { get; set; }

        public string? unit_name { get; set; }

        public string? itemtype { get; set; }

        public double? issue_qty { get; set; }

        public double? recv_qty { get; set; }

        public string? irflag { get; set; }

        public double? rent_rate { get; set; }

        public string? rate_of_one_pcs { get; set; }

        public double? weight_of_one_pcs { get; set; }
        public string? unique_number { get; set; }

        public double? opening_qty { get; set; }

    }


    public class ChallanMiscTranxKey
    {
        public long id { get; set; }
        public long? bill_no_automatic { get; set; }
        public long? pcode { get; set; }
        public string? pname { get; set; }
        public string? agr_code_old { get; set; }
        public string? ch_no { get; set; }
        public DateTime? bill_date { get; set; }
        public string? exp_ac_name { get; set; }
        public long? exp_amt { get; set; }
        public string? exp_remarks { get; set; }
        public string? ir_flag { get; set; }
        public string? fo_oh { get; set; }
        public string? unique_number { get; set; }

    }


    public  class ChallanBreakageTransKey
    {
        public long challan_trans_id { get; set; }
        public long challan_master_id { get; set; }

        public long id { get; set; }
        public double? rate { get; set; }
        public double? qty { get; set; }
        public double? amt { get; set; }
        public string? narr { get; set; }
        public double? damage { get; set; }
        public double? missing { get; set; }
        public string? item_name { get; set; }
        public string? unique_number { get; set; }


    }

    public class RemoveChallanBreakageTransKey
    {
        public long id { get; set; }
        public double? rate { get; set; }
        public double? qty { get; set; }
        public double? amt { get; set; }
        public string? narr { get; set; }
        public double? damage { get; set; }
        public double? missing { get; set; }
        public string? item_name { get; set; }
        public string? unique_number { get; set; }


    }


    public class RemoveChallanMiscTransKey
    {
        public long id { get; set; }
        public double? rate { get; set; }
        public double? qty { get; set; }
        public double? amt { get; set; }
        public string? narr { get; set; }
        public double? damage { get; set; }
        public double? missing { get; set; }
        public string? item_name { get; set; }
        public string? unique_number { get; set; }


    }
}
