using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class VoucherMasterReq
    {
        public long? unique_trn_id { get; set; }
        public long? client_purchaser_code { get; set; }
        public string? client_purchaser_name { get; set; }
        public long? agent_code { get; set; }
        public string? agent_name { get; set; }
        public long? vender_code { get; set; }
        public string? vender_name { get; set; }
        public long? vou_type_id { get; set; }
        public string? vou_type { get; set; }
        public string? vou_fa_year { get; set; }
        public string? vou_ref_no { get; set; }
        public DateTime? vou_date { get; set; }
        public long? vou_cash_bank_id { get; set; }
        public string? vou_cash_bank_name { get; set; }
        public decimal? tot_vou_amt { get; set; }
        public string? username { get; set; }
        public long? status { get; set; }

        public List<VoucherMasterTranxKey>? VoucherMasterTranxKey { get; set; }
        public List<VoucherTranxDeleteArray>? VoucherTranxDeleteArray {  get; set; }
        public VoucherMasterTranxKey? VoucherMasterTranxDetail { get; set; }
    }

    public class VoucherMasterTranxKey
    {
        public long? id { get; set; }
        public long? unique_trn_id { get; set; }
        public long? client_purchaser_code { get; set; }
        public string? client_purchaser_name { get; set; }
        public long? agent_code { get; set; }
        public string? agent_name { get; set; }
        public long? vender_code { get; set; }
        public string? vender_name { get; set; }
        public long? voucher_master_id { get; set; }
        public long? vou_p_id { get; set; }
        public string? vou_pname { get; set; }
        public string? vou_chq_detail { get; set; }
        public string? vou_narr { get; set; }
        public decimal vou_amt { get; set; }
        public string? vou_agst_bill { get; set; }
        public string? username { get; set; }


        public decimal?  vou_gst_amt { get; set; }
        public decimal? vou_gst_per { get; set; }
        public decimal ?vou_gross_amt { get; set; }
    }

    public class VoucherTranxDeleteArray
    {
        public long? id { get; set; }
        public long? unique_trn_id { get; set; }
        public long? client_purchaser_code { get; set; }
        public string? client_purchaser_name { get; set; }
        public long? agent_code { get; set; }
        public string? agent_name { get; set; }
        public long? vender_code { get; set; }
        public string? vender_name { get; set; }
        public long? voucher_master_id { get; set; }
        public long? vou_p_id { get; set; }
        public string? vou_pname { get; set; }
        public string? vou_chq_detail { get; set; }
        public string? vou_narr { get; set; }
        public decimal vou_amt { get; set; }
        public string? vou_agst_bill { get; set; } 
        public string? username { get; set; }




    }
}

