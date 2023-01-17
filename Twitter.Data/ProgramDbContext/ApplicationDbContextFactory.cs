using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Data.ProgramDbContext;

namespace Twitter.Data.ProgramDbContext
{



    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {   
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder = optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Dars41;User Id=postgres;Password=helpmegod1!;");
            var options = optionsBuilder.Options;

            return new ApplicationDbContext(options);
        }
    }
}

