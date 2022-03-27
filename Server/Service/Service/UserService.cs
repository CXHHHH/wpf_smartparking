using IDAL;
using IService;
using System;

namespace Service
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IDbContext dbContext):base(dbContext){ }

        private string GetMD5Str(string inputstr)
        {
            return "";
        }
    }
}
