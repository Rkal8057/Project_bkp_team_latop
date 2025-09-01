using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DB.Login.Tables;
//using DB.Login.Migrations;

namespace DB.Login
{
    public partial class loginDBContext : DbContext
    {
        public loginDBContext(DbContextOptions<loginDBContext> options) : base(options)
        { }
        public virtual DbSet<CategoryMaster> CategoryMaster { get; set; }
        public virtual DbSet<ItemMaster> ItemMaster { get; set; }
        public virtual DbSet<ItemTransMixDetail> ItemTransMixDetail { get; set; }
        public virtual DbSet<ItemTransStockDetail> ItemTransStockDetail { get; set; }



        public virtual DbSet<PartyMaster> PartyMaster { get; set; }
        public virtual DbSet<PartyCategoryMaster> PartyCategoryMaster { get; set; }
        public virtual DbSet<PartyAddressTransMaster> PartyAddressTransMaster { get; set; }
        public virtual DbSet<PartyContactTransMaster> PartyContactTransMaster { get; set; }
        public virtual DbSet<AggrementMaster> AggrementMaster { get; set; }
        public virtual DbSet<PartyItemRateTrans> PartyItemRateTrans { get; set; }
        public virtual DbSet<Remark_Upload_Detail> Remark_Upload_Detail { get; set; }



        public virtual DbSet<IssueReceiptMaster> IssueReceiptMaster { get; set; }
        public virtual DbSet<IssueReceiptTransDetail> IssueReceiptTransDetail { get; set; }
        public virtual DbSet<IssueReceiptMiscTransDetail> IssueReceiptMiscTransDetail { get; set; }
        public virtual DbSet<IssueReceiptBreakageTransDetail> IssueReceiptBreakageTransDetail { get; set; }
        public virtual DbSet<Challan_Single_Item_Master> Challan_Single_Item_Master { get; set; }
        public virtual DbSet<IssueItemExtraDetail> IssueItemExtraDetail { get; set; }   


        public virtual DbSet<SalesMaster> SalesMaster { get; set; }
        public virtual DbSet<SalesTrxMaster> SalesTrxMaster { get; set; }

        public virtual DbSet<State_Master> State_Master { get; set; }
        public virtual DbSet<System_Records> System_Records { get; set; }
        public virtual DbSet<HelperMaster> HelperMaster { get; set; }
        public virtual DbSet<HelperFlagMaster> HelperFlagMaster { get; set; }
        public virtual DbSet<Location_Master> Location_Master { get; set; }
        public virtual DbSet<CaseMaster> CaseMaster { get; set; }
        public virtual DbSet<CaseHireMaster> CaseHireMaster { get; set; }
        public virtual DbSet<Guarantor1Detail> Guarantor1Detail { get; set; }
        public virtual DbSet<Guarantor2Detail> Guarantor2Detail { get; set; }
        public virtual DbSet<RecieptDetail> RecieptDetail { get; set; }
        public virtual DbSet<ExtraDetail> ExtraDetail { get; set; }
        public virtual DbSet<EMIDetail> EMIDetail { get; set; }
        public virtual DbSet<UploadDocument> UploadDocument { get; set; }

        public virtual DbSet<vou_list_master> vou_list_master { get; set; }
        public virtual DbSet<vou_trn_master> vou_trn_master { get; set; }
        public virtual DbSet<vou_master> vou_master { get; set; }
        public virtual DbSet<balance_sheet_master> balance_sheet_master { get; set; }
        public virtual DbSet<Multi_Purpose_Type_Master> Multi_Purpose_Type_Master { get; set; }
        public virtual DbSet<Form_Master> Form_Master { get; set; }
        public virtual DbSet<Auth_Token> Auth_Token { get; set; }
        public virtual DbSet<User_Detail> User_Detail { get; set; }
        public virtual DbSet<User_Registration_History> User_Registration_History { get; set; }
        public virtual DbSet<User_Log_Master> User_Log_Master { get; set; }
        public virtual DbSet<User_OTP_Transaction> User_OTP_Transaction { get; set; }
        public virtual DbSet<User_Profile_Master> User_Profile_Master { get; set; }
        public virtual DbSet<UserMultiAddDetails> UserMultiAddDetails { get; set; }
        public virtual DbSet<Forms_Master> Forms_Master { get; set; }
        public virtual DbSet<Forms_Trx_Master> Forms_Trx_Master { get; set; }
        public virtual DbSet<Bill_Rent_Master> Bill_Rent_Master { get; set;  }
        public virtual DbSet<BusinessContent> BusinessContent { get; set; }
        public virtual DbSet<BusinessSection> BusinessSection { get; set; }
        public virtual DbSet<BusinessUserDetail> BusinessUserDetail { get; set; }

        // mobile /user side table 

