using IDAL;
using ServerEFcore;
using System;

namespace DAL
{
    public class EFCoreDbContext: IDbContext
    {
        EFcoreContext efcorecontext = null;

        public EFCoreDbContext()
        {
            efcorecontext = new EFcoreContext();
        }
        public EFcoreContext GetDbContext()
        {
            return efcorecontext;
        }
    }
}
