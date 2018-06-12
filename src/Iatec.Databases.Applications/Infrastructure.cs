using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class Infrastructure
    {
        public Infrastructure()
        {
            AppDeploy = new HashSet<AppDeploy>();
            Notification = new HashSet<Notification>();
        }

        public Guid InfrastructureId { get; set; }
        public Guid? InfraOwnerId { get; set; }
        public string Name { get; set; }
        public string EmailContact { get; set; }
        public string Description { get; set; }
        public string ConsumerServicePhone { get; set; }
        public string BillingSupportPhone { get; set; }

        public InfraOwner InfraOwner { get; set; }
        public ICollection<AppDeploy> AppDeploy { get; set; }
        public ICollection<Notification> Notification { get; set; }
    }
}
