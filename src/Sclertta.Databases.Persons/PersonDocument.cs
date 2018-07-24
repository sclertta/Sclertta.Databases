using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class PersonDocument
    {
        public Guid PersonDocumentId { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Comments { get; set; }
        public Guid DocumentTypeId { get; set; }
        public Guid PersonId { get; set; }
        public DateTime LastUpdate { get; set; }

        public DocumentType DocumentType { get; set; }
        public Person Person { get; set; }
    }
}
