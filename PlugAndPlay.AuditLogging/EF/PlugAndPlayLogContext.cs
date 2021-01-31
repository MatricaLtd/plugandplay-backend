﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PlugAndPlay.AuditLogging.EF
{
    public partial class PlugAndPlayLogContext : DbContext
    {
        public PlugAndPlayLogContext()
        {
        }

        public PlugAndPlayLogContext(DbContextOptions<PlugAndPlayLogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Command> Command { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Command>(entity =>
            {
                entity.Property(e => e.CommandData).IsRequired();

                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(6)");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Success).HasDefaultValueSql("((0))");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}