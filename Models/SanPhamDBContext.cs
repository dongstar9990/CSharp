using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace B11_Phieu3.Models
{
    public partial class SanPhamDBContext : DbContext
    {
        public SanPhamDBContext()
        {
        }

        public SanPhamDBContext(DbContextOptions<SanPhamDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=SanPhamDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LoaiSanP__730A5759DAAFBA15");

                entity.ToTable("LoaiSanPham");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TenLoai).HasMaxLength(30);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SanPham__2725081C9A2F2B72");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(10)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(30)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK_sp_lsp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
