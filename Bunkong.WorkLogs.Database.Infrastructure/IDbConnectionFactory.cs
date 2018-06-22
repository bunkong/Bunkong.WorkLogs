using System;
using System.Data;

namespace Bunkong.WorkLogs.Database.Infrastructure
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
