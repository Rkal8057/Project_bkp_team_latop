using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_iepf_data_by_company")] 
       
   public class Tr_Iepf_Data_By_Company
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trfno", Order = 2, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("excel_sheet_sno", Order = 3, TypeName = "float")]
       public long? excel_sheet_sno { get; set; }

       [Column("current_exchange", Order = 4, TypeName = "varchar(50)")]
       public string? current_exchange { get; set; }

       [Column("dp_id", Order = 5, TypeName = "varchar(50)")]
       public string? dp_id { get; set; }

       [Column("cl_id", Order = 6, TypeName = "varchar(50)")]
       public string? cl_id { get; set; }

       [Column("no_of_shares", Order = 7, TypeName = "float")]
       public long? no_of_shares { get; set; }

   }
}
