using System;
using Iatec.LegacyDatabases.Gan;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Iatec.LegacyDatabases
{
    public partial class GanDbContext : DbContext
    {
        public virtual DbSet<GanUser> ElAccountsGanuser { get; set; }

        public GanDbContext(DbContextOptions<GanDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GanUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("el_accounts_ganuser");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.AlternateEmail).HasMaxLength(100);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LanguageCode).HasMaxLength(100);

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockOutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastMobileMsgSendDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LastTwoFactAuthCode).HasMaxLength(100);

                entity.Property(e => e.OneTimeCode).HasMaxLength(100);

                entity.Property(e => e.OneTimePasswordGenDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(8000);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(8000);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.TwoFactorAuthSecret).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });
        }
    }
}
