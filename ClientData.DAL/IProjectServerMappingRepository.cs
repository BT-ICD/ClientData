using ClientData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
    public interface IProjectServerMappingRepository
    {
        public List<ProjectServerMappingDTODetail> List(int projectId);
        public ProjectServerMappingDTODetail GetById(int id);
        public ProjectServerMappingDTODetail Add(ProjectServerMappingDTOAdd obj);
        public ProjectServerMappingDTODetail Edit(ProjectServerMappingDTOEdit obj);
        public ProjectServerMappingDTODelete Delete(int id);
        public List<ProjectServerDTOForLOV> GetProjectServers(int? projectId);
    }
}
