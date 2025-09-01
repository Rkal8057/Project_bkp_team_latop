using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Reflection.Emit;

namespace RTA.Masters
{
    public class BusinessContentBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public BusinessContentBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public BusinessContentResp GetBusinessContent(string? business_section_name = null)
        {
            var query = DB.BusinessContent.Where(e => e.delete == 0);

            // Apply the filter if a name is provided
            if (!string.IsNullOrEmpty(business_section_name))
            {
                query = query.Where(e => e.business_section_name.Contains(business_section_name));
            }

            var businessContentData = query
               .OrderByDescending(e => e.content_position)
               .ToList();

            BusinessContentResp data = new BusinessContentResp()
            {
                status = true,
                Message = "data fetched successfully",
                BusinessContentData = businessContentData
            };
            return data;
        }

        public BusinessContentResp GetBusinessContentById(long contentId)
        {
            BusinessContentResp data = new BusinessContentResp()
            {
                status = true,
                Message = "data fetched successfully",
                BusinessContentDataByID = DB.BusinessContent.Where(e => e.delete == 0 && e.id == contentId).FirstOrDefault()
            };
            return data;
        }

        public BusinessContentResp InsertBusinessContent(BusinessContentReq samp)
        {
            BusinessContent SampData = new BusinessContent()
            {
                type = samp.type,
                label = samp.label,
                value = samp.value,
                label_bold = samp.label_bold,
                value_bold = samp.value_bold,
                alignment = samp.alignment,
                icon = samp.icon,
                button_alignment = samp.button_alignment,
                content_position = samp.content_position,
                delete = 0,
                business_section_name= samp.business_section_name,
                business_user_detail_id = samp.business_user_detail_id,
                business_section_id = samp.business_section_id,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };

            DB.BusinessContent.Add(SampData);
            DB.SaveChanges();
            BusinessContentResp data = new BusinessContentResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public BusinessContentResp UpsertMultipleBusinessContent(List<BusinessContentReq> samples)
        {
            foreach (var samp in samples)
            {
                // Check if the content already exists in the database (using an appropriate identifier, e.g., ID or unique fields)
                var existingContent = DB.BusinessContent.FirstOrDefault(bc => bc.id == samp.id);

                if (existingContent != null)
                {
                    // Update existing record
                    existingContent.type = samp.type;
                    existingContent.label = samp.label;
                    existingContent.value = samp.value;
                    existingContent.label_bold = samp.label_bold;
                    existingContent.value_bold = samp.value_bold;
                    existingContent.alignment = samp.alignment;
                    existingContent.icon = samp.icon;
                    existingContent.button_alignment = samp.button_alignment;
                    existingContent.business_section_name = samp.business_section_name;
                    existingContent.business_section_id = samp.business_section_id;
                    existingContent.updated_at = DateTime.Now;

                    // Mark the entity as modified
                    DB.Entry(existingContent).State = EntityState.Modified;
                }
                else
                {
                    // Insert new record
                    BusinessContent newContent = new BusinessContent()
                    {
                        type = samp.type,
                        label = samp.label,
                        value = samp.value,
                        label_bold = samp.label_bold,
                        value_bold = samp.value_bold,
                        alignment = samp.alignment,
                        icon = samp.icon,
                        button_alignment = samp.button_alignment,
                        content_position = samp.content_position,
                        delete = 0,
                        business_section_name = samp.business_section_name,
                        business_user_detail_id = samp.business_user_detail_id,
                        business_section_id= samp.business_section_id,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };

                    DB.BusinessContent.Add(newContent);
                }
            }

            // Save all changes (insertions and updates) in one go
            DB.SaveChanges();

            BusinessContentResp response = new BusinessContentResp()
            {
                status = true,
                Message = "Records processed successfully"
            };

            return response;
        }

        public BusinessContentResp UpdateBusinessContent(long contentId, BusinessContentReq samp)
        {
            var existing = DB.BusinessContent.Find(contentId);

            if (existing == null)
            {
                BusinessContentResp data1 = new BusinessContentResp()
                {
                    status = false,
                    Message = "Content not found"
                };

                return data1;
            }
            existing.type = samp.type;
            existing.label = samp.label;
            existing.value = samp.value;
            existing.label_bold = samp.label_bold;
            existing.value_bold = samp.value_bold;
            existing.alignment = samp.alignment;
            existing.icon = samp.icon;
            existing.button_alignment = samp.button_alignment;
            existing.content_position = samp.content_position;
            existing.business_section_name = samp.business_section_name;
           // existing.business_user_detail_id = samp.business_user_detail_id;
            existing.updated_at = DateTime.Now;

            DB.SaveChanges();

            BusinessContentResp data = new BusinessContentResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }

        public BusinessContentResp DeleteBusinessContent(long contentId)
        {

            BusinessContent del = DB.BusinessContent.SingleOrDefault(parent => parent.id == contentId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.delete = 1;
            DB.SaveChanges();

            BusinessContentResp data = new BusinessContentResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

        public BusinessContentResp DisableBusinessContent(long contentId)
        {

            BusinessContent del = DB.BusinessContent.SingleOrDefault(parent => parent.id == contentId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            if(del.business_content_hide == 1)
            {
                del.business_content_hide = 0;
            }
            else
            {
                del.business_content_hide = 1;
            }

            DB.SaveChanges();

            BusinessContentResp data = new BusinessContentResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

    }
}