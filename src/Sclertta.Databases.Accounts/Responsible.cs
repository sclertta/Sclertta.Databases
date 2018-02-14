using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Accounts
{
    public partial class Responsible
    {
        public Responsible()
        {
            PolicyPlaces = new HashSet<PolicyPlace>();
        }

        public Guid ResponsibleId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<PolicyPlace> PolicyPlaces { get; set; }
    }
}
