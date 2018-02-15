using System;
using Iatec.LegacyDatabases.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Iatec.LegacyDatabases
{
    public partial class AccountsDbContext : DbContext
    {
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<PolicyPlace> PolicyPlace { get; set; }
        public virtual DbSet<Responsible> Responsible { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserActivity> UserActivity { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }

        public AccountsDbContext(DbContextOptions<AccountsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("el_accounts_group");

                entity.Property(e => e.GroupId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Domain)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.DomainId)
                    .HasConstraintName("FK__el_accoun__Domai__182C9B23");

                entity.HasOne(d => d.ParentGroup)
                    .WithMany(p => p.ChildGroups)
                    .HasForeignKey(d => d.ParentGroupId)
                    .HasConstraintName("FK__el_accoun__Paren__1920BF5C");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("el_accounts_location");

                entity.Property(e => e.LocationId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PhonePrefix).HasMaxLength(10);

                entity.Property(e => e.TimeZoneId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK__el_accoun__Regio__1A14E395");
            });

            modelBuilder.Entity<PolicyPlace>(entity =>
            {
                entity.HasKey(e => e.PolicyPlaceId);

                entity.ToTable("el_accounts_policyplace");

                entity.Property(e => e.PolicyPlaceId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Discriminator).HasMaxLength(8);

                entity.Property(e => e.LockoutWindowMin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PwdStrengthExpression).HasMaxLength(100);

                entity.Property(e => e.PwdStrengthMessage).HasMaxLength(1000);

                entity.Property(e => e.ServerUrl).HasMaxLength(255);

                entity.HasOne(d => d.Responsible)
                    .WithMany(p => p.PolicyPlaces)
                    .HasForeignKey(d => d.ResponsibleId)
                    .HasConstraintName("FK__el_accoun__Respo__1B0907CE");
            });

            modelBuilder.Entity<Responsible>(entity =>
            {
                entity.HasKey(e => e.ResponsibleId);

                entity.ToTable("el_accounts_responsible");

                entity.Property(e => e.ResponsibleId).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("el_accounts_user");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Provider).HasColumnName("ProviderEnum");

                entity.Property(e => e.Uid)
                    .HasColumnName("UId")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Domain)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DomainId)
                    .HasConstraintName("FK__el_accoun__Domai__1BFD2C07");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__el_accoun__Locat__1CF15040");
            });

            modelBuilder.Entity<UserActivity>(entity =>
            {
                entity.HasKey(e => e.UserActivityId);

                entity.ToTable("el_accounts_useractivity");

                entity.Property(e => e.UserActivityId).ValueGeneratedNever();

                entity.Property(e => e.ActivityDate).HasColumnType("datetime");

                entity.Property(e => e.BrowsingAgent).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DevicePlataform).HasMaxLength(100);

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserActivities)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__el_accoun__UserI__1DE57479");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(e => e.UserGroupId);

                entity.ToTable("el_accounts_usergroup");

                entity.Property(e => e.UserGroupId).ValueGeneratedNever();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.UserGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__el_accoun__Group__1ED998B2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__el_accoun__UserI__1FCDBCEB");
            });
        }
    }
}
