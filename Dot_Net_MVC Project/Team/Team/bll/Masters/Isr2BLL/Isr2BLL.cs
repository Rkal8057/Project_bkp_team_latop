using DB.Login;
using System;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class Isr2BLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public Isr2BLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ModalIsr2Resp InsertIsr2(ModalIsr2Req isr2Req)
        {
            Isr_2 SampData = new Isr_2()
            {
                bank_name = isr2Req.bank_name,
                bank_branch_name = isr2Req.bank_branch_name,
                branch_address1 = isr2Req.branch_address1,
                branch_address2 = isr2Req.branch_address2,
                branch_address3 = isr2Req.branch_address3,
                branch_city = isr2Req.branch_city,
                branch_pin_code = isr2Req.branch_pin_code,
                branch_phone = isr2Req.branch_phone,
                branch_email = isr2Req.branch_email,
                branch_account_number = isr2Req.branch_account_number,
                account_opening_date = isr2Req.account_opening_date,
                account_first_holder = isr2Req.account_first_holder,
                account_joint1_holder = isr2Req.account_joint1_holder,
                account_joint2_holder = isr2Req.account_joint2_holder,
                account_holder1_photo = isr2Req.account_holder1_photo?.FileName, // Use null conditional operator
                account_holder2_photo = isr2Req.account_holder2_photo?.FileName,
                account_holder3_photo = isr2Req.account_holder3_photo?.FileName,
                investor_address1 = isr2Req.investor_address1,
                investor_address2 = isr2Req.investor_address2,
                investor_address3 = isr2Req.investor_address3,
                investor_city = isr2Req.investor_city,
                investor_pin_code = isr2Req.investor_pin_code,
                investor_number = isr2Req.investor_number,
                investor_email = isr2Req.investor_email,
                investor_signature1 = isr2Req.investor_signature1?.FileName, // Use null conditional operator
                investor_signature2 = isr2Req.investor_signature2?.FileName,
                investor_signature3 = isr2Req.investor_signature3?.FileName,
                bank_manager_name = isr2Req.bank_manager_name,
                employee_code = isr2Req.employee_code,
                email_address = isr2Req.email_address,
                place = isr2Req.place,
                date = isr2Req.date
            };


            DB.Isr_2.Add(SampData);
            DB.SaveChanges();

            ModalIsr2Resp data = new ModalIsr2Resp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }


    }
}