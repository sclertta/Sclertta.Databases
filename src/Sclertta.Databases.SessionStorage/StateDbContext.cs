using System;
using Sclertta.Databases.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sclertta.Databases
{
    public partial class StateDbContext : DbContext
    {
        public virtual DbSet<StateItem> StateItems { get; set; }
        public StateDbContext(DbContextOptions<StateDbContext> options) : base(options)
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
