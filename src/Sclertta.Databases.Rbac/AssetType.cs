using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Rbac
{
    public partial class AssetType
    {
        public AssetType()
        {
            Assets = new HashSet<Asset>();
        }

        public Guid AssetTypeId { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string IconClass { get; set; }
        public bool IsContext { get; set; }

        public ICollection<Asset> Assets { get; set; }
    }
}
