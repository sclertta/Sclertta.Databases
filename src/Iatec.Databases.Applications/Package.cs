using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class Package
    {
        public Package()
        {
            FileContents = new HashSet<FileContent>();
            InstallationHistory = new HashSet<InstallationHistory>();
            Packages = new HashSet<PackageLink>();
            LinkedPackages = new HashSet<PackageLink>();
            PackageReleases = new HashSet<PackageRelease>();
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
        public ICollection<FileContent> FileContents { get; set; }
        public ICollection<InstallationHistory> InstallationHistory { get; set; }
        public ICollection<PackageLink> Packages { get; set; }
        public ICollection<PackageLink> LinkedPackages { get; set; }
        public ICollection<PackageRelease> PackageReleases { get; set; }
    }
}
