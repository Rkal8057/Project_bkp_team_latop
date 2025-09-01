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
    public class StyleMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public StyleMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public StyleMasterResp InsertStyleMaster(StyleMasterReq samp)
        {

            StyleMaster SampData = new StyleMaster()
            {
                background_color = samp.background_color,
                link_color = samp.link_color,
                header_top_color = samp.header_top_color,
                header_bottom_color = samp.header_bottom_color,
                text_color = samp.text_color,
                header_text_color = samp.header_text_color,
                review_content_background_color = samp.review_content_background_color,
                review_hover_color  = samp.review_hover_color,
                review_style= samp.review_style,
                contact_us_style = samp.contact_us_style,
                footer_style= samp.footer_style,
                contact_background_color = samp.contact_background_color,
                footer_background_color = samp.footer_background_color,
                theme_color = samp.theme_color,
                chooseus_style = samp.chooseus_style,
                service_style = samp.service_style,


            };

            DB.StyleMaster.Add(SampData);
            DB.SaveChanges();


            StyleMasterResp data = new StyleMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }


        public StyleMasterResp GetStyleMaster()
        {
            var lastId = (long)(DB.StyleMaster
                 .Max(u => (long?)u.id) ?? 0);

            StyleMasterResp data = new StyleMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                System_RecordsDataById = DB.StyleMaster.Where(e=> e.id  == lastId).FirstOrDefault()
            };

            return data;
        }

        public StyleMasterResp GetStyleMasterById(long styleId)
        {

            StyleMasterResp data = new StyleMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                System_RecordsDataById = DB.StyleMaster.Where(e=> e.id == styleId).FirstOrDefault()
            };

            return data;
        }



        public StyleMasterResp UpdateStyleMaster(long styleId, StyleMasterReq samp)
        {
            var existing = DB.StyleMaster.Find(styleId);

            if (existing == null)
            {

                StyleMasterResp data1 = new StyleMasterResp()
                {
                    status = false,
                    Message = "Style not found"
                };

                return data1;
            }

            existing.background_color = samp.background_color;
            existing.link_color = samp.link_color;
            existing.header_top_color = samp.header_top_color;
            existing.header_bottom_color = samp.header_bottom_color;
            existing.text_color = samp.text_color;
            existing.header_text_color = samp.header_text_color;
            existing.review_content_background_color = samp.review_content_background_color;
            existing.review_hover_color = samp.review_hover_color;
            existing.review_style = samp.review_style;

            existing.contact_us_style = samp.contact_us_style;
            existing.footer_style = samp.footer_style;
            existing.contact_background_color = samp.contact_background_color;
            existing.footer_background_color = samp.footer_background_color;
            existing.theme_color = samp.theme_color;
            existing.chooseus_style = samp.chooseus_style;
            existing.service_style = samp.service_style;


            DB.SaveChanges();

            StyleMasterResp data = new StyleMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }

        public StyleMasterResp DeleteStyleMaster(long styleId)
        {

            StyleMaster del = DB.StyleMaster
                                            .SingleOrDefault(parent => parent.id == styleId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.StyleMaster.Remove(del);
            DB.SaveChanges();

            StyleMasterResp data = new StyleMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;


        }


    }
}