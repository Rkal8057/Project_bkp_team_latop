using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Email_Smtserver_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("smtserver_id", Order = 2, TypeName = "bigint(10)")]
       public long? smtserver_id { get; set; }

       [Column("smtserver_set_default_yn", Order = 3, TypeName = "varchar(1)")]
       public string? smtserver_set_default_yn { get; set; }

       [Column("smtserver_port", Order = 4, TypeName = "varchar(55)")]
       public string? smtserver_port { get; set; }

       [Column("smtserver_host", Order = 5, TypeName = "varchar(55)")]
       public string? smtserver_host { get; set; }

       [Column("smtserver_enable_ssl_yn", Order = 6, TypeName = "varchar(1)")]
       public string? smtserver_enable_ssl_yn { get; set; }

       [Column("smt_server_flag", Order = 7, TypeName = "varchar(55)")]
       public string? smt_server_flag { get; set; }

   }
}
