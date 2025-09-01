using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("e_vote_cdsl_master")] 
       
   public class E_Vote_Cdsl_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("param", Order = 2, TypeName = "varchar(2)")]
       public string? param { get; set; }

       [Column("seprater_1", Order = 3, TypeName = "varchar(2)")]
       public string? seprater_1 { get; set; }

       [Column("param_num", Order = 4, TypeName = "float")]
       public long? param_num { get; set; }

       [Column("seprater_2", Order = 5, TypeName = "varchar(2)")]
       public string? seprater_2 { get; set; }

       [Column("sno_num", Order = 6, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("seprater_3", Order = 7, TypeName = "varchar(2)")]
       public string? seprater_3 { get; set; }

       [Column("sno", Order = 8, TypeName = "varchar(10)")]
       public string? sno { get; set; }

       [Column("seprater_4", Order = 9, TypeName = "varchar(2)")]
       public string? seprater_4 { get; set; }

       [Column("type", Order = 10, TypeName = "varchar(12)")]
       public string? type { get; set; }

       [Column("seprater_5", Order = 11, TypeName = "varchar(2)")]
       public string? seprater_5 { get; set; }

       [Column("boidfl", Order = 12, TypeName = "varchar(16)")]
       public string? boidfl { get; set; }

       [Column("seprater_6", Order = 13, TypeName = "varchar(2)")]
       public string? seprater_6 { get; set; }

       [Column("pan", Order = 14, TypeName = "varchar(10)")]
       public string? pan { get; set; }

       [Column("seprater_7", Order = 15, TypeName = "varchar(2)")]
       public string? seprater_7 { get; set; }

       [Column("uid", Order = 16, TypeName = "varchar(12)")]
       public string? uid { get; set; }

       [Column("seprater_8", Order = 17, TypeName = "varchar(2)")]
       public string? seprater_8 { get; set; }

       [Column("substat", Order = 18, TypeName = "float")]
       public long? substat { get; set; }

       [Column("seprater_9", Order = 19, TypeName = "varchar(2)")]
       public string? seprater_9 { get; set; }

       [Column("noshares", Order = 20, TypeName = "double(18,3)")]
       public long? noshares { get; set; }

       [Column("seprater_10", Order = 21, TypeName = "varchar(2)")]
       public string? seprater_10 { get; set; }

       [Column("fstnm", Order = 22, TypeName = "varchar(100)")]
       public string? fstnm { get; set; }

       [Column("seprater_11", Order = 23, TypeName = "varchar(2)")]
       public string? seprater_11 { get; set; }

       [Column("sndnm", Order = 24, TypeName = "varchar(50)")]
       public string? sndnm { get; set; }

       [Column("seprater_12", Order = 25, TypeName = "varchar(2)")]
       public string? seprater_12 { get; set; }

       [Column("thdnm", Order = 26, TypeName = "varchar(50)")]
       public string? thdnm { get; set; }

       [Column("seprater_13", Order = 27, TypeName = "varchar(2)")]
       public string? seprater_13 { get; set; }

       [Column("ad1", Order = 28, TypeName = "varchar(36)")]
       public string? ad1 { get; set; }

       [Column("seprater_14", Order = 29, TypeName = "varchar(2)")]
       public string? seprater_14 { get; set; }

       [Column("ad2", Order = 30, TypeName = "varchar(36)")]
       public string? ad2 { get; set; }

       [Column("seprater_15", Order = 31, TypeName = "varchar(2)")]
       public string? seprater_15 { get; set; }

       [Column("ad3", Order = 32, TypeName = "varchar(36)")]
       public string? ad3 { get; set; }

       [Column("seprater_16", Order = 33, TypeName = "varchar(2)")]
       public string? seprater_16 { get; set; }

       [Column("city", Order = 34, TypeName = "varchar(25)")]
       public string? city { get; set; }

       [Column("seprater_17", Order = 35, TypeName = "varchar(2)")]
       public string? seprater_17 { get; set; }

       [Column("state", Order = 36, TypeName = "varchar(25)")]
       public string? state { get; set; }

       [Column("seprater_18", Order = 37, TypeName = "varchar(2)")]
       public string? seprater_18 { get; set; }

       [Column("country", Order = 38, TypeName = "varchar(25)")]
       public string? country { get; set; }

       [Column("seprater_19", Order = 39, TypeName = "varchar(2)")]
       public string? seprater_19 { get; set; }

       [Column("picode", Order = 40, TypeName = "varchar(10)")]
       public string? picode { get; set; }

       [Column("seprater_20", Order = 41, TypeName = "varchar(2)")]
       public string? seprater_20 { get; set; }

       [Column("dob", Order = 42, TypeName = "varchar(11)")]
       public string? dob { get; set; }

       [Column("seprater_21", Order = 43, TypeName = "varchar(2)")]
       public string? seprater_21 { get; set; }

       [Column("bankdet", Order = 44, TypeName = "varchar(20)")]
       public string? bankdet { get; set; }

       [Column("seprater_22", Order = 45, TypeName = "varchar(2)")]
       public string? seprater_22 { get; set; }

       [Column("mobno", Order = 46, TypeName = "varchar(10)")]
       public string? mobno { get; set; }

       [Column("seprater_23", Order = 47, TypeName = "varchar(2)")]
       public string? seprater_23 { get; set; }

       [Column("emailid", Order = 48, TypeName = "varchar(60)")]
       public string? emailid { get; set; }

       [Column("seprater_24", Order = 49, TypeName = "varchar(2)")]
       public string? seprater_24 { get; set; }

       [Column("block", Order = 50, TypeName = "varchar(1)")]
       public string? block { get; set; }

       [Column("seprater_25", Order = 51, TypeName = "varchar(2)")]
       public string? seprater_25 { get; set; }

       [Column("blockreaso", Order = 52, TypeName = "varchar(100)")]
       public string? blockreaso { get; set; }

   }
}
