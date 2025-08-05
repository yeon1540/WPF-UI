using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using TeamManager.Data.Entity;

namespace TeamManager.Data
{
    public class TeamManagerDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "TeamManager.db");
            string dbPath = @"D:\GitHub\WPF-UI\TeamManager\TeamManager\TeamManager.db";
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
