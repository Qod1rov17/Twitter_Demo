using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Data;
using Twitter.Data.ProgramDbContext;
using Twitter.Domain.Entities;
using Twitter.Domain.Enums;

namespace Twitter.Service.UserServices
{
    public class RegistrationService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public RegistrationService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task RegisterAsync(string username, string name, string email, string password, Gender gender, int age)
        {
            await applicationDbContext.Users.AddAsync(new User
            {
                UserName = username,
                Name = name,
                Email = email,
                Password = password,
                Gender = gender,
                Age = age
            });
        }
    }
}
