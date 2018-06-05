using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class NaturalPersonMedicine
    {
        public Guid NaturalPersonMedicineId { get; set; }
        public string Description { get; set; }
        public string Dosage { get; set; }
        public Guid NaturalPersonId { get; set; }

        public NaturalPerson NaturalPerson { get; set; }
    }
}
