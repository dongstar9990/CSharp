using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Bai12_Phieu1.Models
{
    public partial class b12_phieu1Context : DbContext
    {
        public b12_phieu1Context()
        {
        }

        public b12_phieu1Context(DbContextOptions<b12_phieu1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Commodity> Commoditys { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceCommodity> InvoiceCommodities { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=b12_phieu1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Commodity>(entity =>
            {
                entity.HasKey(e => e.CommodityCode)
                    .HasName("PK__commodit__6C0BFFF2BF9412C6");

                entity.ToTable("commoditys");

                entity.Property(e => e.CommodityCode)
                    .ValueGeneratedNever()
                    .HasColumnName("commodity_code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceNumber)
                    .HasName("PK__invoices__8081A63B5D44349D");

                entity.ToTable("invoices");

                entity.Property(e => e.InvoiceNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("invoice_number");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoice_date");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username")
                    .IsFixedLength(true);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__invoices__userna__17F790F9");
            });

            modelBuilder.Entity<InvoiceCommodity>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceNumber, e.CommodityCode })
                    .HasName("PK__invoice___B64119C47CD6C681");

                entity.ToTable("invoice_commodity");

                entity.Property(e => e.InvoiceNumber).HasColumnName("invoice_number");

                entity.Property(e => e.CommodityCode).HasColumnName("commodity_code");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.CommodityCodeNavigation)
                    .WithMany(p => p.InvoiceCommodities)
                    .HasForeignKey(d => d.CommodityCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__invoice_c__commo__1DB06A4F");

                entity.HasOne(d => d.InvoiceNumberNavigation)
                    .WithMany(p => p.InvoiceCommodities)
                    .HasForeignKey(d => d.InvoiceNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__invoice_c__invoi__1CBC4616");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__users__F3DBC573BE221E44");

                entity.ToTable("users");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username")
                    .IsFixedLength(true);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("full_name")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
