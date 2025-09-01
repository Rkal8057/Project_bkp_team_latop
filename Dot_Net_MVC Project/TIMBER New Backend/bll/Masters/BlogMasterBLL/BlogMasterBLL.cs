using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class BlogMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public BlogMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }
        public BlogMasterResp GetBlogMaster()
        {
            BlogMasterResp data = new BlogMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                BlogMasterData = DB.BlogMaster.Where(e => e.blog_status == 0).OrderByDescending(e=> e.position).ToList()
            };
            return data;
        }


        public BlogMasterResp GetBlogMasterById(long blogId)
        {
            BlogMasterResp data = new BlogMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                BlogMasterDataByID = DB.BlogMaster.Where(e => e.blog_status == 0 && e.id == blogId).FirstOrDefault()
            };
            return data;
        }

        public BlogMasterResp InsertBlogMaster(BlogMasterReq samp)
        {
            BlogMaster SampData = new BlogMaster()
            {
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vender_code = samp.vender_code,
                vender_name = samp.vender_name,
                blog_title = samp.blog_title,
                blog_category = samp.blog_category,
                blog_category_id = samp.blog_category_id,
                blog_description = samp.blog_description,
                blog_content = samp.blog_content,
                img_url = samp.img_url,
                username = samp.username,
                created_on = DateTime.Now,
                updated_on = DateTime.Now,
                icon_img_url = samp.icon_img_url,
                position = samp.position,
            };

            DB.BlogMaster.Add(SampData);
            DB.SaveChanges();
            BlogMasterResp data = new BlogMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public BlogMasterResp UpdateBlogMaster(long blogId, BlogMasterReq samp)
        {
            var existingCategory = DB.BlogMaster.Find(blogId);

            if (existingCategory == null)
            {
                BlogMasterResp data1 = new BlogMasterResp()
                {
                    status = false,
                    Message = "Category not found"
                };

                return data1;
            }

            existingCategory.client_purchaser_code = samp.client_purchaser_code;
            existingCategory.client_purchaser_name = samp.client_purchaser_name;
            existingCategory.agent_code = samp.agent_code;
            existingCategory.agent_name = samp.agent_name;
            existingCategory.vender_code = samp.vender_code;
            existingCategory.vender_name = samp.vender_name;
            existingCategory.blog_title = samp.blog_title;
            existingCategory.blog_category = samp.blog_category;
            existingCategory.blog_category_id = samp.blog_category_id;
            existingCategory.blog_description = samp.blog_description;
            existingCategory.blog_content = samp.blog_content;
            existingCategory.blog_status = samp.blog_status;
            existingCategory.deleted = samp.deleted;
            existingCategory.img_url = samp.img_url;
            existingCategory.username = samp.username;
            existingCategory.updated_on = DateTime.Now;
            existingCategory.icon_img_url = samp.icon_img_url;
            existingCategory.position = samp.position;

            DB.SaveChanges();

            BlogMasterResp data = new BlogMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }



        public BlogMasterResp DeleteBlogMaster(long blogId)
        {

            BlogMaster del = DB.BlogMaster.SingleOrDefault(parent => parent.id == blogId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.blog_status = 1;
            DB.SaveChanges();

            BlogMasterResp data = new BlogMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

    }
}