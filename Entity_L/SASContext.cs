using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity_Layer
{
    public partial class SASContext : DbContext
    {
        public SASContext()
        {
        }

        public SASContext(DbContextOptions<SASContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Case> Cases { get; set; } = null!;
        public virtual DbSet<CaseStatus> CaseStatuses { get; set; } = null!;
        public virtual DbSet<CaseType> CaseTypes { get; set; } = null!;
        public virtual DbSet<CasesTodayView> CasesTodayViews { get; set; } = null!;
        public virtual DbSet<CasesView> CasesViews { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Detail> Details { get; set; } = null!;
        public virtual DbSet<SubCategory> SubCategories { get; set; } = null!;
        public virtual DbSet<Tracking> Trackings { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=ec2-18-215-96-22.compute-1.amazonaws.com;port=5432;Username=tzwcivhllrjqew;Password=6566053a603e3f97da02bc3c5a100c86ee944fd040d729995cabcc2d6be8e4d3;Database=deu2idj44gijd9");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pgcrypto");

            modelBuilder.Entity<Case>(entity =>
            {
                entity.HasKey(e => e.IdCases)
                    .HasName("Idcaso");

                entity.ToTable("Cases", "SAS");

                entity.Property(e => e.IdCases).UseIdentityAlwaysColumn();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.Time).HasMaxLength(50);
            });

            modelBuilder.Entity<CaseStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("pk");

                entity.ToTable("CaseStatus", "SAS");

                entity.Property(e => e.IdStatus).UseIdentityAlwaysColumn();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<CaseType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CaseType", "SAS");

                entity.Property(e => e.IdCaseType)
                    .ValueGeneratedOnAdd()
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sla)
                    .HasMaxLength(50)
                    .HasColumnName("SLA");

                entity.Property(e => e.Status).HasDefaultValueSql("true");
            });

            modelBuilder.Entity<CasesTodayView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CasesTodayView", "SAS");

                entity.Property(e => e.Casestatus)
                    .HasMaxLength(10)
                    .HasColumnName("casestatus");

                entity.Property(e => e.Casetype)
                    .HasMaxLength(50)
                    .HasColumnName("casetype");

                entity.Property(e => e.Client)
                    .HasMaxLength(50)
                    .HasColumnName("client");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.Time).HasMaxLength(50);
            });

            modelBuilder.Entity<CasesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CasesView", "SAS");

                entity.Property(e => e.Casestatus)
                    .HasMaxLength(10)
                    .HasColumnName("casestatus");

                entity.Property(e => e.Casetype)
                    .HasMaxLength(50)
                    .HasColumnName("casetype");

                entity.Property(e => e.Client)
                    .HasMaxLength(50)
                    .HasColumnName("client");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.Time).HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("Categoria_pkey");

                entity.ToTable("Category", "SAS");

                entity.Property(e => e.IdCategory).UseIdentityAlwaysColumn();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("true");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer)
                    .HasName("Clientes_pkey");

                entity.ToTable("Customer", "SAS");

                entity.Property(e => e.IdCustomer).UseIdentityAlwaysColumn();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Detail>(entity =>
            {
                entity.HasKey(e => e.IdDetails)
                    .HasName("Detalle_pkey");

                entity.ToTable("Details", "SAS");

                entity.Property(e => e.IdDetails).UseIdentityAlwaysColumn();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("true");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.IdSubCategory)
                    .HasName("SubCategoria_pkey");

                entity.ToTable("SubCategory", "SAS");

                entity.Property(e => e.IdSubCategory).UseIdentityAlwaysColumn();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("true");
            });

            modelBuilder.Entity<Tracking>(entity =>
            {
                entity.HasKey(e => e.IdTracking)
                    .HasName("Seguimientos_pkey");

                entity.ToTable("Tracking", "SAS");

                entity.Property(e => e.IdTracking).UseIdentityAlwaysColumn();

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.Time).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("Usuarios_pkey");

                entity.ToTable("Users", "SAS");

                entity.HasIndex(e => e.Code, "codigo")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.Property(e => e.IdUser).UseIdentityAlwaysColumn();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(200);
            });

            modelBuilder.HasSequence("casenumber");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
