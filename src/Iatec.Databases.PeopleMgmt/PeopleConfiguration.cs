﻿using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class PeopleConfiguration
    {
        public Guid PeopleConfigurationId { get; set; }
        public Guid CountryId { get; set; }
        public string PersonFullNameMask { get; set; }

        public Country Country { get; set; }
    }
}
