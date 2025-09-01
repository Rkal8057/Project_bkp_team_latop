using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("stock_tmp_table")] 
       
   public class Stock_Tmp_Table
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("item_name", Order = 2, TypeName = "varchar(50)")]
       public string? item_name { get; set; }

       [Column("billno", Order = 3, TypeName = "varchar(50)")]
       public string? billno { get; set; }

       [Column("bill_date", Order = 4, TypeName = "datetime")]
       public DateTime? bill_date { get; set; }

       [Column("transaction_type", Order = 5, TypeName = "varchar(50)")]
       public string? transaction_type { get; set; }

       [Column("in_qty", Order = 6, TypeName = "double(18,3)")]
       public long? in_qty { get; set; }

       [Column("out_qty", Order = 7, TypeName = "double(18,3)")]
       public long? out_qty { get; set; }

       [Column("balance", Order = 8, TypeName = "double(18,3)")]
       public long? balance { get; set; }

       [Column("min_qty", Order = 9, TypeName = "bigint(10)")]
       public long? min_qty { get; set; }

       [Column("max_qty", Order = 10, TypeName = "bigint(10)")]
       public long? max_qty { get; set; }

       [Column("item_rate", Order = 11, TypeName = "double(18,3)")]
       public long? item_rate { get; set; }

       [Column("total_amt", Order = 12, TypeName = "double(18,3)")]
       public long? total_amt { get; set; }

       [Column("item_type", Order = 13, TypeName = "varchar(6)")]
       public string? item_type { get; set; }

   }
}
