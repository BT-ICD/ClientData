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
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IProjectServerMappingRepository, ProjectServerMappingRepository>();
            services.AddScoped<IProjectDocumentMappingRepository, ProjectDocumentMappingRepository>();
            services.AddScoped<IDocumentTypeRepository, DocumentTypeRepository>();
            services.AddScoped<IProjectDeploymentRepository, ProjectDeploymentRepository>();
        }
    }
}
