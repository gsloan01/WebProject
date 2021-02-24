﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MTGDeckBuilder.Models
{
    public class DB_Entities : DbContext
    {
        public DB_Entities() : base("DB_A6FB48_MTGDeckBuilderDBEntities") { }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<demoEntities>(null);
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);


        }
    }
}