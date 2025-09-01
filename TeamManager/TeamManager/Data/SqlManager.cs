using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using TeamManager.Data.Entity;
using TeamManager.Data.Repositories;

namespace TeamManager.Data
{
    public class SqlManager : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategorys { get; set; }
        public ItemRepo ItemsRepo { get; }

        public SqlManager()
        {
            ItemsRepo = new ItemRepo(this);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionPath = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            string dbPath = Path.Combine(solutionPath, "Data", "TeamManager.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
