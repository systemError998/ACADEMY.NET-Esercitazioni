using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace librioteca.Models;

public partial class Task03BibliotecaContext : DbContext
{
    public Task03BibliotecaContext()
    {
    }

    public Task03BibliotecaContext(DbContextOptions<Task03BibliotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Prestito> Prestitos { get; set; }

    public virtual DbSet<Utente> Utentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACADEMY2024-30\\SQLEXPRESS;Database=task03_biblioteca;User Id=academy;Password=academy2024!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.LibroId).HasName("PK__Libro__18C65F4B6992162C");

            entity.ToTable("Libro");

            entity.Property(e => e.LibroId).HasColumnName("libroID");
            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Autore)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("autore");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.Disponibile)
                .HasDefaultValue(true)
                .HasColumnName("disponibile");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        modelBuilder.Entity<Prestito>(entity =>
        {
            entity.HasKey(e => e.PrestitoId).HasName("PK__Prestito__7E579A75EBEB82E7");

            entity.ToTable("Prestito");

            entity.Property(e => e.PrestitoId).HasColumnName("prestitoID");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.DataPrestito)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("data_prestito");
            entity.Property(e => e.DataRitorno)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("data_ritorno");
            entity.Property(e => e.LibroRif).HasColumnName("libroRIF");
            entity.Property(e => e.UtenteRif).HasColumnName("utenteRIF");

            entity.HasOne(d => d.LibroRifNavigation).WithMany(p => p.Prestitos)
                .HasForeignKey(d => d.LibroRif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Prestito__libroR__5535A963");

            entity.HasOne(d => d.UtenteRifNavigation).WithMany(p => p.Prestitos)
                .HasForeignKey(d => d.UtenteRif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Prestito__utente__5441852A");
        });

        modelBuilder.Entity<Utente>(entity =>
        {
            entity.HasKey(e => e.UtenteId).HasName("PK__Utente__CA5C225343FF6907");

            entity.ToTable("Utente");

            entity.Property(e => e.UtenteId).HasColumnName("utenteID");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("codice");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
