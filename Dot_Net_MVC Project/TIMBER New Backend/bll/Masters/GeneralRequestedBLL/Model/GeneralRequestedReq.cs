using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class GeneralRequestedReq
    {
        // public long? user_id { get; set; }
        public long? service_id { get; set; }
        public long? subservice_id { get; set; }
        public string? service_name { get; set; }
        public string? subservice_name { get; set; }
        public long? gen_approx_amount { get; set; }
        public long? gen_approx_days { get; set; }
        public ICollection<GeneralRequestCheckListDetail>? GeneralRequestCheckListDetail { get; set; }
        public userDetail? userDetail { get; set; }
        public ICollection<GeneralRequestRemark>? GeneralRequestRemark { get; set; }


        public string? general_req_disc_type { get; set; }
        public string? general_req_disc_per { get; set; }
        public string? general_req_disc_amt { get; set; }
        public string? general_req_after_disc_amt { get; set; }
        public string? general_req_receive_amt { get; set; }
        public string? general_req_pending_amt { get; set; }
        public string? general_req_final_amt { get; set; }


        public string? general_req_commission_amt { get; set; }
        public string? general_req_commission_type { get; set; }
        public string? general_req_commission_percentage { get; set; }
        public string? general_req_key_amt { get; set; }
        public string? general_req_key_remark { get; set; }


        public string? sender_name { get; set; }
        public string? sender_mobile { get; set; }
        public string? receiver_name { get; set; }
        public string? receiver_mobile { get; set; }

        public string? general_req_document_img_option { get; set; }
        public string? general_req_payment_mode { get; set; }
        public string? general_req_payment_status { get; set; }

        public string? general_req_transaction_id { get; set; }
        public string? general_req_transaction_image { get; set; }

        public string? status { get; set; }

    }
    public class userDetail
    {
        public int? id { get; set; }
        public string? user_name { get; set; }
        public string? mobile_no { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
        public string? group { get; set; }
        public string? user_agr_code { get; set; }

        public long? user_profile_id { get; set; }
        public long? user_id { get; set; }


        public string? general_req_disc_type { get; set; }
        public string? general_req_disc_per { get; set; }
        public string? general_req_disc_amt { get; set; }
        public string? general_req_after_disc_amt { get; set; }
        public string? general_req_receive_amt { get; set; }
        public string? general_req_pending_amt { get; set; }
    }


    public class GeneralRequestCommunicationDetailReq 
    {
        public long? user_id { get; set; }
        public long? general_request_id { get; set; }
        public string? general_request_remark { get; set; }

    }

}
