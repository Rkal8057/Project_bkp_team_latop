using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class ReviewMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public ReviewMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }
        public ReviewMasterResp GetReviewMaster()
        {
            ReviewMasterResp data = new ReviewMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ReviewMasterData = DB.ReviewMaster.Where(e => e.deleted == 0).ToList()
            };
            return data;
        }

        public ReviewMasterResp GetReviewMasterById(long reviewId)
        {
            ReviewMasterResp data = new ReviewMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ReviewMasterDataByID = DB.ReviewMaster.Where(e => e.id == reviewId && e.deleted == 0).FirstOrDefault()
            };
            return data;
        }

        public ReviewMasterResp InsertReviewMaster(ReviewMasterReq samp)
        {
            ReviewMaster SampData = new ReviewMaster()
            {
                client_purchaser_code = samp.client_purchaser_code,
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vendor_code = samp.vendor_code,
                vendor_name = samp.vendor_name,
                rating_stars = samp.rating_stars,
                product_review = samp.product_review,
                product_id = samp.product_id,
                user_id = samp.user_id,
                created_on = DateTime.Now,
                updated_on = DateTime.Now
            };


            DB.ReviewMaster.Add(SampData);
            DB.SaveChanges();
            ReviewMasterResp data = new ReviewMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public ReviewMasterResp UpdateReviewMaster(long reviewId, ReviewMasterReq samp)
        {
            var existingReview = DB.ReviewMaster.Find(reviewId);

            if (existingReview == null)
            {
                ReviewMasterResp data1 = new ReviewMasterResp()
                {
                    status = false,
                    Message = "Review not found"
                };

                return data1;
            }

            existingReview.client_purchaser_code = samp.client_purchaser_code;
            existingReview.client_purchaser_name = samp.client_purchaser_name;
            existingReview.agent_code = samp.agent_code;
            existingReview.agent_name = samp.agent_name;
            existingReview.vendor_code = samp.vendor_code;
            existingReview.vendor_name = samp.vendor_name;
            existingReview.rating_stars = samp.rating_stars;
            existingReview.product_review = samp.product_review;
            existingReview.product_id = samp.product_id;
            existingReview.user_id = samp.user_id;
            existingReview.created_on = samp.created_on;
            existingReview.updated_on = DateTime.Now;

            DB.SaveChanges();

            ReviewMasterResp data = new ReviewMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }



        public ReviewMasterResp DeleteReviewMaster(long reviewId)
        {

            ReviewMaster del = DB.ReviewMaster.SingleOrDefault(parent => parent.id == reviewId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.deleted = 1;
            DB.SaveChanges();

            ReviewMasterResp data = new ReviewMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

    }
}