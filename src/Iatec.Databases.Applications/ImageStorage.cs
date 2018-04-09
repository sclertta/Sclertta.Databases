using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class ImageStorage
    {
        public ImageStorage()
        {
            AppDeploy = new HashSet<AppDeploy>();
            AppDomainLargeImage = new HashSet<AppDomain>();
            AppDomainMediumImage = new HashSet<AppDomain>();
            AppDomainSmallImage = new HashSet<AppDomain>();
        }

        public Guid ImageStorageId { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] Content { get; set; }

        public ICollection<AppDeploy> AppDeploy { get; set; }
        public ICollection<AppDomain> AppDomainLargeImage { get; set; }
        public ICollection<AppDomain> AppDomainMediumImage { get; set; }
        public ICollection<AppDomain> AppDomainSmallImage { get; set; }
    }
}
