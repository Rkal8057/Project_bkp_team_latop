using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Collections.Generic;

namespace RTA.Masters
{
    public class FormMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public FormMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public FormMasterResp InsertFormMaster(FormMasterReq samp,User_Detail user)
        {
            Form_Master SampData = new Form_Master()
            {
                form_id = samp.form_id,
                form_name = samp.form_name,
                form_table = samp.form_table,
                form_type = samp.form_type,
                form_created_type = samp.form_created_type,
                form_for_id = samp.form_for_id,
                form_for = samp.form_for,
                form_significance = samp.form_significance,
                form_title = samp.form_title,
                form_sub_title = samp.form_sub_title,
                form_save = samp.form_save,
                form_head = samp.form_head,
                form_groups = samp.form_groups,
                form_groups_hidden = samp.form_groups_hidden,
                form_created_on = DateTime.Now, // Assuming you want to set this to the current time
                form_updated_on = DateTime.Now, // Assuming you want to set this to the current time
                form_verification = samp.form_verification,
                form_status = samp.form_status,
                form_search_control_name = samp.form_search_control_name,
                form_view_control_name = samp.form_view_control_name,
                docu_form_for = samp.docu_form_for,
                docu_form_type = samp.docu_form_type,
                sub_cate = samp.sub_cate,
                segm = samp.segm,
                gran_acce_to_prof = samp.gran_acce_to_prof,
                grant_access_profile = samp.grant_access_profile,
                form_display_in_dashboard = samp.form_display_in_dashboard,
                form_group = samp.form_group,
                active_section = samp.active_section,
                stock_field_name = samp.stock_field_name,
                form_have_stock_item = samp.form_have_stock_item,
                stock_field_name_2 = samp.stock_field_name_2,
                stock_field_display_name = samp.stock_field_display_name,
                quick_menu_yn = samp.quick_menu_yn,
                quick_link_menu_yn = samp.quick_link_menu_yn,
                stock_field_name_4_min_inventory = samp.stock_field_name_4_min_inventory,
                user_id = user.id,
                user_name = user.user_name,
                user_mobile = user.user_mobile,
                user_profile = user.user_profile,
                // updated_on = DateTime.Now
            };

            DB.Form_Master.Add(SampData);
            DB.SaveChanges();

            FormMasterResp data = new FormMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public FormMasterResp UpdateFormMaster(long Id, FormMasterReq samp,User_Detail user)
        {
            var existingForm = DB.Form_Master.Find(Id);

            if (existingForm == null)
            {
                FormMasterResp data1 = new FormMasterResp()
                {
                    status = false,
                    Message = "Client not found"
                };

                return data1;
            }

            existingForm.form_name = samp.form_name;
            existingForm.form_table = samp.form_table;
            existingForm.form_type = samp.form_type;
            existingForm.form_created_type = samp.form_created_type;
            existingForm.form_for_id = samp.form_for_id;
            existingForm.form_for = samp.form_for;
            existingForm.form_significance = samp.form_significance;
            existingForm.form_title = samp.form_title;
            existingForm.form_sub_title = samp.form_sub_title;
            existingForm.form_save = samp.form_save;
            existingForm.form_head = samp.form_head;
            existingForm.form_groups = samp.form_groups;
            existingForm.form_groups_hidden = samp.form_groups_hidden;
            existingForm.form_verification = samp.form_verification;
            existingForm.form_status = samp.form_status;
            existingForm.form_search_control_name = samp.form_search_control_name;
            existingForm.form_view_control_name = samp.form_view_control_name;
            existingForm.docu_form_for = samp.docu_form_for;
            existingForm.docu_form_type = samp.docu_form_type;
            existingForm.sub_cate = samp.sub_cate;
            existingForm.segm = samp.segm;
            existingForm.gran_acce_to_prof = samp.gran_acce_to_prof;
            existingForm.grant_access_profile = samp.grant_access_profile;
            existingForm.form_display_in_dashboard = samp.form_display_in_dashboard;
            existingForm.form_group = samp.form_group;
            existingForm.active_section = samp.active_section;
            existingForm.stock_field_name = samp.stock_field_name;
            existingForm.form_have_stock_item = samp.form_have_stock_item;
            existingForm.stock_field_name_2 = samp.stock_field_name_2;
            existingForm.stock_field_display_name = samp.stock_field_display_name;
            existingForm.quick_menu_yn = samp.quick_menu_yn;
            existingForm.quick_link_menu_yn = samp.quick_link_menu_yn;
            existingForm.stock_field_name_4_min_inventory = samp.stock_field_name_4_min_inventory;
            existingForm.form_updated_on = DateTime.Now;
            existingForm.user_id = user.id;
            existingForm.user_name = user.user_name;
            existingForm.user_mobile = user.user_mobile;
            existingForm.user_profile = user.user_profile;
            //existingForm.form_updated_on = DateTime.Now;
            DB.SaveChanges();

            FormMasterResp data = new FormMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }
        public FormMasterResp DeleteFormMaster(int ID)
        {
            Form_Master del = DB.Form_Master.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.Form_Master.Remove(del);
            DB.SaveChanges();
            FormMasterResp data = new FormMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }
        public FormMasterResp GetFormMasterById(long Id)
        {
            FormMasterResp data = new FormMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                FormMasterData = DB.Form_Master.Where(e => e.id == Id).ToList()
            };
            return data;
        }

