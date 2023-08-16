using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.TestModels;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //Connection String
        => optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=Test;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lop__3214EC2707304BA2");

            entity.ToTable("Lop");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'Khanh class')")
                .HasColumnName("name");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SinhVien__3214EC27943752A3");

            entity.ToTable("SinhVien");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idlop).HasColumnName("IDLop");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("('Khanh')")
                .HasColumnName("name");

            entity.HasOne(d => d.IdlopNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.Idlop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SinhVien__IDLop__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
