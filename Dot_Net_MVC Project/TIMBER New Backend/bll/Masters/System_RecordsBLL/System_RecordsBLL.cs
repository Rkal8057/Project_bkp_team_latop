using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Drawing;

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

        public System_Records_ModelResponse InsertSystem_Records(System_Records_ModelRequest add
                //  System_Records_Issue_Purchase_Request purchase , System_Records_Issue_Sale_Request sale
            )
        {
            // issue
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
                bill_type_method = add.bill_type_method,
                cart_tcs_value = add.cart_tcs_value,

                batch_no = add.batch_no,
                style = add.style,
                brand = add.brand,
                color = add.color,
                agent = add.agent,
                dealer = add.dealer,
                round_off = add.round_off,


                transporter_cartage_yn = add.transporter_cartage_yn,
                maintain_accounting_yn = add.maintain_accounting_yn,
                challan_master_method = add.challan_master_method,


                // ========================================//
                purchase_rate_yn = add.purchase_rate_yn,
                profit_yn = add.profit_yn,
                discount_amount_yn = add.discount_amount_yn,
                discount_rate_yn = add.discount_rate_yn,
                gst_amount_yn = add.gst_amount_yn,
                total_profit_yn = add.total_profit_yn,
                total_weight_yn = add.total_weight_yn,
                gst_rate_yn = add.gst_rate_yn,
                irflag = add.irflag,

                // ========================================//

                opening_yn = add.opening_yn,
                damage_yn = add.damage_yn,
                missing_yn = add.missing_yn,
                rent_rate_yn = add.rent_rate_yn,
                agr_qty_yn = add.agr_qty_yn,
                pc_rmt_pp_yn = add.pc_rmt_pp_yn,
                otp_req_deletion_yn =  add.otp_req_deletion_yn,

                hsn_code_yn = add.hsn_code_yn,
                packing_type_yn = add.packing_type_yn,
                scheme_type_yn = add.scheme_type_yn,
                remarks_yn = add.remarks_yn,
                sale_rate_yn = add.sale_rate_yn,
                issue_qty_yn = add.issue_qty_yn,
                discount_percentage_yn = add.discount_percentage_yn,
                grand_total_yn = add.grand_total_yn,
                gst_percentage_yn = add.gst_percentage_yn,
                rate_after_gst_yn = add.rate_after_gst_yn,
                total_amount_yn = add.total_amount_yn,
                current_stock_yn = add.current_stock_yn,
                balance_qty_yn = add.balance_qty_yn,
                system_invoice = add.system_invoice,


                company_about = add.company_about,
                company_image = add.company_image,

                company_logo = add.company_logo,
                facebook_link = add.facebook_link,
                twitter_link = add.twitter_link,
                youtube_link = add.youtube_link,
                linkedin_link = add.linkedin_link,
                map_link = add.map_link,
                private_policy = add.private_policy,
                business_card_link  = add.business_card_link,

            };

            DB.System_Records.Add(admit);

            // sale
            System_Records admit1 = new System_Records()
            { 
                purchase_rate_yn = add.System_Records_Issue_Sale_Request.purchase_rate_yn,
                profit_yn = add.System_Records_Issue_Sale_Request.profit_yn,
                discount_amount_yn = add.System_Records_Issue_Sale_Request.discount_amount_yn,
                discount_rate_yn = add.System_Records_Issue_Sale_Request.discount_rate_yn,
                gst_amount_yn = add.System_Records_Issue_Sale_Request.gst_amount_yn,
                total_profit_yn = add.System_Records_Issue_Sale_Request.total_profit_yn,
                total_weight_yn = add.System_Records_Issue_Sale_Request.total_weight_yn,
                gst_rate_yn = add.System_Records_Issue_Sale_Request.gst_rate_yn,
                irflag = add.System_Records_Issue_Sale_Request.irflag,



                challan_master_method = add.System_Records_Issue_Sale_Request.challan_master_method,
                cart_tcs_value = add.System_Records_Issue_Sale_Request.cart_tcs_value,
                batch_no = add.System_Records_Issue_Sale_Request.batch_no,
                style = add.System_Records_Issue_Sale_Request.style,
                brand = add.System_Records_Issue_Sale_Request.brand,
                color = add.System_Records_Issue_Sale_Request.color,
                agent = add.System_Records_Issue_Sale_Request.agent,
                dealer = add.System_Records_Issue_Sale_Request.dealer,
                round_off = add.System_Records_Issue_Sale_Request.round_off,
                transporter_cartage_yn = add.System_Records_Issue_Sale_Request.transporter_cartage_yn,
                maintain_accounting_yn = add.System_Records_Issue_Sale_Request.maintain_accounting_yn,


                hsn_code_yn = add.System_Records_Issue_Sale_Request.hsn_code_yn,
                packing_type_yn = add.System_Records_Issue_Sale_Request.packing_type_yn,
                scheme_type_yn = add.System_Records_Issue_Sale_Request.scheme_type_yn,
                remarks_yn = add.System_Records_Issue_Sale_Request.remarks_yn,
                sale_rate_yn = add.System_Records_Issue_Sale_Request.sale_rate_yn,
                issue_qty_yn = add.System_Records_Issue_Sale_Request.issue_qty_yn,
                discount_percentage_yn = add.System_Records_Issue_Sale_Request.discount_percentage_yn,
                grand_total_yn = add.System_Records_Issue_Sale_Request.grand_total_yn,
                gst_percentage_yn = add.System_Records_Issue_Sale_Request.gst_percentage_yn,
                rate_after_gst_yn = add.System_Records_Issue_Sale_Request.rate_after_gst_yn,
                total_amount_yn = add.System_Records_Issue_Sale_Request.total_amount_yn,
                current_stock_yn = add.System_Records_Issue_Sale_Request.current_stock_yn,
                balance_qty_yn = add.System_Records_Issue_Sale_Request.balance_qty_yn
            };
            DB.System_Records.Add(admit1);

            // purchase
            System_Records admit2 = new System_Records()
            {
                purchase_rate_yn = add.System_Records_Issue_Purchase_Request.purchase_rate_yn,
                profit_yn = add.System_Records_Issue_Purchase_Request.profit_yn,
                discount_amount_yn = add.System_Records_Issue_Purchase_Request.discount_amount_yn,
                discount_rate_yn = add.System_Records_Issue_Purchase_Request.discount_rate_yn,
                gst_amount_yn = add.System_Records_Issue_Purchase_Request.gst_amount_yn,
                total_profit_yn = add.System_Records_Issue_Purchase_Request.total_profit_yn,
                total_weight_yn = add.System_Records_Issue_Purchase_Request.total_weight_yn,
                gst_rate_yn = add.System_Records_Issue_Purchase_Request.gst_rate_yn,
                irflag = add.System_Records_Issue_Purchase_Request.irflag,


                challan_master_method = add.System_Records_Issue_Purchase_Request.challan_master_method,
                cart_tcs_value = add.System_Records_Issue_Purchase_Request.cart_tcs_value,
                batch_no = add.System_Records_Issue_Purchase_Request.batch_no,
                style = add.System_Records_Issue_Purchase_Request.style,
                brand = add.System_Records_Issue_Purchase_Request.brand,
                color = add.System_Records_Issue_Purchase_Request.color,
                agent = add.System_Records_Issue_Purchase_Request.agent,
                dealer = add.System_Records_Issue_Purchase_Request.dealer,
                round_off = add.System_Records_Issue_Purchase_Request.round_off,
                transporter_cartage_yn = add.System_Records_Issue_Purchase_Request.transporter_cartage_yn,
                maintain_accounting_yn = add.System_Records_Issue_Purchase_Request.maintain_accounting_yn,

                hsn_code_yn = add.System_Records_Issue_Purchase_Request.hsn_code_yn,
                packing_type_yn = add.System_Records_Issue_Purchase_Request.packing_type_yn,
                scheme_type_yn = add.System_Records_Issue_Purchase_Request.scheme_type_yn,
                remarks_yn = add.System_Records_Issue_Purchase_Request.remarks_yn,
                sale_rate_yn = add.System_Records_Issue_Purchase_Request.sale_rate_yn,
                issue_qty_yn = add.System_Records_Issue_Purchase_Request.issue_qty_yn,
                discount_percentage_yn = add.System_Records_Issue_Purchase_Request.discount_percentage_yn,
                grand_total_yn = add.System_Records_Issue_Purchase_Request.grand_total_yn,
                gst_percentage_yn = add.System_Records_Issue_Purchase_Request.gst_percentage_yn,
                rate_after_gst_yn = add.System_Records_Issue_Purchase_Request.rate_after_gst_yn,
                total_amount_yn = add.System_Records_Issue_Purchase_Request.total_amount_yn,
                current_stock_yn = add.System_Records_Issue_Purchase_Request.current_stock_yn,
                balance_qty_yn = add.System_Records_Issue_Purchase_Request.balance_qty_yn

            };
            DB.System_Records.Add(admit2);

            // reci
            System_Records admit3 = new System_Records()
            {
                purchase_rate_yn = add.System_Records_Issue_Recipted_Request.purchase_rate_yn,
                profit_yn = add.System_Records_Issue_Recipted_Request.profit_yn,
                discount_amount_yn = add.System_Records_Issue_Recipted_Request.discount_amount_yn,
                discount_rate_yn = add.System_Records_Issue_Recipted_Request.discount_rate_yn,
                gst_amount_yn = add.System_Records_Issue_Recipted_Request.gst_amount_yn,
                total_profit_yn = add.System_Records_Issue_Recipted_Request.total_profit_yn,
                total_weight_yn = add.System_Records_Issue_Recipted_Request.total_weight_yn,
                gst_rate_yn = add.System_Records_Issue_Recipted_Request.gst_rate_yn,
                irflag = add.System_Records_Issue_Recipted_Request.irflag,


                challan_master_method = add.System_Records_Issue_Recipted_Request.challan_master_method,
                cart_tcs_value = add.System_Records_Issue_Recipted_Request.cart_tcs_value,
                batch_no = add.System_Records_Issue_Recipted_Request.batch_no,
                style = add.System_Records_Issue_Recipted_Request.style,
                brand = add.System_Records_Issue_Recipted_Request.brand,
                color = add.System_Records_Issue_Recipted_Request.color,
                agent = add.System_Records_Issue_Recipted_Request.agent,
                dealer = add.System_Records_Issue_Recipted_Request.dealer,
                round_off = add.System_Records_Issue_Recipted_Request.round_off,
                transporter_cartage_yn = add.System_Records_Issue_Recipted_Request.transporter_cartage_yn,
                maintain_accounting_yn = add.System_Records_Issue_Recipted_Request.maintain_accounting_yn,

                hsn_code_yn = add.System_Records_Issue_Recipted_Request.hsn_code_yn,
                packing_type_yn = add.System_Records_Issue_Recipted_Request.packing_type_yn,
                scheme_type_yn = add.System_Records_Issue_Recipted_Request.scheme_type_yn,
                remarks_yn = add.System_Records_Issue_Recipted_Request.remarks_yn,
                sale_rate_yn = add.System_Records_Issue_Recipted_Request.sale_rate_yn,
                recv_qty_yn = add.System_Records_Issue_Recipted_Request.recv_qty_yn,
                discount_percentage_yn = add.System_Records_Issue_Recipted_Request.discount_percentage_yn,
                grand_total_yn = add.System_Records_Issue_Recipted_Request.grand_total_yn,
                gst_percentage_yn = add.System_Records_Issue_Recipted_Request.gst_percentage_yn,
                rate_after_gst_yn = add.System_Records_Issue_Recipted_Request.rate_after_gst_yn,
                total_amount_yn = add.System_Records_Issue_Recipted_Request.total_amount_yn,
                current_stock_yn = add.System_Records_Issue_Recipted_Request.current_stock_yn,
                balance_qty_yn = add.System_Records_Issue_Recipted_Request.balance_qty_yn
            };
            DB.System_Records.Add(admit3);

            // purchase return  
            System_Records admit4 = new System_Records()
            {
                purchase_rate_yn = add.System_Records_Issue_Purchase_Return_Request.purchase_rate_yn,
                profit_yn = add.System_Records_Issue_Purchase_Return_Request.profit_yn,
                discount_amount_yn = add.System_Records_Issue_Purchase_Return_Request.discount_amount_yn,
                discount_rate_yn = add.System_Records_Issue_Purchase_Return_Request.discount_rate_yn,
                gst_amount_yn = add.System_Records_Issue_Purchase_Return_Request.gst_amount_yn,
                total_profit_yn = add.System_Records_Issue_Purchase_Return_Request.total_profit_yn,
                total_weight_yn = add.System_Records_Issue_Purchase_Return_Request.total_weight_yn,
                gst_rate_yn = add.System_Records_Issue_Purchase_Return_Request.gst_rate_yn,
                irflag = add.System_Records_Issue_Purchase_Return_Request.irflag,


                challan_master_method = add.System_Records_Issue_Purchase_Return_Request.challan_master_method,
                cart_tcs_value = add.System_Records_Issue_Purchase_Return_Request.cart_tcs_value,
                batch_no = add.System_Records_Issue_Purchase_Return_Request.batch_no,
                style = add.System_Records_Issue_Purchase_Return_Request.style,
                brand = add.System_Records_Issue_Purchase_Return_Request.brand,
                color = add.System_Records_Issue_Purchase_Return_Request.color,
                agent = add.System_Records_Issue_Purchase_Return_Request.agent,
                dealer = add.System_Records_Issue_Purchase_Return_Request.dealer,
                round_off = add.System_Records_Issue_Purchase_Return_Request.round_off,
                transporter_cartage_yn = add.System_Records_Issue_Purchase_Return_Request.transporter_cartage_yn,
                maintain_accounting_yn = add.System_Records_Issue_Purchase_Return_Request.maintain_accounting_yn,

                hsn_code_yn = add.System_Records_Issue_Purchase_Return_Request.hsn_code_yn,
                packing_type_yn = add.System_Records_Issue_Purchase_Return_Request.packing_type_yn,
                scheme_type_yn = add.System_Records_Issue_Purchase_Return_Request.scheme_type_yn,
                remarks_yn = add.System_Records_Issue_Purchase_Return_Request.remarks_yn,
                sale_rate_yn = add.System_Records_Issue_Purchase_Return_Request.sale_rate_yn,
                issue_qty_yn = add.System_Records_Issue_Purchase_Return_Request.issue_qty_yn,
                discount_percentage_yn = add.System_Records_Issue_Purchase_Return_Request.discount_percentage_yn,
                grand_total_yn = add.System_Records_Issue_Purchase_Return_Request.grand_total_yn,
                gst_percentage_yn = add.System_Records_Issue_Purchase_Return_Request.gst_percentage_yn,
                rate_after_gst_yn = add.System_Records_Issue_Purchase_Return_Request.rate_after_gst_yn,
                total_amount_yn = add.System_Records_Issue_Purchase_Return_Request.total_amount_yn,
                current_stock_yn = add.System_Records_Issue_Purchase_Return_Request.current_stock_yn,
                balance_qty_yn = add.System_Records_Issue_Purchase_Return_Request.balance_qty_yn
            };
            DB.System_Records.Add(admit4);

            // sale return  
            System_Records admit5 = new System_Records()
            {
                purchase_rate_yn = add.System_Records_Issue_Sale_Return_Request.purchase_rate_yn,
                profit_yn = add.System_Records_Issue_Sale_Return_Request.profit_yn,
                discount_amount_yn = add.System_Records_Issue_Sale_Return_Request.discount_amount_yn,
                discount_rate_yn = add.System_Records_Issue_Sale_Return_Request.discount_rate_yn,
                gst_amount_yn = add.System_Records_Issue_Sale_Return_Request.gst_amount_yn,
                total_profit_yn = add.System_Records_Issue_Sale_Return_Request.total_profit_yn,
                total_weight_yn = add.System_Records_Issue_Sale_Return_Request.total_weight_yn,
                gst_rate_yn = add.System_Records_Issue_Sale_Return_Request.gst_rate_yn,
                irflag = add.System_Records_Issue_Sale_Return_Request.irflag,


                challan_master_method = add.System_Records_Issue_Sale_Return_Request.challan_master_method,
                cart_tcs_value = add.System_Records_Issue_Sale_Return_Request.cart_tcs_value,
                batch_no = add.System_Records_Issue_Sale_Return_Request.batch_no,
                style = add.System_Records_Issue_Sale_Return_Request.style,
                brand = add.System_Records_Issue_Sale_Return_Request.brand,
                color = add.System_Records_Issue_Sale_Return_Request.color,
                agent = add.System_Records_Issue_Sale_Return_Request.agent,
                dealer = add.System_Records_Issue_Sale_Return_Request.dealer,
                round_off = add.System_Records_Issue_Sale_Return_Request.round_off,
                transporter_cartage_yn = add.System_Records_Issue_Sale_Return_Request.transporter_cartage_yn,
                maintain_accounting_yn = add.System_Records_Issue_Sale_Return_Request.maintain_accounting_yn,

                hsn_code_yn = add.System_Records_Issue_Sale_Return_Request.hsn_code_yn,
                packing_type_yn = add.System_Records_Issue_Sale_Return_Request.packing_type_yn,
                scheme_type_yn = add.System_Records_Issue_Sale_Return_Request.scheme_type_yn,
                remarks_yn = add.System_Records_Issue_Sale_Return_Request.remarks_yn,
                sale_rate_yn = add.System_Records_Issue_Sale_Return_Request.sale_rate_yn,
                issue_qty_yn = add.System_Records_Issue_Sale_Return_Request.issue_qty_yn,
                discount_percentage_yn = add.System_Records_Issue_Sale_Return_Request.discount_percentage_yn,
                grand_total_yn = add.System_Records_Issue_Sale_Return_Request.grand_total_yn,
                gst_percentage_yn = add.System_Records_Issue_Sale_Return_Request.gst_percentage_yn,
                rate_after_gst_yn = add.System_Records_Issue_Sale_Return_Request.rate_after_gst_yn,
                total_amount_yn = add.System_Records_Issue_Sale_Return_Request.total_amount_yn,
                current_stock_yn = add.System_Records_Issue_Sale_Return_Request.current_stock_yn,
                balance_qty_yn = add.System_Records_Issue_Sale_Return_Request.balance_qty_yn
            };
            DB.System_Records.Add(admit5);


            // Voucher Recipted  
            System_Records admit6 = new System_Records()
            {
                gst_percentage_yn = add.System_Records_Voucher_Recipted_Request.gst_percentage_yn,
                gst_amount_yn = add.System_Records_Voucher_Recipted_Request.gst_amount_yn,
                grand_total_yn = add.System_Records_Voucher_Recipted_Request.grand_total_yn,
                irflag = add.System_Records_Voucher_Recipted_Request.irflag,
            };
            DB.System_Records.Add(admit6);


            // Voucher Payment  
            System_Records admit7 = new System_Records()
            {
                gst_percentage_yn = add.System_Records_Voucher_Payment_Request.gst_percentage_yn,
                gst_amount_yn = add.System_Records_Voucher_Payment_Request.gst_amount_yn,
                grand_total_yn = add.System_Records_Voucher_Payment_Request.grand_total_yn,
                irflag = add.System_Records_Voucher_Payment_Request.irflag,
            };
            DB.System_Records.Add(admit7);

            // Voucher Contra  
            System_Records admit8 = new System_Records()
            {
                gst_percentage_yn = add.System_Records_Voucher_Contra_Request.gst_percentage_yn,
                gst_amount_yn = add.System_Records_Voucher_Contra_Request.gst_amount_yn,
                grand_total_yn = add.System_Records_Voucher_Contra_Request.grand_total_yn,
                irflag = add.System_Records_Voucher_Contra_Request.irflag,
            };
            DB.System_Records.Add(admit8);


            // Voucher Journal  
            System_Records admit9 = new System_Records()
            {
                gst_percentage_yn = add.System_Records_Voucher_Journal_Request.gst_percentage_yn,
                gst_amount_yn = add.System_Records_Voucher_Journal_Request.gst_amount_yn,
                grand_total_yn = add.System_Records_Voucher_Journal_Request.grand_total_yn,
                irflag = add.System_Records_Voucher_Journal_Request.irflag,
            };
            DB.System_Records.Add(admit9);

            // Voucher Credit  
            System_Records admit10 = new System_Records()
            {
                gst_percentage_yn = add.System_Records_Voucher_Credit_Request.gst_percentage_yn,
                gst_amount_yn = add.System_Records_Voucher_Credit_Request.gst_amount_yn,
                grand_total_yn = add.System_Records_Voucher_Credit_Request.grand_total_yn,
                irflag = add.System_Records_Voucher_Credit_Request.irflag,
            };
            DB.System_Records.Add(admit10);


            // Voucher Debit  
            System_Records admit11 = new System_Records()
            {
                gst_percentage_yn = add.System_Records_Voucher_Debit_Request.gst_percentage_yn,
                gst_amount_yn = add.System_Records_Voucher_Debit_Request.gst_amount_yn,
                grand_total_yn = add.System_Records_Voucher_Debit_Request.grand_total_yn,
                irflag = add.System_Records_Voucher_Debit_Request.irflag,
            };
            DB.System_Records.Add(admit11);

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

                    result.bill_type_method = add.bill_type_method;
                    result.cart_tcs_value = add.cart_tcs_value;

                    result.batch_no = add.batch_no;
                    result.style = add.style;
                    result.brand = add.brand;
                    result.color = add.color;
                    result.agent = add.agent;
                    result.dealer = add.dealer;
                    result.round_off = add.round_off;


                    result.transporter_cartage_yn = add.transporter_cartage_yn;
                    result.maintain_accounting_yn = add.maintain_accounting_yn;
                    result.challan_master_method = add.challan_master_method;

                    result.purchase_rate_yn = add.purchase_rate_yn;
                    result.profit_yn = add.profit_yn;
                    result.discount_amount_yn = add.discount_amount_yn;
                    result.discount_rate_yn = add.discount_rate_yn;
                    result.gst_amount_yn = add.gst_amount_yn;
                    result.total_profit_yn = add.total_profit_yn;
                    result.total_weight_yn = add.total_weight_yn;
                    result.gst_rate_yn = add.gst_rate_yn;


                    result.opening_yn = add.opening_yn;
                    result.damage_yn = add.damage_yn;
                    result.missing_yn = add.missing_yn;
                    result.rent_rate_yn = add.rent_rate_yn;
                    result.agr_qty_yn = add.agr_qty_yn;
                    result.pc_rmt_pp_yn = add.pc_rmt_pp_yn;
                    result.irflag = add.irflag;


                    result.otp_req_deletion_yn = add.otp_req_deletion_yn;

                    result.hsn_code_yn = add.hsn_code_yn;
                    result.packing_type_yn = add.packing_type_yn;
                    result.scheme_type_yn = add.scheme_type_yn;
                    result.remarks_yn = add.remarks_yn;
                    result.sale_rate_yn = add.sale_rate_yn;
                    result.issue_qty_yn = add.issue_qty_yn;
                    result.discount_percentage_yn = add.discount_percentage_yn;
                    result.grand_total_yn = add.grand_total_yn;
                    result.gst_percentage_yn = add.gst_percentage_yn;
                    result.rate_after_gst_yn = add.rate_after_gst_yn;
                    result.total_amount_yn = add.total_amount_yn;
                    result.current_stock_yn = add.current_stock_yn;
                    result.balance_qty_yn = add.balance_qty_yn;
                    result.system_invoice = add.system_invoice;

                    result.company_about = add.company_about;
                    result.company_image = add.company_image;

                    result.company_logo = add.company_logo;
                    result.facebook_link = add.facebook_link;
                    result.twitter_link = add.twitter_link;
                    result.youtube_link = add.youtube_link;
                    result.linkedin_link = add.linkedin_link;
                    result.map_link = add.map_link;
                    result.private_policy = add.private_policy;
                    result.business_card_link = add.business_card_link;
                }

                // sale
                if (add.System_Records_Issue_Sale_Request != null)
                {
                    var result1 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Issue_Sale_Request.irflag && s.id == add.System_Records_Issue_Sale_Request.id);
                    if (result1 != null)
                    {
                        result1.purchase_rate_yn = add.System_Records_Issue_Sale_Request.purchase_rate_yn;
                        result1.profit_yn = add.System_Records_Issue_Sale_Request.profit_yn;
                        result1.discount_amount_yn = add.System_Records_Issue_Sale_Request.discount_amount_yn;
                        result1.discount_rate_yn = add.System_Records_Issue_Sale_Request.discount_rate_yn;
                        result1.gst_amount_yn = add.System_Records_Issue_Sale_Request.gst_amount_yn;
                        result1.total_profit_yn = add.System_Records_Issue_Sale_Request.total_profit_yn;
                        result1.total_weight_yn = add.System_Records_Issue_Sale_Request.total_weight_yn;
                        result1.gst_rate_yn = add.System_Records_Issue_Sale_Request.gst_rate_yn;


                        result1.challan_master_method = add.System_Records_Issue_Sale_Request.challan_master_method;
                        result1.cart_tcs_value = add.System_Records_Issue_Sale_Request.cart_tcs_value;
                        result1.batch_no = add.System_Records_Issue_Sale_Request.batch_no;
                        result1.style = add.System_Records_Issue_Sale_Request.style;
                        result1.brand = add.System_Records_Issue_Sale_Request.brand;
                        result1.color = add.System_Records_Issue_Sale_Request.color;
                        result1.agent = add.System_Records_Issue_Sale_Request.agent;
                        result1.dealer = add.System_Records_Issue_Sale_Request.dealer;
                        result1.round_off = add.System_Records_Issue_Sale_Request.round_off;
                        result1.transporter_cartage_yn = add.System_Records_Issue_Sale_Request.transporter_cartage_yn;
                        result1.maintain_accounting_yn = add.System_Records_Issue_Sale_Request.maintain_accounting_yn;



                        result1.hsn_code_yn = add.System_Records_Issue_Sale_Request.hsn_code_yn;
                        result1.packing_type_yn = add.System_Records_Issue_Sale_Request.packing_type_yn;
                        result1.scheme_type_yn = add.System_Records_Issue_Sale_Request.scheme_type_yn;
                        result1.remarks_yn = add.System_Records_Issue_Sale_Request.remarks_yn;
                        result1.sale_rate_yn = add.System_Records_Issue_Sale_Request.sale_rate_yn;
                        result1.issue_qty_yn = add.System_Records_Issue_Sale_Request.issue_qty_yn;
                        result1.discount_percentage_yn = add.System_Records_Issue_Sale_Request.discount_percentage_yn;
                        result1.grand_total_yn = add.System_Records_Issue_Sale_Request.grand_total_yn;
                        result1.gst_percentage_yn = add.System_Records_Issue_Sale_Request.gst_percentage_yn;
                        result1.rate_after_gst_yn = add.System_Records_Issue_Sale_Request.rate_after_gst_yn;
                        result1.total_amount_yn = add.System_Records_Issue_Sale_Request.total_amount_yn;
                        result1.current_stock_yn = add.System_Records_Issue_Sale_Request.current_stock_yn;
                        result1.balance_qty_yn = add.System_Records_Issue_Sale_Request.balance_qty_yn;
                    }
                    else
                    {
                        System_Records admit1 = new System_Records()
                        {
                            purchase_rate_yn = add.System_Records_Issue_Sale_Request.purchase_rate_yn,
                            profit_yn = add.System_Records_Issue_Sale_Request.profit_yn,
                            discount_amount_yn = add.System_Records_Issue_Sale_Request.discount_amount_yn,
                            discount_rate_yn = add.System_Records_Issue_Sale_Request.discount_rate_yn,
                            gst_amount_yn = add.System_Records_Issue_Sale_Request.gst_amount_yn,
                            total_profit_yn = add.System_Records_Issue_Sale_Request.total_profit_yn,
                            total_weight_yn = add.System_Records_Issue_Sale_Request.total_weight_yn,
                            gst_rate_yn = add.System_Records_Issue_Sale_Request.gst_rate_yn,
                            irflag = add.System_Records_Issue_Sale_Request.irflag,


                            challan_master_method = add.System_Records_Issue_Sale_Request.challan_master_method,
                            cart_tcs_value = add.System_Records_Issue_Sale_Request.cart_tcs_value,
                            batch_no = add.System_Records_Issue_Sale_Request.batch_no,
                            style = add.System_Records_Issue_Sale_Request.style,
                            brand = add.System_Records_Issue_Sale_Request.brand,
                            color = add.System_Records_Issue_Sale_Request.color,
                            agent = add.System_Records_Issue_Sale_Request.agent,
                            dealer = add.System_Records_Issue_Sale_Request.dealer,
                            round_off = add.System_Records_Issue_Sale_Request.round_off,
                            transporter_cartage_yn = add.System_Records_Issue_Sale_Request.transporter_cartage_yn,
                            maintain_accounting_yn = add.System_Records_Issue_Sale_Request.maintain_accounting_yn,


                            hsn_code_yn = add.System_Records_Issue_Sale_Request.hsn_code_yn,
                            packing_type_yn = add.System_Records_Issue_Sale_Request.packing_type_yn,
                            scheme_type_yn = add.System_Records_Issue_Sale_Request.scheme_type_yn,
                            remarks_yn = add.System_Records_Issue_Sale_Request.remarks_yn,
                            sale_rate_yn = add.System_Records_Issue_Sale_Request.sale_rate_yn,
                            issue_qty_yn = add.System_Records_Issue_Sale_Request.issue_qty_yn,
                            discount_percentage_yn = add.System_Records_Issue_Sale_Request.discount_percentage_yn,
                            grand_total_yn = add.System_Records_Issue_Sale_Request.grand_total_yn,
                            gst_percentage_yn = add.System_Records_Issue_Sale_Request.gst_percentage_yn,
                            rate_after_gst_yn = add.System_Records_Issue_Sale_Request.rate_after_gst_yn,
                            total_amount_yn = add.System_Records_Issue_Sale_Request.total_amount_yn,
                            current_stock_yn = add.System_Records_Issue_Sale_Request.current_stock_yn,
                            balance_qty_yn = add.System_Records_Issue_Sale_Request.balance_qty_yn

                        };
                        DB.System_Records.Add(admit1);

                    }
                }

                // purchase
                if (add.System_Records_Issue_Purchase_Request != null)
                {
                    var result2 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Issue_Purchase_Request.irflag && s.id == add.System_Records_Issue_Purchase_Request.id);
                    if (result2 != null)
                    {
                        result2.purchase_rate_yn = add.System_Records_Issue_Purchase_Request.purchase_rate_yn;
                        result2.profit_yn = add.System_Records_Issue_Purchase_Request.profit_yn;
                        result2.discount_amount_yn = add.System_Records_Issue_Purchase_Request.discount_amount_yn;
                        result2.discount_rate_yn = add.System_Records_Issue_Purchase_Request.discount_rate_yn;
                        result2.gst_amount_yn = add.System_Records_Issue_Purchase_Request.gst_amount_yn;
                        result2.total_profit_yn = add.System_Records_Issue_Purchase_Request.total_profit_yn;
                        result2.total_weight_yn = add.System_Records_Issue_Purchase_Request.total_weight_yn;
                        result2.gst_rate_yn = add.System_Records_Issue_Purchase_Request.gst_rate_yn;

                        result2.challan_master_method = add.System_Records_Issue_Purchase_Request.challan_master_method;
                        result2.cart_tcs_value = add.System_Records_Issue_Purchase_Request.cart_tcs_value;
                        result2.batch_no = add.System_Records_Issue_Purchase_Request.batch_no;
                        result2.style = add.System_Records_Issue_Purchase_Request.style;
                        result2.brand = add.System_Records_Issue_Purchase_Request.brand;
                        result2.color = add.System_Records_Issue_Purchase_Request.color;
                        result2.agent = add.System_Records_Issue_Purchase_Request.agent;
                        result2.dealer = add.System_Records_Issue_Purchase_Request.dealer;
                        result2.round_off = add.System_Records_Issue_Purchase_Request.round_off;
                        result2.transporter_cartage_yn = add.System_Records_Issue_Purchase_Request.transporter_cartage_yn;
                        result2.maintain_accounting_yn = add.System_Records_Issue_Purchase_Request.maintain_accounting_yn;

                        result2.hsn_code_yn = add.System_Records_Issue_Purchase_Request.hsn_code_yn;
                        result2.packing_type_yn = add.System_Records_Issue_Purchase_Request.packing_type_yn;
                        result2.scheme_type_yn = add.System_Records_Issue_Purchase_Request.scheme_type_yn;
                        result2.remarks_yn = add.System_Records_Issue_Purchase_Request.remarks_yn;
                        result2.sale_rate_yn = add.System_Records_Issue_Purchase_Request.sale_rate_yn;
                        result2.issue_qty_yn = add.System_Records_Issue_Purchase_Request.issue_qty_yn;
                        result2.discount_percentage_yn = add.System_Records_Issue_Purchase_Request.discount_percentage_yn;
                        result2.grand_total_yn = add.System_Records_Issue_Purchase_Request.grand_total_yn;
                        result2.gst_percentage_yn = add.System_Records_Issue_Purchase_Request.gst_percentage_yn;
                        result2.rate_after_gst_yn = add.System_Records_Issue_Purchase_Request.rate_after_gst_yn;
                        result2.total_amount_yn = add.System_Records_Issue_Purchase_Request.total_amount_yn;
                        result2.current_stock_yn = add.System_Records_Issue_Purchase_Request.current_stock_yn;
                        result2.balance_qty_yn = add.System_Records_Issue_Purchase_Request.balance_qty_yn;
                    }
                    else
                    {
                        System_Records admit1 = new System_Records()
                        {
                            purchase_rate_yn = add.System_Records_Issue_Purchase_Request.purchase_rate_yn,
                            profit_yn = add.System_Records_Issue_Purchase_Request.profit_yn,
                            discount_amount_yn = add.System_Records_Issue_Purchase_Request.discount_amount_yn,
                            discount_rate_yn = add.System_Records_Issue_Purchase_Request.discount_rate_yn,
                            gst_amount_yn = add.System_Records_Issue_Purchase_Request.gst_amount_yn,
                            total_profit_yn = add.System_Records_Issue_Purchase_Request.total_profit_yn,
                            total_weight_yn = add.System_Records_Issue_Purchase_Request.total_weight_yn,
                            gst_rate_yn = add.System_Records_Issue_Purchase_Request.gst_rate_yn,
                            irflag = add.System_Records_Issue_Purchase_Request.irflag,

                            challan_master_method = add.System_Records_Issue_Purchase_Request.challan_master_method,
                            cart_tcs_value = add.System_Records_Issue_Purchase_Request.cart_tcs_value,
                            batch_no = add.System_Records_Issue_Purchase_Request.batch_no,
                            style = add.System_Records_Issue_Purchase_Request.style,
                            brand = add.System_Records_Issue_Purchase_Request.brand,
                            color = add.System_Records_Issue_Purchase_Request.color,
                            agent = add.System_Records_Issue_Purchase_Request.agent,
                            dealer = add.System_Records_Issue_Purchase_Request.dealer,
                            round_off = add.System_Records_Issue_Purchase_Request.round_off,
                            transporter_cartage_yn = add.System_Records_Issue_Purchase_Request.transporter_cartage_yn,
                            maintain_accounting_yn = add.System_Records_Issue_Purchase_Request.maintain_accounting_yn,

                            hsn_code_yn = add.System_Records_Issue_Purchase_Request.hsn_code_yn,
                            packing_type_yn = add.System_Records_Issue_Purchase_Request.packing_type_yn,
                            scheme_type_yn = add.System_Records_Issue_Purchase_Request.scheme_type_yn,
                            remarks_yn = add.System_Records_Issue_Purchase_Request.remarks_yn,
                            sale_rate_yn = add.System_Records_Issue_Purchase_Request.sale_rate_yn,
                            issue_qty_yn = add.System_Records_Issue_Purchase_Request.issue_qty_yn,
                            discount_percentage_yn = add.System_Records_Issue_Purchase_Request.discount_percentage_yn,
                            grand_total_yn = add.System_Records_Issue_Purchase_Request.grand_total_yn,
                            gst_percentage_yn = add.System_Records_Issue_Purchase_Request.gst_percentage_yn,
                            rate_after_gst_yn = add.System_Records_Issue_Purchase_Request.rate_after_gst_yn,
                            total_amount_yn = add.System_Records_Issue_Purchase_Request.total_amount_yn,
                            current_stock_yn = add.System_Records_Issue_Purchase_Request.current_stock_yn,
                            balance_qty_yn = add.System_Records_Issue_Purchase_Request.balance_qty_yn

                        };
                        DB.System_Records.Add(admit1);
                    }
                }


                // rec
                if (add.System_Records_Issue_Recipted_Request != null)
                {
                    var result3 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Issue_Recipted_Request.irflag && s.id == add.System_Records_Issue_Recipted_Request.id);
                    if (result3 != null)
                    {
                        result3.purchase_rate_yn = add.System_Records_Issue_Recipted_Request.purchase_rate_yn;
                        result3.profit_yn = add.System_Records_Issue_Recipted_Request.profit_yn;
                        result3.discount_amount_yn = add.System_Records_Issue_Recipted_Request.discount_amount_yn;
                        result3.discount_rate_yn = add.System_Records_Issue_Recipted_Request.discount_rate_yn;
                        result3.gst_amount_yn = add.System_Records_Issue_Recipted_Request.gst_amount_yn;
                        result3.total_profit_yn = add.System_Records_Issue_Recipted_Request.total_profit_yn;
                        result3.total_weight_yn = add.System_Records_Issue_Recipted_Request.total_weight_yn;
                        result3.gst_rate_yn = add.System_Records_Issue_Recipted_Request.gst_rate_yn;

                        result3.challan_master_method = add.System_Records_Issue_Recipted_Request.challan_master_method;
                        result3.cart_tcs_value = add.System_Records_Issue_Recipted_Request.cart_tcs_value;
                        result3.batch_no = add.System_Records_Issue_Recipted_Request.batch_no;
                        result3.style = add.System_Records_Issue_Recipted_Request.style;
                        result3.brand = add.System_Records_Issue_Recipted_Request.brand;
                        result3.color = add.System_Records_Issue_Recipted_Request.color;
                        result3.agent = add.System_Records_Issue_Recipted_Request.agent;
                        result3.dealer = add.System_Records_Issue_Recipted_Request.dealer;
                        result3.round_off = add.System_Records_Issue_Recipted_Request.round_off;
                        result3.transporter_cartage_yn = add.System_Records_Issue_Recipted_Request.transporter_cartage_yn;
                        result3.maintain_accounting_yn = add.System_Records_Issue_Recipted_Request.maintain_accounting_yn;

                        result3.hsn_code_yn = add.System_Records_Issue_Recipted_Request.hsn_code_yn;
                        result3.packing_type_yn = add.System_Records_Issue_Recipted_Request.packing_type_yn;
                        result3.scheme_type_yn = add.System_Records_Issue_Recipted_Request.scheme_type_yn;
                        result3.remarks_yn = add.System_Records_Issue_Recipted_Request.remarks_yn;
                        result3.sale_rate_yn = add.System_Records_Issue_Recipted_Request.sale_rate_yn;
                        result3.recv_qty_yn = add.System_Records_Issue_Recipted_Request.recv_qty_yn;
                        result3.discount_percentage_yn = add.System_Records_Issue_Recipted_Request.discount_percentage_yn;
                        result3.grand_total_yn = add.System_Records_Issue_Recipted_Request.grand_total_yn;
                        result3.gst_percentage_yn = add.System_Records_Issue_Recipted_Request.gst_percentage_yn;
                        result3.rate_after_gst_yn = add.System_Records_Issue_Recipted_Request.rate_after_gst_yn;
                        result3.total_amount_yn = add.System_Records_Issue_Recipted_Request.total_amount_yn;
                        result3.current_stock_yn = add.System_Records_Issue_Recipted_Request.current_stock_yn;
                        result3.balance_qty_yn = add.System_Records_Issue_Recipted_Request.balance_qty_yn;
                    }
                    else
                    {
                        System_Records admit1 = new System_Records()
                        {
                            purchase_rate_yn = add.System_Records_Issue_Recipted_Request.purchase_rate_yn,
                            profit_yn = add.System_Records_Issue_Recipted_Request.profit_yn,
                            discount_amount_yn = add.System_Records_Issue_Recipted_Request.discount_amount_yn,
                            discount_rate_yn = add.System_Records_Issue_Recipted_Request.discount_rate_yn,
                            gst_amount_yn = add.System_Records_Issue_Recipted_Request.gst_amount_yn,
                            total_profit_yn = add.System_Records_Issue_Recipted_Request.total_profit_yn,
                            total_weight_yn = add.System_Records_Issue_Recipted_Request.total_weight_yn,
                            gst_rate_yn = add.System_Records_Issue_Recipted_Request.gst_rate_yn,
                            irflag = add.System_Records_Issue_Recipted_Request.irflag,

                            challan_master_method = add.System_Records_Issue_Recipted_Request.challan_master_method,
                            cart_tcs_value = add.System_Records_Issue_Recipted_Request.cart_tcs_value,
                            batch_no = add.System_Records_Issue_Recipted_Request.batch_no,
                            style = add.System_Records_Issue_Recipted_Request.style,
                            brand = add.System_Records_Issue_Recipted_Request.brand,
                            color = add.System_Records_Issue_Recipted_Request.color,
                            agent = add.System_Records_Issue_Recipted_Request.agent,
                            dealer = add.System_Records_Issue_Recipted_Request.dealer,
                            round_off = add.System_Records_Issue_Recipted_Request.round_off,
                            transporter_cartage_yn = add.System_Records_Issue_Recipted_Request.transporter_cartage_yn,
                            maintain_accounting_yn = add.System_Records_Issue_Recipted_Request.maintain_accounting_yn,

                            hsn_code_yn = add.System_Records_Issue_Recipted_Request.hsn_code_yn,
                            packing_type_yn = add.System_Records_Issue_Recipted_Request.packing_type_yn,
                            scheme_type_yn = add.System_Records_Issue_Recipted_Request.scheme_type_yn,
                            remarks_yn = add.System_Records_Issue_Recipted_Request.remarks_yn,
                            sale_rate_yn = add.System_Records_Issue_Recipted_Request.sale_rate_yn,
                            recv_qty_yn = add.System_Records_Issue_Recipted_Request.recv_qty_yn,
                            discount_percentage_yn = add.System_Records_Issue_Recipted_Request.discount_percentage_yn,
                            grand_total_yn = add.System_Records_Issue_Recipted_Request.grand_total_yn,
                            gst_percentage_yn = add.System_Records_Issue_Recipted_Request.gst_percentage_yn,
                            rate_after_gst_yn = add.System_Records_Issue_Recipted_Request.rate_after_gst_yn,
                            total_amount_yn = add.System_Records_Issue_Recipted_Request.total_amount_yn,
                            current_stock_yn = add.System_Records_Issue_Recipted_Request.current_stock_yn,
                            balance_qty_yn = add.System_Records_Issue_Recipted_Request.balance_qty_yn
                        };
                        DB.System_Records.Add(admit1);
                    }
                }


                // sale return challan 
                if (add.System_Records_Issue_Sale_Return_Request != null)
                {
                    var result4 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Issue_Sale_Return_Request.irflag && s.id == add.System_Records_Issue_Sale_Return_Request.id);
                    if (result4 != null)
                    {
                        result4.purchase_rate_yn = add.System_Records_Issue_Sale_Return_Request.purchase_rate_yn;
                        result4.profit_yn = add.System_Records_Issue_Sale_Return_Request.profit_yn;
                        result4.discount_amount_yn = add.System_Records_Issue_Sale_Return_Request.discount_amount_yn;
                        result4.discount_rate_yn = add.System_Records_Issue_Sale_Return_Request.discount_rate_yn;
                        result4.gst_amount_yn = add.System_Records_Issue_Sale_Return_Request.gst_amount_yn;
                        result4.total_profit_yn = add.System_Records_Issue_Sale_Return_Request.total_profit_yn;
                        result4.total_weight_yn = add.System_Records_Issue_Sale_Return_Request.total_weight_yn;
                        result4.gst_rate_yn = add.System_Records_Issue_Sale_Return_Request.gst_rate_yn;

                        result4.challan_master_method = add.System_Records_Issue_Sale_Return_Request.challan_master_method;
                        result4.cart_tcs_value = add.System_Records_Issue_Sale_Return_Request.cart_tcs_value;
                        result4.batch_no = add.System_Records_Issue_Sale_Return_Request.batch_no;
                        result4.style = add.System_Records_Issue_Sale_Return_Request.style;
                        result4.brand = add.System_Records_Issue_Sale_Return_Request.brand;
                        result4.color = add.System_Records_Issue_Sale_Return_Request.color;
                        result4.agent = add.System_Records_Issue_Sale_Return_Request.agent;
                        result4.dealer = add.System_Records_Issue_Sale_Return_Request.dealer;
                        result4.round_off = add.System_Records_Issue_Sale_Return_Request.round_off;
                        result4.transporter_cartage_yn = add.System_Records_Issue_Sale_Return_Request.transporter_cartage_yn;
                        result4.maintain_accounting_yn = add.System_Records_Issue_Sale_Return_Request.maintain_accounting_yn;

                        result4.hsn_code_yn = add.System_Records_Issue_Sale_Return_Request.hsn_code_yn;
                        result4.packing_type_yn = add.System_Records_Issue_Sale_Return_Request.packing_type_yn;
                        result4.scheme_type_yn = add.System_Records_Issue_Sale_Return_Request.scheme_type_yn;
                        result4.remarks_yn = add.System_Records_Issue_Sale_Return_Request.remarks_yn;
                        result4.sale_rate_yn = add.System_Records_Issue_Sale_Return_Request.sale_rate_yn;
                        result4.issue_qty_yn = add.System_Records_Issue_Sale_Return_Request.issue_qty_yn;
                        result4.discount_percentage_yn = add.System_Records_Issue_Sale_Return_Request.discount_percentage_yn;
                        result4.grand_total_yn = add.System_Records_Issue_Sale_Return_Request.grand_total_yn;
                        result4.gst_percentage_yn = add.System_Records_Issue_Sale_Return_Request.gst_percentage_yn;
                        result4.rate_after_gst_yn = add.System_Records_Issue_Sale_Return_Request.rate_after_gst_yn;
                        result4.total_amount_yn = add.System_Records_Issue_Sale_Return_Request.total_amount_yn;
                        result4.current_stock_yn = add.System_Records_Issue_Sale_Return_Request.current_stock_yn;
                        result4.balance_qty_yn = add.System_Records_Issue_Sale_Return_Request.balance_qty_yn;
                    }
                    else
                    {
                        System_Records admit1 = new System_Records()
                        {
                            purchase_rate_yn = add.System_Records_Issue_Sale_Return_Request.purchase_rate_yn,
                            profit_yn = add.System_Records_Issue_Sale_Return_Request.profit_yn,
                            discount_amount_yn = add.System_Records_Issue_Sale_Return_Request.discount_amount_yn,
                            discount_rate_yn = add.System_Records_Issue_Sale_Return_Request.discount_rate_yn,
                            gst_amount_yn = add.System_Records_Issue_Sale_Return_Request.gst_amount_yn,
                            total_profit_yn = add.System_Records_Issue_Sale_Return_Request.total_profit_yn,
                            total_weight_yn = add.System_Records_Issue_Sale_Return_Request.total_weight_yn,
                            gst_rate_yn = add.System_Records_Issue_Sale_Return_Request.gst_rate_yn,
                            irflag = add.System_Records_Issue_Sale_Return_Request.irflag,

                            challan_master_method = add.System_Records_Issue_Sale_Return_Request.challan_master_method,
                            cart_tcs_value = add.System_Records_Issue_Sale_Return_Request.cart_tcs_value,
                            batch_no = add.System_Records_Issue_Sale_Return_Request.batch_no,
                            style = add.System_Records_Issue_Sale_Return_Request.style,
                            brand = add.System_Records_Issue_Sale_Return_Request.brand,
                            color = add.System_Records_Issue_Sale_Return_Request.color,
                            agent = add.System_Records_Issue_Sale_Return_Request.agent,
                            dealer = add.System_Records_Issue_Sale_Return_Request.dealer,
                            round_off = add.System_Records_Issue_Sale_Return_Request.round_off,
                            transporter_cartage_yn = add.System_Records_Issue_Sale_Return_Request.transporter_cartage_yn,
                            maintain_accounting_yn = add.System_Records_Issue_Sale_Return_Request.maintain_accounting_yn,

                            hsn_code_yn = add.System_Records_Issue_Sale_Return_Request.hsn_code_yn,
                            packing_type_yn = add.System_Records_Issue_Sale_Return_Request.packing_type_yn,
                            scheme_type_yn = add.System_Records_Issue_Sale_Return_Request.scheme_type_yn,
                            remarks_yn = add.System_Records_Issue_Sale_Return_Request.remarks_yn,
                            sale_rate_yn = add.System_Records_Issue_Sale_Return_Request.sale_rate_yn,
                            issue_qty_yn = add.System_Records_Issue_Sale_Return_Request.issue_qty_yn,
                            discount_percentage_yn = add.System_Records_Issue_Sale_Return_Request.discount_percentage_yn,
                            grand_total_yn = add.System_Records_Issue_Sale_Return_Request.grand_total_yn,
                            gst_percentage_yn = add.System_Records_Issue_Sale_Return_Request.gst_percentage_yn,
                            rate_after_gst_yn = add.System_Records_Issue_Sale_Return_Request.rate_after_gst_yn,
                            total_amount_yn = add.System_Records_Issue_Sale_Return_Request.total_amount_yn,
                            current_stock_yn = add.System_Records_Issue_Sale_Return_Request.current_stock_yn,
                            balance_qty_yn = add.System_Records_Issue_Sale_Return_Request.balance_qty_yn
                        };
                        DB.System_Records.Add(admit1);
                    }
                }

                // purchase return challan 
                if (add.System_Records_Issue_Purchase_Return_Request != null)
                {
                    var result5 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Issue_Purchase_Return_Request.irflag && s.id == add.System_Records_Issue_Purchase_Return_Request.id);
                    if (result5 != null)
                    {
                        result5.purchase_rate_yn = add.System_Records_Issue_Purchase_Return_Request.purchase_rate_yn;
                        result5.profit_yn = add.System_Records_Issue_Purchase_Return_Request.profit_yn;
                        result5.discount_amount_yn = add.System_Records_Issue_Purchase_Return_Request.discount_amount_yn;
                        result5.discount_rate_yn = add.System_Records_Issue_Purchase_Return_Request.discount_rate_yn;
                        result5.gst_amount_yn = add.System_Records_Issue_Purchase_Return_Request.gst_amount_yn;
                        result5.total_profit_yn = add.System_Records_Issue_Purchase_Return_Request.total_profit_yn;
                        result5.total_weight_yn = add.System_Records_Issue_Purchase_Return_Request.total_weight_yn;
                        result5.gst_rate_yn = add.System_Records_Issue_Purchase_Return_Request.gst_rate_yn;

                        result5.challan_master_method = add.System_Records_Issue_Purchase_Return_Request.challan_master_method;
                        result5.cart_tcs_value = add.System_Records_Issue_Purchase_Return_Request.cart_tcs_value;
                        result5.batch_no = add.System_Records_Issue_Purchase_Return_Request.batch_no;
                        result5.style = add.System_Records_Issue_Purchase_Return_Request.style;
                        result5.brand = add.System_Records_Issue_Purchase_Return_Request.brand;
                        result5.color = add.System_Records_Issue_Purchase_Return_Request.color;
                        result5.agent = add.System_Records_Issue_Purchase_Return_Request.agent;
                        result5.dealer = add.System_Records_Issue_Purchase_Return_Request.dealer;
                        result5.round_off = add.System_Records_Issue_Purchase_Return_Request.round_off;
                        result5.transporter_cartage_yn = add.System_Records_Issue_Purchase_Return_Request.transporter_cartage_yn;
                        result5.maintain_accounting_yn = add.System_Records_Issue_Purchase_Return_Request.maintain_accounting_yn;

                        result5.hsn_code_yn = add.System_Records_Issue_Purchase_Return_Request.hsn_code_yn;
                        result5.packing_type_yn = add.System_Records_Issue_Purchase_Return_Request.packing_type_yn;
                        result5.scheme_type_yn = add.System_Records_Issue_Purchase_Return_Request.scheme_type_yn;
                        result5.remarks_yn = add.System_Records_Issue_Purchase_Return_Request.remarks_yn;
                        result5.sale_rate_yn = add.System_Records_Issue_Purchase_Return_Request.sale_rate_yn;
                        result5.issue_qty_yn = add.System_Records_Issue_Purchase_Return_Request.issue_qty_yn;
                        result5.discount_percentage_yn = add.System_Records_Issue_Purchase_Return_Request.discount_percentage_yn;
                        result5.grand_total_yn = add.System_Records_Issue_Purchase_Return_Request.grand_total_yn;
                        result5.gst_percentage_yn = add.System_Records_Issue_Purchase_Return_Request.gst_percentage_yn;
                        result5.rate_after_gst_yn = add.System_Records_Issue_Purchase_Return_Request.rate_after_gst_yn;
                        result5.total_amount_yn = add.System_Records_Issue_Purchase_Return_Request.total_amount_yn;
                        result5.current_stock_yn = add.System_Records_Issue_Purchase_Return_Request.current_stock_yn;
                        result5.balance_qty_yn = add.System_Records_Issue_Purchase_Return_Request.balance_qty_yn;
                    }
                    else
                    {
                        System_Records admit1 = new System_Records()
                        {
                            purchase_rate_yn = add.System_Records_Issue_Purchase_Return_Request.purchase_rate_yn,
                            profit_yn = add.System_Records_Issue_Purchase_Return_Request.profit_yn,
                            discount_amount_yn = add.System_Records_Issue_Purchase_Return_Request.discount_amount_yn,
                            discount_rate_yn = add.System_Records_Issue_Purchase_Return_Request.discount_rate_yn,
                            gst_amount_yn = add.System_Records_Issue_Purchase_Return_Request.gst_amount_yn,
                            total_profit_yn = add.System_Records_Issue_Purchase_Return_Request.total_profit_yn,
                            total_weight_yn = add.System_Records_Issue_Purchase_Return_Request.total_weight_yn,
                            gst_rate_yn = add.System_Records_Issue_Purchase_Return_Request.gst_rate_yn,
                            irflag = add.System_Records_Issue_Purchase_Return_Request.irflag,

                            challan_master_method = add.System_Records_Issue_Purchase_Return_Request.challan_master_method,
                            cart_tcs_value = add.System_Records_Issue_Purchase_Return_Request.cart_tcs_value,
                            batch_no = add.System_Records_Issue_Purchase_Return_Request.batch_no,
                            style = add.System_Records_Issue_Purchase_Return_Request.style,
                            brand = add.System_Records_Issue_Purchase_Return_Request.brand,
                            color = add.System_Records_Issue_Purchase_Return_Request.color,
                            agent = add.System_Records_Issue_Purchase_Return_Request.agent,
                            dealer = add.System_Records_Issue_Purchase_Return_Request.dealer,
                            round_off = add.System_Records_Issue_Purchase_Return_Request.round_off,
                            transporter_cartage_yn = add.System_Records_Issue_Purchase_Return_Request.transporter_cartage_yn,
                            maintain_accounting_yn = add.System_Records_Issue_Purchase_Return_Request.maintain_accounting_yn,

                            hsn_code_yn = add.System_Records_Issue_Purchase_Return_Request.hsn_code_yn,
                            packing_type_yn = add.System_Records_Issue_Purchase_Return_Request.packing_type_yn,
                            scheme_type_yn = add.System_Records_Issue_Purchase_Return_Request.scheme_type_yn,
                            remarks_yn = add.System_Records_Issue_Purchase_Return_Request.remarks_yn,
                            sale_rate_yn = add.System_Records_Issue_Purchase_Return_Request.sale_rate_yn,
                            issue_qty_yn = add.System_Records_Issue_Purchase_Return_Request.issue_qty_yn,
                            discount_percentage_yn = add.System_Records_Issue_Purchase_Return_Request.discount_percentage_yn,
                            grand_total_yn = add.System_Records_Issue_Purchase_Return_Request.grand_total_yn,
                            gst_percentage_yn = add.System_Records_Issue_Purchase_Return_Request.gst_percentage_yn,
                            rate_after_gst_yn = add.System_Records_Issue_Purchase_Return_Request.rate_after_gst_yn,
                            total_amount_yn = add.System_Records_Issue_Purchase_Return_Request.total_amount_yn,
                            current_stock_yn = add.System_Records_Issue_Purchase_Return_Request.current_stock_yn,
                            balance_qty_yn = add.System_Records_Issue_Purchase_Return_Request.balance_qty_yn
                        };
                        DB.System_Records.Add(admit1);
                    }
                }




                // voucher recipted
                if (add.System_Records_Voucher_Recipted_Request != null)
                {
                    var result6 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Voucher_Recipted_Request.irflag && s.id == add.System_Records_Voucher_Recipted_Request.id);
                    if (result6 != null)
                    {
                        result6.gst_percentage_yn = add.System_Records_Voucher_Recipted_Request.gst_percentage_yn;
                        result6.gst_amount_yn = add.System_Records_Voucher_Recipted_Request.gst_amount_yn;
                        result6.grand_total_yn = add.System_Records_Voucher_Recipted_Request.grand_total_yn;
                        result6.irflag = add.System_Records_Voucher_Recipted_Request.irflag;

                    }
                    else
                    {
                        System_Records admit6 = new System_Records()
                        {
                            gst_percentage_yn = add.System_Records_Voucher_Recipted_Request.gst_percentage_yn,
                            gst_amount_yn = add.System_Records_Voucher_Recipted_Request.gst_amount_yn,
                            grand_total_yn = add.System_Records_Voucher_Recipted_Request.grand_total_yn,
                            irflag = add.System_Records_Voucher_Recipted_Request.irflag,
                        };
                        DB.System_Records.Add(admit6);
                    }
                }

                // voucher Payment
                if (add.System_Records_Voucher_Payment_Request != null)
                {
                    var result7 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Voucher_Payment_Request.irflag && s.id == add.System_Records_Voucher_Payment_Request.id);
                    if (result7 != null)
                    {
                        result7.gst_percentage_yn = add.System_Records_Voucher_Payment_Request.gst_percentage_yn;
                        result7.gst_amount_yn = add.System_Records_Voucher_Payment_Request.gst_amount_yn;
                        result7.grand_total_yn = add.System_Records_Voucher_Payment_Request.grand_total_yn;
                        result7.irflag = add.System_Records_Voucher_Payment_Request.irflag;

                    }
                    else
                    {
                        System_Records admit6 = new System_Records()
                        {
                            gst_percentage_yn = add.System_Records_Voucher_Payment_Request.gst_percentage_yn,
                            gst_amount_yn = add.System_Records_Voucher_Payment_Request.gst_amount_yn,
                            grand_total_yn = add.System_Records_Voucher_Payment_Request.grand_total_yn,
                            irflag = add.System_Records_Voucher_Payment_Request.irflag,
                        };
                        DB.System_Records.Add(admit6);
                    }
                }

                // voucher Contra
                if (add.System_Records_Voucher_Contra_Request != null)
                {
                    var result8 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Voucher_Contra_Request.irflag && s.id == add.System_Records_Voucher_Contra_Request.id);
                    if (result8 != null)
                    {
                        result8.gst_percentage_yn = add.System_Records_Voucher_Contra_Request.gst_percentage_yn;
                        result8.gst_amount_yn = add.System_Records_Voucher_Contra_Request.gst_amount_yn;
                        result8.grand_total_yn = add.System_Records_Voucher_Contra_Request.grand_total_yn;
                        result8.irflag = add.System_Records_Voucher_Contra_Request.irflag;

                    }
                    else
                    {
                        System_Records admit6 = new System_Records()
                        {
                            gst_percentage_yn = add.System_Records_Voucher_Contra_Request.gst_percentage_yn,
                            gst_amount_yn = add.System_Records_Voucher_Contra_Request.gst_amount_yn,
                            grand_total_yn = add.System_Records_Voucher_Contra_Request.grand_total_yn,
                            irflag = add.System_Records_Voucher_Contra_Request.irflag,
                        };
                        DB.System_Records.Add(admit6);
                    }
                }


                // voucher Journal
                if (add.System_Records_Voucher_Journal_Request != null)
                {
                    var result9 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Voucher_Journal_Request.irflag && s.id == add.System_Records_Voucher_Journal_Request.id);
                    if (result9 != null)
                    {
                        result9.gst_percentage_yn = add.System_Records_Voucher_Journal_Request.gst_percentage_yn;
                        result9.gst_amount_yn = add.System_Records_Voucher_Journal_Request.gst_amount_yn;
                        result9.grand_total_yn = add.System_Records_Voucher_Journal_Request.grand_total_yn;
                        result9.irflag = add.System_Records_Voucher_Journal_Request.irflag;

                    }
                    else
                    {
                        System_Records admit6 = new System_Records()
                        {
                            gst_percentage_yn = add.System_Records_Voucher_Journal_Request.gst_percentage_yn,
                            gst_amount_yn = add.System_Records_Voucher_Journal_Request.gst_amount_yn,
                            grand_total_yn = add.System_Records_Voucher_Journal_Request.grand_total_yn,
                            irflag = add.System_Records_Voucher_Journal_Request.irflag,
                        };
                        DB.System_Records.Add(admit6);
                    }
                }

                // voucher Credit
                if (add.System_Records_Voucher_Credit_Request != null)
                {
                    var result10 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Voucher_Credit_Request.irflag && s.id == add.System_Records_Voucher_Credit_Request.id);
                    if (result10 != null)
                    {
                        result10.gst_percentage_yn = add.System_Records_Voucher_Credit_Request.gst_percentage_yn;
                        result10.gst_amount_yn = add.System_Records_Voucher_Credit_Request.gst_amount_yn;
                        result10.grand_total_yn = add.System_Records_Voucher_Credit_Request.grand_total_yn;
                        result10.irflag = add.System_Records_Voucher_Credit_Request.irflag;

                    }
                    else
                    {
                        System_Records admit6 = new System_Records()
                        {
                            gst_percentage_yn = add.System_Records_Voucher_Credit_Request.gst_percentage_yn,
                            gst_amount_yn = add.System_Records_Voucher_Credit_Request.gst_amount_yn,
                            grand_total_yn = add.System_Records_Voucher_Credit_Request.grand_total_yn,
                            irflag = add.System_Records_Voucher_Credit_Request.irflag,
                        };
                        DB.System_Records.Add(admit6);
                    }
                }

                // voucher Debit
                if (add.System_Records_Voucher_Debit_Request != null)
                {
                    var result11 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Voucher_Debit_Request.irflag && s.id == add.System_Records_Voucher_Debit_Request.id);
                    if (result11 != null)
                    {
                        result11.gst_percentage_yn = add.System_Records_Voucher_Debit_Request.gst_percentage_yn;
                        result11.gst_amount_yn = add.System_Records_Voucher_Debit_Request.gst_amount_yn;
                        result11.grand_total_yn = add.System_Records_Voucher_Debit_Request.grand_total_yn;
                        result11.irflag = add.System_Records_Voucher_Debit_Request.irflag;

                    }
                    else
                    {
                        System_Records admit6 = new System_Records()
                        {
                            gst_percentage_yn = add.System_Records_Voucher_Debit_Request.gst_percentage_yn,
                            gst_amount_yn = add.System_Records_Voucher_Debit_Request.gst_amount_yn,
                            grand_total_yn = add.System_Records_Voucher_Debit_Request.grand_total_yn,
                            irflag = add.System_Records_Voucher_Debit_Request.irflag,
                        };
                        DB.System_Records.Add(admit6);
                    }
                }
                DB.SaveChanges();



                // AMC MASTER
               /* if (add.System_Records_Issue_Purchase_Request != null)
                {
                    var result2 = DB.System_Records.FirstOrDefault(s => s.irflag == add.System_Records_Issue_Purchase_Request.irflag && s.id == add.System_Records_Issue_Purchase_Request.id);
                    if (result2 != null)
                    {
                        result2.purchase_rate_yn = add.System_Records_Issue_Purchase_Request.purchase_rate_yn;
                        result2.profit_yn = add.System_Records_Issue_Purchase_Request.profit_yn;
                        result2.discount_amount_yn = add.System_Records_Issue_Purchase_Request.discount_amount_yn;
                        result2.discount_rate_yn = add.System_Records_Issue_Purchase_Request.discount_rate_yn;
                        result2.gst_amount_yn = add.System_Records_Issue_Purchase_Request.gst_amount_yn;
                        result2.total_profit_yn = add.System_Records_Issue_Purchase_Request.total_profit_yn;
                        result2.total_weight_yn = add.System_Records_Issue_Purchase_Request.total_weight_yn;
                        result2.gst_rate_yn = add.System_Records_Issue_Purchase_Request.gst_rate_yn;

                        result2.challan_master_method = add.System_Records_Issue_Purchase_Request.challan_master_method;
                        result2.cart_tcs_value = add.System_Records_Issue_Purchase_Request.cart_tcs_value;
                        result2.batch_no = add.System_Records_Issue_Purchase_Request.batch_no;
                        result2.style = add.System_Records_Issue_Purchase_Request.style;
                        result2.brand = add.System_Records_Issue_Purchase_Request.brand;
                        result2.color = add.System_Records_Issue_Purchase_Request.color;
                        result2.agent = add.System_Records_Issue_Purchase_Request.agent;
                        result2.dealer = add.System_Records_Issue_Purchase_Request.dealer;
                        result2.round_off = add.System_Records_Issue_Purchase_Request.round_off;
                        result2.transporter_cartage_yn = add.System_Records_Issue_Purchase_Request.transporter_cartage_yn;
                        result2.maintain_accounting_yn = add.System_Records_Issue_Purchase_Request.maintain_accounting_yn;

                        result2.hsn_code_yn = add.System_Records_Issue_Purchase_Request.hsn_code_yn;
                        result2.packing_type_yn = add.System_Records_Issue_Purchase_Request.packing_type_yn;
                        result2.scheme_type_yn = add.System_Records_Issue_Purchase_Request.scheme_type_yn;
                        result2.remarks_yn = add.System_Records_Issue_Purchase_Request.remarks_yn;
                        result2.sale_rate_yn = add.System_Records_Issue_Purchase_Request.sale_rate_yn;
                        result2.issue_qty_yn = add.System_Records_Issue_Purchase_Request.issue_qty_yn;
                        result2.discount_percentage_yn = add.System_Records_Issue_Purchase_Request.discount_percentage_yn;
                        result2.grand_total_yn = add.System_Records_Issue_Purchase_Request.grand_total_yn;
                        result2.gst_percentage_yn = add.System_Records_Issue_Purchase_Request.gst_percentage_yn;
                        result2.rate_after_gst_yn = add.System_Records_Issue_Purchase_Request.rate_after_gst_yn;
                        result2.total_amount_yn = add.System_Records_Issue_Purchase_Request.total_amount_yn;
                        result2.current_stock_yn = add.System_Records_Issue_Purchase_Request.current_stock_yn;
                        result2.balance_qty_yn = add.System_Records_Issue_Purchase_Request.balance_qty_yn;
                    }
                    else
                    {
                        System_Records admit1 = new System_Records()
                        {
                            purchase_rate_yn = add.System_Records_Issue_Purchase_Request.purchase_rate_yn,
                            profit_yn = add.System_Records_Issue_Purchase_Request.profit_yn,
                            discount_amount_yn = add.System_Records_Issue_Purchase_Request.discount_amount_yn,
                            discount_rate_yn = add.System_Records_Issue_Purchase_Request.discount_rate_yn,
                            gst_amount_yn = add.System_Records_Issue_Purchase_Request.gst_amount_yn,
                            total_profit_yn = add.System_Records_Issue_Purchase_Request.total_profit_yn,
                            total_weight_yn = add.System_Records_Issue_Purchase_Request.total_weight_yn,
                            gst_rate_yn = add.System_Records_Issue_Purchase_Request.gst_rate_yn,
                            irflag = add.System_Records_Issue_Purchase_Request.irflag,

                            challan_master_method = add.System_Records_Issue_Purchase_Request.challan_master_method,
                            cart_tcs_value = add.System_Records_Issue_Purchase_Request.cart_tcs_value,
                            batch_no = add.System_Records_Issue_Purchase_Request.batch_no,
                            style = add.System_Records_Issue_Purchase_Request.style,
                            brand = add.System_Records_Issue_Purchase_Request.brand,
                            color = add.System_Records_Issue_Purchase_Request.color,
                            agent = add.System_Records_Issue_Purchase_Request.agent,
                            dealer = add.System_Records_Issue_Purchase_Request.dealer,
                            round_off = add.System_Records_Issue_Purchase_Request.round_off,
                            transporter_cartage_yn = add.System_Records_Issue_Purchase_Request.transporter_cartage_yn,
                            maintain_accounting_yn = add.System_Records_Issue_Purchase_Request.maintain_accounting_yn,

                            hsn_code_yn = add.System_Records_Issue_Purchase_Request.hsn_code_yn,
                            packing_type_yn = add.System_Records_Issue_Purchase_Request.packing_type_yn,
                            scheme_type_yn = add.System_Records_Issue_Purchase_Request.scheme_type_yn,
                            remarks_yn = add.System_Records_Issue_Purchase_Request.remarks_yn,
                            sale_rate_yn = add.System_Records_Issue_Purchase_Request.sale_rate_yn,
                            issue_qty_yn = add.System_Records_Issue_Purchase_Request.issue_qty_yn,
                            discount_percentage_yn = add.System_Records_Issue_Purchase_Request.discount_percentage_yn,
                            grand_total_yn = add.System_Records_Issue_Purchase_Request.grand_total_yn,
                            gst_percentage_yn = add.System_Records_Issue_Purchase_Request.gst_percentage_yn,
                            rate_after_gst_yn = add.System_Records_Issue_Purchase_Request.rate_after_gst_yn,
                            total_amount_yn = add.System_Records_Issue_Purchase_Request.total_amount_yn,
                            current_stock_yn = add.System_Records_Issue_Purchase_Request.current_stock_yn,
                            balance_qty_yn = add.System_Records_Issue_Purchase_Request.balance_qty_yn

                        };
                        DB.System_Records.Add(admit1);
                    }
                }*/

                return new System_Records_ModelResponse
                {
                    status = true,
                    Message = "Update successfully"
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
            query = query.Where(e => e.irflag == "system").OrderByDescending(admission => admission.id);

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
            long MaxId = (long)DB.System_Records.Where(e=> e.irflag == "system").Max(u => u.id);
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


        public System_Records_ModelResponse GetSystem_RecordsByIdWithFlag(string flag)
        {
           
            long IssueSaleMaxId = (long)DB.System_Records
                        .Where(u => u.irflag == flag)
                        .Max(u => u.id);

            System_Records IssueSaleDetail = DB.System_Records
                                            .Where(e => e.id == IssueSaleMaxId && e.irflag == flag)
                                            .SingleOrDefault();

            System_Records_ModelResponse data = new System_Records_ModelResponse()
            {
                status = true,
                Message = "Data Fetched Successfully ",
                System_RecordsDataById = IssueSaleDetail
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