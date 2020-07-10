using ClientData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
    public interface IServerRepository
    {
        public List<ServerDTODetail> List();
        public ServerDTODetail GetById(int id);
        public ServerDTODetail Add(ServerDTODetail obj);
        public ServerDTODetail Edit(ServerDTODetail obj);
        public ServerDTODelete Delete(int id);
        public List<ServerDTOFORLOV> ListForLOV(int? ServerTypeId);
    }
}
