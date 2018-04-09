using System;
using System.Collections.Generic;

namespace Iatec.Databases.Accounts
{
    public partial class PolicyPlace
    {
        public PolicyPlace()
        {
            Groups = new HashSet<Group>();
            Locations = new HashSet<Location>();
            Users = new HashSet<User>();
        }

        public Guid PolicyPlaceId { get; set; }
        public string Name { get; set; }
        public int? MaxInvalidPwdAttempts { get; set; }
        public int? MaxOneTimePwdPeerDay { get; set; }
        public int? MaxMobileMsgPeerDay { get; set; }
        public string Description { get; set; }
        public string ServerUrl { get; set; }
        public string Discriminator { get; set; }
        public Guid? ResponsibleId { get; set; }
        public int? PwdAgeInDaysCount { get; set; }
        public string PwdStrengthExpression { get; set; }
        public string PwdStrengthMessage { get; set; }
        public int? LockoutWindowMin { get; set; }
        public int? PwdAgeWarningDaysCount { get; set; }

        public Responsible Responsible { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Location> Locations { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
