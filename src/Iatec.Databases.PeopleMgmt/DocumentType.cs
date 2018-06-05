using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            PersonDocument = new HashSet<PersonDocument>();
        }

        public Guid DocumentTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsRequiredComments { get; set; }
        public bool IsRequiredExpiration { get; set; }
        public bool IsRequiredIssueBy { get; set; }
        public bool IsRequiredIssueDate { get; set; }
        public string DocumentNumberMask { get; set; }
        public int DocumentValidation { get; set; }
        public int DocumentTypeClassification { get; set; }
        public bool IsPersonIdentifier { get; set; }

        public ICollection<PersonDocument> PersonDocument { get; set; }
    }
}
