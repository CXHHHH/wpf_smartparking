using ServerEFcore;
using System;

namespace IDAL
{
    public interface IDbContext
    {
        EFcoreContext GetDbContext();
    }
}
