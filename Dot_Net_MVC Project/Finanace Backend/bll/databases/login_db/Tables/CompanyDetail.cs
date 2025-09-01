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
    public class CompanyDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("company_name", Order = 2, TypeName = "text")]
        public string? company_name { get; set; }

        [Column("company_address", Order = 3, TypeName = "text")]
        public string? company_address { get; set; }

        [Column("company_city", Order = 4, TypeName = "text")]
        public string? company_city { get; set; }

        [Column("company_pincode", Order = 5, TypeName = "text")]
        public string? company_pincode { get; set; }

        [Column("company_country", Order = 6, TypeName = "text")]
        public string? company_country { get; set; }

        [Column("company_email", Order = 7, TypeName = "text")]
        public string? company_email { get; set; }

        [Column("company_phone", Order = 8, TypeName = "text")]
        public string? company_phone { get; set; }

        public ICollection<HelperDetail>? HelperDetail { get; set; }   

    }
}
