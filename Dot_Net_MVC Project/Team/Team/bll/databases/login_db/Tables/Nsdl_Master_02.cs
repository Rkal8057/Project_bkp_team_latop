using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Nsdl_Master_02
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("benpos_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? benpos_auto_id { get; set; }

       [Column("import_id", Order = 3, TypeName = "float")]
       public long? import_id { get; set; }

       [Column("import_id_txt", Order = 4, TypeName = "text")]
       public string? import_id_txt { get; set; }

       [Column("import_date", Order = 5, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("entry_date", Order = 6, TypeName = "datetime")]
       public DateTime? entry_date { get; set; }

       [Column("comp_sno", Order = 7, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 8, TypeName = "text")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 9, TypeName = "text")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 10, TypeName = "text")]
       public string? comp_name_short { get; set; }

       [Column("username", Order = 11, TypeName = "text")]
       public string? username { get; set; }

       [Column("category_header", Order = 12, TypeName = "text")]
       public string? category_header { get; set; }

       [Column("category_header_detail", Order = 13, TypeName = "text")]
       public string? category_header_detail { get; set; }

       [Column("p_pi_pn", Order = 14, TypeName = "varchar(3)")]
       public string? p_pi_pn { get; set; }

       [Column("p_pi_pn_details", Order = 15, TypeName = "text")]
       public string? p_pi_pn_details { get; set; }

       [Column("holder_share_status", Order = 16, TypeName = "varchar(100)")]
       public string? holder_share_status { get; set; }

       [Column("account_type", Order = 17, TypeName = "varchar(100)")]
       public string? account_type { get; set; }

       [Column("share_lock_yn", Order = 18, TypeName = "varchar(100)")]
       public string? share_lock_yn { get; set; }

       [Column("share_plg_yn", Order = 19, TypeName = "varchar(100)")]
       public string? share_plg_yn { get; set; }

       [Column("non_promoter", Order = 20, TypeName = "varchar(25)")]
       public string? non_promoter { get; set; }

       [Column("other1", Order = 21, TypeName = "text")]
       public string? other1 { get; set; }

       [Column("other2", Order = 22, TypeName = "text")]
       public string? other2 { get; set; }

       [Column("other3", Order = 23, TypeName = "text")]
       public string? other3 { get; set; }

       [Column("other4", Order = 24, TypeName = "text")]
       public string? other4 { get; set; }

       [Column("other5", Order = 25, TypeName = "text")]
       public string? other5 { get; set; }

       [Column("other_number1_sno", Order = 26, TypeName = "float")]
       public long? other_number1_sno { get; set; }

       [Column("other_number2_sno", Order = 27, TypeName = "float")]
       public long? other_number2_sno { get; set; }

       [Column("other_number3_sno", Order = 28, TypeName = "float")]
       public long? other_number3_sno { get; set; }

       [Column("other_number4_sno", Order = 29, TypeName = "float")]
       public long? other_number4_sno { get; set; }

       [Column("other_number5_sno", Order = 30, TypeName = "float")]
       public long? other_number5_sno { get; set; }

       [Column("rtype", Order = 31, TypeName = "float")]
       public long? rtype { get; set; }

       [Column("lno", Order = 32, TypeName = "float")]
       public long? lno { get; set; }

       [Column("dp_id", Order = 33, TypeName = "varchar(8)")]
       public string? dp_id { get; set; }

       [Column("ben_ac_num", Order = 34, TypeName = "varchar(8)")]
       public string? ben_ac_num { get; set; }

       [Column("ben_type", Order = 35, TypeName = "varchar(2)")]
       public string? ben_type { get; set; }

       [Column("ben_sub_tp", Order = 36, TypeName = "varchar(2)")]
       public string? ben_sub_tp { get; set; }

       [Column("bacccat", Order = 37, TypeName = "varchar(2)")]
       public string? bacccat { get; set; }

       [Column("benocc", Order = 38, TypeName = "varchar(2)")]
       public string? benocc { get; set; }

       [Column("fst_hld_nm", Order = 39, TypeName = "text")]
       public string? fst_hld_nm { get; set; }

       [Column("fst_hld_fh", Order = 40, TypeName = "text")]
       public string? fst_hld_fh { get; set; }

       [Column("ben_ad_pa1", Order = 41, TypeName = "text")]
       public string? ben_ad_pa1 { get; set; }

       [Column("ben_ad_pa2", Order = 42, TypeName = "text")]
       public string? ben_ad_pa2 { get; set; }

       [Column("ben_ad_pa3", Order = 43, TypeName = "text")]
       public string? ben_ad_pa3 { get; set; }

       [Column("ben_ad_pa4", Order = 44, TypeName = "text")]
       public string? ben_ad_pa4 { get; set; }

       [Column("ben_ad_pin", Order = 45, TypeName = "varchar(10)")]
       public string? ben_ad_pin { get; set; }

       [Column("benphn", Order = 46, TypeName = "text")]
       public string? benphn { get; set; }

       [Column("benfax", Order = 47, TypeName = "text")]
       public string? benfax { get; set; }

       [Column("snd_hld_nm", Order = 48, TypeName = "text")]
       public string? snd_hld_nm { get; set; }

       [Column("sndfhn", Order = 49, TypeName = "text")]
       public string? sndfhn { get; set; }

       [Column("thd_hld_nm", Order = 50, TypeName = "text")]
       public string? thd_hld_nm { get; set; }

       [Column("thfhn", Order = 51, TypeName = "text")]
       public string? thfhn { get; set; }

       [Column("fil1", Order = 52, TypeName = "text")]
       public string? fil1 { get; set; }

       [Column("fill2", Order = 53, TypeName = "text")]
       public string? fill2 { get; set; }

       [Column("istpan", Order = 54, TypeName = "text")]
       public string? istpan { get; set; }

       [Column("sndpan", Order = 55, TypeName = "text")]
       public string? sndpan { get; set; }

       [Column("thdpan", Order = 56, TypeName = "text")]
       public string? thdpan { get; set; }

       [Column("nomgur", Order = 57, TypeName = "varchar(1)")]
       public string? nomgur { get; set; }

       [Column("ngname", Order = 58, TypeName = "text")]
       public string? ngname { get; set; }

       [Column("ngad1", Order = 59, TypeName = "text")]
       public string? ngad1 { get; set; }

       [Column("ngad2", Order = 60, TypeName = "text")]
       public string? ngad2 { get; set; }

       [Column("ngad3", Order = 61, TypeName = "text")]
       public string? ngad3 { get; set; }

       [Column("ngad4", Order = 62, TypeName = "text")]
       public string? ngad4 { get; set; }

       [Column("ngpin", Order = 63, TypeName = "varchar(10)")]
       public string? ngpin { get; set; }

       [Column("dob", Order = 64, TypeName = "datetime")]
       public DateTime? dob { get; set; }

       [Column("minor", Order = 65, TypeName = "varchar(1)")]
       public string? minor { get; set; }

       [Column("benbank", Order = 66, TypeName = "text")]
       public string? benbank { get; set; }

       [Column("bannmbr", Order = 67, TypeName = "varchar(135)")]
       public string? bannmbr { get; set; }

       [Column("bnkad1", Order = 68, TypeName = "text")]
       public string? bnkad1 { get; set; }

       [Column("bnkad2", Order = 69, TypeName = "text")]
       public string? bnkad2 { get; set; }

       [Column("bnkad3", Order = 70, TypeName = "text")]
       public string? bnkad3 { get; set; }

       [Column("bnkad4", Order = 71, TypeName = "text")]
       public string? bnkad4 { get; set; }

       [Column("bnkpin", Order = 72, TypeName = "varchar(10)")]
       public string? bnkpin { get; set; }

       [Column("rbiref", Order = 73, TypeName = "text")]
       public string? rbiref { get; set; }

       [Column("rbiapdt", Order = 74, TypeName = "datetime")]
       public DateTime? rbiapdt { get; set; }

       [Column("sebireg", Order = 75, TypeName = "text")]
       public string? sebireg { get; set; }

       [Column("bentaxst", Order = 76, TypeName = "text")]
       public string? bentaxst { get; set; }

       [Column("benstat", Order = 77, TypeName = "varchar(2)")]
       public string? benstat { get; set; }

       [Column("ben_positi", Order = 78, TypeName = "float")]
       public long? ben_positi { get; set; }

       [Column("benlock", Order = 79, TypeName = "text")]
       public string? benlock { get; set; }

       [Column("benblk", Order = 80, TypeName = "text")]
       public string? benblk { get; set; }

       [Column("benplg", Order = 81, TypeName = "text")]
       public string? benplg { get; set; }

       [Column("benplglk", Order = 82, TypeName = "text")]
       public string? benplglk { get; set; }

       [Column("benplgun", Order = 83, TypeName = "text")]
       public string? benplgun { get; set; }

       [Column("benplgcloc", Order = 84, TypeName = "text")]
       public string? benplgcloc { get; set; }

       [Column("benrem", Order = 85, TypeName = "text")]
       public string? benrem { get; set; }

       [Column("benremloc", Order = 86, TypeName = "text")]
       public string? benremloc { get; set; }

       [Column("bencmidpos", Order = 87, TypeName = "text")]
       public string? bencmidpos { get; set; }

       [Column("cmpool", Order = 88, TypeName = "text")]
       public string? cmpool { get; set; }

       [Column("ccsett", Order = 89, TypeName = "text")]
       public string? ccsett { get; set; }

       [Column("micrno", Order = 90, TypeName = "text")]
       public string? micrno { get; set; }

       [Column("ifsc", Order = 91, TypeName = "varchar(111)")]
       public string? ifsc { get; set; }

       [Column("bnktype", Order = 92, TypeName = "varchar(2)")]
       public string? bnktype { get; set; }

       [Column("fill3", Order = 93, TypeName = "text")]
       public string? fill3 { get; set; }

       [Column("fstmapin", Order = 94, TypeName = "text")]
       public string? fstmapin { get; set; }

       [Column("sndmapin", Order = 95, TypeName = "text")]
       public string? sndmapin { get; set; }

       [Column("thdmapin", Order = 96, TypeName = "text")]
       public string? thdmapin { get; set; }

       [Column("fstemail", Order = 97, TypeName = "text")]
       public string? fstemail { get; set; }

       [Column("sndemail", Order = 98, TypeName = "text")]
       public string? sndemail { get; set; }

       [Column("thdemail", Order = 99, TypeName = "text")]
       public string? thdemail { get; set; }

       [Column("fill4", Order = 100, TypeName = "text")]
       public string? fill4 { get; set; }

   }
}
