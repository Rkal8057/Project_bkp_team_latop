using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DB.Login.Tables
{
    public class GeneralRequestedDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("user_id", Order = 2, TypeName = "bigint")]
        public long? user_id { get; set; }

        [Column("service_id", Order = 3, TypeName = "bigint")]
        public long? service_id { get; set; }

        [Column("service_name", Order = 4, TypeName = "text")]
        public string? service_name { get; set; }

        [Column("subservice_id", Order = 5, TypeName = "bigint")]
        public long? subservice_id { get; set; }

        [Column("subservice_name", Order = 6, TypeName = "text")]
        public string? subservice_name { get; set; }

        [Column("gen_approx_amount", Order = 7, TypeName = "bigint")]
        public long? gen_approx_amount { get; set; } 

        [Column("gen_approx_days", Order = 8, TypeName = "bigint")]
        public long? gen_approx_days { get; set; } 

        [Column("status", Order = 9, TypeName = "text")]
        public string? status { get; set; } = "Pending";


        [Column("general_req_disc_type", Order =10, TypeName = "text")]
        public string? general_req_disc_type { get; set; }

        [Column("general_req_disc_per", Order =11, TypeName = "text")]
        public string? general_req_disc_per { get; set; }

        [Column("general_req_disc_amt", Order =12, TypeName = "text")]
        public string? general_req_disc_amt { get; set; }

        [Column("general_req_after_disc_amt", Order =13, TypeName = "text")]
        public string? general_req_after_disc_amt { get; set; }

        [Column("general_req_receive_amt", Order =14, TypeName = "text")]
        public string? general_req_receive_amt { get; set; }

        [Column("general_req_pending_amt", Order =15, TypeName = "text")]
        public string? general_req_pending_amt { get; set; }

        [Column("general_req_final_amt", Order = 16, TypeName = "text")]
        public string? general_req_final_amt { get; set; }



        [Column("general_req_commission_amt", Order = 17, TypeName = "text")]
        public string? general_req_commission_amt { get; set; }

        [Column("general_req_commission_type", Order = 18, TypeName = "text")]
        public string? general_req_commission_type { get; set; }

        [Column("general_req_commission_percentage", Order = 19, TypeName = "text")]
        public string? general_req_commission_percentage { get; set; }

        [Column("general_req_key_amt", Order = 20, TypeName = "text")]
        public string? general_req_key_amt { get; set; }

        [Column("general_req_key_remark", Order = 21, TypeName = "text")]
        public string? general_req_key_remark { get; set; }

        [Column("sender_name", Order = 22, TypeName = "text")]
        public string? sender_name { get; set; }

        [Column("sender_mobile", Order = 23, TypeName = "text")]
        public string? sender_mobile { get; set; }

        [Column("receiver_name", Order = 24, TypeName = "text")]
        public string? receiver_name { get; set; }

        [Column("receiver_mobile", Order = 25, TypeName = "text")]
        public string? receiver_mobile { get; set; }

        [Column("general_req_document_img_option", Order = 26, TypeName = "text")]
        public string? general_req_document_img_option { get; set; }

        [Column("general_req_payment_mode", Order = 27, TypeName = "text")]
        public string? general_req_payment_mode { get; set; }

        [Column("general_req_payment_status", Order = 28, TypeName = "text")]
        public string? general_req_payment_status { get; set; }

        [Column("created_at", Order = 29, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 30, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;

        [Column("party_id", Order = 31, TypeName = "bigint")]
        public long? party_id { get; set; }

        [Column("general_req_transaction_id", Order = 32, TypeName = "text")]
        public string? general_req_transaction_id { get; set; }

        [Column("general_req_transaction_image", Order = 33, TypeName = "text")]
        public string? general_req_transaction_image { get; set; }

        [JsonIgnore]
        public ICollection<GeneralRequestCheckListDetail>? GeneralRequestCheckListDetail { get; set; }

        public ICollection<GeneralRequestCommunicationDetail>? GeneralRequestCommunicationDetail { get; set; }

        public ICollection<GeneralRequestRemark>? GeneralRequestRemark { get; set; }

        public PartyMaster Party { get; set; }


        

    }
}
