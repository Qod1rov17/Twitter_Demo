using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Data.ProgramDbContext;
using Twitter.Domain;
using Twitter.Domain.Enums;
using Twitter.Domain.Entities;

namespace Twitter.Service.UserServices
{
    public class UserRegistrationService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public async Task Register(string password, string name, string username, string surname, string email, int age, Gender gender)
        {
            await applicationDbContext.Users.AddAsync(new User()
            {
                UserName = username,
                Name = name,
                Surname = surname,
                Email = email,
                Age = age,
                Gender = gender
            });
        }
    }
}
