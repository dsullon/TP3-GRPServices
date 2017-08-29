using System;
using System.Data;

namespace GRP.Data.Infrastructure
{
    public interface IConnectionFactory: IDisposable
    {
        IDbConnection GetConnection { get; }
    }
}
