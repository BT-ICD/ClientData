using ClientData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientData.DAL
{
    public class ProjectDocumentMappingRepository: IProjectDocumentMappingRepository
    {
        private readonly ClientDataDbContext _context;
        public ProjectDocumentMappingRepository(ClientDataDbContext _context)
        {
            this._context = _context;
        }
        public ProjectDocumentMappingDTODetails Add(ProjectDocumentMappingDTODetails  obj)
        {
            var result = _context.ProjectDocumentMappingDTODetails.FromSqlRaw("Exec ProjectDocumentMapping_Insert {0},{1},{2},{3}", obj.ProjectId, obj.DocumentTypeId, obj.ActualFileName,  obj.Notes).ToList().FirstOrDefault();
            return result;
        }
        public ProjectDocumentMappingDTODetails Edit(ProjectDocumentMappingDTODetails obj)
        {
            var result = _context.ProjectDocumentMappingDTODetails.FromSqlRaw("Exec ProjectDocumentMapping_Edit {0},{1},{2},{3},{4},{5}", obj.ProjectDocumentMappingId , obj.ProjectId, obj.DocumentTypeId, obj.ActualFileName, obj.StoreAsFileName, obj.Notes).ToList().FirstOrDefault();
            return result;
        }
        public ProjectDocumentMappingDTODetails GetById(int id)
        {
            var result = _context.ProjectDocumentMappingDTODetails.FromSqlRaw("Exec ProjectDocumentMapping_GetById {0}", id).ToList().FirstOrDefault();
            return result;
        }
        public List<ProjectDocumentMappingDTODetails> List(int projectId)
        {
            var result = _context.ProjectDocumentMappingDTODetails.FromSqlRaw("Exec ProjectDocumentMapping_List {0}", projectId).ToList();
            return result;
        }
        public ProjectDocumentMappingDTODelete Delete(int id)
        {
            var result = _context.ProjectDocumentMappingDTODelete.FromSqlRaw("Exec ProjectDocumentMapping_Delete {0}", id).ToList().FirstOrDefault();
            return result;
        }


    }
}
