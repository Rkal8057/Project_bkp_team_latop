using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class ISR_1
    {
        [Key]
        [Column("Id", Order = 1, TypeName = "bigint")]
        public long Id { get; set; }

        [Column("CompanyName", Order = 2, TypeName = "text")]
        public string CompanyName { get; set; }

        [Column("PanCheckbox", Order = 3, TypeName = "bit")]
        public bool CheckboxPan { get; set; }

        [Column("BankDetailCheckbox", Order = 4, TypeName = "bit")]
        public bool CheckboxBankDetail { get; set; }

        [Column("SignatureCheckbox", Order = 5, TypeName = "bit")]
        public bool CheckboxSignature { get; set; }

        [Column("MobileNumberCheckbox", Order = 6, TypeName = "bit")]
        public bool CheckboxMobileNumber { get; set; }

        [Column("EmailIdCheckbox", Order = 7, TypeName = "bit")]
        public bool CheckboxEmailId { get; set; }

        [Column("AddressCheckbox", Order = 8, TypeName = "bit")]
        public bool CheckboxAddress { get; set; }

        [Column("FirstHolder", Order = 9, TypeName = "text")]
        public string FirstHolder { get; set; }

        [Column("SecondHolder", Order = 10, TypeName = "text")]
        public string SecondHolder { get; set; }

        [Column("ThirdHolder", Order = 11, TypeName = "text")]
        public string ThirdHolder { get; set; }

        [Column("Securities", Order = 12, TypeName = "text")]
        public string Securities { get; set; }

        [Column("FaceValue", Order = 13, TypeName = "text")]
        public string FaceValue { get; set; }

        [Column("DistinctiveNumbers", Order = 14, TypeName = "text")]
        public string DistinctiveNumbers { get; set; }

        [Column("Pan_LinkedToAadhaar", Order = 15, TypeName = "text")]
        public string Pan_LinkedToAadhaar { get; set; }

        [Column("FirstHolderName", Order = 16, TypeName = "text")]
        public string FirstHolderName { get; set; }

        [Column("SecondHolderName", Order = 17, TypeName = "text")]
        public string SecondHolderName { get; set; }

        [Column("ThirdHolderName", Order = 18, TypeName = "text")]
        public string ThirdHolderName { get; set; }

        [Column("DPIDClientID_CDSLClientID", Order = 19, TypeName = "text")]
        public string DPIDClientID_CDSLClientID { get; set; }

        [Column("ProofAddress_Aadhaar", Order = 20, TypeName = "bit")]
        public bool ProofAddress_Aadhaar { get; set; }

        [Column("ProofAddress_ResidenceOrDrivingLicense", Order = 21, TypeName = "bit")]
        public bool ProofAddress_ResidenceOrDrivingLicense { get; set; }

        [Column("ProofAddress_FlatMaintenance", Order = 22, TypeName = "bit")]
        public bool ProofAddress_FlatMaintenance { get; set; }

        [Column("ProofAddress_UtilityBills", Order = 23, TypeName = "bit")]
        public bool ProofAddress_UtilityBills { get; set; }

        [Column("ProofAddress_IdentityCard", Order = 24, TypeName = "bit")]
        public bool ProofAddress_IdentityCard { get; set; }

        [Column("ProofAddress_FIIOrSubAccount", Order = 25, TypeName = "bit")]
        public bool ProofAddress_FIIOrSubAccount { get; set; }

        [Column("ProofAddress_SpouseAddressProof", Order = 26, TypeName = "bit")]
        public bool ProofAddress_SpouseAddressProof { get; set; }

        [Column("ProofAddress_ClientMasterList", Order = 27, TypeName = "bit")]
        public bool ProofAddress_ClientMasterList { get; set; }

        [Column("IFSCCode", Order = 28, TypeName = "text")]
        public string IFSCCode { get; set; }

        [Column("AccountNumber", Order = 29, TypeName = "text")]
        public string AccountNumber { get; set; }

        [Column("BankName", Order = 30, TypeName = "text")]
        public string BankName { get; set; }

        [Column("BranchName", Order = 31, TypeName = "text")]
        public string BranchName { get; set; }

        [Column("EmailAddress", Order = 32, TypeName = "text")]
        public string EmailAddress { get; set; }

        [Column("MobileNumber", Order = 33, TypeName = "text")]
        public string MobileNumber { get; set; }

        [Column("currentDate", Order = 34, TypeName = "date")]
        public DateTime currentDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<Folio_Master> Folio_Master { get; set; }
        public virtual ICollection<Holders_Master> Holders_Master { get; set; }


    }
}
