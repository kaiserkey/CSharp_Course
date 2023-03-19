﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace net_project.Models;

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

/*      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=Youtube;uid=root;password=1234", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));
 */

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        optionsBuilder.UseMySql(
            configuration.GetConnectionString("MySQLContext"),
            Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));
    }
}

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
