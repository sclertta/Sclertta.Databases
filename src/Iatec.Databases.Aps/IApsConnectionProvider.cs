using System;
using System.Collections.Generic;
using System.Text;

namespace Iatec.Databases.Aps
{
    public interface IApsConnectionProvider
    {
        string ApsConnectionString { get; }
    }
}
