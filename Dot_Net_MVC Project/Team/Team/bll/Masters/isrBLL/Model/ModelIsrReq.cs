using DB.Login.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ModelIsr1Req
    {
        public string ?CompanyName { get; set; }
        public bool CheckboxPan { get; set; }
        public bool CheckboxBankDetail { get; set; }
        public bool CheckboxSignature { get; set; }
        public bool CheckboxMobileNumber { get; set; }
        public bool CheckboxEmailId { get; set; }
        public bool CheckboxAddress { get; set; }
        public string ?FirstHolder { get; set; }
        public string ?SecondHolder { get; set; }
        public string ?ThirdHolder { get; set; }
        public string ?Securities { get; set; }
        public string ?FaceValue { get; set; }
        public string ?DistinctiveNumbers { get; set; }
        public string ?FirstHolderName { get; set; }
        public string ?SecondHolderName { get; set; }
        public string ?ThirdHolderName { get; set; }
        public string ?DPIDClientID_CDSLClientID { get; set; }
        public string ?IFSCCode { get; set; }
        public string ?AccountNumber { get; set; }
        public string ?BankName { get; set; }
        public string ?BranchName { get; set; }
        public string ?EMailAddress { get; set; }
        public string ?MobileNumber { get; set; }
        public DateTime currentDate { get; set; }

        //public Folio_Master[] foli { get; set; }
        //[JsonIgnore]
        public ICollection<Folio_Master> ? folio_master { get; set; }
        public ICollection<Holders_Master>? holder_master { get; set; }
    }
}
