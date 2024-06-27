using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Comm.sqlite.Models
{
    public partial class DefaultContext : DbContext
    {
        public DefaultContext()
        {
        }

        public DefaultContext(DbContextOptions<DefaultContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlarmHistory> AlarmHistory { get; set; }
        public virtual DbSet<AlarmInfo> AlarmInfo { get; set; }
        public virtual DbSet<Eqpinfo> Eqpinfo { get; set; }
        public virtual DbSet<Io> Io { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductInfo> ProductInfo { get; set; }
        public virtual DbSet<RecipeList> RecipeList { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScreenInfo> ScreenInfo { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<Utility> Utility { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=D:\\DB\\Default.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlarmHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClearTime)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Heavy).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.OccurTime)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Unit).IsRequired();
            });

            modelBuilder.Entity<AlarmInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChiComment).IsRequired();

                entity.Property(e => e.ChiDescription).IsRequired();

                entity.Property(e => e.ChiSolution).IsRequired();

                entity.Property(e => e.EngComment).IsRequired();

                entity.Property(e => e.EngDescription).IsRequired();

                entity.Property(e => e.EngSolution).IsRequired();

                entity.Property(e => e.Heavy).IsRequired();

                entity.Property(e => e.ImageDir).IsRequired();

                entity.Property(e => e.KorCommant).IsRequired();

                entity.Property(e => e.KorDescription).IsRequired();

                entity.Property(e => e.KorSolution).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Unit).IsRequired();
            });

            modelBuilder.Entity<Eqpinfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data).IsRequired();
            });

            modelBuilder.Entity<Io>(entity =>
            {
                entity.ToTable("IO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Unit).IsRequired();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BlockId)
                    .IsRequired()
                    .HasColumnName("BlockID");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.LotId)
                    .IsRequired()
                    .HasColumnName("LotID");

                entity.Property(e => e.ProductBlob)
                    .IsRequired()
                    .HasColumnName("ProductBLOB");

                entity.Property(e => e.Recipe).IsRequired();

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnType("VARCHAR");
            });

            modelBuilder.Entity<ProductInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LotId)
                    .IsRequired()
                    .HasColumnName("LotID");

                entity.Property(e => e.PinfoBlob)
                    .IsRequired()
                    .HasColumnName("PInfoBLOB");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasColumnName("ProductID");

                entity.Property(e => e.Recipe).IsRequired();

                entity.Property(e => e.Stage).IsRequired();
            });

            modelBuilder.Entity<RecipeList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessLevel).IsRequired();

                entity.Property(e => e.CreateTime)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.Unit);

                entity.Property(e => e.Unit).HasDefaultValueSql("'UnitName'");

                entity.Property(e => e.CmdIndex).HasColumnName("Cmd_Index");

                entity.Property(e => e.EnetIp)
                    .IsRequired()
                    .HasColumnName("ENet_IP")
                    .HasDefaultValueSql("'127.0.0.1'");

                entity.Property(e => e.EnetPort)
                    .IsRequired()
                    .HasColumnName("ENet_Port")
                    .HasDefaultValueSql("8000");

                entity.Property(e => e.EnetUse).HasColumnName("ENet_Use");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasColumnName("ProductID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReciveMsg)
                    .IsRequired()
                    .HasColumnName("Recive_Msg")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RunIndex)
                    .HasColumnName("Run_Index")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SendMsg)
                    .IsRequired()
                    .HasColumnName("Send_Msg")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeqIndex).HasColumnName("Seq_Index");

                entity.Property(e => e.SerialBuad)
                    .IsRequired()
                    .HasColumnName("Serial_Buad")
                    .HasDefaultValueSql("9600");

                entity.Property(e => e.SerialPort)
                    .IsRequired()
                    .HasColumnName("Serial_Port")
                    .HasDefaultValueSql("'COM1'");

                entity.Property(e => e.SerialUse).HasColumnName("Serial_Use");
            });

            modelBuilder.Entity<ScreenInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Auto)
                    .HasColumnName("AUTO")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Manual)
                    .HasColumnName("MANUAL")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Recipe)
                    .HasColumnName("RECIPE")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.System)
                    .HasColumnName("SYSTEM")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Level).IsRequired();

                entity.Property(e => e.Password).IsRequired();
            });

            modelBuilder.Entity<Utility>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'ID'");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Adress2)
                    .IsRequired()
                    .HasDefaultValueSql("0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
