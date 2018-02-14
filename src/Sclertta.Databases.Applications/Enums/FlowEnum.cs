using System;
using System.Collections.Generic;
using System.Text;

namespace Sclertta.Databases.Applications
{
    public enum FlowEnum
    {
        AuthorizationCode = 0,
        Implicit = 1,
        Hybrid = 2,
        ClientCredentials = 3,
        ResourceOwner = 4,
    }
}
