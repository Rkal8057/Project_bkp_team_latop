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
        public virtual DbSet<Remark_Upload_Detail> Remark_Upload_Detail { get; set; }


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


            modelBuilder.Entity<IssueReceiptTransDetail>(entity =>
            {
                entity.HasOne(e => e.AggrementMaster)
                    .WithMany(e => e.IssueReceiptTransDetail)
                    .HasForeignKey(e => e.aggrement_id);

                  // entity.HasQueryFilter(e => e.delete_at == 0);
            });


            modelBuilder.Entity<PartyItemRateTrans>(entity =>
            {
                entity.HasOne(e => e.PartyMaster)
                .WithMany(e => e.PartyItemRateTrans)
                .HasForeignKey(e => e.party_master_id);

                entity.HasQueryFilter(e => e.delete == 0);

            });




        }

    }
}