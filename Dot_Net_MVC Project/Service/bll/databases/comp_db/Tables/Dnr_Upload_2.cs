using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("dnr_upload_2")] 
       
   public class Dnr_Upload_2
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("file_no", Order = 3, TypeName = "float")]
       public long? file_no { get; set; }

       [Column("bath_id", Order = 4, TypeName = "varchar(8)")]
       public string? bath_id { get; set; }

       [Column("lnno", Order = 5, TypeName = "varchar(6)")]
       public string? lnno { get; set; }

       [Column("recotype", Order = 6, TypeName = "varchar(2)")]
       public string? recotype { get; set; }

       [Column("dpeosid", Order = 7, TypeName = "varchar(8)")]
       public string? dpeosid { get; set; }

       [Column("bpid", Order = 8, TypeName = "varchar(8)")]
       public string? bpid { get; set; }

       [Column("rtref", Order = 9, TypeName = "varchar(35)")]
       public string? rtref { get; set; }

       [Column("uploadf", Order = 10, TypeName = "varchar(1)")]
       public string? uploadf { get; set; }

       [Column("isin", Order = 11, TypeName = "varchar(12)")]
       public string? isin { get; set; }

       [Column("dnfrom", Order = 12, TypeName = "varchar(18)")]
       public string? dnfrom { get; set; }

       [Column("dnto", Order = 13, TypeName = "varchar(18)")]
       public string? dnto { get; set; }

       [Column("numdn", Order = 14, TypeName = "varchar(18)")]
       public string? numdn { get; set; }

       [Column("uploadqty", Order = 15, TypeName = "varchar(18)")]
       public string? uploadqty { get; set; }

       [Column("totaluploalqty", Order = 16, TypeName = "varchar(18)")]
       public string? totaluploalqty { get; set; }

       [Column("totaldetaitqty", Order = 17, TypeName = "varchar(18)")]
       public string? totaldetaitqty { get; set; }

       [Column("totaldematqty", Order = 18, TypeName = "varchar(18)")]
       public string? totaldematqty { get; set; }

       [Column("totalphyqty", Order = 19, TypeName = "varchar(18)")]
       public string? totalphyqty { get; set; }

       [Column("otherqty", Order = 20, TypeName = "varchar(18)")]
       public string? otherqty { get; set; }

   }
}
