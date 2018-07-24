using System;
using System.Collections.Generic;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    public interface IConnectionStringProvider
    {
        string ConnectionString { get; }
    }
}
