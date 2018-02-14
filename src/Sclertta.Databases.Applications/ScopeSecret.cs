using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Applications
{
    public partial class ScopeSecret
    {
        public int Id { get; set; }
        public byte[] SecretHash { get; set; }
        public DateTime? Expiration { get; set; }
        public string ScopeOldId { get; set; }
        public int ScopeId { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }

        public Scope Scope { get; set; }
    }
}
