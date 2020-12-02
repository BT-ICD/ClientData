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
        public virtual DbSet<ServerDTOFORLOV> ServerDTOFORLOV { get; set; }
        
       public virtual DbSet<ServerDTODelete> ServerDTODelete { get; set; }
       public virtual DbSet<Project> Projects { get; set; }
       public virtual DbSet<ProjectDTODetail> ProjectDTODetails { get; set; }
        public virtual DbSet<ProjectDTODelete> ProjectDTODelete { get; set; }
        public virtual DbSet<ProjectServerMapping> ProjectServerMappings { get; set; }
        public virtual DbSet<ProjectServerMappingDTODetail> ProjectServerMappingDTODetail { get; set; }
        public virtual DbSet<ProjectServerMappingDTODelete> ProjectServerMappingDTODelete { get; set; }
        public virtual DbSet<ProjectServerDTOForLOV> ProjectServerDTOForLOV { get; set; }
        public virtual DbSet<ProjectDocumentMapping> ProjectDocumentMapping{ get; set; }
        public virtual DbSet<ProjectDocumentMappingDTODetails> ProjectDocumentMappingDTODetails { get; set; }
        public virtual DbSet<ProjectDocumentMappingDTODelete> ProjectDocumentMappingDTODelete { get; set; }
        public virtual DbSet<DocumentTypeDTODetail> DocumentTypeDTODetail { get; set; }
        public virtual DbSet<DocumentTypeDTODelete> DocumentTypeDTODelete { get; set; }
        public virtual DbSet<ProjectDeployment> ProjectDeployments { get; set; }
        public virtual DbSet<ProjectDeploymentDTODetails> ProjectDeploymentDTODetails { get; set; }

        public virtual DbSet<ProjectDeploymentDTODelete> ProjectDeploymentDTODelete { get; set; }
        public virtual DbSet<TeamMember> TeamMember { get; set; }
        public virtual DbSet<TeamMemberDTO> TeamMemberDTO{ get; set; }
        public virtual DbSet<TeamMemberDTODetail> TeamMemberDTODetail { get; set; }
        public virtual DbSet<TeamMemberDTODelete> TeamMemberDTODelete { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<ServerTypeDTODetail>(
                eb =>
                {
                    eb.HasNoKey();
                });
            
            modelBuilder.Entity<ServerTypeDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ServerDTOFORLOV>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ServerDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ServerDTODetail>(eb=> { eb.HasNoKey();});
            modelBuilder.Entity<ProjectDTODetail>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectServerMappingDTODetail>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectServerMappingDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectServerDTOForLOV>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectDocumentMappingDTODetails>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectDocumentMappingDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<DocumentTypeDTODetail>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<DocumentTypeDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectDeploymentDTODetails>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<ProjectDeploymentDTODelete>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<TeamMember>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<TeamMemberDTO>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<TeamMemberDTODetail>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<TeamMemberDTODelete>(eb => { eb.HasNoKey(); });

        }
    }
}
