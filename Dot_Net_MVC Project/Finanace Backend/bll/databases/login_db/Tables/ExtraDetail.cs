using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class ExtraDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("extra_Registration_No", Order = 2, TypeName = "text")]
        public string? extra_Registration_No { get; set; }

        [Column("extra_Hirer_Name", Order = 3, TypeName = "text")]
        public string? extra_Hirer_Name { get; set; }

        [Column("extra_Item_Type", Order = 4, TypeName = "text")]
        public string? extra_Item_Type { get; set; }

        [Column("extra_Manufacturer", Order = 5, TypeName = "text")]
        public string? extra_Manufacturer { get; set; }

        [Column("extra_Model_Name", Order = 6, TypeName = "text")]
        public string? extra_Model_Name { get; set; }

        [Column("extra_Year_of_Registration", Order = 7, TypeName = "text")]
        public string? extra_Year_of_Registration { get; set; }

        [Column("extra_RC_Given", Order = 8, TypeName = "text")]
        public string? extra_RC_Given { get; set; }

        [Column("extra_RC_Taken_By", Order = 9, TypeName = "text")]
        public string? extra_RC_Taken_By { get; set; }

        [Column("extra_Chassis_No", Order = 10, TypeName = "text")]
        public string? extra_Chassis_No { get; set; }

        [Column("extra_Engine_No", Order = 11, TypeName = "text")]
        public string? extra_Engine_No { get; set; }

        [Column("extra_NOC_Made", Order = 12, TypeName ="text")]
        public string? extra_NOC_Made { get; set; }

        [Column("extra_Taken_By", Order = 13, TypeName = "text")]
        public string? extra_Taken_By { get; set; }

        [Column("extra_Addhaar_No", Order = 14, TypeName = "text")]
        public string? extra_Addhaar_No { get; set; }

        [Column("extra_Pan_Card_No", Order = 15, TypeName = "text")]
        public string? extra_Pan_Card_No { get; set; }

        [Column("extra_DL_No", Order = 16, TypeName = "text")]
        public string? extra_DL_No { get; set; }

        [Column("extra_Case_No", Order = 17, TypeName = "text")]
        public string? extra_Case_No { get; set; }

        [Column("extra_RC_Given_Date", Order = 18, TypeName = "date")]
        public DateTime? extra_RC_Given_Date { get; set; }

        [Column("extra_Date", Order = 19, TypeName = "date")]
        public DateTime? extra_Date { get; set; }

        [Column("extra_Date_Taken_By", Order = 20, TypeName = "date")]
        public DateTime? extra_Date_Taken_By { get; set; }

        [ForeignKey("CaseMaster"), Column("Case_Master_id", Order = 21, TypeName = "bigint")]
        public long? Case_Master_id { get; set; }
        public virtual CaseMaster? CaseMaster { get; set; }
    }
}
