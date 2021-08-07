using Profile.DataAccess;
using Profile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.Repository
{
	public class UserProfileRepository:IUserProfileRepository<UserProfile>
	{
		readonly UserContext _userContext;

		public UserProfileRepository(UserContext context)
		{
			_userContext = context;
		}

		public IEnumerable<UserProfile> GetAllImageProfile() 
		{
			return _userContext.userProfiles.ToList();
		}
	}
}
