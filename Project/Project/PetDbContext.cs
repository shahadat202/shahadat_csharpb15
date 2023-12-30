﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class PetDbContext : DbContext
    {
        private readonly string _connectionString;
        public PetDbContext()
        {
            _connectionString = "Server = DESKTOP-N8A2ENF\\SQLEXPRESS; Database = CSharpB15; User Id = csharpb15; Password = 123456; Trust Server Certificate = True";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
                optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<Sale> sales { get; set; }
        public DbSet<FeedingSchedule> feedingSchedules { get; set;}
        public DbSet<MonthlyReport> monthlyReports { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<MonthlyReport>(entity =>
        //    {
        //        entity.HasNoKey();
        //    });
        //}
    }
}
