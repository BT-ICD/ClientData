using ClientData.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace ClientData.DAL
{
    public class ServerRepository : IServerRepository
    {
        private readonly ClientDataDbContext _context;
        public ServerRepository(ClientDataDbContext _context)
        {
            this._context = _context;
        }
        public ServerDTODetail Add(ServerDTODetail obj)
        {
            var result = _context.ServerDTODetail.FromSqlRaw("Exec Server_Insert {0},{1},{2},{3},{4},{5}", obj.Name, obj.ServerTypeId, obj.InternalIP, obj.ExternalIP, obj.URLToAccess, obj.Notes).ToList().FirstOrDefault();
            return result;
        }

        public ServerDTODelete Delete(int id)
        {
            var result = _context.ServerDTODelete.FromSqlRaw("Exec Server_Delete {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public ServerDTODetail Edit(ServerDTODetail obj)
        {
            var result = _context.ServerDTODetail.FromSqlRaw("Exec Server_Edit {0},{1},{2},{3},{4},{5},{6}", obj.ServerId, obj.Name, obj.ServerTypeId, obj.InternalIP, obj.ExternalIP, obj.URLToAccess, obj.Notes).ToList().FirstOrDefault();
            return result;
        }

        public ServerDTODetail GetById(int id)
        {
            var result = _context.ServerDTODetail.FromSqlRaw("Exec Server_GetById {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public List<ServerDTODetail> List()
        {
            var result = _context.ServerDTODetail.FromSqlRaw("Exec Server_List").ToList();
            return result;
        }

    }
}
