using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Login.Tables
{
    public class UploadDocument
    {
        [Key]
        [Column("id", Order = 0, TypeName = "bigint")]
        public long Id { get; set; }

        [Column("upload_document_name", Order = 1, TypeName = "text")]
        public string? upload_document_name { get; set; }

        [Column("upload_document_path", Order = 2, TypeName = "text")]
        public string? upload_document_path { get; set; }

        [ForeignKey("CaseMaster"), Column("Case_Master_id", Order = 5, TypeName = "bigint")]
        public long? Case_Master_id { get; set; }
        public virtual CaseMaster? CaseMaster { get; set; }
    }
}
