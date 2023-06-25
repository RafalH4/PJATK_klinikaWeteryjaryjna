using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KlinikaWeterynaryjna.Domain;

public partial class KlinikaWeterynaryjnaContext : DbContext
{
    public KlinikaWeterynaryjnaContext()
    {
    }

    public KlinikaWeterynaryjnaContext(DbContextOptions<KlinikaWeterynaryjnaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Uzytkownik> Uzytkowniks { get; set; }

    public virtual DbSet<Wlasciciel> Wlasciciels { get; set; }

    public virtual DbSet<Zwierze> Zwierzes { get; set; }

    public virtual DbSet<ZwierzetaZwlascicielami> ZwierzetaZwlascicielamis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-LQFAVEE;Initial Catalog=KlinikaWeterynaryjna;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Uzytkownik>(entity =>
        {
            entity.HasKey(e => e.IdUzytkownik);

            entity.ToTable("Uzytkownik");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Haslo).IsUnicode(false);
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Wlasciciel>(entity =>
        {
            entity.HasKey(e => e.IdWlasciciel);

            entity.ToTable("Wlasciciel", tb =>
                {
                    tb.HasTrigger("MSmerge_del_B3C0B9C0509247EBA3281BCAE58E1AA4");
                    tb.HasTrigger("MSmerge_ins_B3C0B9C0509247EBA3281BCAE58E1AA4");
                    tb.HasTrigger("MSmerge_upd_B3C0B9C0509247EBA3281BCAE58E1AA4");
                });

            entity.HasIndex(e => e.Rowguid, "MSmerge_index_1221579390").IsUnique();

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Imie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("rowguid");
            entity.Property(e => e.Telefon)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Zwierze>(entity =>
        {
            entity.HasKey(e => e.IdZwierze);

            entity.ToTable("Zwierze", tb =>
                {
                    tb.HasTrigger("MSmerge_del_CD623EC84B214DBAB4B0AD6311F5689F");
                    tb.HasTrigger("MSmerge_ins_CD623EC84B214DBAB4B0AD6311F5689F");
                    tb.HasTrigger("MSmerge_upd_CD623EC84B214DBAB4B0AD6311F5689F");
                });

            entity.HasIndex(e => e.Rowguid, "MSmerge_index_1253579504").IsUnique();

            entity.Property(e => e.DataOstWizyty).HasColumnType("date");
            entity.Property(e => e.Gatunek)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("rowguid");

            entity.HasOne(d => d.IdWlascicielNavigation).WithMany(p => p.Zwierzes)
                .HasForeignKey(d => d.IdWlasciciel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Zwierze_Wlasciciel");
        });

        modelBuilder.Entity<ZwierzetaZwlascicielami>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZwierzetaZWlascicielami");

            entity.Property(e => e.DataOstWizyty).HasColumnType("date");
            entity.Property(e => e.Gatunek)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Imie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
