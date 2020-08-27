using ClientData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClientData.DAL
{
    public class ProjectDeploymentRepository : IProjectDeploymentRepository
    {
        private readonly ClientDataDbContext _context;
        public ProjectDeploymentRepository(ClientDataDbContext _context)
        {
            this._context = _context;
        }
        public ProjectDeploymentDTODetails Add(ProjectDeploymentDTOAdd obj)
        {
            var result = _context.ProjectDeploymentDTODetails.FromSqlRaw("Exec ProjectDeployment_Insert {0},{1},{2},{3},{4},{5},{6}", obj.ProjectId, obj.DeploymentDate, obj.ServerId, obj.Features, obj.Version, obj.ActualFileName, obj.Notes).ToList().FirstOrDefault();
            return result;
        }

        public ProjectDeploymentDTODelete Delete(int id)
        {
            var result = _context.ProjectDeploymentDTODelete.FromSqlRaw("Exec ProjectDeployment_Delete {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public ProjectDeploymentDTODetails Edit(ProjectDeploymentDTOEdit obj)
        {
            var result = _context.ProjectDeploymentDTODetails.FromSqlRaw("Exec ProjectDeployment_Edit {0},{1},{2},{3},{4},{5},{6},{7}", obj.ProjectDeploymentId , obj.ProjectId, obj.DeploymentDate, obj.ServerId, obj.Features, obj.Version, obj.ActualFileName, obj.Notes).ToList().FirstOrDefault();
            return result;
        }

        public ProjectDeploymentDTODetails GetById(int id)
        {
            var result = _context.ProjectDeploymentDTODetails.FromSqlRaw("Exec ProjectDeployment_GetById {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public List<ProjectDeploymentDTODetails> List(int ProjectId)
        {
            var result = _context.ProjectDeploymentDTODetails.FromSqlRaw("Exec ProjectDeployment_List {0}", ProjectId).ToList();
            return result;
        }
    }
}
