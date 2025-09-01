using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class Remark_Upload_Detail
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("upload_document_path", Order = 1, TypeName = "text")]
        public string upload_document_path { get; set; }

        [Column("remarks", Order = 2, TypeName = "text")]
        public string remarks { get; set; }

        [Column("attended_by", Order = 3, TypeName = "text")]
        public string attended_by { get; set; }

        [ ForeignKey("ItemMaster") , Column("item_master_id", Order = 4, TypeName = "bigint")]
        public long? item_master_id { get; set; }

        [ForeignKey("PartyMaster"), Column("party_master_id", Order = 5, TypeName = "bigint")]
        public long? party_master_id { get; set; }

        [Column("flag_master", Order = 6, TypeName = "text")]
        public string flag_master { get; set; }

        [Column("delete_at", Order = 7, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;


        [Column("created_by", Order = 8, TypeName = "datetime")]
        public DateTime? created_by { get; set; }

        [Column("updated_by", Order = 9, TypeName = "datetime")]
        public DateTime? updated_by { get; set; }

        public virtual ItemMaster ?  ItemMaster { get; set; }
        public virtual PartyMaster? PartyMaster { get; set; }

    }
}
