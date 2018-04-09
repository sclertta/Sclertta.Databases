using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class Region
    {
        public Region()
        {
            AppDeploy = new HashSet<AppDeploy>();
            Notification = new HashSet<Notification>();
            PackageRelease = new HashSet<PackageRelease>();
            RegionalSettings = new HashSet<RegionalSettings>();
        }

        public Guid RegionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CultureCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string TimeZone { get; set; }

        public ICollection<AppDeploy> AppDeploy { get; set; }
        public ICollection<Notification> Notification { get; set; }
        public ICollection<PackageRelease> PackageRelease { get; set; }
        public ICollection<RegionalSettings> RegionalSettings { get; set; }
    }
}
