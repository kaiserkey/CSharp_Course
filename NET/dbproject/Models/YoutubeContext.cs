using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dbproject.Models;

public partial class YoutubeContext : DbContext
{
    public YoutubeContext()
    {
    }

    public YoutubeContext(DbContextOptions<YoutubeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Playlist> Playlists { get; set; }

    public virtual DbSet<Video> Videos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_bin")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Playlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Playlist");

            entity.HasIndex(e => e.VideoId, "fk_Playlist_Video_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre).HasMaxLength(45);
            entity.Property(e => e.VideoId).HasColumnName("Video_id");

            entity.HasOne(d => d.Video).WithMany(p => p.Playlists)
                .HasForeignKey(d => d.VideoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Playlist_Video");
        });

        modelBuilder.Entity<Video>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Video");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
