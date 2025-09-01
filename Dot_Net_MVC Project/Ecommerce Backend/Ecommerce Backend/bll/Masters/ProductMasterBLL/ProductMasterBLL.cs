using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class ProductMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public ProductMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ProductMasterResp GetProductMaster(string? categorySearchKey, string? productSearchKey, string[]? searchKey, string? subcategoryName, string? searchKeyData)
        {


            List<ProductMaster> productDetail = null;
            List<CategoryMaster> searchData = null;

            if (searchKeyData != null)
            {
                /* searchData = DB.CategoryMaster
                   .Include(category => category.subCategoryMasters)
                       .ThenInclude(subcategory => subcategory.ProductMaster)
                           .ThenInclude(product => product.ReviewMaster)
                               .Where(category =>
                                   EF.Functions.Like(category.category_name, "%" + searchKeyData + "%") ||
                                   category.subCategoryMasters.Any(subcategory =>
                                       EF.Functions.Like(subcategory.sub_category_name, "%" + searchKeyData + "%") ||
                                       subcategory.ProductMaster.Any(product =>
                                           EF.Functions.Like(product.product_title, "%" + searchKeyData + "%"))))
                               .ToList();*/

                productDetail= DB.ProductMaster
                             .Where(product => EF.Functions.Like(product.product_category, "%" + searchKeyData + "%")
                                             || EF.Functions.Like(product.product_sub_category, "%" + searchKeyData + "%")
                                             || EF.Functions.Like(product.product_title, "%" + searchKeyData + "%"))
                             .ToList();

            }
            else if(categorySearchKey != null && subcategoryName != null){

                CategoryMaster categoryMaster = DB.CategoryMaster.Where(category => category.category_name == categorySearchKey).FirstOrDefault();
                SubCategoryMaster subcategoryMaster = DB.SubCategoryMaster.Where(subcategory => subcategory.sub_category_name == subcategoryName).FirstOrDefault();

                productDetail = DB.ProductMaster
                    .Include(e => e.ProductTransMaster)
                    .AsEnumerable()
                    .Where(e => e.product_category_id == categoryMaster.id && e.product_sub_category_id == subcategoryMaster.id &&
                                (searchKey.Any() ? e.ProductTransMaster.Any(ptm => searchKey.Any(sk => ptm.product_filter_data.Contains(sk))) : true))
                    .ToList();
            }   
            else if (categorySearchKey != null)
            {

                CategoryMaster categoryMaster = DB.CategoryMaster.Where(category => category.category_name == categorySearchKey).FirstOrDefault();

                if (categoryMaster != null)
                {
                    productDetail = DB.ProductMaster
                      .Include(e => e.ProductTransMaster)
                      .AsEnumerable()
                      .Where(e => e.product_category_id == categoryMaster.id &&
                                  (searchKey.Any() ? e.ProductTransMaster.Any(ptm => searchKey.Any(sk => ptm.product_filter_data.Contains(sk))) : true))
                      .ToList();
                }
                else
                {
                    productDetail = null;

                }
            } else if (productSearchKey != null)
            {
                productDetail = DB.ProductMaster
                    .Where(e => e.product_status == 0 && EF.Functions.Like(e.product_title, "%" + productSearchKey + "%"))
                    .ToList();
            }
            else
            {
                productDetail = DB.ProductMaster.Include(e => e.ReviewMaster)
                    .Where(e => e.product_status == 0).ToList();
            }



            

            ProductMasterResp data = new ProductMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ProductMasterData = productDetail,
                CategoryMasterData = searchData

            };
            return data;
        }

        public ProductMasterResp GetProductMasterById(long productId)
        {

            ProductMasterResp data = new ProductMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ProductMasterDataByID = DB.ProductMaster.
                Include(e => e.ProductMultipleImageTransMaster).
                Include(e => e.ProductTransMaster)
                .Include(e=>e.ReviewMaster).ThenInclude(product=> product.User_Detail)
                .Where(e => e.id == productId).FirstOrDefault()
            };
            return data;
        }

        public ProductMasterResp GetRelatedProduct(string subcategoryName, long productId)
        {

            ProductMasterResp data = new ProductMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ProductMasterData = DB.ProductMaster
                    .Include(e => e.ReviewMaster)
                    .Where(e => e.product_sub_category == subcategoryName && e.id != productId)
                    .ToList()
        };
            return data;
        }

        public ProductMasterResp InsertProductMaster(ProductMasterReq samp)
        {
            ProductMaster SampData = new ProductMaster()
            {
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                vender_name = samp.vender_name,
                vender_code = samp.vender_code,
                agent_name = samp.agent_name,
                agent_code = samp.agent_code,
                product_title = samp.product_title,
                product_price = samp.product_price,
                product_del_price = samp.product_del_price,
                product_category = samp.product_category,
                product_sub_category_id = samp.product_sub_category_id,
                product_sub_category = samp.product_sub_category,
                product_category_id = samp.product_category_id,
                product_description = samp.product_description,
                product_content = samp.product_content,
                img_url = samp.img_url,
                username = samp.username,
                user_id = samp.user_id,
                comp_name = samp.comp_name,
                comp_id = samp.comp_id,



                product_store_qty = samp.product_store_qty,
                product_to_be_returned_by = samp.product_to_be_returned_by,
                product_returnable  = samp.product_returnable,
                product_purchasing_price = samp.product_purchasing_price,
                product_commission_received_in = samp.product_commission_received_in,
                product_commission_percentage = samp.product_commission_percentage,
                product_commission_amt = samp.product_commission_amt,
                product_points_earned = samp.product_points_earned
            };

            DB.ProductMaster.Add(SampData);
            DB.SaveChanges();

            foreach (ProductMultipleImageTransKey multipleUploadString in samp.productMultipleImageTransMaster)
            {
                ProductMultipleImageTransMaster SampData1 = new ProductMultipleImageTransMaster()
                {
                    img_url = multipleUploadString.img_url,
                    product_id = SampData.id
                };

                DB.ProductMultipleImageTransMaster.Add(SampData1);
            }
            DB.SaveChanges();


            foreach (var keyName in samp.ProductItemArray)
            {
                ProductTransMaster sampData2 = new ProductTransMaster()
                {
                    product_id = SampData.id,
                    product_filter_data = keyName.product_filter_data,
                    product_filter_name = keyName.product_filter_name,
                    product_item_stock = keyName.product_item_stock,
                };

                DB.ProductTransMaster.Add(sampData2);
            }

            DB.SaveChanges();

            ProductMasterResp data = new ProductMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public ProductMasterResp UpdateProductMaster(long productId, ProductMasterReq samp)
        {

            var existingProduct = DB.ProductMaster.
                  Include(e => e.ProductMultipleImageTransMaster)
                .Where(e => e.id == productId).FirstOrDefault();

            if (existingProduct == null)
            {

                ProductMasterResp data1 = new ProductMasterResp()
                {
                    status = false,
                    Message = "Product not found"
                };

                return data1;
            }

            existingProduct.client_purchaser_code = samp.client_purchaser_code;
            existingProduct.client_purchaser_name = samp.client_purchaser_name;
            existingProduct.vender_name = samp.vender_name;
            existingProduct.vender_code = samp.vender_code;
            existingProduct.agent_name = samp.agent_name;
            existingProduct.agent_code = samp.agent_code;
            existingProduct.product_title = samp.product_title;
            existingProduct.product_price = samp.product_price;
            existingProduct.product_del_price = samp.product_del_price;
            existingProduct.product_category = samp.product_category;
            existingProduct.product_sub_category_id = samp.product_sub_category_id;
            existingProduct.product_sub_category = samp.product_sub_category;
            existingProduct.product_category_id = samp.product_category_id;
            existingProduct.product_description = samp.product_description;
            existingProduct.product_content = samp.product_content;
            existingProduct.img_url = samp.img_url;
            existingProduct.username = samp.username;
            existingProduct.user_id = samp.user_id;
            existingProduct.comp_name = samp.comp_name;
            existingProduct.comp_id = samp.comp_id;
            existingProduct.product_store_qty = samp.product_store_qty;


            existingProduct.product_store_qty = samp.product_store_qty;
            existingProduct.product_to_be_returned_by = samp.product_to_be_returned_by;
            existingProduct.product_returnable = samp.product_returnable;
            existingProduct.product_purchasing_price = samp.product_purchasing_price;
            existingProduct.product_commission_received_in = samp.product_commission_received_in;
            existingProduct.product_commission_percentage = samp.product_commission_percentage;
            existingProduct.product_commission_amt = samp.product_commission_amt;
            existingProduct.product_points_earned = samp.product_points_earned;




            foreach (ProductMultipleImageTransKey multipleUploadString in samp.productMultipleImageTransMaster)
            {
                ProductMultipleImageTransMaster exiting_image_url = DB.ProductMultipleImageTransMaster.Where(e => e.id == multipleUploadString.id).FirstOrDefault();
                if (exiting_image_url == null)
                {
                    ProductMultipleImageTransMaster SampData1 = new ProductMultipleImageTransMaster()
                    {
                        img_url = multipleUploadString.img_url,
                        product_id = existingProduct.id
                    };

                    DB.ProductMultipleImageTransMaster.Add(SampData1);
                }
            }

            DB.SaveChanges();



            foreach (var deleteimageid in samp.deletedImages)
            {
                ProductMultipleImageTransMaster del_image_url = DB.ProductMultipleImageTransMaster.Where(e => e.id == deleteimageid.id).FirstOrDefault();
                DB.ProductMultipleImageTransMaster.Remove(del_image_url);
                DB.SaveChanges();
            }




            foreach (var keyName in samp.ProductItemArray)
            {

                ProductTransMaster exiting_data = DB.ProductTransMaster.Where(e => e.id == keyName.id).FirstOrDefault();

                if (exiting_data == null)
                {
                    ProductTransMaster sampData2 = new ProductTransMaster()
                    {
                        product_id = existingProduct.id,
                        product_filter_data = keyName.product_filter_data,
                        product_filter_name = keyName.product_filter_name,
                        product_item_stock = keyName.product_item_stock,
                    };

                    DB.ProductTransMaster.Add(sampData2);
                }
            }
            DB.SaveChanges();

            foreach (var keyName in samp.ProductDeleteItemArray)
            {
                ProductTransMaster del = DB.ProductTransMaster.Where(e => e.id == keyName.id).FirstOrDefault();
                DB.ProductTransMaster.Remove(del);
                DB.SaveChanges();
            }

            ProductMasterResp data = new ProductMasterResp()
            {
                status = true,
                Message = "update successfully"
            };
            return data;
        }

        public ProductMasterResp DeleteProductMaster(long productId)
        {
            var del = DB.ProductMaster.Where(e => e.id == productId).FirstOrDefault();

            if (del == null)
            {

                ProductMasterResp data1 = new ProductMasterResp()
                {
                    status = false,
                    Message = "Product not found"
                };

                return data1;
            }

            del.product_status = 1;

            DB.SaveChanges();
            ProductMasterResp data = new ProductMasterResp()
            {
                status = true,
                Message = "delete successfully"
            };
            return data;
        }




    }
}