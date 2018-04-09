using System;
using System.Collections.Generic;
using System.Text;

namespace Iatec.Databases.Applications
{
    public enum OidcFlowEnum
    {
        AuthorizationCode = 0,
        Implicit = 1,
        Hybrid = 2,
        ClientCredentials = 3,
        ResourceOwner = 4,
        Custom = 5,
        AuthorizationCodeWithProofKey = 6,
        HybridWithProofKey = 7,
    }
}
