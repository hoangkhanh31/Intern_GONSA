using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class GonsaContext : DbContext
{
    public GonsaContext()
    {
    }

    public GonsaContext(DbContextOptions<GonsaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CbnvGonsa> CbnvGonsas { get; set; }

    public virtual DbSet<UserMiddleware> UserMiddlewares { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=GONSA;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CbnvGonsa>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__CBNV_Gon__7AB896891108C28F");

            entity.ToTable("CBNV_Gonsa");

            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_Nhan_Vien");
            entity.Property(e => e.ChucVu)
                .HasMaxLength(500)
                .HasColumnName("Chuc_Vu");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PhongBan)
                .HasMaxLength(500)
                .HasColumnName("Phong_Ban");
            entity.Property(e => e.SoDt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("So_DT");
            entity.Property(e => e.TenNhanVien)
                .HasMaxLength(200)
                .HasColumnName("Ten_Nhan_Vien");
        });

        modelBuilder.Entity<UserMiddleware>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__User_Mid__536C85E56D56FC05");

            entity.ToTable("User_Middleware");

            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ma_Nhan_Vien");
            entity.Property(e => e.Note).HasMaxLength(1000);
            entity.Property(e => e.Passwd)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserPrivilege)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Privilege");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.UserMiddlewares)
                .HasForeignKey(d => d.MaNhanVien)
                .HasConstraintName("FK_MaNhanVien");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
