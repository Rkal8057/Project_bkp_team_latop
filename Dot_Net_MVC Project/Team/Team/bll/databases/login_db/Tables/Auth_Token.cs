using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Login.Tables
{
    public class Auth_Token
    {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long id { get; set; }
       
       [Column("crypto_key", Order = 2, TypeName = "varchar(30)"),Required]
       public string crypto_key { get; set; }

       [Column("user_code", Order = 3, TypeName = "bigint(10)"),Required]
       public long user_code { get; set; }

       [Column("creation_dttm", Order = 4, TypeName = "datetime"),Required]
       public DateTime creation_dttm { get; set; }
    }
}