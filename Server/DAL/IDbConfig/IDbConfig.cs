using ServerEFcore;
using System;

namespace IDbConfig
{
    public interface IDbContext
    {
        EFcoreContext GetDbContext();
    }
}
