using ClientData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
    public interface IServerTypeRepository
    {
        public List<ServerTypeDTODetail> List();
        public ServerTypeDTODetail GetById(int id);
        public ServerTypeDTODetail Add(ServerTypeDTODetail serverTypeDTOAdd);
        public ServerTypeDTODetail Edit(ServerTypeDTODetail serverTypeDTOEdit);
        public ServerTypeDTODelete Delete(int id);


    }
}