        public virtual DbSet<BlogMaster> BlogMaster { get; set; }
        public virtual DbSet<ReviewMaster> ReviewMaster { get; set; }
        public virtual DbSet<ContactMaster> ContactMaster { get; set; }
        public virtual DbSet<ClientMaster> ClientMaster { get; set; }
        public virtual DbSet<PortfolioMaster> PortfolioMaster { get; set; }
        public virtual DbSet<Slider_Master> Slider_Master { get; set; }
        public virtual DbSet<StyleMaster> StyleMaster { get; set; }
        public virtual DbSet<ServiceMaster> ServiceMaster { get; set; }
        public virtual DbSet<ServiceSubCategoryMaster> ServiceSubCategoryMaster { get; set; }
        public virtual DbSet<CheckListMaster> CheckListMaster { get; set; }

        public virtual DbSet<GeneralRequestedDetail> GeneralRequestedDetail { get; set; }
        public virtual DbSet<GeneralRequestCheckListDetail> GeneralRequestCheckListDetail { get; set; }

        public virtual DbSet<DailyTask> DailyTask { get; set; }
        public virtual DbSet<DailyTaskTans> DailyTaskTans { get; set; }
        public virtual DbSet<GeneralRequestCommunicationDetail> GeneralRequestCommunicationDetail { get; set; }
        public virtual DbSet<GeneralRequestRemark> GeneralRequestRemark { get; set; }
        public virtual DbSet<BussinessUserSectionDetail> BussinessUserSectionDetail { get; set; }
        public virtual DbSet<BussinessUserContentDetail> BussinessUserContentDetail { get; set; }
        public virtual DbSet<ActivityNameMaster> ActivityNameMaster { get; set; }
        public virtual DbSet<ActivityMaster> ActivityMaster { get; set; }
        public virtual DbSet<ActivityTranxMaster> ActivityTranxMaster { get; set; }
        public virtual DbSet<IssueReceiptTransWarrantyDetail> IssueReceiptTransWarrantyDetail { get; set; }
        public virtual DbSet<WarrantyExtended> WarrantyExtended { get; set; }
        public virtual DbSet<Sms_Msg_Master> Sms_Msg_Master { get; set; }

        

        public void TruncateTable(string tableName)
        {
            Database.ExecuteSqlRaw($"TRUNCATE TABLE {tableName};");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ItemTransMixDetail>(entity =>
            {
                entity.HasOne(e => e.ItemMaster)
                .WithMany(e => e.ItemTransMixDetail)
                .HasForeignKey(e => e.item_master_id);

                entity.HasQueryFilter(e => e.delete_at == 0);

            });



            modelBuilder.Entity<AggrementMaster>(entity =>
            {
                entity.HasOne(e => e.ItemMaster)
                .WithMany(e => e.AggrementMaster)
                .HasForeignKey(e => e.item_code);

                 entity.HasQueryFilter(e => e.delete == 0);

            });


            //modelBuilder.Entity<IssueReceiptTransDetail>(entity =>
            //{
            //    entity.HasOne(e => e.AggrementMaster)
            //        .WithMany(e => e.IssueReceiptTransDetail)
            //        .HasForeignKey(e => e.aggrement_id);

            //      // entity.HasQueryFilter(e => e.delete_at == 0);
            //});


            modelBuilder.Entity<PartyItemRateTrans>(entity =>
            {
                entity.HasOne(e => e.PartyMaster)
                .WithMany(e => e.PartyItemRateTrans)
                .HasForeignKey(e => e.party_master_id);

                entity.HasQueryFilter(e => e.delete == 0);

            });


           /* modelBuilder.Entity<PartyAddressTransMaster>(entity =>
            {
                entity.HasOne(e => e.PartyMaster)
                .WithMany(e => e.PartyAddressTransMaster)
                .HasForeignKey(e => e.party_master_id);

                entity.HasQueryFilter(e => e.delete_at == 0);

            });

            modelBuilder.Entity<PartyContactTransMaster>(entity =>
            {
                entity.HasOne(e => e.PartyMaster)
                .WithMany(e => e.PartyContactTransMaster)
                .HasForeignKey(e => e.party_master_id);
                entity.HasQueryFilter(e => e.delete_at == 0);
            });

            modelBuilder.Entity<PartyContactTransMaster>(entity =>
            {
                entity.HasOne(e => e.CaseMaster)
                .WithMany(e => e.PartyContactTransMaster)
                .HasForeignKey(e => e.case_master_id);
                entity.HasQueryFilter(e => e.delete_at == 0);
            });

            modelBuilder.Entity<PartyAddressTransMaster>(entity =>
            {
                entity.HasOne(e => e.CaseMaster)
                .WithMany(e => e.PartyAddressTransMaster)
                .HasForeignKey(e => e.case_master_id);
                entity.HasQueryFilter(e => e.delete_at == 0);
            });*/



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

        }

    }
}