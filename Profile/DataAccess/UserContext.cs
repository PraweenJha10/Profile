using Microsoft.EntityFrameworkCore;
using Profile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.DataAccess
{
    public class UserContext:DbContext
    {
        protected readonly DbContextOptions DbContextOptions;

        public UserContext(DbContextOptions<UserContext> contextOptions):base (contextOptions)
        {
           
        }
        public DbSet<UserInfo> userInfo { get; set; }
    }
}
