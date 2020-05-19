using ClientData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientData.DAL
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ClientDataDbContext _context;
        public ProjectRepository(ClientDataDbContext _context)
        {
            this._context = _context;
        }
        public ProjectDTODetail Add(ProjectDTODetail obj)
        {
            var result = _context.ProjectDTODetails.FromSqlRaw("Exec Project_Insert {0},{1},{2},{3}", obj.Name, obj.About, obj.Notes, obj.SourceCodeLocation).ToList().FirstOrDefault();
            return result;
        }

        public ProjectDTODelete Delete(int id)
        {
            var result = _context.ProjectDTODelete.FromSqlRaw("Exec Project_Delete {0}", id).ToList().FirstOrDefault();
            return result;
        }
        public ProjectDTODetail Edit(ProjectDTODetail obj)
        {
            var result = _context.ProjectDTODetails.FromSqlRaw("Exec Project_Edit {0},{1},{2},{3},{4}", obj.ProjectId, obj.Name, obj.About, obj.Notes, obj.SourceCodeLocation).ToList().FirstOrDefault();
            return result;
        }

        public ProjectDTODetail GetById(int id)
        {
            var result = _context.ProjectDTODetails.FromSqlRaw("Exec Project_GetById {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public List<ProjectDTODetail> List()
        {
            var result = _context.ProjectDTODetails.FromSqlRaw("Exec Project_List").ToList();
            return result;
        }
    }
}
