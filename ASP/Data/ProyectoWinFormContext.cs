using System;
using ASPNET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASPNET.Data
{
    public partial class ProyectoWinFormContext : DbContext
    {
        public ProyectoWinFormContext()
        {
        }

        public ProyectoWinFormContext(DbContextOptions<ProyectoWinFormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AutorSet> AutorSet { get; set; }
        public virtual DbSet<ClasificacionSet> ClasificacionSet { get; set; }
        public virtual DbSet<ConfiguracionSet> ConfiguracionSet { get; set; }
        public virtual DbSet<EditorialSet> EditorialSet { get; set; }
        public virtual DbSet<GeneroSet> GeneroSet { get; set; }
        public virtual DbSet<LibroSet> LibroSet { get; set; }
        public virtual DbSet<PrestamoSet> PrestamoSet { get; set; }
        public virtual DbSet<UsuarioSet> UsuarioSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {/*
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Database=ProyectoWinForm;Trusted_Connection=True");*/
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutorSet>(entity =>
            {
                entity.HasKey(e => e.AutorId);

                entity.Property(e => e.Apellidos).IsRequired();

                entity.Property(e => e.Nombre).IsRequired();
            });

            modelBuilder.Entity<ClasificacionSet>(entity =>
            {
                entity.HasKey(e => e.ClasificacionId);

                entity.Property(e => e.Descripcion).IsRequired();
            });

            modelBuilder.Entity<ConfiguracionSet>(entity =>
            {
                entity.HasKey(e => e.ConfiguracionId);
            });

            modelBuilder.Entity<EditorialSet>(entity =>
            {
                entity.HasKey(e => e.EditorialId);

                entity.Property(e => e.CodigoPostal).IsRequired();

                entity.Property(e => e.Direccion).IsRequired();

                entity.Property(e => e.Poblacion).IsRequired();

                entity.Property(e => e.Provincia).IsRequired();

                entity.Property(e => e.RazonSocial).IsRequired();

                entity.Property(e => e.Telefono1).IsRequired();
            });

            modelBuilder.Entity<GeneroSet>(entity =>
            {
                entity.HasKey(e => e.GeneroId);

                entity.Property(e => e.Descripcion).IsRequired();
            });

            modelBuilder.Entity<LibroSet>(entity =>
            {
                entity.HasKey(e => e.LibroId);

                entity.HasIndex(e => e.AutorAutorId)
                    .HasName("IX_FK_AutorLibro");

                entity.HasIndex(e => e.ClasificacionClasificacionId)
                    .HasName("IX_FK_ClasificacionLibro");

                entity.HasIndex(e => e.EditorialEditorialId)
                    .HasName("IX_FK_EditorialLibro");

                entity.HasIndex(e => e.GeneroGeneroId)
                    .HasName("IX_FK_GeneroLibro");

                entity.Property(e => e.Descripción).IsRequired();

                entity.Property(e => e.Titulo).IsRequired();

                entity.HasOne(d => d.AutorAutor)
                    .WithMany(p => p.LibroSet)
                    .HasForeignKey(d => d.AutorAutorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutorLibro");

                entity.HasOne(d => d.ClasificacionClasificacion)
                    .WithMany(p => p.LibroSet)
                    .HasForeignKey(d => d.ClasificacionClasificacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClasificacionLibro");

                entity.HasOne(d => d.EditorialEditorial)
                    .WithMany(p => p.LibroSet)
                    .HasForeignKey(d => d.EditorialEditorialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EditorialLibro");

                entity.HasOne(d => d.GeneroGenero)
                    .WithMany(p => p.LibroSet)
                    .HasForeignKey(d => d.GeneroGeneroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneroLibro");
            });

            modelBuilder.Entity<PrestamoSet>(entity =>
            {
                entity.HasKey(e => e.PrestamoId);

                entity.HasIndex(e => e.LibroLibroId)
                    .HasName("IX_FK_LibroPrestamo");

                entity.HasIndex(e => e.UsuarioDni)
                    .HasName("IX_FK_UsuarioPrestamo");

                entity.Property(e => e.FechaDevolucion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.UsuarioDni)
                    .IsRequired()
                    .HasColumnName("UsuarioDNI")
                    .HasMaxLength(10);

                entity.HasOne(d => d.LibroLibro)
                    .WithMany(p => p.PrestamoSet)
                    .HasForeignKey(d => d.LibroLibroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LibroPrestamo");

                entity.HasOne(d => d.UsuarioDniNavigation)
                    .WithMany(p => p.PrestamoSet)
                    .HasForeignKey(d => d.UsuarioDni)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioPrestamo");
            });

            modelBuilder.Entity<UsuarioSet>(entity =>
            {
                entity.HasKey(e => e.Dni);

                entity.Property(e => e.Dni)
                    .HasColumnName("DNI")
                    .HasMaxLength(10);

                entity.Property(e => e.Apellidos).IsRequired();

                entity.Property(e => e.CodigoPostal).IsRequired();

                entity.Property(e => e.Direccion).IsRequired();

                entity.Property(e => e.Nombre).IsRequired();

                entity.Property(e => e.Poblacion).IsRequired();

                entity.Property(e => e.Provincia).IsRequired();

                entity.Property(e => e.Telefono1).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
