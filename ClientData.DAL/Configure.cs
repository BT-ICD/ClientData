using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
   public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ClientDataDbContext>(options => options.UseSqlServer(connectionString));
            //services.AddSingleton(connectionString);
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IServerTypeRepository, ServerTypeRepository>();
            services.AddScoped<IServerRepository, ServerRepository>();
        }
    }
}
