using ClientData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientData.DAL
{
    public class ProjectServerMappingRepository : IProjectServerMappingRepository
    {
        private readonly ClientDataDbContext _context;
        public ProjectServerMappingRepository(ClientDataDbContext _context)
        {
            this._context = _context;
        }
        public ProjectServerMappingDTODetail Add(ProjectServerMappingDTOAdd obj)
        {
            var result = _context.ProjectServerMappingDTODetail.FromSqlRaw("Exec ProjectServerMapping_Insert {0},{1},{2},{3},{4},{5},{6},{7},{8}", obj.ProjectId, obj.ServerId, obj.DeployedServerTypeId, obj.UrlToAccess, obj.DeployedLocation, obj.AppLogLocation, obj.DbServerID, obj.DbName, obj.Notes).ToList().FirstOrDefault();
            return result;
            
        }
        public ProjectServerMappingDTODelete Delete(int id)
        {
            var result = _context.ProjectServerMappingDTODelete.FromSqlRaw("Exec ProjectServerMapping_Delete {0} ", id).ToList().FirstOrDefault();
            return result;
        }

        public ProjectServerMappingDTODetail Edit(ProjectServerMappingDTOEdit obj)
        {
            
            var result = _context.ProjectServerMappingDTODetail.FromSqlRaw("Exec ProjectServerMapping_Edit {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",  obj.ProjectServerMappingId, obj.ProjectId, obj.ServerId, obj.DeployedServerTypeId, obj.UrlToAccess, obj.DeployedLocation, obj.AppLogLocation, obj.DbServerID,obj.DbName ,obj.Notes).ToList().FirstOrDefault();
            return result;
        }

        public ProjectServerMappingDTODetail GetById(int id)
        {
            var result = _context.ProjectServerMappingDTODetail.FromSqlRaw("Exec ProjectServerMapping_GetById {0}",id).ToList().FirstOrDefault();
            return result;
        }

        public List<ProjectServerMappingDTODetail> List(int projectId)
        {
            var result = _context.ProjectServerMappingDTODetail.FromSqlRaw("Exec ProjectServerMapping_List {0}", projectId).ToList();
            return result;
        }
    }
}
