using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class Guarantor1Detail
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("guarantor1_Name", Order = 2, TypeName = "text")]
        public string? guarantor1_Name { get; set; }

        [Column("guarantor1_SWH_Name", Order = 3, TypeName = "text")]
        public string? guarantor1_SWH_Name { get; set; }

        [Column("guarantor1_Resi_Address", Order = 4, TypeName = "text")]
        public string? guarantor1_Resi_Address { get; set; }

        [Column("guarantor1_Phones_No", Order = 5, TypeName = "text")]
        public string? guarantor1_Phones_No { get; set; }

        [Column("guarantor1_Campany_Name", Order = 6, TypeName = "text")]
        public string? guarantor1_Company_Name { get; set; }

        [Column("guarantor1_Off_Address", Order = 7, TypeName = "text")]
        public string? guarantor1_Off_Address { get; set; }

        [Column("guarantor1_Off_Phone_No", Order = 8, TypeName = "text")]
        public string? guarantor1_Off_Phone_No { get; set; }

        [ForeignKey("CaseMaster"), Column("Case_Master_id", Order = 9, TypeName = "bigint")]
        public long? Case_Master_id { get; set; }
        public virtual CaseMaster? CaseMaster { get; set; }
    }
}
