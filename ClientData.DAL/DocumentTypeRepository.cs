using ClientData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientData.DAL
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly ClientDataDbContext _clientDataDbContext;
        public DocumentTypeRepository(ClientDataDbContext _clientDataDbContext)
        {
            this._clientDataDbContext = _clientDataDbContext;
        }

        public DocumentTypeDTODetail Add(DocumentTypeDTOAdd documentTypeDTOAdd)
        {
            var result =_clientDataDbContext.DocumentTypeDTODetail.FromSqlRaw("Exec DocumentType_Insert {0}", documentTypeDTOAdd.Name).ToList().FirstOrDefault();
            return result;
        }

        public DocumentTypeDTODelete Delete(int id)
        {
            var result = _clientDataDbContext.DocumentTypeDTODelete.FromSqlRaw("Exec DocumentType_Delete {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public DocumentTypeDTODetail Edit(DocumentTypeDTODetail documentTypeDTODetail)
        {
            var result = _clientDataDbContext.DocumentTypeDTODetail.FromSqlRaw("Exec DocumentType_Edit {0},{1}", documentTypeDTODetail.DocumentTypeId, documentTypeDTODetail.Name).ToList().FirstOrDefault();
            return result;
        }

        public DocumentTypeDTODetail GetById(int id)
        {
            var result = _clientDataDbContext.DocumentTypeDTODetail.FromSqlRaw("Exec DocumentType_GetById {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public List<DocumentTypeDTODetail> List()
        {
            var result = _clientDataDbContext.DocumentTypeDTODetail.FromSqlRaw("Exec DocumentType_List").ToList();
            return result;
        }
    }
}
