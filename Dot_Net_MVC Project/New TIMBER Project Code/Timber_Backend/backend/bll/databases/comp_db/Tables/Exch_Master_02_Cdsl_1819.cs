using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("exch_master_02_cdsl_1819")] 
       
   public class Exch_Master_02_Cdsl_1819
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

       [Column("category_header", Order = 12, TypeName = "varchar(50)")]
       public string? category_header { get; set; }

       [Column("category_header_detail", Order = 13, TypeName = "varchar(50)")]
       public string? category_header_detail { get; set; }

       [Column("p_pi_pn", Order = 14, TypeName = "varchar(3)")]
       public string? p_pi_pn { get; set; }

       [Column("p_pi_pn_details", Order = 15, TypeName = "varchar(50)")]
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

       [Column("other1", Order = 21, TypeName = "varchar(50)")]
       public string? other1 { get; set; }

       [Column("other2", Order = 22, TypeName = "varchar(50)")]
       public string? other2 { get; set; }

       [Column("other3", Order = 23, TypeName = "varchar(50)")]
       public string? other3 { get; set; }

       [Column("other4", Order = 24, TypeName = "varchar(50)")]
       public string? other4 { get; set; }

       [Column("other5", Order = 25, TypeName = "varchar(50)")]
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

       [Column("isincd", Order = 31, TypeName = "varchar(12)")]
       public string? isincd { get; set; }

       [Column("dpid", Order = 32, TypeName = "varchar(8)")]
       public string? dpid { get; set; }

       [Column("cl_id", Order = 33, TypeName = "varchar(8)")]
       public string? cl_id { get; set; }

       [Column("names", Order = 34, TypeName = "varchar(164)")]
       public string? names { get; set; }

       [Column("jt1", Order = 35, TypeName = "varchar(164)")]
       public string? jt1 { get; set; }

       [Column("jt2", Order = 36, TypeName = "varchar(164)")]
       public string? jt2 { get; set; }

       [Column("gname", Order = 37, TypeName = "varchar(142)")]
       public string? gname { get; set; }

       [Column("cnname", Order = 38, TypeName = "varchar(142)")]
       public string? cnname { get; set; }

       [Column("fname", Order = 39, TypeName = "varchar(50)")]
       public string? fname { get; set; }

       [Column("mf", Order = 40, TypeName = "varchar(1)")]
       public string? mf { get; set; }

       [Column("bdt", Order = 41, TypeName = "varchar(11)")]
       public string? bdt { get; set; }

       [Column("acstat", Order = 42, TypeName = "float")]
       public long? acstat { get; set; }

       [Column("bocat", Order = 43, TypeName = "float")]
       public long? bocat { get; set; }

       [Column("bopr", Order = 44, TypeName = "float")]
       public long? bopr { get; set; }

       [Column("custtype", Order = 45, TypeName = "float")]
       public long? custtype { get; set; }

       [Column("bosubtype", Order = 46, TypeName = "float")]
       public long? bosubtype { get; set; }

       [Column("occupation", Order = 47, TypeName = "varchar(2)")]
       public string? occupation { get; set; }

       [Column("pan1", Order = 48, TypeName = "varchar(25)")]
       public string? pan1 { get; set; }

       [Column("pan2", Order = 49, TypeName = "varchar(25)")]
       public string? pan2 { get; set; }

       [Column("pan3", Order = 50, TypeName = "varchar(25)")]
       public string? pan3 { get; set; }

       [Column("bofrflag", Order = 51, TypeName = "varchar(1)")]
       public string? bofrflag { get; set; }

       [Column("frrscode", Order = 52, TypeName = "float")]
       public long? frrscode { get; set; }

       [Column("isinst", Order = 53, TypeName = "varchar(1)")]
       public string? isinst { get; set; }

       [Column("opdt", Order = 54, TypeName = "datetime")]
       public DateTime? opdt { get; set; }

       [Column("sebirno", Order = 55, TypeName = "varchar(24)")]
       public string? sebirno { get; set; }

       [Column("seid", Order = 56, TypeName = "float")]
       public long? seid { get; set; }

       [Column("chcid", Order = 57, TypeName = "float")]
       public long? chcid { get; set; }

       [Column("cmid", Order = 58, TypeName = "varchar(8)")]
       public string? cmid { get; set; }

       [Column("trid", Order = 59, TypeName = "varchar(8)")]
       public string? trid { get; set; }

       [Column("rbino", Order = 60, TypeName = "varchar(30)")]
       public string? rbino { get; set; }

       [Column("rbiapdt", Order = 61, TypeName = "varchar(11)")]
       public string? rbiapdt { get; set; }

       [Column("tds", Order = 62, TypeName = "float")]
       public long? tds { get; set; }

       [Column("nation", Order = 63, TypeName = "varchar(2)")]
       public string? nation { get; set; }

       [Column("ad1", Order = 64, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 65, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("ad3", Order = 66, TypeName = "varchar(50)")]
       public string? ad3 { get; set; }

       [Column("city", Order = 67, TypeName = "varchar(25)")]
       public string? city { get; set; }

       [Column("state", Order = 68, TypeName = "varchar(25)")]
       public string? state { get; set; }

       [Column("country", Order = 69, TypeName = "varchar(25)")]
       public string? country { get; set; }

       [Column("pincode", Order = 70, TypeName = "varchar(10)")]
       public string? pincode { get; set; }

       [Column("pad1", Order = 71, TypeName = "varchar(50)")]
       public string? pad1 { get; set; }

       [Column("pad2", Order = 72, TypeName = "varchar(50)")]
       public string? pad2 { get; set; }

       [Column("pad3", Order = 73, TypeName = "varchar(50)")]
       public string? pad3 { get; set; }

       [Column("pcity", Order = 74, TypeName = "varchar(25)")]
       public string? pcity { get; set; }

       [Column("pstate", Order = 75, TypeName = "varchar(25)")]
       public string? pstate { get; set; }

       [Column("pcont", Order = 76, TypeName = "varchar(25)")]
       public string? pcont { get; set; }

       [Column("ppin", Order = 77, TypeName = "varchar(10)")]
       public string? ppin { get; set; }

       [Column("telno1", Order = 78, TypeName = "varchar(17)")]
       public string? telno1 { get; set; }

       [Column("telno2", Order = 79, TypeName = "varchar(17)")]
       public string? telno2 { get; set; }

       [Column("bofax", Order = 80, TypeName = "varchar(17)")]
       public string? bofax { get; set; }

       [Column("boemail", Order = 81, TypeName = "varchar(50)")]
       public string? boemail { get; set; }

       [Column("ecsmandate", Order = 82, TypeName = "varchar(1)")]
       public string? ecsmandate { get; set; }

       [Column("divmicrno", Order = 83, TypeName = "varchar(12)")]
       public string? divmicrno { get; set; }

       [Column("divbkbr", Order = 84, TypeName = "varchar(12)")]
       public string? divbkbr { get; set; }

       [Column("bknm", Order = 85, TypeName = "varchar(100)")]
       public string? bknm { get; set; }

       [Column("bkad1", Order = 86, TypeName = "varchar(40)")]
       public string? bkad1 { get; set; }

       [Column("bkad2", Order = 87, TypeName = "varchar(40)")]
       public string? bkad2 { get; set; }

       [Column("bkad3", Order = 88, TypeName = "varchar(40)")]
       public string? bkad3 { get; set; }

       [Column("bkcity", Order = 89, TypeName = "varchar(25)")]
       public string? bkcity { get; set; }

       [Column("bkst", Order = 90, TypeName = "varchar(25)")]
       public string? bkst { get; set; }

       [Column("bkcont", Order = 91, TypeName = "varchar(25)")]
       public string? bkcont { get; set; }

       [Column("bkpin", Order = 92, TypeName = "varchar(10)")]
       public string? bkpin { get; set; }

       [Column("divcr", Order = 93, TypeName = "float")]
       public long? divcr { get; set; }

       [Column("divbkty", Order = 94, TypeName = "float")]
       public long? divbkty { get; set; }

       [Column("divbknm", Order = 95, TypeName = "varchar(20)")]
       public string? divbknm { get; set; }

       [Column("noshares", Order = 96, TypeName = "float")]
       public long? noshares { get; set; }

       [Column("shlock", Order = 97, TypeName = "float")]
       public long? shlock { get; set; }

       [Column("plbal", Order = 98, TypeName = "float")]
       public long? plbal { get; set; }

       [Column("sfkpbal", Order = 99, TypeName = "float")]
       public long? sfkpbal { get; set; }

       [Column("earmarkbal", Order = 100, TypeName = "float")]
       public long? earmarkbal { get; set; }

       [Column("pnremat", Order = 101, TypeName = "varchar(22)")]
       public string? pnremat { get; set; }

       [Column("freebal", Order = 102, TypeName = "varchar(22)")]
       public string? freebal { get; set; }

       [Column("pndmver", Order = 103, TypeName = "varchar(22)")]
       public string? pndmver { get; set; }

       [Column("pndmconf", Order = 104, TypeName = "varchar(22)")]
       public string? pndmconf { get; set; }

       [Column("dateofben", Order = 105, TypeName = "varchar(8)")]
       public string? dateofben { get; set; }

       [Column("bdt1", Order = 106, TypeName = "datetime")]
       public DateTime? bdt1 { get; set; }

   }
}
