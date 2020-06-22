using ClientData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
    public interface IProjectDocumentMappingRepository
    {
        public List<ProjectDocumentMappingDTODetails> List(int projectId);
        public ProjectDocumentMappingDTODetails GetById(int id);
        public ProjectDocumentMappingDTODetails Add(ProjectDocumentMappingDTODetails obj);
        public ProjectDocumentMappingDTODetails Edit(ProjectDocumentMappingDTODetails obj);
        public ProjectDocumentMappingDTODelete Delete(int id);

    }
}
