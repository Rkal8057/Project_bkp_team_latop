using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Ca_Upload_Cdsl_03
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id_03", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id_03 { get; set; }

       [Column("trfno", Order = 3, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("sno_num", Order = 4, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("record_type", Order = 5, TypeName = "varchar(2)")]
       public string? record_type { get; set; }

       [Column("ca_isin", Order = 6, TypeName = "varchar(12)")]
       public string? ca_isin { get; set; }

       [Column("dn_from", Order = 7, TypeName = "varchar(18)")]
       public string? dn_from { get; set; }

       [Column("dn_to", Order = 8, TypeName = "varchar(18)")]
       public string? dn_to { get; set; }

       [Column("dn_quantity", Order = 9, TypeName = "varchar(18)")]
       public string? dn_quantity { get; set; }

       [Column("debit_credit_flag", Order = 10, TypeName = "varchar(1)")]
       public string? debit_credit_flag { get; set; }

   }
}
