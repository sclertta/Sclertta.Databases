﻿using System;
using Iatec.Databases.Applications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Iatec.Databases
{
    public partial class ApplicationsDbContext : DbContext
    {
        public virtual DbSet<AllowedScope> AllowedScopes { get; set; }
        public virtual DbSet<AppCategory> AppCategories { get; set; }
        public virtual DbSet<AppDeploy> AppDeploys { get; set; }
        public virtual DbSet<AppDeployHelp> AppDeployHelps { get; set; }
        public virtual DbSet<AppDeployHelpContent> AppDeployHelpContents { get; set; }
        public virtual DbSet<AppDeploySecret> AppDeploySecrets { get; set; }
        public virtual DbSet<Applications.AppDomain> AppDomains { get; set; }
        public virtual DbSet<AppHub> AppHubs { get; set; }
        public virtual DbSet<AppSolution> AppSolutions { get; set; }
        public virtual DbSet<AppTermsOfUse> AppTermsOfUses { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientLicense> ClientLicenses { get; set; }
        public virtual DbSet<ExecutionType> ExecutionTypes { get; set; }
        public virtual DbSet<FileContent> FileContents { get; set; }
        public virtual DbSet<ImageStorage> ImageStorages { get; set; }
        public virtual DbSet<InfraOwner> InfraOwners { get; set; }
        public virtual DbSet<Infrastructure> Infrastructures { get; set; }
        public virtual DbSet<InstallationHistory> InstallationHistories { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationUser> NotificationUsers { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<OrgResponsible> OrgResponsibles { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<PackageLink> PackageLinks { get; set; }
        public virtual DbSet<PackageRelease> PackageReleases { get; set; }
        public virtual DbSet<PackageType> PackageTypes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<RegionalSettings> RegionalSettings { get; set; }
        public virtual DbSet<Scope> Scopes { get; set; }
        public virtual DbSet<ScopeSecret> ScopeSecrets { get; set; }

        public ApplicationsDbContext(DbContextOptions<ApplicationsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllowedScope>(entity =>
            {
                entity.Property(e => e.ScopeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScopeOldId)
                    .HasColumnName("Scope_old_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.AppDeploy)
                    .WithMany(p => p.AllowedScopes)
                    .HasForeignKey(d => d.AppDeployId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AllowedSc__AppDe__1F63A897");

                entity.HasOne(d => d.Scope)
                    .WithMany(p => p.AllowedScope)
                    .HasForeignKey(d => d.ScopeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Scope_Id_InAllowed");
            });

            modelBuilder.Entity<AppCategory>(entity =>
            {
                entity.Property(e => e.AppCategoryId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<AppDeploy>(entity =>
            {
                entity.Property(e => e.AppDeployId).ValueGeneratedNever();

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.ContactEmail).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.DomainAllowed).HasMaxLength(255);

                entity.Property(e => e.MachineThumprint).HasMaxLength(255);

                entity.Property(e => e.ShowInDashboard).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkipRoutesNumForHelp).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AppDomain)
                    .WithMany(p => p.AppDeploys)
                    .HasForeignKey(d => d.AppDomainId)
                    .HasConstraintName("R_5");

                entity.HasOne(d => d.ClientLicense)
                    .WithMany(p => p.AppDeploys)
                    .HasForeignKey(d => d.ClientLicenseId)
                    .HasConstraintName("FK_client_license");

                entity.HasOne(d => d.Infrastructure)
                    .WithMany(p => p.AppDeploy)
                    .HasForeignKey(d => d.InfrastructureId)
                    .HasConstraintName("R_10");

                entity.HasOne(d => d.LogoImage)
                    .WithMany(p => p.AppDeploys)
                    .HasForeignKey(d => d.LogoImageId)
                    .HasConstraintName("R_6");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.AppDeploys)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("R_11");
            });

            modelBuilder.Entity<AppDeployHelp>(entity =>
            {
                entity.Property(e => e.AppDeployHelpId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RelativeUrl)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlCaught)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.AppDeploy)
                    .WithMany(p => p.AppDeployHelps)
                    .HasForeignKey(d => d.AppDeployId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppDeployHelp_AppDeploy");

                entity.HasOne(d => d.ParentAppDeployHelp)
                    .WithMany(p => p.InverseParentAppDeployHelps)
                    .HasForeignKey(d => d.ParentAppDeployHelpId)
                    .HasConstraintName("FK_AppDeployHelp_AppDeployHelp");
            });

            modelBuilder.Entity<AppDeployHelpContent>(entity =>
            {
                entity.Property(e => e.AppDeployHelpContentId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HelpUrlTarget)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AppDeployHelp)
                    .WithMany(p => p.AppDeployHelpContents)
                    .HasForeignKey(d => d.AppDeployHelpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppDeployHelpContent_AppDeployHelp");
            });

            modelBuilder.Entity<AppDeploySecret>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Expiration).HasColumnType("datetime");

                entity.Property(e => e.SecretHash)
                    .IsRequired()
                    .HasColumnType("binary(32)");

                entity.HasOne(d => d.AppDeploy)
                    .WithMany(p => p.AppDeploySecrets)
                    .HasForeignKey(d => d.AppDeployId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppDeploy__AppDe__3A179ED3");
            });

            modelBuilder.Entity<Applications.AppDomain>(entity =>
            {
                entity.Property(e => e.AppDomainId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.HelpUrl).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.OidcFlowEnum).HasDefaultValueSql("((0))");

                entity.Property(e => e.RenewRelativeUrl).HasMaxLength(200);

                entity.Property(e => e.SerialCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SignInRelativeUrl).HasMaxLength(200);

                entity.Property(e => e.SignOutRelativeUrl).HasMaxLength(200);

                entity.Property(e => e.TestRelativeUrl).HasMaxLength(200);

                entity.Property(e => e.UserSupportEmail).HasMaxLength(100);

                entity.Property(e => e.UserSupportUrl).HasMaxLength(100);

                entity.HasOne(d => d.AppCategory)
                    .WithMany(p => p.AppDomains)
                    .HasForeignKey(d => d.AppCategoryId)
                    .HasConstraintName("R_4");

                entity.HasOne(d => d.AppSolution)
                    .WithMany(p => p.AppDomains)
                    .HasForeignKey(d => d.AppSolutionId)
                    .HasConstraintName("FK_AppDomain_Solution");

                entity.HasOne(d => d.LargeImage)
                    .WithMany(p => p.AppDomainLargeImage)
                    .HasForeignKey(d => d.LargeImageId)
                    .HasConstraintName("R_1");

                entity.HasOne(d => d.MediumImage)
                    .WithMany(p => p.AppDomainMediumImage)
                    .HasForeignKey(d => d.MediumImageId)
                    .HasConstraintName("R_2");

                entity.HasOne(d => d.SmallImage)
                    .WithMany(p => p.AppDomainSmallImage)
                    .HasForeignKey(d => d.SmallImageId)
                    .HasConstraintName("R_3");
            });

            modelBuilder.Entity<AppHub>(entity =>
            {
                entity.Property(e => e.AppHubId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.AppDomain)
                    .WithMany(p => p.AppHubs)
                    .HasForeignKey(d => d.AppDomainId)
                    .HasConstraintName("FK__AppHub__AppDomai__0D7A0286");
            });

            modelBuilder.Entity<AppSolution>(entity =>
            {
                entity.Property(e => e.AppSolutionId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppTermsOfUse>(entity =>
            {
                entity.Property(e => e.AppTermsOfUseId).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.TermsContentTypeEnum).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AppDomain)
                    .WithMany(p => p.AppTermsOfUse)
                    .HasForeignKey(d => d.AppDomainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTermsO__AppDo__4183B671");

                entity.HasOne(d => d.RegionalSettings)
                    .WithMany(p => p.AppTermsOfUse)
                    .HasForeignKey(d => d.RegionalSettingsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AppTermsO__Regio__4277DAAA");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId).ValueGeneratedNever();

                entity.Property(e => e.ContactEmail).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<ClientLicense>(entity =>
            {
                entity.Property(e => e.ClientLicenseId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AppDomain)
                    .WithMany(p => p.ClientLicenses)
                    .HasForeignKey(d => d.AppDomainId)
                    .HasConstraintName("R_8");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientLicense)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("R_7");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ClientLicense)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK__ClientLic__Organ__3A4CA8FD");
            });

            modelBuilder.Entity<ExecutionType>(entity =>
            {
                entity.Property(e => e.ExecutionTypeId).ValueGeneratedNever();

                entity.Property(e => e.FileExtension).HasMaxLength(50);

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TypeFullName).HasMaxLength(200);
            });

            modelBuilder.Entity<FileContent>(entity =>
            {
                entity.Property(e => e.FileContentId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ExecutionType)
                    .WithMany(p => p.FileContents)
                    .HasForeignKey(d => d.ExecutionTypeId)
                    .HasConstraintName("FK__FileConte__Execu__2739D489");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.FileContents)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK__FileConte__Packa__282DF8C2");
            });

            modelBuilder.Entity<ImageStorage>(entity =>
            {
                entity.Property(e => e.ImageStorageId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<InfraOwner>(entity =>
            {
                entity.Property(e => e.InfraOwnerId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EmailContact)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Infrastructure>(entity =>
            {
                entity.Property(e => e.InfrastructureId).ValueGeneratedNever();

                entity.Property(e => e.BillingSupportPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumerServicePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EmailContact)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.InfraOwner)
                    .WithMany(p => p.Infrastructures)
                    .HasForeignKey(d => d.InfraOwnerId)
                    .HasConstraintName("R_9");
            });

            modelBuilder.Entity<InstallationHistory>(entity =>
            {
                entity.Property(e => e.InstallationHistoryId).ValueGeneratedNever();

                entity.Property(e => e.InstallationDate).HasColumnType("datetime");

                entity.Property(e => e.InstalledBy).HasMaxLength(100);

                entity.HasOne(d => d.AppHub)
                    .WithMany(p => p.InstallationHistory)
                    .HasForeignKey(d => d.AppHubId)
                    .HasConstraintName("FK__Installat__AppHu__22751F6C");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.InstallationHistory)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK__Installat__Packa__2180FB33");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.NotificationId).ValueGeneratedNever();

                entity.Property(e => e.BeginDateTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contents).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.Groups)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastModificationDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Users)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.AppDeploy)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.AppDeployId)
                    .HasConstraintName("FK_Notification_AppDeploy");

                entity.HasOne(d => d.AppDomain)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.AppDomainId)
                    .HasConstraintName("FK_Notification_AppDomain");

                entity.HasOne(d => d.Infrastructure)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.InfrastructureId)
                    .HasConstraintName("FK_Notification_Infrastructure");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Notification_Region");
            });

            modelBuilder.Entity<NotificationUser>(entity =>
            {
                entity.Property(e => e.NotificationUserId).ValueGeneratedNever();

                entity.Property(e => e.ReadedOnDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(150);

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.NotificationUsers)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("FK_NotificationUser_Notification");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.Property(e => e.OrganizationId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EmailContact)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OrgResponsible>(entity =>
            {
                entity.Property(e => e.OrgResponsibleId).ValueGeneratedNever();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrgResponsibles)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrgRespon__Clien__40F9A68C");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrgResponsibles)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrgRespon__Organ__40058253");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.Property(e => e.PackageId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FileChecksum)
                    .IsRequired()
                    .HasColumnType("binary(32)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SavedInLocalBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SavedInLocalDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.AppDomain)
                    .WithMany(p => p.Packages)
                    .HasForeignKey(d => d.AppDomainId)
                    .HasConstraintName("FK__Package__AppDoma__19DFD96B");

                entity.HasOne(d => d.PackageType)
                    .WithMany(p => p.Packages)
                    .HasForeignKey(d => d.PackageTypeId)
                    .HasConstraintName("FK__Package__Package__1AD3FDA4");
            });

            modelBuilder.Entity<PackageLink>(entity =>
            {
                entity.Property(e => e.PackageLinkId).ValueGeneratedNever();

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Packages)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PackageLi__Packa__2DE6D218");

                entity.HasOne(d => d.PackageLinked)
                    .WithMany(p => p.LinkedPackages)
                    .HasForeignKey(d => d.PackageLinkedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PackageLi__Packa__2CF2ADDF");
            });

            modelBuilder.Entity<PackageRelease>(entity =>
            {
                entity.Property(e => e.PackageReleaseId).ValueGeneratedNever();

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.ReleaseNotes).HasMaxLength(300);

                entity.Property(e => e.ReleasedBy).HasMaxLength(100);

                entity.HasOne(d => d.AppDeploy)
                    .WithMany(p => p.PackageReleases)
                    .HasForeignKey(d => d.AppDeployId)
                    .HasConstraintName("FK__PackageRe__AppDe__3587F3E0");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PackageReleases)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__PackageRe__Clien__339FAB6E");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PackageReleases)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK__PackageRe__Packa__32AB8735");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.PackageReleases)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK__PackageRe__Regio__3493CFA7");
            });

            modelBuilder.Entity<PackageType>(entity =>
            {
                entity.Property(e => e.PackageTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId).ValueGeneratedNever();

                entity.Property(e => e.CultureCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeZone).HasMaxLength(100);
            });

            modelBuilder.Entity<RegionalSettings>(entity =>
            {
                entity.Property(e => e.RegionalSettingsId).ValueGeneratedNever();

                entity.Property(e => e.SupportEmail).HasMaxLength(50);

                entity.Property(e => e.SupportUrl).HasMaxLength(255);

                entity.Property(e => e.TermsAndPrivacyUrl).HasMaxLength(255);

                entity.HasOne(d => d.AppDomain)
                    .WithMany(p => p.RegionalSettings)
                    .HasForeignKey(d => d.AppDomainId)
                    .HasConstraintName("R_15");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RegionalSettings)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("R_16");
            });

            modelBuilder.Entity<Scope>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeOldId)
                    .HasColumnName("Scope_old_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");
            });

            modelBuilder.Entity<ScopeSecret>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Expiration).HasColumnType("datetime");

                entity.Property(e => e.ScopeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScopeOldId)
                    .HasColumnName("Scope_old_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SecretHash)
                    .IsRequired()
                    .HasColumnType("binary(32)");

                entity.HasOne(d => d.Scope)
                    .WithMany(p => p.ScopeSecrets)
                    .HasForeignKey(d => d.ScopeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Scope_Id");
            });
        }
    }
}
