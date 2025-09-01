using System;
using DB.Login;
using DB.RTAComp;
using DB.Login.Tables;
using System.Linq;
using RTA.Masters.Models;
using System.Text.RegularExpressions;

namespace RTA.Masters;
public class CompMstBLL
{
    private loginDBContext DB;
    private string DBConnStr;

    public CompMstBLL(string _DBConnStr)
    {
        DBConnStr = _DBConnStr;
        DB = loginDBContextFactory.Create(DBConnStr);
    }
    public ModelCompData GetCompData()
    {
        ModelCompData data = new ModelCompData()
        {
            status = true,
            Message = "",
            CompMasters = DB.Comp_Selection_Master.ToList()
        };
        return data;
    }

    public ModelCompData GetCompDataById(long id)
    {
        ModelCompData data = new ModelCompData()
        {
            status = true,
            Message = "",
            CompMasters = DB.Comp_Selection_Master.ToList()
        };
        return data;
    }

    private string Comp_db_name(string comp_name)
    {
        string Comp_full_name = comp_name;
        string ShortName = "";
        Comp_full_name.Split(' ').ToList().ForEach(i =>
        {
            if (Regex.IsMatch(i[0].ToString(), @"^[a-zA-Z]+$"))
            {
                ShortName += i[0].ToString().ToLower();
            }
        });
        return ShortName;
    }

    // saerch comapny 
    public ModelCompData SearchCompName(int id)
    {
        ModelCompData data = new ModelCompData()
        {
            status = true,
            Message = "",
            CompMasters = DB.Comp_Selection_Master.Where(x => x.id == id).Select(m => new Comp_Selection_Master
            {
                id = m.id,
                c_comp_name = m.c_comp_name + "#" + m.c_comp_isin,
                //c_comp_name = m.c_add1 + " " + m.c_add2 + " " + m.c_add3 + " " + m.c_add4,
            }).ToList(),
        };
        return data;
    }

