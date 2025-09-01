using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Dp_Cl_Id_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("created_id", Order = 2, TypeName = "bigint(10)")]
       public long? created_id { get; set; }

       [Column("created_on", Order = 3, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 4, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("dp_id", Order = 5, TypeName = "varchar(8)")]
       public string? dp_id { get; set; }

       [Column("cl_id", Order = 6, TypeName = "varchar(8)")]
       public string? cl_id { get; set; }

       [Column("fst_hld_nm", Order = 7, TypeName = "varchar(2255)")]
       public string? fst_hld_nm { get; set; }

       [Column("snd_hld_nm", Order = 8, TypeName = "text")]
       public string? snd_hld_nm { get; set; }

       [Column("thd_hld_nm", Order = 9, TypeName = "text")]
       public string? thd_hld_nm { get; set; }

       [Column("fst_hld_fh", Order = 10, TypeName = "text")]
       public string? fst_hld_fh { get; set; }

       [Column("snd_hld_fh", Order = 11, TypeName = "text")]
       public string? snd_hld_fh { get; set; }

       [Column("thd_hld_fh", Order = 12, TypeName = "text")]
       public string? thd_hld_fh { get; set; }

       [Column("fst_pan", Order = 13, TypeName = "text")]
       public string? fst_pan { get; set; }

       [Column("snd_pan", Order = 14, TypeName = "text")]
       public string? snd_pan { get; set; }

       [Column("thd_pan", Order = 15, TypeName = "text")]
       public string? thd_pan { get; set; }

       [Column("ben_ad_pa1", Order = 16, TypeName = "text")]
       public string? ben_ad_pa1 { get; set; }

       [Column("ben_ad_pa2", Order = 17, TypeName = "text")]
       public string? ben_ad_pa2 { get; set; }

       [Column("ben_ad_pa3", Order = 18, TypeName = "text")]
       public string? ben_ad_pa3 { get; set; }

       [Column("ben_ad_pa4", Order = 19, TypeName = "text")]
       public string? ben_ad_pa4 { get; set; }

       [Column("ben_ad_pin", Order = 20, TypeName = "varchar(10)")]
       public string? ben_ad_pin { get; set; }

       [Column("benphn", Order = 21, TypeName = "text")]
       public string? benphn { get; set; }

       [Column("benfax", Order = 22, TypeName = "text")]
       public string? benfax { get; set; }

       [Column("minor", Order = 23, TypeName = "varchar(1)")]
       public string? minor { get; set; }

       [Column("nomgur", Order = 24, TypeName = "varchar(1)")]
       public string? nomgur { get; set; }

       [Column("ngname", Order = 25, TypeName = "text")]
       public string? ngname { get; set; }

       [Column("ngad1", Order = 26, TypeName = "text")]
       public string? ngad1 { get; set; }

       [Column("ngad2", Order = 27, TypeName = "text")]
       public string? ngad2 { get; set; }

       [Column("ngad3", Order = 28, TypeName = "text")]
       public string? ngad3 { get; set; }

       [Column("ngad4", Order = 29, TypeName = "text")]
       public string? ngad4 { get; set; }

       [Column("ngpin", Order = 30, TypeName = "varchar(10)")]
       public string? ngpin { get; set; }

       [Column("benbank", Order = 31, TypeName = "text")]
       public string? benbank { get; set; }

       [Column("bannmbr", Order = 32, TypeName = "varchar(135)")]
       public string? bannmbr { get; set; }

       [Column("bnkad1", Order = 33, TypeName = "text")]
       public string? bnkad1 { get; set; }

       [Column("bnkad2", Order = 34, TypeName = "text")]
       public string? bnkad2 { get; set; }

       [Column("bnkad3", Order = 35, TypeName = "text")]
       public string? bnkad3 { get; set; }

       [Column("bnkad4", Order = 36, TypeName = "text")]
       public string? bnkad4 { get; set; }

       [Column("bnkpin", Order = 37, TypeName = "varchar(10)")]
       public string? bnkpin { get; set; }

       [Column("micrno", Order = 38, TypeName = "text")]
       public string? micrno { get; set; }

       [Column("ifsc", Order = 39, TypeName = "varchar(111)")]
       public string? ifsc { get; set; }

       [Column("bnktype", Order = 40, TypeName = "varchar(2)")]
       public string? bnktype { get; set; }

       [Column("fill3", Order = 41, TypeName = "text")]
       public string? fill3 { get; set; }

   }
}
