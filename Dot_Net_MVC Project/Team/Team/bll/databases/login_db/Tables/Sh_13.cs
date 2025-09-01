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
    public class Sh_13
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("company_name", Order = 2, TypeName = "text")]
        public string? company_name { get; set; }

        [Column("company_address", Order = 3, TypeName = "text")]
        public string? company_address { get; set; }

        [Column("descriptions1", Order = 4, TypeName = "text")]
        public string? descriptions1 { get; set; }

        [Column("descriptions2", Order = 5, TypeName = "text")]
        public string? descriptions2 { get; set; }

        [Column("descriptions3", Order = 6, TypeName = "text")]
        public string? descriptions3 { get; set; }

        [Column("particulars_nominee_name", Order = 7, TypeName = "text")]
        public string? particulars_nominee_name { get; set; }

        [Column("particulars_nominee_dob", Order = 8, TypeName = "date")]
        public DateTime? particulars_nominee_dob { get; set; }

        [Column("particulars_nominee_father_mother_spouse_name", Order = 9, TypeName = "text")]
        public string? particulars_nominee_father_mother_spouse_name { get; set; }

        [Column("particulars_nominee_occupation", Order = 10, TypeName = "text")]
        public string? particulars_nominee_occupation { get; set; }

        [Column("particulars_nominee_nationality", Order = 11, TypeName = "text")]
        public string? particulars_nominee_nationality { get; set; }

        [Column("particulars_nominee_address_1", Order = 12, TypeName = "text")]
        public string? particulars_nominee_address_1 { get; set; }

        [Column("particulars_nominee_address_2", Order = 13, TypeName = "text")]
        public string? particulars_nominee_address_2 { get; set; }

        [Column("particulars_nominee_address_3", Order = 14, TypeName = "text")]
        public string? particulars_nominee_address_3 { get; set; }

        [Column("particulars_nominee_city", Order = 15, TypeName = "text")]
        public string? particulars_nominee_city { get; set; }

        [Column("particulars_nominee_pincode", Order = 16, TypeName = "bigint")]
        public long? particulars_nominee_pincode { get; set; }

        [Column("particulars_nominee_email", Order = 17, TypeName = "text")]
        public string? particulars_nominee_email { get; set; }

        [Column("particulars_nominee_security_holder", Order = 18, TypeName = "text")]
        public string? particulars_nominee_security_holder { get; set; }

        [Column("minor_nominee_dob", Order = 19, TypeName = "date")]
        public DateTime? minor_nominee_dob { get; set; }

        [Column("minor_nominee_date_of_attaining_majority", Order = 20, TypeName = "date")]
        public DateTime? minor_nominee_date_of_attaining_majority { get; set; }

        [Column("minor_nominee_guardian_name", Order = 21, TypeName = "text")]
        public string? minor_nominee_guardian_name { get; set; }

        [Column("minor_nominee_address_line_1", Order = 22, TypeName = "text")]
        public string? minor_nominee_address_line_1 { get; set; }

        [Column("minor_nominee_address_line_2", Order = 23, TypeName = "text")]
        public string? minor_nominee_address_line_2 { get; set; }

        [Column("minor_nominee_address_line_3", Order = 24, TypeName = "text")]
        public string? minor_nominee_address_line_3 { get; set; }

        [Column("minor_nominee_city", Order = 25, TypeName = "text")]
        public string? minor_nominee_city { get; set; }

        [Column("minor_nominee_pincode", Order = 26, TypeName = "bigint")]
        public long? minor_nominee_pincode { get; set; }


        [Column("minor_nominee_status", Order = 27, TypeName = "bit")]
        public bool? minor_nominee_status { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Sh_13_securities>? Sh_13_securities { get; set; }
    }
}