    //create new company
    public ModelCompData NewComp(ModelGenCompReq CompReq, ModelCompDBParas CompDBParas,string username)
    {
        try
        {

            long compID = 101;

            if (DB.Comp_Selection_Master.Count() > 0)
            {
                compID = DB.Comp_Selection_Master.Max(x => x.id) + 1;

            }

            string prefix = Comp_db_name(CompReq.c_comp_name);
            string middle_prt = "_" + compID.ToString();
            string suffix = "_rta";


            string dbname = prefix + middle_prt + suffix;

            string sname = prefix + middle_prt ;

            Comp_Selection_Master Comp = new Comp_Selection_Master()
            {
                id = compID,
                c_comp_isin = CompReq.c_comp_isin,
                c_comp_name = CompReq.c_comp_name,
                c_comp_short_name = sname,
                c_paid_up_capital = CompReq.c_paid_up_capital,
                c_add1 = CompReq.c_add1,
                c_add2 = CompReq.c_add2,
                c_add3 = CompReq.c_add3,
                c_add4 = CompReq.c_add4,
                c_city = CompReq.c_city,
                c_database_name = dbname,
                c_state = CompReq.c_state,
                c_state_code = CompReq.c_state_code,
                c_email = CompReq.c_email,
                c_website = CompReq.c_website,
                c_phones = CompReq.c_phones,
                c_contact_person = CompReq.c_contact_person,
                c_gstin = CompReq.c_gstin,
                c_gst_type = CompReq.c_gst_type,
                c_pan = CompReq.c_pan,
                c_bank_ac_no = CompReq.c_bank_ac_no,
                c_bank_name = CompReq.c_bank_name,
                c_badd1 = CompReq.c_badd1,
                c_badd2 = CompReq.c_badd2,
                c_badd3 = CompReq.c_badd3,
                c_bcity = CompReq.c_bcity,
                c_bstate = CompReq.c_bstate,
                c_bstate_code = CompReq.c_bstate_code,
                c_bank_ifsc = CompReq.c_bank_ifsc,
                c_bank_micr = CompReq.c_bank_micr,
                c_create_date = DateTime.Now,
                //c_temp_comp_id = CompReq.c_temp_comp_id,
                c_share_face_value = CompReq.c_share_face_value,
                c_folio_no_auto_yn = CompReq.c_folio_no_auto_yn,
                c_company_type = CompReq.c_company_type,
                c_cin_bcin_no = CompReq.c_cin_bcin_no,
                c_company_code = CompReq.c_company_code,
                c_company_sub_code = CompReq.c_company_sub_code,
                c_more_isin_yn = CompReq.c_more_isin_yn,
                c_master_comp_isin = CompReq.c_master_comp_isin,
                c_master_comp_code = CompReq.c_master_comp_code,
                c_master_comp_name = CompReq.c_master_comp_name,
                c_nsdl_conn_yn = CompReq.c_nsdl_conn_yn,
                c_cdsl_conn_yn = CompReq.c_cdsl_conn_yn,
                c_phy_shares_yn = CompReq.c_phy_shares_yn,
                c_tan = CompReq.c_tan,
                c_isin_detail = CompReq.c_isin_detail,
                c_pay_term_days = CompReq.c_pay_term_days,
                c_pay_term_detail = CompReq.c_pay_term_detail,
                c_other_detail = CompReq.c_other_detail,
                c_d_o_activate = CompReq.c_d_o_activate,
                c_d_o_apply = CompReq.c_d_o_apply,
                c_d_o_creation = CompReq.c_d_o_creation,
                c_created_by = username,
                c_d_o_updation = CompReq.c_d_o_updation,
                //c_updated_by = CompReq.c_updated_by,
                c_contact_person2 = CompReq.c_contact_person2,
                c_contact_ph = CompReq.c_contact_ph,
                c_contact_ph2 = CompReq.c_contact_ph2,
                c_contact_p_email = CompReq.c_contact_p_email,
                c_contact_p_email2 = CompReq.c_contact_p_email2,
                c_add1_2 = CompReq.c_add1_2,
                c_add2_2 = CompReq.c_add2_2,
                c_add3_2 = CompReq.c_add3_2,
                c_city2 = CompReq.c_city2,
                c_pincode_2 = CompReq.c_pincode_2,
                c_state2 = CompReq.c_state2,
                c_state_code2 = CompReq.c_state_code2,
                c_list_to_email_yn = CompReq.c_list_to_email_yn,
                c_rep_top10_email_yn = CompReq.c_rep_top10_email_yn,
                c_other_rpt_email_yn = CompReq.c_other_rpt_email_yn,
                c_source_email_yn = CompReq.c_source_email_yn,
                //c_comp_auto_id = CompReq.c_comp_auto_id,
                c_maintain_type = CompReq.c_maintain_type,
                c_data_tyep_description = CompReq.c_data_tyep_description,
                c_isin_type = CompReq.c_isin_type,
                c_phy_demat_both = CompReq.c_phy_demat_both,
                c_pincode = CompReq.c_pincode,
                c_group_name = CompReq.c_group_name,
                c_issuer_code = CompReq.c_issuer_code,
                c_phy_conn_yn = CompReq.c_phy_conn_yn,
                c_rep_weekly_email_yn = CompReq.c_rep_weekly_email_yn,
                c_company_old_code = CompReq.c_company_old_code,
                c_tot_equity = CompReq.c_tot_equity,
                cin_bcin_no = CompReq.cin_bcin_no,
                folio_no_auto_yn = CompReq.folio_no_auto_yn,
                //temp_comp_id = CompReq.temp_comp_id,
                c_tot_equity_fully = CompReq.c_tot_equity_fully,
                c_tot_equity_partly = CompReq.c_tot_equity_partly,
                c_share_face_value_partly = CompReq.c_share_face_value_partly,
                c_sign_image_path_auto_yn = CompReq.c_sign_image_path_auto_yn,
                c_scrip_code = CompReq.c_scrip_code,
                c_name_of_scrip = CompReq.c_name_of_scrip,
                c_class_of_security = CompReq.c_class_of_security,
                folio_convert_to_numrice_yn = CompReq.folio_convert_to_numrice_yn,
                cert_convert_to_numrice_yn = CompReq.cert_convert_to_numrice_yn,
                //test_coloum = CompReq.test_coloum,
                listing_on_bse_nse = CompReq.listing_on_bse_nse,
                company_agreement_type = CompReq.company_agreement_type,
                start_date_agree = CompReq.start_date_agree,
                end_date_agree = CompReq.end_date_agree,
                company_status = CompReq.company_status,
                folio_lenght = CompReq.folio_lenght,
                listing_on_bse_yn = CompReq.listing_on_bse_yn,
                listing_on_nse_yn = CompReq.listing_on_nse_yn,
                listing_on_mse_yn = CompReq.listing_on_mse_yn,

            };

            DB.Comp_Selection_Master.Add(Comp);

            DB.Comp_DB.Add(new Comp_DB()
            {
                CompMstId = compID,
                db_name = dbname,
                db_user = CompDBParas.userId,
                db_pass = CompDBParas.password,
                server = CompDBParas.server_ip
            });

            DB.Partymaster.Add(new Partymaster()
            {
                company_name = CompReq.c_comp_name,
                email_address = CompReq.c_email,
                website_address = CompReq.c_website,
                add1 = CompReq.c_add1,
                add2 = CompReq.c_add2,
                add3 = CompReq.c_add3,
                add4 = CompReq.c_add4,
                add5 = CompReq.c_city,
                add6 = CompReq.c_state,
                add7 = CompReq.c_state_code,
                isin_no = CompReq.c_comp_isin,
                entry_date_time = DateTime.Now,
                gstin_no = CompReq.c_gstin,
                comp_id = compID

            });

            DB.User_Detail.Add(new User_Detail()
            {
                user_code = CompReq.c_contact_ph,
                user_pass = sname+"@123",
                user_profile = "company",
                user_name = CompReq.c_contact_person,
                //user_mobile = CompReq.c_contact_ph2,
                user_email = CompReq.c_contact_p_email,
                comp_name = CompReq.c_comp_name,
                comp_id = compID

            });

            Console.WriteLine("checkpoint 2");
            DB.SaveChanges();
            Console.WriteLine("checkpoint 3");

            string ConnStr = "SERVER=" + CompDBParas.server_ip + ";" +
                    "PORT=3306;DATABASE=" + dbname + ";USER ID=" + CompDBParas.userId + "; " +
                    "PASSWORD=" + CompDBParas.password + ";Pooling=false;" +
                    "Allow User Variables=True;";

            new compDbContextFactory().MigrateDbContext(ConnStr);

            ModelCompData Resp = new ModelCompData()
            {
                status = true,
                Message = "The company has been created successfully"
            };

            Console.WriteLine("comp data : " + Resp.status);


            return Resp;

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.InnerException.Message);
            throw new Exception("Error : " + ex.Message);
        }

    }

}
