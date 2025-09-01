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
    public class Sh_14
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("company_name", Order = 2, TypeName = "text")]
        public string? company_name { get; set; }

        [Column("company_address", Order = 3, TypeName = "text")]
        public string? company_address { get; set; }

        [Column("nominee_type_cancel", Order = 4, TypeName = "text")]
        public string? nominee_type_cancel { get; set; }

        [Column("nominate_type_required", Order = 5, TypeName = "text")]
        public string? nominate_type_required { get; set; }

        [Column("particulars_nominee_name", Order = 6, TypeName = "text")]
        public string? particulars_nominee_name { get; set; }

        [Column("particulars_nominee_dob", Order = 7, TypeName = "date")]
        public DateTime? particulars_nominee_dob { get; set; }

        [Column("particulars_nominee_father_mother_spouse_name", Order = 8, TypeName = "text")]
        public string? particulars_nominee_father_mother_spouse_name { get; set; }

        [Column("particulars_nominee_occupation", Order = 9, TypeName = "text")]
        public string? particulars_nominee_occupation { get; set; }

        [Column("particulars_nominee_nationality", Order = 10, TypeName = "text")]
        public string? particulars_nominee_nationality { get; set; }

        [Column("particulars_nominee_address_1", Order = 11, TypeName = "text")]
        public string? particulars_nominee_address_1 { get; set; }

        [Column("particulars_nominee_address_2", Order = 12, TypeName = "text")]
        public string? particulars_nominee_address_2 { get; set; }

        [Column("particulars_nominee_address_3", Order = 13, TypeName = "text")]
        public string? particulars_nominee_address_3 { get; set; }

        [Column("particulars_nominee_city", Order = 14, TypeName = "text")]
        public string? particulars_nominee_city { get; set; }

        [Column("particulars_nominee_pincode", Order = 15, TypeName = "bigint")]
        public long? particulars_nominee_pincode { get; set; }

        [Column("particulars_nominee_email", Order = 16, TypeName = "text")]
        public string? particulars_nominee_email { get; set; }

        [Column("particulars_nominee_security_holder", Order = 17, TypeName = "text")]
        public string? particulars_nominee_security_holder { get; set; }

        [Column("minor_nominee_dob", Order = 18, TypeName = "date")]
        public DateTime? minor_nominee_dob { get; set; }

        [Column("minor_nominee_date_of_attaining_majority", Order = 19, TypeName = "date")]
        public DateTime? minor_nominee_date_of_attaining_majority { get; set; }

        [Column("minor_nominee_guardian_name", Order = 20, TypeName = "text")]
        public string? minor_nominee_guardian_name { get; set; }

        [Column("minor_nominee_address_line_1", Order = 21, TypeName = "text")]
        public string? minor_nominee_address_line_1 { get; set; }

        [Column("minor_nominee_address_line_2", Order = 22, TypeName = "text")]
        public string? minor_nominee_address_line_2 { get; set; }

        [Column("minor_nominee_address_line_3", Order = 23, TypeName = "text")]
        public string? minor_nominee_address_line_3 { get; set; }

        [Column("minor_nominee_city", Order = 24, TypeName = "text")]
        public string? minor_nominee_city { get; set; }

        [Column("minor_nominee_pincode", Order = 25, TypeName = "bigint")]
        public long? minor_nominee_pincode { get; set; }

        [Column("holder1", Order = 26, TypeName = "text")]
        public string? holder1 { get; set; }

        [Column("holder2", Order = 27, TypeName = "text")]
        public string? holder2 { get; set; }

        [Column("holder3", Order = 28, TypeName = "text")]
        public string? holder3 { get; set; }

        [Column("minor_nominee_status", Order = 29, TypeName = "bit")]
        public bool? minor_nominee_status { get; set; }

        [JsonIgnore]
        public virtual ICollection<Sh_14_securities>? Sh_14_securities { get; set; }
    }
}
