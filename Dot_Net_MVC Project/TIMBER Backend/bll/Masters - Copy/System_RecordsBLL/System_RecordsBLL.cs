using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class System_RecordsBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public System_RecordsBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public System_Records_ModelResponse InsertSystem_Records(System_Records_ModelRequest add)
        {   
            System_Records admit = new System_Records()
            {
                home_state_code = add.home_state_code,
                default_tax_name = add.default_tax_name,
                default_tax_per = add.default_tax_per,
                default_unit = add.default_unit,
                default_hsn_code = add.default_hsn_code,
                default_company_no = add.default_company_no,
                company_name = add.company_name,
                company_address = add.company_address,
                company_address_1 = add.company_address_1,
                company_phone = add.company_phone,
                sale_retrun_code = add.sale_retrun_code,
                sale_return_name_default = add.sale_return_name_default,
                sale_code = add.sale_code,
                sale_name_default = add.sale_name_default,
                bank_code = add.bank_code,
                bank_name_default = add.bank_name_default,
                cash_name_default = add.cash_name_default,
                cash_code = add.cash_code,
                year_from = add.year_from,
                year_to = add.year_to,
                display_height = add.display_height,
                saledatabaselock = add.saledatabaselock,
                database_1_path = add.database_1_path,
                database_2_path = add.database_2_path,
                auto_raw_yes_no = add.auto_raw_yes_no,
                weekly_off_day = add.weekly_off_day,
                //other2 = add.other2,
                //other3 = add.other3,
                //other4 = add.other4,
                //other5 = add.other5,
                //other6 = add.other6,
                //other7 = add.other7,
                //other8 = add.other8,
                //other9 = add.other9,
                //other10 = add.other10,
                //other11 = add.other11,
                //other12 = add.other12,
                //other13 = add.other13,
                //other14 = add.other14,
                //other15 = add.other15,
                //other16 = add.other16,
                //other17 = add.other17,
                //other18 = add.other18,
                //other19 = add.other19,
                //other20 = add.other20,
                sale_format = add.sale_format,
                home_state = add.home_state,
                email_sender = add.email_sender,
                email_receiver = add.email_receiver,
                ch_bill_header_name = add.ch_bill_header_name,
                ss_bill_header_name = add.ss_bill_header_name,
                sr_bill_header_name = add.sr_bill_header_name,
                pp_bill_header_name = add.pp_bill_header_name,
                pr_bill_header_name = add.pr_bill_header_name,
                po_bill_header_name = add.po_bill_header_name,
                so_bill_header_name = add.so_bill_header_name,
                rc_bill_header_name = add.rc_bill_header_name,
                qu_bill_header_name = add.qu_bill_header_name,
                rounded_off = add.rounded_off,
                c_rta_id = add.c_rta_id,
                c_operator_id = add.c_operator_id,
                p_register_comp_add = add.p_register_comp_add,
                data_validation_check_yn = add.data_validation_check_yn,


            };
            DB.System_Records.Add(admit);
            DB.SaveChanges();
            System_Records_ModelResponse data = new System_Records_ModelResponse()
            {
                status = true,
                Message = "Inserted successfully"
            };
            return data;
        }

        public System_Records_ModelResponse UpdateSystem_Records(int ID, System_Records_ModelRequest add)
        {
            try
            {
                var result = DB.System_Records.FirstOrDefault(s => s.id == ID);
                if (result != null)
                {
                    result.home_state_code = add.home_state_code;
                    result.default_tax_name = add.default_tax_name;
                    result.default_tax_per = add.default_tax_per;
                    result.default_unit = add.default_unit;
                    result.default_hsn_code = add.default_hsn_code;
                    result.default_company_no = add.default_company_no;
                    result.company_name = add.company_name;
                    result.company_address = add.company_address;
                    result.company_address_1 = add.company_address_1;
                    result.company_phone = add.company_phone;
                    result.sale_retrun_code = add.sale_retrun_code;
                    result.sale_return_name_default = add.sale_return_name_default;
                    result.sale_code = add.sale_code;
                    result.sale_name_default = add.sale_name_default;
                    result.bank_code = add.bank_code;
                    result.bank_name_default = add.bank_name_default;
                    result.cash_name_default = add.cash_name_default;
                    result.cash_code = add.cash_code;
                    result.year_from = add.year_from;
                    result.year_to = add.year_to;
                    result.display_height = add.display_height;
                    result.saledatabaselock = add.saledatabaselock;
                    result.database_1_path = add.database_1_path;
                    result.database_2_path = add.database_2_path;
                    result.auto_raw_yes_no = add.auto_raw_yes_no;
                    result.weekly_off_day = add.weekly_off_day;
                    //result.other2 = add.other2;
                    //result.other3 = add.other3;
                    //result.other4 = add.other4;
                    //result.other5 = add.other5;
                    //result.other6 = add.other6;
                    //result.other7 = add.other7;
                    //result.other8 = add.other8;
                    //result.other9 = add.other9;
                    //result.other10 = add.other10;
                    //result.other11 = add.other11;
                    //result.other12 = add.other12;
                    //result.other13 = add.other13;
                    //result.other14 = add.other14;
                    //result.other15 = add.other15;
                    //result.other16 = add.other16;
                    //result.other17 = add.other17;
                    //result.other18 = add.other18;
                    //result.other19 = add.other19;
                    //result.other20 = add.other20;
                    result.sale_format = add.sale_format;
                    result.home_state = add.home_state;
                    result.email_sender = add.email_sender;
                    result.email_receiver = add.email_receiver;
                    result.ch_bill_header_name = add.ch_bill_header_name;
                    result.ss_bill_header_name = add.ss_bill_header_name;
                    result.sr_bill_header_name = add.sr_bill_header_name;
                    result.pp_bill_header_name = add.pp_bill_header_name;
                    result.pr_bill_header_name = add.pr_bill_header_name;
                    result.po_bill_header_name = add.po_bill_header_name;
                    result.so_bill_header_name = add.so_bill_header_name;
                    result.rc_bill_header_name = add.rc_bill_header_name;
                    result.qu_bill_header_name = add.qu_bill_header_name;
                    result.rounded_off = add.rounded_off;
                    result.c_rta_id = add.c_rta_id;
                    result.c_operator_id = add.c_operator_id;
                    result.p_register_comp_add = add.p_register_comp_add;
                    result.data_validation_check_yn = add.data_validation_check_yn;


                    DB.SaveChanges();

                    return new System_Records_ModelResponse
                    {
                        status = true,
                        Message = "Updated successfully "
                    };
                }

                return new System_Records_ModelResponse
                {
                    status = false,
                    Message = "ID does Not exist"
                };
            }
            catch (Exception ex)
            {
                // Log the exception For debugging
                Console.WriteLine(ex.Message);

                return new System_Records_ModelResponse
                {
                    status = false,
                    Message = "An Error occurred While updating System_Records"
                };
            }
        }


        public System_Records_ModelResponse GetSystem_Records(string? search)
        {
            IQueryable<System_Records> query = DB.System_Records.AsQueryable();

            // Apply search filters if search string is provided
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x =>
                    x.home_state_code.ToString().Contains(search) ||
                    x.default_tax_name.ToString().Contains(search) ||
                    x.default_tax_per.ToString().Contains(search) ||
                    x.default_unit.ToString().Contains(search) ||
                    x.default_hsn_code.ToString().Contains(search) ||
                    x.default_company_no.ToString().Contains(search) ||
                    x.company_name.ToString().Contains(search) ||
                    x.company_address.ToString().Contains(search) ||
                    x.company_address_1.ToString().Contains(search) ||
                    x.company_phone.ToString().Contains(search) ||
                    x.sale_retrun_code.ToString().Contains(search) ||
                    x.sale_return_name_default.ToString().Contains(search) ||
                    x.sale_code.ToString().Contains(search) ||
                    x.sale_name_default.ToString().Contains(search) ||
                    x.bank_code.ToString().Contains(search) ||
                    x.bank_name_default.ToString().Contains(search) ||
                    x.cash_name_default.ToString().Contains(search) ||
                    x.cash_code.ToString().Contains(search) ||
                    x.year_from.ToString().Contains(search) ||
                    x.year_to.ToString().Contains(search) ||
                    x.display_height.ToString().Contains(search) ||
                    x.saledatabaselock.ToString().Contains(search) ||
                    x.database_1_path.ToString().Contains(search) ||
                    x.database_2_path.ToString().Contains(search) ||
                    x.auto_raw_yes_no.ToString().Contains(search) ||
                    x.weekly_off_day.ToString().Contains(search) ||
                    //x.other2.ToString().Contains(search) ||
                    //x.other3.ToString().Contains(search) ||
                    //x.other4.ToString().Contains(search) ||
                    //x.other5.ToString().Contains(search) ||
                    //x.other6.ToString().Contains(search) ||
                    //x.other7.ToString().Contains(search) ||
                    //x.other8.ToString().Contains(search) ||
                    //x.other9.ToString().Contains(search) ||
                    //x.other10.ToString().Contains(search) ||
                    //x.other11.ToString().Contains(search) ||
                    //x.other12.ToString().Contains(search) ||
                    //x.other13.ToString().Contains(search) ||
                    //x.other14.ToString().Contains(search) ||
                    //x.other15.ToString().Contains(search) ||
                    //x.other16.ToString().Contains(search) ||
                    //x.other17.ToString().Contains(search) ||
                    //x.other18.ToString().Contains(search) ||
                    //x.other19.ToString().Contains(search) ||
                    //x.other20.ToString().Contains(search) ||
                    x.sale_format.ToString().Contains(search) ||
                    x.home_state.ToString().Contains(search) ||
                    x.email_sender.ToString().Contains(search) ||
                    x.email_receiver.ToString().Contains(search) ||
                    x.ch_bill_header_name.ToString().Contains(search) ||
                    x.ss_bill_header_name.ToString().Contains(search) ||
                    x.sr_bill_header_name.ToString().Contains(search) ||
                    x.pp_bill_header_name.ToString().Contains(search) ||
                    x.pr_bill_header_name.ToString().Contains(search) ||
                    x.po_bill_header_name.ToString().Contains(search) ||
                    x.so_bill_header_name.ToString().Contains(search) ||
                    x.rc_bill_header_name.ToString().Contains(search) ||
                    x.qu_bill_header_name.ToString().Contains(search) ||
                    x.rounded_off.ToString().Contains(search) ||
                    x.c_rta_id.ToString().Contains(search) ||
                    x.c_operator_id.ToString().Contains(search) ||
                    x.p_register_comp_add.ToString().Contains(search) ||
                    x.data_validation_check_yn.ToString().Contains(search) 
                );
            }

            // Order the results by Id in descending order
            query = query.OrderByDescending(admission => admission.id);

            // Take only the top 10 results
            query = query.Take(10);
            // Execute the query and convert the results to a list
            List<System_Records> LocalDataList = query.ToList();

            System_Records_ModelResponse data = new System_Records_ModelResponse()
            {
                status = true,
                Message = "Data Fetched Successfully ",
                Data = LocalDataList
            };
            return data;
        }


        public System_Records_ModelResponse GetSystem_RecordsById()
        {
            long MaxId = (long)DB.System_Records.Max(u => u.id);
            System_Records lastCompany = DB.System_Records
                .Where(e => e.id == MaxId).SingleOrDefault();

            System_Records_ModelResponse data = new System_Records_ModelResponse()
            {
                status = true,
                Message = "Data Fetched Successfully ",
                System_RecordsDataById = lastCompany
            };
            return data;
        }


        public System_Records_ModelResponse DeleteSystem_Records(int ID)
        {
            System_Records del = DB.System_Records.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("Record Not Found");
            }

            DB.System_Records.Remove(del);
            DB.SaveChanges();
            System_Records_ModelResponse data = new System_Records_ModelResponse()
            {
                status = true,
                Message = "Deleted successfully"
            };
            return data;
        }
    }
}