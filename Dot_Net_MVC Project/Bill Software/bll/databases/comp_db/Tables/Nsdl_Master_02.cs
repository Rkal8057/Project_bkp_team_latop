using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("nsdl_master_02")] 
       
   public class Nsdl_Master_02
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("benpos_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? benpos_auto_id { get; set; }

       [Column("import_id", Order = 3, TypeName = "float")]
       public long? import_id { get; set; }

       [Column("import_id_txt", Order = 4, TypeName = "varchar(50)")]
       public string? import_id_txt { get; set; }

       [Column("import_date", Order = 5, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("entry_date", Order = 6, TypeName = "datetime")]
       public DateTime? entry_date { get; set; }

       [Column("comp_sno", Order = 7, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 8, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 9, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 10, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("username", Order = 11, TypeName = "varchar(50)")]
       public string? username { get; set; }

       [Column("rtype", Order = 12, TypeName = "float")]
       public long? rtype { get; set; }

       [Column("lno", Order = 13, TypeName = "float")]
       public long? lno { get; set; }

       [Column("dp_id", Order = 14, TypeName = "varchar(8)")]
       public string? dp_id { get; set; }

       [Column("ben_ac_num", Order = 15, TypeName = "varchar(8)")]
       public string? ben_ac_num { get; set; }

       [Column("ben_type", Order = 16, TypeName = "varchar(2)")]
       public string? ben_type { get; set; }

       [Column("ben_sub_tp", Order = 17, TypeName = "varchar(2)")]
       public string? ben_sub_tp { get; set; }

       [Column("bacccat", Order = 18, TypeName = "varchar(2)")]
       public string? bacccat { get; set; }

       [Column("benocc", Order = 19, TypeName = "varchar(2)")]
       public string? benocc { get; set; }

       [Column("fst_hld_nm", Order = 20, TypeName = "varchar(50)")]
       public string? fst_hld_nm { get; set; }

       [Column("fst_hld_fh", Order = 21, TypeName = "varchar(50)")]
       public string? fst_hld_fh { get; set; }

       [Column("ben_ad_pa1", Order = 22, TypeName = "varchar(50)")]
       public string? ben_ad_pa1 { get; set; }

       [Column("ben_ad_pa2", Order = 23, TypeName = "varchar(50)")]
       public string? ben_ad_pa2 { get; set; }

       [Column("ben_ad_pa3", Order = 24, TypeName = "varchar(50)")]
       public string? ben_ad_pa3 { get; set; }

       [Column("ben_ad_pa4", Order = 25, TypeName = "varchar(50)")]
       public string? ben_ad_pa4 { get; set; }

       [Column("ben_ad_pin", Order = 26, TypeName = "varchar(10)")]
       public string? ben_ad_pin { get; set; }

       [Column("benphn", Order = 27, TypeName = "varchar(50)")]
       public string? benphn { get; set; }

       [Column("benfax", Order = 28, TypeName = "varchar(50)")]
       public string? benfax { get; set; }

       [Column("snd_hld_nm", Order = 29, TypeName = "varchar(50)")]
       public string? snd_hld_nm { get; set; }

       [Column("sndfhn", Order = 30, TypeName = "varchar(50)")]
       public string? sndfhn { get; set; }

       [Column("thd_hld_nm", Order = 31, TypeName = "varchar(50)")]
       public string? thd_hld_nm { get; set; }

       [Column("thfhn", Order = 32, TypeName = "varchar(50)")]
       public string? thfhn { get; set; }

       [Column("fil1", Order = 33, TypeName = "varchar(50)")]
       public string? fil1 { get; set; }

       [Column("fill2", Order = 34, TypeName = "varchar(50)")]
       public string? fill2 { get; set; }

       [Column("istpan", Order = 35, TypeName = "varchar(50)")]
       public string? istpan { get; set; }

       [Column("sndpan", Order = 36, TypeName = "varchar(50)")]
       public string? sndpan { get; set; }

       [Column("thdpan", Order = 37, TypeName = "varchar(50)")]
       public string? thdpan { get; set; }

       [Column("nomgur", Order = 38, TypeName = "varchar(1)")]
       public string? nomgur { get; set; }

       [Column("ngname", Order = 39, TypeName = "varchar(50)")]
       public string? ngname { get; set; }

       [Column("ngad1", Order = 40, TypeName = "varchar(50)")]
       public string? ngad1 { get; set; }

       [Column("ngad2", Order = 41, TypeName = "varchar(50)")]
       public string? ngad2 { get; set; }

       [Column("ngad3", Order = 42, TypeName = "varchar(50)")]
       public string? ngad3 { get; set; }

       [Column("ngad4", Order = 43, TypeName = "varchar(50)")]
       public string? ngad4 { get; set; }

       [Column("ngpin", Order = 44, TypeName = "varchar(10)")]
       public string? ngpin { get; set; }

       [Column("dob", Order = 45, TypeName = "datetime")]
       public DateTime? dob { get; set; }

       [Column("minor", Order = 46, TypeName = "varchar(1)")]
       public string? minor { get; set; }

       [Column("benbank", Order = 47, TypeName = "varchar(50)")]
       public string? benbank { get; set; }

       [Column("bannmbr", Order = 48, TypeName = "varchar(135)")]
       public string? bannmbr { get; set; }

       [Column("bnkad1", Order = 49, TypeName = "varchar(50)")]
       public string? bnkad1 { get; set; }

       [Column("bnkad2", Order = 50, TypeName = "varchar(50)")]
       public string? bnkad2 { get; set; }

       [Column("bnkad3", Order = 51, TypeName = "varchar(50)")]
       public string? bnkad3 { get; set; }

       [Column("bnkad4", Order = 52, TypeName = "varchar(50)")]
       public string? bnkad4 { get; set; }

       [Column("bnkpin", Order = 53, TypeName = "varchar(10)")]
       public string? bnkpin { get; set; }

       [Column("rbiref", Order = 54, TypeName = "varchar(50)")]
       public string? rbiref { get; set; }

       [Column("rbiapdt", Order = 55, TypeName = "datetime")]
       public DateTime? rbiapdt { get; set; }

       [Column("sebireg", Order = 56, TypeName = "varchar(50)")]
       public string? sebireg { get; set; }

       [Column("bentaxst", Order = 57, TypeName = "varchar(50)")]
       public string? bentaxst { get; set; }

       [Column("benstat", Order = 58, TypeName = "varchar(2)")]
       public string? benstat { get; set; }

       [Column("ben_positi", Order = 59, TypeName = "float")]
       public long? ben_positi { get; set; }

       [Column("benlock", Order = 60, TypeName = "varchar(50)")]
       public string? benlock { get; set; }

       [Column("benblk", Order = 61, TypeName = "varchar(50)")]
       public string? benblk { get; set; }

       [Column("benplg", Order = 62, TypeName = "varchar(50)")]
       public string? benplg { get; set; }

       [Column("benplglk", Order = 63, TypeName = "varchar(50)")]
       public string? benplglk { get; set; }

       [Column("benplgun", Order = 64, TypeName = "varchar(50)")]
       public string? benplgun { get; set; }

       [Column("benplgcloc", Order = 65, TypeName = "varchar(50)")]
       public string? benplgcloc { get; set; }

       [Column("benrem", Order = 66, TypeName = "varchar(50)")]
       public string? benrem { get; set; }

       [Column("benremloc", Order = 67, TypeName = "varchar(50)")]
       public string? benremloc { get; set; }

       [Column("bencmidpos", Order = 68, TypeName = "varchar(50)")]
       public string? bencmidpos { get; set; }

       [Column("cmpool", Order = 69, TypeName = "varchar(50)")]
       public string? cmpool { get; set; }

       [Column("ccsett", Order = 70, TypeName = "varchar(50)")]
       public string? ccsett { get; set; }

       [Column("micrno", Order = 71, TypeName = "varchar(50)")]
       public string? micrno { get; set; }

       [Column("ifsc", Order = 72, TypeName = "varchar(111)")]
       public string? ifsc { get; set; }

       [Column("bnktype", Order = 73, TypeName = "varchar(2)")]
       public string? bnktype { get; set; }

       [Column("fill3", Order = 74, TypeName = "varchar(50)")]
       public string? fill3 { get; set; }

       [Column("fstmapin", Order = 75, TypeName = "varchar(50)")]
       public string? fstmapin { get; set; }

       [Column("sndmapin", Order = 76, TypeName = "varchar(50)")]
       public string? sndmapin { get; set; }

       [Column("thdmapin", Order = 77, TypeName = "varchar(50)")]
       public string? thdmapin { get; set; }

       [Column("fstemail", Order = 78, TypeName = "varchar(50)")]
       public string? fstemail { get; set; }

       [Column("sndemail", Order = 79, TypeName = "varchar(50)")]
       public string? sndemail { get; set; }

       [Column("thdemail", Order = 80, TypeName = "varchar(50)")]
       public string? thdemail { get; set; }

       [Column("fill4", Order = 81, TypeName = "varchar(50)")]
       public string? fill4 { get; set; }

   }
}
