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
        public ProjectServerMappingDTODetail Add(ProjectServerMappingDTODetail obj);
        public ProjectServerMappingDTODetail Edit(ProjectServerMappingDTODetail obj);
        public ProjectServerMappingDTODelete Delete(int id);
    }
}
