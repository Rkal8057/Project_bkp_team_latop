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

        public virtual DbSet<PartyMaster> PartyMaster { get; set; }
        public virtual DbSet<SalesMaster> SalesMaster { get; set; }
        public virtual DbSet<SalesTrxMaster> SalesTrxMaster { get; set; }

    }
}