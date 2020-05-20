using ClientData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
    public interface IProjectRepository
    {


        public List<ProjectDTODetail> List();
        public ProjectDTODetail GetById(int id);
        public ProjectDTODetail Add(ProjectDTODetail obj);
        public ProjectDTODetail Edit(ProjectDTODetail obj);
        public ProjectDTODelete Delete(int id);
    }
}
