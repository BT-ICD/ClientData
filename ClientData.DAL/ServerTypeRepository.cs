using ClientData.Models;
using Microsoft.EntityFrameworkCore;

using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
    public class ServerTypeRepository : IServerTypeRepository

    {
        private readonly ClientDataDbContext _context;
        public ServerTypeRepository(ClientDataDbContext _context)
        {
            this._context = _context;
        }
        public  ServerTypeDTODetail Add(ServerTypeDTODetail serverTypeDTOAdd)
        {
            //    var result = _context.ServerType.FromSqlRaw<ServerTypeDTOEdit>("Exec ServerType_Insert {0} ", serverTypeDTOAdd.Name).FirstOrDefault();
            var result = _context.ServerTypeDTODetail.FromSqlRaw<ServerTypeDTODetail>("Exec ServerType_Insert {0}", serverTypeDTOAdd.Name).ToList().FirstOrDefault();
            return result;
        }

        public ServerTypeDTODetail Edit(ServerTypeDTODetail serverTypeDTOEdit)
        {
            var result = _context.ServerTypeDTODetail.FromSqlRaw<ServerTypeDTODetail>("Exec ServerType_Edit {0},{1}", serverTypeDTOEdit.ServerTypeId, serverTypeDTOEdit.Name).ToList().FirstOrDefault();
            return result;
        }

        public ServerTypeDTODelete Delete(int id)
        {
           var result = _context.ServerTypeDelete.FromSqlRaw<ServerTypeDTODelete> ("Exec ServerType_Delete {0}",id).ToList().FirstOrDefault();
            return result;
        }

        public ServerTypeDTODetail GetById(int id)
        {
            var result = _context.ServerTypeDTODetail.FromSqlRaw<ServerTypeDTODetail>("Exec ServerType_GetById {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public List<ServerTypeDTODetail> List()
        {
            var result = _context.ServerTypeDTODetail.FromSqlRaw("Exec ServerType_GetList").ToList();
            return result;
        }
    }
}
