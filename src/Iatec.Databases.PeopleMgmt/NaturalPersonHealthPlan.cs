using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class NaturalPersonHealthPlan
    {
        public Guid NaturalPersonHealthPlanId { get; set; }
        public Guid NaturalPersonId { get; set; }
        public Guid HealthPlanId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string MedicalId { get; set; }

        public HealthPlan HealthPlan { get; set; }
        public NaturalPerson NaturalPerson { get; set; }
    }
}
