using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DB.Login.Tables;
using System.Collections.Generic;
//using DB.Login.Migrations;

namespace DB.Login
{
    public partial class loginDBContext : DbContext
    {
        public loginDBContext(DbContextOptions<loginDBContext> options) : base(options)
        { }
       
        public virtual DbSet<CategoryMaster> CategoryMaster { get; set; }
        public virtual DbSet<CategoryTranxMaster> CategoryTranxMaster { get; set; }
        public virtual DbSet<SubCategoryMaster> SubCategoryMaster { get; set; }
        public virtual DbSet<ProductMaster> ProductMaster { get; set; }
        public virtual DbSet<OrderMaster> OrderMaster { get; set; }
        public virtual DbSet<OrderItemMaster> OrderItemMaster { get; set; }
        public virtual DbSet<ProductMultipleImageTransMaster> ProductMultipleImageTransMaster { get; set; }
        public virtual DbSet<SystemMaster> SystemMaster { get; set; }
        public virtual DbSet<PaymentMaster> PaymentMaster { get; set; }
        public virtual DbSet<SystemFilterMaster> SystemFilterMaster { get; set; }
        public virtual DbSet<SystemFilterTranxMaster> SystemFilterTranxMaster { get; set; }
        public virtual DbSet<ProductTransMaster> ProductTransMaster { get; set; }
        public virtual DbSet<BlogMaster> BlogMaster { get; set; }
        public virtual DbSet<ClientMaster> ClientMaster { get; set; }
        public virtual DbSet<ContactMaster> ContactMaster { get; set; }
        public virtual DbSet<FaqMaster> FaqMaster { get; set; }
        public virtual DbSet<Slider_Master> Slider_Master { get; set; }
        public virtual DbSet<Mini_Slider_Master> Mini_Slider_Master { get; set; }
        public virtual DbSet<ReviewMaster> ReviewMaster { get; set; }
        public virtual DbSet<AddToCartMaster> AddToCartMaster { get; set; }
        public virtual DbSet<HelperMaster> HelperMaster { get; set; }
        public virtual DbSet<ReturnMaster> ReturnMaster { get; set; }
        public virtual DbSet<PartyMaster> PartyMaster { get; set; }
        public virtual DbSet<vou_list_master> vou_list_master { get; set; }
        public virtual DbSet<vou_trn_master> vou_trn_master { get; set; }
        public virtual DbSet<vou_master> vou_master { get; set; }


        public virtual DbSet<Auth_Token> Auth_Token { get; set; }
        public virtual DbSet<User_Detail> User_Detail { get; set; }
        public virtual DbSet<User_Log_Master> User_Log_Master { get; set; }
        public virtual DbSet<User_OTP_Transaction> User_OTP_Transaction { get; set; }
        public virtual DbSet<User_Profile_Master> User_Profile_Master { get; set; }
        public virtual DbSet<UserMultiAddDetails> UserMultiAddDetails { get; set; }
        public virtual DbSet<Forms_Master> Forms_Master { get; set; }
        public virtual DbSet<Forms_Trx_Master> Forms_Trx_Master { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Detail>(entity =>
            {
                entity.HasIndex(e => e.user_code).IsUnique();
                entity.HasOne(e => e.User_Profile_Masters)
                    .WithMany(e => e.User_Details).HasForeignKey(e => e.user_profile_id);
            });


            modelBuilder.Entity<Forms_Trx_Master>(entity =>
            {
                entity.HasOne(e => e.Forms_Master)
                .WithMany(e => e.Forms_Trx_Masters).HasForeignKey(e => e.form_master_id);
                entity.HasOne(e => e.User_Detail)
                .WithMany(e => e.Forms_Trx_Masters).HasForeignKey(e => e.user_id);
            });

            modelBuilder.Entity<UserMultiAddDetails>(entity =>
            {
                entity.HasOne(e => e.User_Detail)
                .WithMany(e => e.UserMultiAddDetails).HasForeignKey(e => e.userId);
            });

            modelBuilder.Entity<User_OTP_Transaction>(entity =>
            {
                entity.HasOne(e => e.User_Detail)
                .WithMany(e => e.User_OTP_Transactions).HasForeignKey(e => e.UserDetailId);
            });

            modelBuilder.Entity<ReviewMaster>(entity =>
            {
                entity.HasOne(e => e.User_Detail)
                .WithMany(e => e.ReviewMaster).HasForeignKey(e => e.user_id);
            });

            modelBuilder.Entity<ReturnMaster>(entity =>
            {
                entity.HasOne(e => e.OrderItemMaster)
                .WithMany(e => e.ReturnMaster).HasForeignKey(e => e.order_item_id);
            });

        }
    }
   

}