using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.AccessControl
{
    public partial class Asset
    {
        public Asset()
        {
            Permissions = new HashSet<Permission>();
            Roles = new HashSet<Role>();
            ChildAssets = new HashSet<Asset>();
        }

        public Guid AssetId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DateLastUpdate { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public Guid? AssetTypeId { get; set; }
        public Guid? ParentId { get; set; }

        public AssetType AssetType { get; set; }
        public Asset Parent { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<Asset> ChildAssets { get; set; }
    }
}
