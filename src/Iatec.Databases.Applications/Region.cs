using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class Region
    {
        public Region()
        {
            AppDeploys = new HashSet<AppDeploy>();
            Notifications = new HashSet<Notification>();
            PackageReleases = new HashSet<PackageRelease>();
            RegionalSettings = new HashSet<RegionalSettings>();
        }

        public Guid RegionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CultureCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string TimeZone { get; set; }

        public ICollection<AppDeploy> AppDeploys { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<PackageRelease> PackageReleases { get; set; }
        public ICollection<RegionalSettings> RegionalSettings { get; set; }
    }
}
