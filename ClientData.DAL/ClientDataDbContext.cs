using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using ClientData.Models;
namespace ClientData.DAL
{
    public class ClientDataDbContext:DbContext
    {
       public ClientDataDbContext(DbContextOptions<ClientDataDbContext> options):base(options){}
       public virtual DbSet<Client> Client { get; set; }
       public virtual DbSet<ServerType> ServerType { get; set; }
       public virtual DbSet<ServerTypeDTODetail> ServerTypeDTODetail { get; set; }
       public virtual DbSet<ServerTypeDTODelete> ServerTypeDelete { get; set; }
       public virtual DbSet<Server> Server { get; set; }
       public virtual DbSet<ServerDTODetail> ServerDTODetail { get; set; }
       public virtual DbSet<ServerDTODelete> ServerDTODelete { get; set; }
       public virtual DbSet<Project> Projects { get; set; }
       public virtual DbSet<ProjectDTODetail> ProjectDTODetails { get; set; }
        public virtual DbSet<ProjectDTODelete> ProjectDTODelete { get; set; }
        public virtual DbSet<ProjectServerMapping> ProjectServerMappings { get; set; }
        public virtual DbSet<ProjectServerMappingDTODetail> ProjectServerMappingDTODetail { get; set; }
        public virtual DbSet<ProjectServerMappingDTODelete> ProjectServerMappingDTODelete { get; set; }
        public virtual DbSet<ProjectDocumentMapping> ProjectDocumentMapping{ get; set; }
        public virtual DbSet<ProjectDocumentMappingDTODetails> ProjectDocumentMappingDTODetails { get; set; }
        public virtual DbSet<ProjectDocumentMappingDTODelete> ProjectDocumentMappingDTODelete { get; set; }
        public virtual DbSet<DocumentTypeDTODetail> DocumentTypeDTODetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<ServerTypeDTODetail>(
                eb =>
                {
                    eb.HasNoKey();
                });
            
            modelBuilder.Entity<ServerTypeDTODelete>(eb => { eb.HasNoKey(); });
            
            modelBuilder.Entity<ServerDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ServerDTODetail>(eb=> { eb.HasNoKey();});
            modelBuilder.Entity<ProjectDTODetail>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectServerMappingDTODetail>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectServerMappingDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectDocumentMappingDTODetails>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectDocumentMappingDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<DocumentTypeDTODetail>(eb => { eb.HasNoKey(); });


        }
    }
}