        public FormMasterResp GetFormMaster(string? search)
        {
            // Initialize the response model
            FormMasterResp data = new FormMasterResp();

            try
            {

                var query = DB.Form_Master.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(record =>
                           record.form_name.Contains(search) ||
                    record.form_table.Contains(search) ||
                    record.form_type.Contains(search));
                    //admission.class_detail.Contains(search) ||
                    //admission.class_display_name.Contains(search));
                }

                query = query.OrderByDescending(admission => admission.id);
                var admissionData = query.Take(10).ToList();

                // Set the response data
                data.status = true;
                data.Message = "Data fetched successfully";
                data.FormMasterData = admissionData;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                data.status = false;
                data.Message = "An error occurred while fetching data: " + ex.Message;
                data.FormMasterData = null; // Set data to null or an empty list
            }

            return data;
        }

        public FormMasterResp GetDisplayeMenu(User_Detail user)
        {
            // Initialize the response model
            FormMasterResp data = new FormMasterResp();          

            try
            {
                // Fetch all data in a single query
                var subMenuNames = DB.Multi_Purpose_Type_Master
                                    .Where(s => s.multi_purpose_flag == "form_type")
                                    .Select(s => new { s.multi_purpose_type , s.auto_id , s.exchange_name})
                                    .OrderBy(s => s.auto_id)
                                    .ToList();

                var formMasters = DB.Form_Master
                                   .Select(s => new { s.form_type, s.form_name, s.form_table, s.grant_access_profile, s.form_id })
                                   .OrderBy(s => s.form_id)
                                   .ToList();
                var userProfile = DB.User_Profile_Master
                     .Where(up => up.id == user.user_profile_id)
                     .Select(up => up.user_profile)
                     .FirstOrDefault();

                if (userProfile == null)
                {
                    throw new Exception("User profile not found");
                }

                List<DisplayeMenu> displayeMenus = new List<DisplayeMenu>();
                foreach (var subMenu in subMenuNames)
                {
                    DisplayeMenu displayeMenu = new DisplayeMenu
                    {
                        subMenuName = subMenu.multi_purpose_type,
                        icon = "bi bi-card-text",
                        href = subMenu.exchange_name ?? "#",
                        subMenuItems = new List<MenuItem>()
                    };

                    var menuItems = formMasters
                                    .Where(fm => fm.form_type == subMenu.multi_purpose_type
                                    && fm.grant_access_profile.Contains(userProfile))
                                    .Select(fm => new MenuItem
                                    {
                                        title = fm.form_name,
                                        href = fm.form_table,
                                        icon = "bi bi-card-text"
                                    })
                                    .ToList();

                    displayeMenu.subMenuItems.AddRange(menuItems);
                    displayeMenus.Add(displayeMenu);
                }




                // Set the response data
                data.status = true;
                data.Message = "Data fetched successfully";
                data.DisplayeMenus = displayeMenus;
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                data.status = false;
                data.Message = "An error occurred while fetching data: " + ex.Message;
                data.FormMasterData = null; // Set data to null or an empty list
            }

            return data;
        }

    }
}
