using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Applications
{
    public partial class Package
    {
        public Package()
        {
            FileContent = new HashSet<FileContent>();
            InstallationHistory = new HashSet<InstallationHistory>();
            PackageLinkPackage = new HashSet<PackageLink>();
            PackageLinkPackageLinked = new HashSet<PackageLink>();
            PackageRelease = new HashSet<PackageRelease>();
        }

        public Guid PackageId { get; set; }
        public string CreatedBy { get; set; }
        public string Instructions { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string BugTrackRef { get; set; }
        public Guid? AppDomainId { get; set; }
        public Guid? PackageTypeId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int PackageStatusEnum { get; set; }
        public bool IsMultipleTimesExecution { get; set; }
        public int PackageImportanceEnum { get; set; }
        public byte[] FileChecksum { get; set; }
        public bool SavedInLocalClient { get; set; }
        public string SavedInLocalBy { get; set; }
        public DateTime? SavedInLocalDate { get; set; }

        public AppDomain AppDomain { get; set; }
        public PackageType PackageType { get; set; }
        public ICollection<FileContent> FileContent { get; set; }
        public ICollection<InstallationHistory> InstallationHistory { get; set; }
        public ICollection<PackageLink> PackageLinkPackage { get; set; }
        public ICollection<PackageLink> PackageLinkPackageLinked { get; set; }
        public ICollection<PackageRelease> PackageRelease { get; set; }
    }
}
