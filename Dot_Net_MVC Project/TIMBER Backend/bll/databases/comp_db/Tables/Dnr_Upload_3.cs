using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("dnr_upload_3")] 
       
   public class Dnr_Upload_3
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

       [Column("isin", Order = 9, TypeName = "varchar(12)")]
       public string? isin { get; set; }

       [Column("natureisin", Order = 10, TypeName = "varchar(1)")]
       public string? natureisin { get; set; }

       [Column("cutflag", Order = 11, TypeName = "varchar(1)")]
       public string? cutflag { get; set; }

       [Column("transflag", Order = 12, TypeName = "varchar(1)")]
       public string? transflag { get; set; }

       [Column("allotmentd", Order = 13, TypeName = "varchar(8)")]
       public string? allotmentd { get; set; }

       [Column("fromdn", Order = 14, TypeName = "varchar(18)")]
       public string? fromdn { get; set; }

       [Column("todn", Order = 15, TypeName = "varchar(18)")]
       public string? todn { get; set; }

       [Column("totdnqty", Order = 16, TypeName = "varchar(18)")]
       public string? totdnqty { get; set; }

       [Column("typeholding_d_p", Order = 17, TypeName = "varchar(2)")]
       public string? typeholding_d_p { get; set; }

       [Column("flagstatus", Order = 18, TypeName = "varchar(2)")]
       public string? flagstatus { get; set; }

       [Column("issuedescription", Order = 19, TypeName = "varchar(35)")]
       public string? issuedescription { get; set; }

       [Column("nse", Order = 20, TypeName = "varchar(1)")]
       public string? nse { get; set; }

       [Column("nseinprin", Order = 21, TypeName = "varchar(8)")]
       public string? nseinprin { get; set; }

       [Column("nselisting", Order = 22, TypeName = "varchar(8)")]
       public string? nselisting { get; set; }

       [Column("nsetrading", Order = 23, TypeName = "varchar(8)")]
       public string? nsetrading { get; set; }

       [Column("bse", Order = 24, TypeName = "varchar(1)")]
       public string? bse { get; set; }

       [Column("bseinprinc", Order = 25, TypeName = "varchar(8)")]
       public string? bseinprinc { get; set; }

       [Column("bselisting", Order = 26, TypeName = "varchar(8)")]
       public string? bselisting { get; set; }

       [Column("bsetrading", Order = 27, TypeName = "varchar(8)")]
       public string? bsetrading { get; set; }

       [Column("msei", Order = 28, TypeName = "varchar(1)")]
       public string? msei { get; set; }

       [Column("mseiinpric", Order = 29, TypeName = "varchar(8)")]
       public string? mseiinpric { get; set; }

       [Column("mseilising", Order = 30, TypeName = "varchar(8)")]
       public string? mseilising { get; set; }

       [Column("mseitradin", Order = 31, TypeName = "varchar(8)")]
       public string? mseitradin { get; set; }

   }
}
