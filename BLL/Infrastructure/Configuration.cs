using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using DLL.Context;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Infrastructure
{
    public static class Configuration
    {
        public static void ConfigurationService(IServiceCollection serviceCollection,string connectionString,IdentityBuilder builder)
        {
            serviceCollection.AddDbContext<IStoreContext>(options =>
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("IStore")));
            
            builder.AddEntityFrameworkStores<IStoreContext>();
        }
    }
}
