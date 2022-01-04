using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SupermarketSystem.Models
{
    public partial class supermarketContext : DbContext
    {
        public supermarketContext()
        {
        }

        public supermarketContext(DbContextOptions<supermarketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GoodsGroupTbl> GoodsGroupTbls { get; set; }
        public virtual DbSet<GoodsInfoTbl> GoodsInfoTbls { get; set; }
        public virtual DbSet<GoodsNameTbl> GoodsNameTbls { get; set; }
        public virtual DbSet<GoodsRegistrationTbl> GoodsRegistrationTbls { get; set; }
        public virtual DbSet<SuplierTbl> SuplierTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=supermarket;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<GoodsGroupTbl>(entity =>
            {
                entity.ToTable("GoodsGroupTbl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodsInfoTbl>(entity =>
            {
                entity.ToTable("GoodsInfoTbl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.GoodsNameTblId).HasColumnName("GoodsNameTblID");

                entity.HasOne(d => d.GoodsNameTbl)
                    .WithMany(p => p.GoodsInfoTbls)
                    .HasForeignKey(d => d.GoodsNameTblId)
                    .HasConstraintName("FK__GoodsInfo__Goods__32E0915F");
            });

            modelBuilder.Entity<GoodsNameTbl>(entity =>
            {
                entity.ToTable("GoodsNameTbl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GoodsGroupTblId).HasColumnName("GoodsGroupTblID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.GoodsGroupTbl)
                    .WithMany(p => p.GoodsNameTbls)
                    .HasForeignKey(d => d.GoodsGroupTblId)
                    .HasConstraintName("FK__GoodsName__Goods__276EDEB3");
            });

            modelBuilder.Entity<GoodsRegistrationTbl>(entity =>
            {
                entity.ToTable("GoodsRegistrationTbl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.RegistrationDate).HasColumnType("date");

                entity.Property(e => e.SuplierTblId).HasColumnName("SuplierTblID");

                entity.HasOne(d => d.SuplierTbl)
                    .WithMany(p => p.GoodsRegistrationTbls)
                    .HasForeignKey(d => d.SuplierTblId)
                    .HasConstraintName("FK__GoodsRegi__Supli__2A4B4B5E");
            });

            modelBuilder.Entity<SuplierTbl>(entity =>
            {
                entity.ToTable("SuplierTbl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
