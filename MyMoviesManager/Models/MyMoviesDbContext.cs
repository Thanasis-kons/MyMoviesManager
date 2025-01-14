﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyMoviesManager.Models;

public partial class MyMoviesDbContext : DbContext
{
    public MyMoviesDbContext()
    {
    }

    public MyMoviesDbContext(DbContextOptions<MyMoviesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actors> Actors { get; set; }

    public virtual DbSet<Movies> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\THANA\\source\\repos\\MyMoviesManager\\MyMoviesManager\\MyMoviesDb.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actors>(entity =>
        {
            entity.HasKey(e => e.ActorId).HasName("PK__Actors__57B3EA4BE6EED3E5");

            entity.Property(e => e.ActorName).HasMaxLength(100);

            entity.HasOne(d => d.Movie).WithMany(p => p.Actors)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK__Actors__MovieId__267ABA7A");
        });

        modelBuilder.Entity<Movies>(entity =>
        {
            entity.HasKey(e => e.MovieId).HasName("PK__Movies__4BD2941AAA6A70EA");

            entity.Property(e => e.Availability).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.ImagePath).HasMaxLength(255);
            entity.Property(e => e.Imdbrating).HasColumnName("IMDBRating");
            entity.Property(e => e.ReleaseDate).HasColumnType("date");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.WatchedDate).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}