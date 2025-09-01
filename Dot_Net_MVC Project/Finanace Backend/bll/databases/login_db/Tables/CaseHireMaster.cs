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
    public class CaseHireMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("Hire_Name", Order = 1, TypeName = "text")]
        public string? Hire_Name { get; set; }

        [Column("Hire_SWH_Name", Order = 2, TypeName = "text")]
        public string? Hire_SWH_Name { get; set; }

        [Column("Hire_Resi_Address", Order = 3, TypeName = "text")]
        public string? Hire_Resi_Address { get; set; }

        [Column("Hire_Ph_No", Order = 4, TypeName = "text")]
        public string? Hire_Ph_No { get; set; }

        [Column("Hire_Company_Name", Order = 5, TypeName = "text")]
        public string? Hire_Company_Name { get; set; }

        [Column("Hire_Off_Ph_Nos", Order = 6, TypeName = "text")]
        public string? Hire_Off_Ph_Nos { get; set; }

        [Column("Hire_Off_Address", Order = 7, TypeName = "text")]
        public string? Hire_Off_Address { get; set; }

        [Column("Hire_Ph_No2", Order = 8, TypeName = "text")]
        public string? Hire_Ph_No2 { get; set; }

        [Column("Hire_Post", Order = 9, TypeName = "text")]
        public string? Hire_Post { get; set; }

        [Column("Hire_Profession", Order = 10, TypeName = "text")]
        public string? Hire_Profession { get; set; }

        [Column("Hire_Area", Order = 11, TypeName = "text")]
        public string? Hire_Area { get; set; }

        [Column("Hire_Location", Order = 12, TypeName = "text")]
        public string? Hire_Location { get; set; }

        [Column("Hire_Email", Order = 13, TypeName = "text")]
        public string? Hire_Email { get; set; }

        [Column("Hire_Whatsapp_Phone", Order = 14, TypeName = "text")]
        public string? Hire_Whatsapp_Phone { get; set; }
        [ForeignKey("CaseMaster"), Column("Case_Master_id", Order = 15, TypeName = "bigint")]
        public long? Case_Master_id { get; set; }
        public virtual CaseMaster? CaseMaster { get; set; }
    }
}
