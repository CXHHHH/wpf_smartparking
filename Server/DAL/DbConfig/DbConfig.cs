using IDbConfig;
using ServerEFcore;
using System;

namespace DbConfig
{
    public class DbContext: IDbContext
    {
        public EFcoreContext GetDbContext()
        {
            return new EFcoreContext();
        }
    }
}
