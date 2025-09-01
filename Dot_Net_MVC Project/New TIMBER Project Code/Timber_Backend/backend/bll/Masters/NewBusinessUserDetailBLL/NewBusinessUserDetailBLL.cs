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
    public class NewBusinessUserDetailBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public NewBusinessUserDetailBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public NewBusinessUserDetailResp CreateNewBusinessUserDetail(NewBusinessUserDetailReq samp)
        {

            User_Detail checkuser = DB.User_Detail.Where(e => e.id == samp.id).FirstOrDefault();
            
            BusinessUserDetail SampData = null;
            if (checkuser == null)
            {
                throw new Exception("User are not exits so please create the account");
            }
            else
            {
                SampData  = new BusinessUserDetail()
                {
                    user_name = checkuser.user_name,
                    user_ph = checkuser.user_mobile.ToString(),
                    user_email = checkuser.user_email,
                    delete = 0,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    user_profile_id = checkuser.id,
                    user_flag = samp.user_flag
                    //user_title = checkuser.,
                    //user_company = checkuser.user_company,
                    //user_img = checkuser.user_img,
                    //party_id = checkuser.party_id,
                    //party_name = checkuser.party_name,
                    //theme_color = checkuser.theme_color,
                };

                DB.BusinessUserDetail.Add(SampData);
                DB.SaveChanges();
            }



            // Check if BusinessSectionDataByIDType is not null
            if (samp.NewBusinessSectionDataByIDType != null)
            {
                // Loop through each section in BusinessSectionDataByIDType
                foreach (var sectionData in samp.NewBusinessSectionDataByIDType)
                {
                    // Create a new section entry
                    BussinessUserSectionDetail newSection = new BussinessUserSectionDetail()
                    {
                        title = sectionData.Section.title,
                        title_alignment = sectionData.Section.title_alignment,
                        title_bold = sectionData.Section.title_bold,
                        title_font_size = sectionData.Section.title_font_size,
                        section_position = sectionData.Section.section_position,
                        delete = 0,
                        business_user_detail_id = SampData.id, // Assign user id from samp.id
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now,
                        business_section_hide = sectionData.Section.business_section_hide,
                        section_multiple = sectionData.Section.section_multiple,
                        section_flag = samp.user_flag,                        
                    };

                    // Add new section to the database and save changes to get the Section ID
                    DB.BussinessUserSectionDetail.Add(newSection);
                    DB.SaveChanges();

                    // Check if there are any contents in the section
                    if (sectionData.Contents != null && sectionData.Contents.Count > 0)
                    {
                        foreach (var contentData in sectionData.Contents)
                        {
                            // Create a new content entry for each content in the section
                            BussinessUserContentDetail newContent = new BussinessUserContentDetail()
                            {
                                type = contentData.type,
                                label = contentData.label,
                                value = contentData.value,
                                label_bold = contentData.label_bold,
                                drop_value = contentData.drop_value,
                                value_bold = contentData.value_bold,
                                alignment = contentData.alignment,
                                icon = contentData.icon,
                                button_alignment = contentData.button_alignment,
                                content_position = contentData.content_position,
                                delete = 0,
                                business_section_name = contentData.business_section_name,
                                business_user_detail_id = SampData.id, // Assign the user ID from samp
                                business_section_id = newSection.id, // Assign the section ID from the newly created section
                                created_at = DateTime.Now,
                                updated_at = DateTime.Now,
                                business_content_hide = contentData.business_content_hide,
                                content_flag = samp.user_flag
                            };

                            // Add new content to the database
                            DB.BussinessUserContentDetail.Add(newContent);
                        }

                        // Save all the new content details after looping through the contents
                        DB.SaveChanges();
                    }
                }
            }

            // Create and return the response object
            NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
            {
                status = true,
                Message = "Inserted successfully",
            };

            return data;
        }

        public NewBusinessUserDetailResp GetBusinessCardByuserId(long bUserId)
        {

            var userDetail = DB.BusinessUserDetail
                    .Where(e=> e.user_profile_id ==  bUserId).ToList();   

             NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                 BusinessUserDetailData = userDetail,
            };
            return data;
        }

        public NewBusinessUserDetailResp GetBusinessCardWithSectionContentById(long bUserid )
        {

            var sectionsWithContents = DB.BussinessUserSectionDetail
               .Where(section => section.delete == 0 && 
                        section.business_user_detail_id == bUserid )
               .OrderBy(section => section.section_position)
               .Select(section => new
               {
                   Section = section,
                   Contents = DB.BussinessUserContentDetail
                       .Where(content => content.business_section_id == section.id && 
                              content.delete == 0 && 
                              content.business_user_detail_id == bUserid ) 
                       .OrderBy(content => content.content_position)
                       .ToList()
               })
               .ToList();

            var userDetail = DB.BusinessUserDetail
                    .Where(e => e.id == bUserid).FirstOrDefault();

            NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                NewBusinessSectionDataByIDType = sectionsWithContents,
                BusinessUserDetailByID = userDetail
            };
            return data;
        }

        public NewBusinessUserDetailResp DisableNewBusinessSection(long sectionId)
        {

            BussinessUserSectionDetail del = DB.BussinessUserSectionDetail.SingleOrDefault(parent => parent.id == sectionId);
            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            var associatedContents = DB.BussinessUserContentDetail
                  .Where(content => content.business_section_name == del.title && content.delete == 0)
                  .ToList();

            if (associatedContents.Count != 0)
            {
                foreach (BussinessUserContentDetail content in associatedContents)
                {
                    if (content.business_content_hide == 1)
                    {
                        content.business_content_hide = 0;
                    }
                    else
                    {
                        content.business_content_hide = 1;
                    }
                }
            }

            if (del.business_section_hide == 1)
            {
                del.business_section_hide = 0;
            }
            else
            {
                del.business_section_hide = 1;
            }

            DB.SaveChanges();

            NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

        public NewBusinessUserDetailResp DisableNewBusinessContent(long contentId)
        {

            BussinessUserContentDetail del = DB.BussinessUserContentDetail.SingleOrDefault(parent => parent.id == contentId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            if (del.business_content_hide == 1)
            {
                del.business_content_hide = 0;
            }
            else
            {
                del.business_content_hide = 1;
            }

            DB.SaveChanges();

            NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

        public NewBusinessUserDetailResp UpdateNewBusinessUserDetail(NewBusinessUserDetailReq samp)
        {
            // Check if the user exists
           /* User_Detail checkuser = DB.User_Detail.Where(e => e.id == samp.id).FirstOrDefault();

            if (checkuser == null)
            {
                throw new Exception("User does not exist, please create the account.");
            }*/

            // Check if BusinessUserDetail already exists for this user
            BusinessUserDetail existingUserDetail = DB.BusinessUserDetail.Where(e => e.id == samp.id).FirstOrDefault();

            existingUserDetail.user_flag = samp.user_flag;

            //if (existingUserDetail != null)
            //{
            //    Update existing BusinessUserDetail
            //    existingUserDetail.user_name = checkuser.user_name;
            //    existingUserDetail.user_ph = checkuser.user_mobile.ToString();
            //    existingUserDetail.user_email = checkuser.user_email;
            //    existingUserDetail.updated_at = DateTime.Now;

            //    Save changes to the BusinessUserDetail
            //    DB.SaveChanges();
            //}
            //else
            //{
            //    If BusinessUserDetail doesn't exist, create a new one
            //    existingUserDetail = new BusinessUserDetail()
            //    {
            //        user_name = checkuser.user_name,
            //        user_ph = checkuser.user_mobile.ToString(),
            //        user_email = checkuser.user_email,
            //        delete = 0,
            //        created_at = DateTime.Now,
            //        updated_at = DateTime.Now,
            //        user_profile_id = checkuser.id
            //    };

            //    DB.BusinessUserDetail.Add(existingUserDetail);
            //    DB.SaveChanges();
            //}

            // Check if BusinessSectionDataByIDType is not null
            if (samp.NewBusinessSectionDataByIDType != null)
            {
                // Loop through each section in BusinessSectionDataByIDType
                foreach (var sectionData in samp.NewBusinessSectionDataByIDType)
                {
                    // Check if the section already exists for this user
                    BussinessUserSectionDetail existingSection = DB.BussinessUserSectionDetail
                        .Where(s => s.id  == sectionData.Section.id )
                        .FirstOrDefault();

                    if (existingSection != null)
                    {
                        // Update existing section
                        existingSection.title_alignment = sectionData.Section.title_alignment;
                        existingSection.title_bold = sectionData.Section.title_bold;
                        existingSection.title_font_size = sectionData.Section.title_font_size;
                        existingSection.section_position = sectionData.Section.section_position;
                        existingSection.updated_at = DateTime.Now;
                        existingSection.business_section_hide = sectionData.Section.business_section_hide;
                        existingSection.section_flag = samp.user_flag;

                        DB.SaveChanges();
                    }
                    else
                    {
                        // Create new section if it doesn't exist
                        existingSection = new BussinessUserSectionDetail()
                        {
                            title = sectionData.Section.title,
                            title_alignment = sectionData.Section.title_alignment,
                            title_bold = sectionData.Section.title_bold,
                            title_font_size = sectionData.Section.title_font_size,
                            section_position = sectionData.Section.section_position,
                            delete = 0,
                            business_user_detail_id = existingUserDetail.id, // Assign user id
                            created_at = DateTime.Now,
                            updated_at = DateTime.Now,
                            business_section_hide = sectionData.Section.business_section_hide,
                            section_flag = samp.user_flag
                        };

                        DB.BussinessUserSectionDetail.Add(existingSection);
                        DB.SaveChanges();
                    }

                    // Check if there are any contents in the section
                    if (sectionData.Contents != null && sectionData.Contents.Count > 0)
                    {
                        foreach (var contentData in sectionData.Contents)
                        {
                            // Check if the content already exists
                            BussinessUserContentDetail existingContent = DB.BussinessUserContentDetail
                                .Where(c => c.id == contentData.id )
                                .FirstOrDefault();

                            if (existingContent != null)
                            {
                                // Update existing content
                                existingContent.type = contentData.type;
                                existingContent.value = contentData.value;
                                existingContent.label_bold = contentData.label_bold;
                                existingContent.drop_value = contentData.drop_value;
                                existingContent.value_bold = contentData.value_bold;
                                existingContent.alignment = contentData.alignment;
                                existingContent.icon = contentData.icon;
                                existingContent.button_alignment = contentData.button_alignment;
                                existingContent.content_position = contentData.content_position;
                                existingContent.updated_at = DateTime.Now;
                                existingContent.business_content_hide = contentData.business_content_hide;
                                existingContent.content_flag = samp.user_flag;

                                DB.SaveChanges();
                            }
                            else
                            {
                                // Create new content if it doesn't exist
                                BussinessUserContentDetail newContent = new BussinessUserContentDetail()
                                {
                                    type = contentData.type,
                                    label = contentData.label,
                                    value = contentData.value,
                                    label_bold = contentData.label_bold,
                                    drop_value = contentData.drop_value,
                                    value_bold = contentData.value_bold,
                                    alignment = contentData.alignment,
                                    icon = contentData.icon,
                                    button_alignment = contentData.button_alignment,
                                    content_position = contentData.content_position,
                                    delete = 0,
                                    business_section_name = contentData.business_section_name,
                                    business_user_detail_id = existingUserDetail.id, // Assign the user ID
                                    business_section_id = existingSection.id, // Assign the section ID
                                    created_at = DateTime.Now,
                                    updated_at = DateTime.Now,
                                    business_content_hide = contentData.business_content_hide,
                                    content_flag = samp.user_flag,
                                };

                                DB.BussinessUserContentDetail.Add(newContent);
                                DB.SaveChanges();
                            }
                        }
                    }
                }
            }

            // Create and return the response object
            NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
            {
                status = true,
                Message = "Updated successfully",
            };

            return data;
        }

        public NewBusinessUserDetailResp DeleteNewBusinessUserDetail(long tableId)
        {
            
            // Find the BusinessUserDetail to delete
            BusinessUserDetail existingUserDetail = DB.BusinessUserDetail
                .Where(e => e.id == tableId)
                .FirstOrDefault();

            if (existingUserDetail != null)
            {
                // Find and delete related sections
                var sections = DB.BussinessUserSectionDetail
                    .Where(s => s.business_user_detail_id == existingUserDetail.id)
                    .ToList();

                foreach (var section in sections)
                {
                    // Find and delete related content
                    var contents = DB.BussinessUserContentDetail
                        .Where(c => c.business_section_id == section.id)
                        .ToList();

                    DB.BussinessUserContentDetail.RemoveRange(contents);

                    // Delete the section
                    DB.BussinessUserSectionDetail.Remove(section);
                }

                // Delete the BusinessUserDetail
                DB.BusinessUserDetail.Remove(existingUserDetail);

                // Save all changes
                DB.SaveChanges();
            }
           

            // Create and return the response object
            NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
            {
                status = true,
                Message = "Deleted successfully",
            };

            return data;
        }


    }
}