using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Data.ProgramDbContext;

namespace Twitter.Service.UserServices
{
    public class UserLoginService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserLoginService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public bool Login(string email, string password)
        {
            return applicationDbContext.Users.Any(x=>x.Email == email && x.Password == password);
        }
    }

}
