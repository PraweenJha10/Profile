using Profile.DataAccess;
using Profile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.Repository
{
    public class UserDataRepository:IUserDataRepository<UserInfo>
    {
        readonly UserContext _userContext;
        public UserDataRepository(UserContext context)
        {
            _userContext=context;
        }

        public IEnumerable<UserInfo> GetAll()
        {
            return _userContext.userInfo.ToList();
        }

    }
}
