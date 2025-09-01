using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class System_Records_ModelRequest
    {

        public string? home_state_code { get; set; }

        public string? default_tax_name { get; set; }

        public string? default_tax_per { get; set; }

        public string? default_unit { get; set; }

        public string? default_hsn_code { get; set; }

        public string? default_company_no { get; set; }

        public string? company_name { get; set; }

        public string? company_address { get; set; }

        public string? company_address_1 { get; set; }

        public string? company_phone { get; set; }

        public long? sale_retrun_code { get; set; }

        public string? sale_return_name_default { get; set; }

        public long? sale_code { get; set; }

        public string? sale_name_default { get; set; }

        public long? bank_code { get; set; }

        public string? bank_name_default { get; set; }

        public string? cash_name_default { get; set; }

        public long? cash_code { get; set; }

        public DateTime? year_from { get; set; }

        public DateTime? year_to { get; set; }

        public string? display_height { get; set; }

        public string? saledatabaselock { get; set; }

        public string? database_1_path { get; set; }

        public string? database_2_path { get; set; }

        public string? auto_raw_yes_no { get; set; }

        public string? weekly_off_day { get; set; }

        public string? other2 { get; set; }

        public string? other3 { get; set; }

        public string? other4 { get; set; }

        public string? other5 { get; set; }

        public string? other6 { get; set; }

        public string? other7 { get; set; }

        public string? other8 { get; set; }

        public string? other9 { get; set; }

        public string? other10 { get; set; }

        public string? other11 { get; set; }

        public string? other12 { get; set; }

        public string? other13 { get; set; }

        public string? other14 { get; set; }

        public string? other15 { get; set; }

        public string? other16 { get; set; }

        public string? other17 { get; set; }

        public string? other18 { get; set; }

        public string? other19 { get; set; }

        public string? other20 { get; set; }

        public string? sale_format { get; set; }

        public string? home_state { get; set; }

        public string? email_sender { get; set; }

        public string? email_receiver { get; set; }

        public string? ch_bill_header_name { get; set; }

        public string? ss_bill_header_name { get; set; }

        public string? sr_bill_header_name { get; set; }

        public string? pp_bill_header_name { get; set; }

        public string? pr_bill_header_name { get; set; }

        public string? po_bill_header_name { get; set; }

        public string? so_bill_header_name { get; set; }

        public string? rc_bill_header_name { get; set; }

        public string? qu_bill_header_name { get; set; }

        public string? rounded_off { get; set; }

        public string? c_rta_id { get; set; }

        public string? c_operator_id { get; set; }

        public string? p_register_comp_add { get; set; }

        public string? data_validation_check_yn { get; set; }


        public string? bill_type_method { get; set; }
        public double? cart_tcs_value { get; set; }
        public string? batch_no { get; set; }
        public string? style { get; set; }
        public string? brand { get; set; }
        public string? color { get; set; }
        public string? agent { get; set; }
        public string? dealer { get; set; }
        public string? round_off { get; set; }



        public string? transporter_cartage_yn { get; set; }
        public string? maintain_accounting_yn { get; set; }
        public string? challan_master_method { get; set; }

        public string? purchase_rate_yn { get; set; }
        public string? profit_yn { get; set; }
        public string? discount_amount_yn { get; set; }
        public string? discount_rate_yn { get; set; }
        public string? gst_amount_yn { get; set; }
        public string? total_profit_yn { get; set; }
        public string? total_weight_yn { get; set; }
        public string? gst_rate_yn { get; set; }

        public string? opening_yn { get; set; }
        public string? damage_yn { get; set; }
        public string? missing_yn { get; set; }
        public string? rent_rate_yn { get; set; }
        public string? agr_qty_yn { get; set; }
        public string? pc_rmt_pp_yn { get; set; }

    }
}

