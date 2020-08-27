using System;
using System.Collections.Generic;
using System.Text;
using ClientData.Models;
namespace ClientData.DAL
{
    public interface IProjectDeploymentRepository
    {
        public List<ProjectDeploymentDTODetails> List(int ProjectId);
        public ProjectDeploymentDTODetails GetById(int id);
        public ProjectDeploymentDTODetails Add(ProjectDeploymentDTOAdd obj);
        public ProjectDeploymentDTODetails Edit(ProjectDeploymentDTOEdit obj);

        public ProjectDeploymentDTODelete Delete(int id);

    }
}
