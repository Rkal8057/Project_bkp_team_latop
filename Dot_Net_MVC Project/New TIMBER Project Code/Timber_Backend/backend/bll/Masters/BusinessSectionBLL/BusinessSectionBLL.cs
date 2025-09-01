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
    public class BusinessSectionBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public BusinessSectionBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public BusinessSectionResp GetBusinessSection(string? searchKey = null)
        {

            var query = DB.BusinessSection.Where(e => e.delete == 0);

            if (!string.IsNullOrEmpty(searchKey))
            {
                string pattern = $"%{searchKey}%";
                query = query.Where(e => EF.Functions.Like(e.title, pattern));
            }
            var businessSections = query.OrderByDescending(e => e.section_position).ToList();

            BusinessSectionResp data = new BusinessSectionResp()
            {
                status = true,
                Message = "Data fetched successfully",
                BusinessSectionData = businessSections
            };

            return data;
        }


        public BusinessSectionResp GetBusinessSectionById(long sectionId)
        {
            var sectionData = DB.BusinessSection
               .Where(e => e.delete == 0 && e.id == sectionId).FirstOrDefault();


            List<BusinessContent> contentData = new List<BusinessContent>();
            if (sectionData != null)
            {
                contentData = DB.BusinessContent
               .Where(c => c.delete == 0 && c.business_section_name == sectionData.title).ToList();

            }

            BusinessSectionResp data = new BusinessSectionResp()
            {
                status = true,
                Message = "data fetched successfully",
                BusinessSectionDataByID = sectionData,
                BusinessContentData = contentData
            };
            
            return data;
        }

        public BusinessSectionResp InsertBusinessSection(BusinessSectionReq samp)
        {
            BusinessSection SampData = new BusinessSection()
            {
                title = samp.title,
                title_alignment = samp.title_alignment,
                title_bold = samp.title_bold,
                title_font_size = samp.title_font_size,
                section_position = samp.section_position,
                delete = 0,
                business_user_detail_id = samp.business_user_detail_id,
                section_multiple = samp.section_multiple,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
            };

            DB.BusinessSection.Add(SampData);
            DB.SaveChanges();

            BusinessSectionResp data = new BusinessSectionResp()
            {
                status = true,
                Message = "inserted successfully",
                BusinessSectionDataByID = DB.BusinessSection.Where( e=> e.id == SampData.id).FirstOrDefault(),
            };
            return data;
        }

        public BusinessSectionResp UpdateBusinessSection(long sectionId, BusinessSectionReq samp)
        {
            var existing = DB.BusinessSection.Find(sectionId);

            if (existing == null)
            {
                BusinessSectionResp data1 = new BusinessSectionResp()
                {
                    status = false,
                    Message = "Content not found"
                };

                return data1;
            }

            existing.title = samp.title;
            existing.title_alignment = samp.title_alignment;
            existing.title_bold = samp.title_bold;
            existing.title_font_size = samp.title_font_size;
            existing.section_position = samp.section_position;
            existing.delete = 0;
            existing.business_user_detail_id = samp.business_user_detail_id;
            existing.section_multiple = samp.section_multiple;
            existing.updated_at = DateTime.Now;
            DB.SaveChanges();

            BusinessSectionResp data = new BusinessSectionResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }



        public BusinessSectionResp DeleteBusinessSection(long sectionId)
        {

            BusinessSection del = DB.BusinessSection.SingleOrDefault(parent => parent.id == sectionId);
            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            var associatedContents = DB.BusinessContent
                  .Where(content => content.business_section_name == del.title && content.delete == 0)
                  .ToList();

            if (associatedContents.Count != 0)
            {
                foreach (BusinessContent content in associatedContents)
                {
                    content.delete = 1;
                }
            }

            del.delete = 1;
            DB.SaveChanges();

            BusinessSectionResp data = new BusinessSectionResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }



        public BusinessSectionResp DisableBusinessSection(long sectionId)
        {

            BusinessSection del = DB.BusinessSection.SingleOrDefault(parent => parent.id == sectionId);
            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            var associatedContents = DB.BusinessContent
                  .Where(content => content.business_section_name == del.title && content.delete == 0)
                  .ToList();

            if (associatedContents.Count != 0)
            {
                foreach (BusinessContent content in associatedContents)
                {
                    if(content.business_content_hide == 1)
                    {
                        content.business_content_hide = 0;
                    }
                    else
                    {
                     content.business_content_hide = 1;
                    }
                }
            }

            if(del.business_section_hide == 1)
            {
                del.business_section_hide = 0;
            }
            else
            {
                del.business_section_hide = 1;
            }

            DB.SaveChanges();

            BusinessSectionResp data = new BusinessSectionResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }


        public BusinessSectionResp GetBusinessSectionWithContent( string flag )
        {
            
                var sectionData = DB.BusinessSection
                 .Where(e => e.delete == 0)
                 .Where(e => flag == "admin" ? true : e.business_section_hide == 0  )
                 .OrderBy(e => e.section_position)
                 .Select(e => new
                 {
                     Section = e,
                     Contents = DB.BusinessContent
                         .Where(c => c.business_section_id == e.id && c.delete == 0)
                         .Where( c => flag == "admin" ? true : c.business_content_hide == 0)
                         .OrderBy(e => e.content_position)
                         .ToList()
                 })
                 .ToList();

       
            BusinessSectionResp data = new BusinessSectionResp()
            {
                status = true,
                Message = "data fetched successfully",
                BusinessSectionDataByIDType = sectionData
            };
            return data;
        }
    }
}