using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("e_upload_cdsl_header")] 
       
   public class E_Upload_Cdsl_Header
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("rta_id", Order = 3, TypeName = "varchar(6)")]
       public string? rta_id { get; set; }

       [Column("operator_id", Order = 4, TypeName = "varchar(6)")]
       public string? operator_id { get; set; }

       [Column("tot_no_records", Order = 5, TypeName = "varchar(6)")]
       public string? tot_no_records { get; set; }

       [Column("file_extension", Order = 6, TypeName = "varchar(5)")]
       public string? file_extension { get; set; }

       [Column("business_date", Order = 7, TypeName = "varchar(8)")]
       public string? business_date { get; set; }

   }
}
