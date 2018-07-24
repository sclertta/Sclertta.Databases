using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class HealthPlan
    {
        public HealthPlan()
        {
            NaturalPersonHealthPlan = new HashSet<NaturalPersonHealthPlan>();
        }

        public Guid HealthPlanId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PlanPhone { get; set; }

        public ICollection<NaturalPersonHealthPlan> NaturalPersonHealthPlan { get; set; }
    }
}
