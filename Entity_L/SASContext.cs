using System;
using System.Collections.Generic;
using System.Text.Json;
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

        public virtual DbSet<Caso> Casos { get; set; } = null!;
        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Detalle> Detalles { get; set; } = null!;
        public virtual DbSet<SubCategorium> SubCategoria { get; set; } = null!;
        public virtual DbSet<TipoDeCaso> TipoDeCasos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=ec2-18-215-96-22.compute-1.amazonaws.com;port=5432;Username=tzwcivhllrjqew;Password=6566053a603e3f97da02bc3c5a100c86ee944fd040d729995cabcc2d6be8e4d3;Database=deu2idj44gijd9");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caso>(entity =>
            {
                entity.HasKey(e => e.IdCaso)
                    .HasName("Idcaso");

                entity.ToTable("Casos", "SAS");

                entity.Property(e => e.IdCaso).ValueGeneratedNever();

                //entity.Property(e => e.Extra).HasConversion(json => json.GetRawText(), str => JsonDocument.Parse(str, default).RootElement);

                entity.Property(e => e.Fecha).HasMaxLength(50);

                entity.Property(e => e.Tiempo).HasMaxLength(50);
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("Categoria_pkey");

                entity.ToTable("Categoria", "SAS");

                entity.Property(e => e.IdCategoria).UseIdentityAlwaysColumn();

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("Clientes_pkey");

                entity.ToTable("Clientes", "SAS");

                entity.Property(e => e.IdCliente).UseIdentityAlwaysColumn();

                entity.Property(e => e.Apellidos).HasMaxLength(50);

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Detalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("Detalle_pkey");

                entity.ToTable("Detalle", "SAS");

                entity.Property(e => e.IdDetalle).UseIdentityAlwaysColumn();

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<SubCategorium>(entity =>
            {
                entity.HasKey(e => e.IdSubCategoria)
                    .HasName("SubCategoria_pkey");

                entity.ToTable("SubCategoria", "SAS");

                entity.Property(e => e.IdSubCategoria).UseIdentityAlwaysColumn();

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoDeCaso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TipoDeCasos", "SAS");

                entity.Property(e => e.IdCaso)
                    .ValueGeneratedOnAdd()
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Sla)
                    .HasMaxLength(50)
                    .HasColumnName("SLA");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("Usuarios_pkey");

                entity.ToTable("Usuarios", "SAS");

                entity.HasIndex(e => e.Codigo, "codigo")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).UseIdentityAlwaysColumn();

                entity.Property(e => e.Apellidos).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
