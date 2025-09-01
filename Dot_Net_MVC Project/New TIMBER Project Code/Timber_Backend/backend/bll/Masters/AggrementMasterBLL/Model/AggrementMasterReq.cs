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
    public class AggrementMasterReq
    {

        public long id { get; set; }
        public long? party_master_id { get; set; }
        public long? pcode { get; set; }
        public string? pname_short_code { get; set; }
        public string? pname { get; set; }
        public string? agr_code_old { get; set; }
        public string? agr_no_old { get; set; }
        public string? item_status_agr { get; set; }
        public long? item_code { get; set; }
        public string? item_short_name { get; set; }
        public string? item_name { get; set; }
        public long? item_group_code { get; set; }
        public string? item_group_name { get; set; }
        public string? mix_item_yes_no { get; set; }
        public string? item_loc { get; set; }
        public double? rent_rate { get; set; }
        public double? broken_chg { get; set; }
        public double? agr_qty { get; set; }
        public DateTime? agr_date { get; set; }
        public double? opening_qty { get; set; }
        public string? rate_on_type { get; set; }
        public double? missing_rate { get; set; }
        public double? notaxrate { get; set; }
        public long? s_no { get; set; }
        public string? rate_of_one_pcs { get; set; }
        public double? weight_of_one_pcs { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
    }
}
