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

        }
    }
}
