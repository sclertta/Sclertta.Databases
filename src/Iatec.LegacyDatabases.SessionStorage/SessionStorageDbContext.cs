﻿using System;
using Iatec.LegacyDatabases.SessionStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Iatec.LegacyDatabases
{
    public partial class SessionStorageDbContext : DbContext
    {
        public virtual DbSet<StateItem> StateItem { get; set; }
        public SessionStorageDbContext(DbContextOptions<SessionStorageDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateItem>(entity =>
            {
                entity.HasKey(e => e.StateItemId);

                entity.ToTable("el_state_item");

                entity.Property(e => e.StateItemId).ValueGeneratedNever();

                entity.Property(e => e.ContextName).HasMaxLength(100);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UserPrincipal).HasMaxLength(100);
            });
        }
    }
}
