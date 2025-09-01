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
    public class IssueReceiptTransDetail
    {
        [Key]
        [Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [ForeignKey("IssueReceiptMaster") ,Column("challan_master_id", Order = 1, TypeName = "bigint")]
        public long? challan_master_id { get; set; }

        [Column("pcode", Order = 2, TypeName = "bigint")]
        public long? pcode { get; set; }

        [Column("pname", Order = 3, TypeName = "text")]
        public string? pname { get; set; }

        [ForeignKey("ItemMaster") ,Column("item_code", Order = 4, TypeName = "bigint")]
        public long? item_code { get; set; }

        [Column("item_short_name", Order = 5, TypeName = "text")]
        public string? item_short_name { get; set; }

        [Column("item_name", Order = 6, TypeName = "text")]
        public string? item_name { get; set; }

        [Column("item_group_code", Order = 7, TypeName = "bigint")]
        public long? item_group_code { get; set; }

        [Column("item_group_name", Order = 8, TypeName = "text")]
        public string? item_group_name { get; set; }

        [Column("unit_name", Order = 9, TypeName = "text")]
        public string? unit_name { get; set; }

        [Column("itemtype", Order = 10, TypeName = "text")]
        public string? itemtype { get; set; }

        [Column("issue_qty", Order = 11, TypeName = "decimal(18,2)")]
        public double? issue_qty { get; set; }

        [Column("recv_qty", Order = 12, TypeName = "decimal(18,2)")]
        public double? recv_qty { get; set; }

        [Column("irflag", Order = 13, TypeName = "text")]
        public string? irflag { get; set; }

        [Column("rent_rate", Order = 14, TypeName = "decimal(18,2)")]
        public double? rent_rate { get; set; }

        [Column("rate_of_one_pcs", Order = 15, TypeName = "text")]
        public string? rate_of_one_pcs { get; set; }

        [Column("weight_of_one_pcs", Order = 16, TypeName = "decimal(18,2)")]
        public double? weight_of_one_pcs { get; set; }

        [Column("unique_number", Order = 17, TypeName = "text")]
        public string? unique_number { get; set; }

        [Column("opening_qty", Order = 18, TypeName = "decimal(18,2)")]
        public double? opening_qty { get; set; }

        [Column("delete_at", Order = 19, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [ForeignKey("AggrementMaster"), Column("aggrement_id", Order = 20, TypeName = "bigint")]
        public long? aggrement_id { get; set; }



        [Column("item_purchase_one_pc", Order = 21, TypeName = "decimal(18,2)")]
        public double? item_purchase_one_pc { get; set; }

        [Column("item_rate_one_pc", Order = 22, TypeName = "decimal(18,2)")]
        public double? item_rate_one_pc { get; set; }

        [Column("item_profit_one_pc", Order = 23, TypeName = "decimal(18,2)")]
        public double? item_profit_one_pc { get; set; }

        [Column("item_qty", Order = 24, TypeName = "bigint")] // `issue_qty`
        public long? item_qty { get; set; }

        [Column("item_discount_percentage_one_pc", Order = 25, TypeName = "decimal(18,2)")]
        public double? item_discount_percentage_one_pc { get; set; }

        [Column("item_discount_amount_one_pc", Order = 26, TypeName = "decimal(18,2)")]
        public double? item_discount_amount_one_pc { get; set; }

        [Column("item_discount_rate_one_pc", Order = 27, TypeName = "decimal(18,2)")]
        public double? item_discount_rate_one_pc { get; set; }

        [Column("item_gross_amount_one_pc", Order = 28, TypeName = "decimal(18,2)")]
        public double? item_gross_amount_one_pc { get; set; }

        [Column("item_gst_percenatge_one_pc", Order = 29, TypeName = "decimal(18,2)")]
        public double? item_gst_percenatge_one_pc { get; set; }

        [Column("item_gst_amt_one_pc", Order = 30, TypeName = "decimal(18,2)")]
        public double? item_gst_amt_one_pc { get; set; }

        [Column("item_gst_rate_one_pc", Order = 31, TypeName = "decimal(18,2)")]
        public double? item_gst_rate_one_pc { get; set; }

        [Column("item_rate_after_gst_one_pc", Order = 32, TypeName = "decimal(18,2)")]
        public double? item_rate_after_gst_one_pc { get; set; }

        [Column("total_amount_with_gst_one_pc", Order = 33, TypeName = "decimal(18,2)")]
        public double? total_amount_with_gst_one_pc { get; set; }

        [Column("profit_amount_one_pc", Order = 34, TypeName = "decimal(18,2)")]
        public double? profit_amount_one_pc { get; set; }

        [Column("item_hsn_code_one_pc", Order = 35, TypeName = "text")]
        public string? item_hsn_code_one_pc { get; set; }

        [Column("item_packing_type_one_pc", Order = 36, TypeName = "text")]
        public string? item_packing_type_one_pc { get; set; }

        [Column("item_remarks_one_pc", Order = 37, TypeName = "text")]
        public string? item_remarks_one_pc { get; set; }

        [Column("item_weight_one_pc", Order = 38, TypeName = "decimal(18,2)")]
        public double? item_weight_one_pc { get; set; }

        [Column("item_scheme_type_one_pc", Order = 39, TypeName = "text")]
        public string? item_scheme_type_one_pc { get; set; }


        
        public virtual IssueReceiptMaster? IssueReceiptMaster { get; set; }
        public virtual ItemMaster? ItemMaster { get; set; }
        public virtual AggrementMaster? AggrementMaster { get; set; }



    }
}
