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

        public List<DocumentTypeDTODetail> List()
        {
            var result = _clientDataDbContext.DocumentTypeDTODetail.FromSqlRaw("Exec DocumentType_List").ToList();
            return result;
        }
    }
}
