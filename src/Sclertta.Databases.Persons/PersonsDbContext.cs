using System;
using Sclertta.Databases.Persons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sclertta.Databases
{
    public partial class PersonsDbContext : DbContext
    {
        public PersonsDbContext()
        {
        }

        public PersonsDbContext(DbContextOptions<PersonsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<AllergyType> AllergyType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DisabilityType> DisabilityType { get; set; }
        public virtual DbSet<Disease> Disease { get; set; }
        public virtual DbSet<DiseaseType> DiseaseType { get; set; }
        public virtual DbSet<DocHostContent> DocHostContent { get; set; }
        public virtual DbSet<DocHostItem> DocHostItem { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContact { get; set; }
        public virtual DbSet<Ethnicity> Ethnicity { get; set; }
        public virtual DbSet<HealthPlan> HealthPlan { get; set; }
        public virtual DbSet<LegalEntity> LegalEntity { get; set; }
        public virtual DbSet<LegalEntitySystemUpdate> LegalEntitySystemUpdate { get; set; }
        public virtual DbSet<Locality> Locality { get; set; }
        public virtual DbSet<LocalityImportLog> LocalityImportLog { get; set; }
        public virtual DbSet<LocalityType> LocalityType { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<NaturalPerson> NaturalPerson { get; set; }
        public virtual DbSet<NaturalPersonAllergy> NaturalPersonAllergy { get; set; }
        public virtual DbSet<NaturalPersonDisability> NaturalPersonDisability { get; set; }
        public virtual DbSet<NaturalPersonDisease> NaturalPersonDisease { get; set; }
        public virtual DbSet<NaturalPersonHealthPlan> NaturalPersonHealthPlan { get; set; }
        public virtual DbSet<NaturalPersonMedicine> NaturalPersonMedicine { get; set; }
        public virtual DbSet<NaturalPersonNationality> NaturalPersonNationality { get; set; }
        public virtual DbSet<NaturalPersonRelationship> NaturalPersonRelationship { get; set; }
        public virtual DbSet<NaturalPersonSimilar> NaturalPersonSimilar { get; set; }
        public virtual DbSet<NaturalPersonSystemUpdate> NaturalPersonSystemUpdate { get; set; }
        public virtual DbSet<Occupation> Occupation { get; set; }
        public virtual DbSet<PeopleConfiguration> PeopleConfiguration { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonAddress> PersonAddress { get; set; }
        public virtual DbSet<PersonDocument> PersonDocument { get; set; }
        public virtual DbSet<PersonEcontact> PersonEcontact { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<PersonSystemReference> PersonSystemReference { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<Religion> Religion { get; set; }
        public virtual DbSet<Scholarity> Scholarity { get; set; }
        public virtual DbSet<SystemClient> SystemClient { get; set; }
        public virtual DbSet<SystemReference> SystemReference { get; set; }
        public virtual DbSet<ZipPostalCodeAddress> ZipPostalCodeAddress { get; set; }
        public virtual DbSet<ZipPostalCodeAddressImportLog> ZipPostalCodeAddressImportLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.HasKey(e => e.PersonAddressTypeId);

                entity.Property(e => e.PersonAddressTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AllergyType>(entity =>
            {
                entity.Property(e => e.AllergyTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).ValueGeneratedNever();

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CultureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InternationalCodePhone)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NameFemaleNationality)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameMaleNationality)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DisabilityType>(entity =>
            {
                entity.Property(e => e.DisabilityTypeId).ValueGeneratedNever();

                entity.Property(e => e.DisabilityGovernmentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.Property(e => e.DiseaseId).ValueGeneratedNever();

                entity.Property(e => e.Cid)
                    .HasColumnName("CID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.DiseaseType)
                    .WithMany(p => p.Disease)
                    .HasForeignKey(d => d.DiseaseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Disease_DiseaseType");
            });

            modelBuilder.Entity<DiseaseType>(entity =>
            {
                entity.Property(e => e.DiseaseTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocHostContent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Content).HasColumnType("image");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DocHostContent)
                    .HasForeignKey<DocHostContent>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DocumentC__Stora__7849DB76");
            });

            modelBuilder.Entity<DocHostItem>(entity =>
            {
                entity.Property(e => e.Guid)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.Property(e => e.DocumentTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNumberMask)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmergencyContact>(entity =>
            {
                entity.Property(e => e.EmergencyContactId).ValueGeneratedNever();

                entity.Property(e => e.ContactPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.NaturalPerson)
                    .WithMany(p => p.EmergencyContact)
                    .HasForeignKey(d => d.NaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmergencyContact_NaturalPerson");
            });

            modelBuilder.Entity<Ethnicity>(entity =>
            {
                entity.Property(e => e.EthnicityId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HealthPlan>(entity =>
            {
                entity.Property(e => e.HealthPlanId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlanPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LegalEntity>(entity =>
            {
                entity.Property(e => e.LegalEntityId).ValueGeneratedNever();

                entity.Property(e => e.Acronym)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LegalName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneticName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneInfoId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.LegalEntityNavigation)
                    .WithOne(p => p.LegalEntity)
                    .HasForeignKey<LegalEntity>(d => d.LegalEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LegalEntity_Person");
            });

            modelBuilder.Entity<LegalEntitySystemUpdate>(entity =>
            {
                entity.Property(e => e.LegalEntitySystemUpdateId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.PersonSystemReference)
                    .WithMany(p => p.LegalEntitySystemUpdate)
                    .HasForeignKey(d => d.PersonSystemReferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LegalEntitySystemUpdate_PersonSystemReference");
            });

            modelBuilder.Entity<Locality>(entity =>
            {
                entity.HasIndex(e => new { e.Code, e.Name })
                    .HasName("IX_Locality_01");

                entity.Property(e => e.LocalityId).ValueGeneratedNever();

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormattedName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GeographicLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NameFemaleNaturality)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameMaleNaturality)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZipPostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocalityType)
                    .WithMany(p => p.Locality)
                    .HasForeignKey(d => d.LocalityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Locality_LocalityType");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Locality_Locality");
            });

            modelBuilder.Entity<LocalityImportLog>(entity =>
            {
                entity.Property(e => e.LocalityImportLogId).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocalityType>(entity =>
            {
                entity.Property(e => e.LocalityTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormattedNameMask)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.LocalityType)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocalityType_Country");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.Property(e => e.MaritalStatusId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NaturalPerson>(entity =>
            {
                entity.HasIndex(e => e.BirthDate)
                    .HasName("IX_NaturalPerson_02");

                entity.HasIndex(e => e.FullName)
                    .HasName("IX_NaturalPerson_03");

                entity.HasIndex(e => e.MotherName)
                    .HasName("IX_NaturalPerson_05");

                entity.HasIndex(e => e.NaturalPersonId)
                    .HasName("IX_NaturalPerson_ID");

                entity.HasIndex(e => e.PhoneticFullName)
                    .HasName("IX_NaturalPerson_04");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.MiddleName })
                    .HasName("IX_NaturalPerson_01");

                entity.HasIndex(e => new { e.FullName, e.PhoneticFullName, e.MotherName })
                    .HasName("IX_NaturalPerson_06");

                entity.Property(e => e.NaturalPersonId).ValueGeneratedNever();

                entity.Property(e => e.AuthenticationUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaptismDate).HasColumnType("datetime");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.DeceaseDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneticFullName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SocialName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.BirthCity)
                    .WithMany(p => p.NaturalPerson)
                    .HasForeignKey(d => d.BirthCityId)
                    .HasConstraintName("FK_NaturalPerson_BirthCity");

                entity.HasOne(d => d.BirthCountry)
                    .WithMany(p => p.NaturalPerson)
                    .HasForeignKey(d => d.BirthCountryId)
                    .HasConstraintName("FK_NaturalPerson_Country");

                entity.HasOne(d => d.Ethnicity)
                    .WithMany(p => p.NaturalPerson)
                    .HasForeignKey(d => d.EthnicityId)
                    .HasConstraintName("FK_NaturalPerson_Ethnicity");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.NaturalPerson)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_NaturalPerson_MaritalStatus");

                entity.HasOne(d => d.NaturalPersonNavigation)
                    .WithOne(p => p.NaturalPerson)
                    .HasForeignKey<NaturalPerson>(d => d.NaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPerson_Person");

                entity.HasOne(d => d.Occupation)
                    .WithMany(p => p.NaturalPerson)
                    .HasForeignKey(d => d.OccupationId)
                    .HasConstraintName("FK_NaturalPerson_Occupation");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.NaturalPerson)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_NaturalPerson_Religion");

                entity.HasOne(d => d.Scholarity)
                    .WithMany(p => p.NaturalPerson)
                    .HasForeignKey(d => d.ScholarityId)
                    .HasConstraintName("FK_NaturalPerson_Scholarity");
            });

            modelBuilder.Entity<NaturalPersonAllergy>(entity =>
            {
                entity.Property(e => e.NaturalPersonAllergyId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.AllergyType)
                    .WithMany(p => p.NaturalPersonAllergy)
                    .HasForeignKey(d => d.AllergyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonAllergy_AllergyType");

                entity.HasOne(d => d.NaturalPerson)
                    .WithMany(p => p.NaturalPersonAllergy)
                    .HasForeignKey(d => d.NaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonAllergy_NaturalPerson");
            });

            modelBuilder.Entity<NaturalPersonDisability>(entity =>
            {
                entity.Property(e => e.NaturalPersonDisabilityId).ValueGeneratedNever();

                entity.HasOne(d => d.DisabilityType)
                    .WithMany(p => p.NaturalPersonDisability)
                    .HasForeignKey(d => d.DisabilityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonDisability_DisabilityType");

                entity.HasOne(d => d.NaturalPerson)
                    .WithMany(p => p.NaturalPersonDisability)
                    .HasForeignKey(d => d.NaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonDisability_NaturalPerson");
            });

            modelBuilder.Entity<NaturalPersonDisease>(entity =>
            {
                entity.Property(e => e.NaturalPersonDiseaseId).ValueGeneratedNever();

                entity.HasOne(d => d.Disease)
                    .WithMany(p => p.NaturalPersonDisease)
                    .HasForeignKey(d => d.DiseaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonDisease_Disease");

                entity.HasOne(d => d.NaturalPerson)
                    .WithMany(p => p.NaturalPersonDisease)
                    .HasForeignKey(d => d.NaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonDisease_NaturalPerson");
            });

            modelBuilder.Entity<NaturalPersonHealthPlan>(entity =>
            {
                entity.Property(e => e.NaturalPersonHealthPlanId).ValueGeneratedNever();

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.MedicalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.HealthPlan)
                    .WithMany(p => p.NaturalPersonHealthPlan)
                    .HasForeignKey(d => d.HealthPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonHealthPlan_HealthPlan");

                entity.HasOne(d => d.NaturalPerson)
                    .WithMany(p => p.NaturalPersonHealthPlan)
                    .HasForeignKey(d => d.NaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonHealthPlan_NaturalPerson");
            });

            modelBuilder.Entity<NaturalPersonMedicine>(entity =>
            {
                entity.Property(e => e.NaturalPersonMedicineId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Dosage)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.NaturalPerson)
                    .WithMany(p => p.NaturalPersonMedicine)
                    .HasForeignKey(d => d.NaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonMedicine_NaturalPerson");
            });

            modelBuilder.Entity<NaturalPersonNationality>(entity =>
            {
                entity.HasIndex(e => new { e.NaturalPersonNationalityId, e.NaturalPersonId, e.CountryId })
                    .HasName("ix_NaturalPersonNationality_NaturalPersonId_CountryId_includes");

                entity.Property(e => e.NaturalPersonNationalityId).ValueGeneratedNever();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.NaturalPersonNationality)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonNationality_Country");

                entity.HasOne(d => d.NaturalPerson)
                    .WithMany(p => p.NaturalPersonNationality)
                    .HasForeignKey(d => d.NaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonNationality_NaturalPerson");
            });

            modelBuilder.Entity<NaturalPersonRelationship>(entity =>
            {
                entity.HasIndex(e => new { e.NaturalPersonRelationshipId, e.RelatedId, e.Relationship })
                    .HasName("ix_NaturalPersonRelationship_RelatedIdRelationship_includes");

                entity.HasIndex(e => new { e.NaturalPersonRelationshipId, e.LivesWith, e.NaturalPersonId, e.RelatedId, e.Relationship })
                    .HasName("ix_NaturalPersonRelationship_NaturalPersonId_RelatedId_Relationship_includes");

                entity.Property(e => e.NaturalPersonRelationshipId).ValueGeneratedNever();

                entity.HasOne(d => d.NaturalPerson)
                    .WithMany(p => p.NaturalPersonRelationshipNaturalPerson)
                    .HasForeignKey(d => d.NaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonRelationship_NaturalPerson");

                entity.HasOne(d => d.Related)
                    .WithMany(p => p.NaturalPersonRelationshipRelated)
                    .HasForeignKey(d => d.RelatedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonRelationship_Related");
            });

            modelBuilder.Entity<NaturalPersonSimilar>(entity =>
            {
                entity.HasIndex(e => e.MainNaturalPersonId)
                    .HasName("IX_NaturalPersonSimilar_MainId");

                entity.HasIndex(e => e.SimilarNaturalPersonId)
                    .HasName("IX_NaturalPersonSimilar_Id");

                entity.Property(e => e.NaturalPersonSimilarId).ValueGeneratedNever();

                entity.HasOne(d => d.MainNaturalPerson)
                    .WithMany(p => p.NaturalPersonSimilarMainNaturalPerson)
                    .HasForeignKey(d => d.MainNaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonSimilar_MainNaturalPerson");

                entity.HasOne(d => d.SimilarNaturalPerson)
                    .WithMany(p => p.NaturalPersonSimilarSimilarNaturalPerson)
                    .HasForeignKey(d => d.SimilarNaturalPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonSimilar_SimilarNaturalPerson");
            });

            modelBuilder.Entity<NaturalPersonSystemUpdate>(entity =>
            {
                entity.HasIndex(e => new { e.NaturalPersonSystemUpdateId, e.PersonSystemReferenceId, e.NaturalPersonEntityType })
                    .HasName("ix_NaturalPersonSystemUpdate_PersonSystemReferenceId_NaturalPersonEntityType_includes");

                entity.Property(e => e.NaturalPersonSystemUpdateId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.PersonSystemReference)
                    .WithMany(p => p.NaturalPersonSystemUpdate)
                    .HasForeignKey(d => d.PersonSystemReferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NaturalPersonSystemUpdate_PersonSystemReference");
            });

            modelBuilder.Entity<Occupation>(entity =>
            {
                entity.Property(e => e.OccupationId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeopleConfiguration>(entity =>
            {
                entity.Property(e => e.PeopleConfigurationId).ValueGeneratedNever();

                entity.Property(e => e.PersonFullNameMask)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PeopleConfiguration)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PeopleConfiguration_Country");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.LastUpdate)
                    .HasName("IX_Person_01");

                entity.HasIndex(e => new { e.PersonId, e.LastUpdate, e.ActivePersonId, e.PersonStatus })
                    .HasName("ix_Person_PersonStatus_includes");

                entity.Property(e => e.PersonId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PersonAddress>(entity =>
            {
                entity.HasIndex(e => new { e.PersonId, e.PersonAddressTypeId, e.PersonAddressId })
                    .HasName("ix_PersonAddress_PersonId_PersonAddressTypeId");

                entity.Property(e => e.PersonAddressId).ValueGeneratedNever();

                entity.Property(e => e.AddressLine01)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine02)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine03)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OtherLocality)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZipPostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonAddress_Country");

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => d.LocalityId)
                    .HasConstraintName("FK_PersonAddress_Locality");

                entity.HasOne(d => d.PersonAddressType)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => d.PersonAddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonAddress_PersonAddressType");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonAddress_Person");
            });

            modelBuilder.Entity<PersonDocument>(entity =>
            {
                entity.HasIndex(e => e.DocumentNumber)
                    .HasName("IX_PersonDocument_01");

                entity.HasIndex(e => new { e.DocumentNumber, e.DocumentTypeId, e.PersonId })
                    .HasName("PersonId_DocumentNumber_DocumentTypeId");

                entity.HasIndex(e => new { e.PersonDocumentId, e.PersonId, e.DocumentNumber })
                    .HasName("ix_PersonDocument_PersonIdDocumentNumber");

                entity.Property(e => e.PersonDocumentId).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.DocumentNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.IssueBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.PersonDocument)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonDocument_DocumentType");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonDocument)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonDocument_Person");
            });

            modelBuilder.Entity<PersonEcontact>(entity =>
            {
                entity.ToTable("PersonEContact");

                entity.HasIndex(e => new { e.Contact, e.ContactType, e.PersonId, e.PersonEcontactId })
                    .HasName("ix_PersonEContact_Contact_ContactType_PersonIdPersonEContactId");

                entity.HasIndex(e => new { e.PersonEcontactId, e.Contact, e.DisplayAs, e.ContactType, e.LastUpdate, e.PersonId })
                    .HasName("ix_PersonEContact_PersonId_includes");

                entity.Property(e => e.PersonEcontactId)
                    .HasColumnName("PersonEContactId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAs)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonEcontact)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonEContact_Person");
            });

            modelBuilder.Entity<PersonPhone>(entity =>
            {
                entity.HasIndex(e => new { e.CountryAreaCode, e.CityAreaCode, e.LocalNumber, e.PersonId, e.PersonPhoneTypeId, e.PersonPhoneId })
                    .HasName("ix_PersonPhone_CountryAreaCode_CityAreaCode_LocalNumber_PersonId_PersonPhoneTypeIdPersonPhoneId");

                entity.HasIndex(e => new { e.CountryAreaCode, e.CityAreaCode, e.LocalNumber, e.Extension, e.PersonPhoneTypeId, e.IsDefault, e.IsSmsreceiver, e.LastUpdate, e.PersonId, e.PersonPhoneId })
                    .HasName("ix_PersonPhone_PersonIdPersonPhoneId");

                entity.HasIndex(e => new { e.PersonPhoneId, e.CountryAreaCode, e.CityAreaCode, e.LocalNumber, e.Extension, e.PersonId, e.IsDefault, e.IsSmsreceiver, e.LastUpdate, e.PersonPhoneTypeId })
                    .HasName("ix_PersonPhone_PersonPhoneTypeId_includes");

                entity.Property(e => e.PersonPhoneId).ValueGeneratedNever();

                entity.Property(e => e.CityAreaCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CountryAreaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsSmsreceiver).HasColumnName("IsSMSReceiver");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LocalNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonPhone_Person");

                entity.HasOne(d => d.PersonPhoneType)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.PersonPhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonPhone_PersonPhoneType");
            });

            modelBuilder.Entity<PersonSystemReference>(entity =>
            {
                entity.HasIndex(e => new { e.PersonSystemReferenceId, e.PersonId, e.SystemUseStatus })
                    .HasName("ix_PersonSystemReference_PersonId_SystemUseStatus_includes");

                entity.HasIndex(e => new { e.PersonSystemReferenceId, e.StartDate, e.EndDate, e.SystemClientId, e.PersonId, e.SystemUseStatus })
                    .HasName("ix_PersonSystemReference_SystemClientId_PersonId_SystemUseStatus_includes");

                entity.Property(e => e.PersonSystemReferenceId).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonSystemReference)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonSystemReference_Person");

                entity.HasOne(d => d.SystemClient)
                    .WithMany(p => p.PersonSystemReference)
                    .HasForeignKey(d => d.SystemClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonSystemReference_SystemClient");
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.HasKey(e => e.PersonPhoneTypeId);

                entity.Property(e => e.PersonPhoneTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.Property(e => e.ReligionId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Scholarity>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UQ_Scholarity_Code")
                    .IsUnique();

                entity.Property(e => e.ScholarityId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemClient>(entity =>
            {
                entity.Property(e => e.SystemClientId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemReference>(entity =>
            {
                entity.Property(e => e.SystemReferenceId).ValueGeneratedNever();

                entity.Property(e => e.BeginUseDate).HasColumnType("datetime");

                entity.HasOne(d => d.SystemClient)
                    .WithMany(p => p.SystemReference)
                    .HasForeignKey(d => d.SystemClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemReference_SystemClient");
            });

            modelBuilder.Entity<ZipPostalCodeAddress>(entity =>
            {
                entity.HasKey(e => e.ZipPostalCodeAddress1);

                entity.HasIndex(e => e.AddressLine01)
                    .HasName("IX_ZipPostalCodeAddress_02");

                entity.HasIndex(e => e.AddressLine02)
                    .HasName("IX_ZipPostalCodeAddress_03");

                entity.HasIndex(e => e.BigUserRefNumber)
                    .HasName("IX_ZipPostalCodeAddress_06");

                entity.HasIndex(e => e.NeighborhoodRefNumber)
                    .HasName("IX_ZipPostalCodeAddress_07");

                entity.HasIndex(e => e.RefNumber)
                    .HasName("IX_ZipPostalCodeAddress_05");

                entity.HasIndex(e => e.ZipPostalCode)
                    .HasName("IX_ZipPostalCodeAddress_01");

                entity.HasIndex(e => new { e.AddressLine01, e.AddressLine02, e.ZipPostalCode })
                    .HasName("IX_ZipPostalCodeAddress_04");

                entity.Property(e => e.ZipPostalCodeAddress1)
                    .HasColumnName("ZipPostalCodeAddress")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine01)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine02)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine03)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BigUserRefNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NeighborhoodRefNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipPostalCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ZipPostalCodeAddress)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZipPostalCodeAddress_Country");

                entity.HasOne(d => d.Locality)
                    .WithMany(p => p.ZipPostalCodeAddress)
                    .HasForeignKey(d => d.LocalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZipPostalCodeAddress_Locality");
            });

            modelBuilder.Entity<ZipPostalCodeAddressImportLog>(entity =>
            {
                entity.Property(e => e.ZipPostalCodeAddressImportLogId).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });
        }
    }
}
