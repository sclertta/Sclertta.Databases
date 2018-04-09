using System;
using Iatec.Databases.AccessControl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Iatec.Databases
{
    public partial class AccessControlDbContext : DbContext
    {
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<ConstraintDefinition> ConstraintDefinition { get; set; }
        public virtual DbSet<ConstraintItem> ConstraintItem { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleConstraint> RoleConstraint { get; set; }
        public virtual DbSet<RoleMember> RoleMember { get; set; }
   
        public AccessControlDbContext(DbContextOptions<AccessControlDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>(entity =>
            {
                entity.HasKey(e => e.AssetId);

                entity.ToTable("el_accesscontrol_Asset");

                entity.Property(e => e.AssetId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            
                entity.HasOne(d => d.AssetType)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.AssetTypeId)
                    .HasConstraintName("FK__el_access__Asset__38996AB5");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ChildAssets)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_el_accesscontrol_Asset_el_accesscontrol_Asset");
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.HasKey(e => e.AssetTypeId);

                entity.ToTable("el_accesscontrol_AssetType");

                entity.Property(e => e.AssetTypeId).ValueGeneratedNever();

                entity.Property(e => e.IconClass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ConstraintDefinition>(entity =>
            {
                entity.HasKey(e => e.ConstraintDefinitionId);

                entity.ToTable("el_accesscontrol_constraintdefinition");

                entity.Property(e => e.ConstraintDefinitionId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ConstraintItem>(entity =>
            {
                entity.HasKey(e => e.ConstraintItemId);

                entity.ToTable("el_accesscontrol_constraintitem");

                entity.Property(e => e.ConstraintItemId).ValueGeneratedNever();

                entity.Property(e => e.Field).HasMaxLength(255);

                entity.Property(e => e.GroupingCode).HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.ConstraintDefinition)
                    .WithMany(p => p.ConstraintItems)
                    .HasForeignKey(d => d.ConstraintDefinitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("constraint_constraintItem");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.ToTable("el_accesscontrol_permission");

                entity.Property(e => e.PermissionId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_el_accesscontrol_permission_el_accesscontrol_Asset");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("permission_role");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("el_accesscontrol_role");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_el_accesscontrol_role_el_accesscontrol_Asset");

                entity.HasOne(d => d.ParentRole)
                    .WithMany(p => p.ChildRoles)
                    .HasForeignKey(d => d.ParentRoleId)
                    .HasConstraintName("role_parentRole");
            });

            modelBuilder.Entity<RoleConstraint>(entity =>
            {
                entity.HasKey(e => e.RoleConstraintId);

                entity.ToTable("el_accesscontrol_roleconstraint");

                entity.Property(e => e.RoleConstraintId).ValueGeneratedNever();

                entity.HasOne(d => d.ConstraintDefinition)
                    .WithMany(p => p.RoleConstraints)
                    .HasForeignKey(d => d.ConstraintDefinitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("roleConstraint_constraintDefinition");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleConstraints)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("roleConstraint_role");
            });

            modelBuilder.Entity<RoleMember>(entity =>
            {
                entity.HasKey(e => e.RoleMemberId);

                entity.ToTable("el_accesscontrol_rolemember");

                entity.Property(e => e.RoleMemberId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(255);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleMembers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rolemember_role");
            });
        }
    }
}
