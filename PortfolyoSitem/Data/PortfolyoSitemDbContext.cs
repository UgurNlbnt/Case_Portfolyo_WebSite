using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PortfolyoSitem.Data;

public partial class PortfolyoSitemDbContext : DbContext
{
    public PortfolyoSitemDbContext()
    {
    }

    public PortfolyoSitemDbContext(DbContextOptions<PortfolyoSitemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AboutTable> AboutTables { get; set; }

    public virtual DbSet<CategoryTable> CategoryTables { get; set; }

    public virtual DbSet<CertificateTable> CertificateTables { get; set; }

    public virtual DbSet<ContactTable> ContactTables { get; set; }

    public virtual DbSet<EducationTable> EducationTables { get; set; }

    public virtual DbSet<ExperiencesTable> ExperiencesTables { get; set; }

    public virtual DbSet<ProfileTable> ProfileTables { get; set; }

    public virtual DbSet<ProjectsTable> ProjectsTables { get; set; }

    public virtual DbSet<SkillsTable> SkillsTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PortfolyoSitemDb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AboutTable>(entity =>
        {
            entity.HasKey(e => e.AboutId);

            entity.ToTable("AboutTable");

            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Title).HasMaxLength(1000);
        });

        modelBuilder.Entity<CategoryTable>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("CategoryTable");

            entity.Property(e => e.CategoryName).HasMaxLength(100);
        });

        modelBuilder.Entity<CertificateTable>(entity =>
        {
            entity.HasKey(e => e.CertificationsId);

            entity.ToTable("CertificateTable");

            entity.Property(e => e.CertificateName).HasMaxLength(500);
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.IconUrl).HasMaxLength(500);
            entity.Property(e => e.ShortDescription).HasMaxLength(500);
            entity.Property(e => e.Year).HasMaxLength(500);
        });

        modelBuilder.Entity<ContactTable>(entity =>
        {
            entity.HasKey(e => e.ContactId);

            entity.ToTable("ContactTable");

            entity.Property(e => e.EmailAdress).HasMaxLength(50);
            entity.Property(e => e.GithubUrl).HasMaxLength(500);
            entity.Property(e => e.InstagramUrl).HasMaxLength(500);
            entity.Property(e => e.LinkedlnUrl).HasMaxLength(500);
            entity.Property(e => e.ShortDescription).HasMaxLength(1000);
        });

        modelBuilder.Entity<EducationTable>(entity =>
        {
            entity.HasKey(e => e.EducationId);

            entity.ToTable("EducationTable");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ProgramName).HasMaxLength(50);
            entity.Property(e => e.SchoolName).HasMaxLength(50);
            entity.Property(e => e.Year).HasMaxLength(100);
            entity.Property(e => e.İconUrl).HasMaxLength(500);
        });

        modelBuilder.Entity<ExperiencesTable>(entity =>
        {
            entity.HasKey(e => e.ExperienceId);

            entity.ToTable("ExperiencesTable");

            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ShortDescription).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.Year).HasMaxLength(50);
        });

        modelBuilder.Entity<ProfileTable>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("ProfileTable");

            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.ImageUrl).HasMaxLength(500);
            entity.Property(e => e.ShortDescription).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<ProjectsTable>(entity =>
        {
            entity.HasKey(e => e.ProjectId);

            entity.ToTable("ProjectsTable");

            entity.Property(e => e.ProjectDescription).HasMaxLength(500);
            entity.Property(e => e.ProjectName).HasMaxLength(100);
            entity.Property(e => e.ProjectUrl).HasMaxLength(500);
            entity.Property(e => e.ShortDescription).HasMaxLength(200);
            entity.Property(e => e.UsingTechnologies).HasMaxLength(500);

            entity.HasOne(d => d.Category).WithMany(p => p.ProjectsTables)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_ProjectsTable_CategoryTable");
        });

        modelBuilder.Entity<SkillsTable>(entity =>
        {
            entity.HasKey(e => e.SkillsId);

            entity.ToTable("SkillsTable");

            entity.Property(e => e.ShortDescription).HasMaxLength(500);
            entity.Property(e => e.SkillName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
