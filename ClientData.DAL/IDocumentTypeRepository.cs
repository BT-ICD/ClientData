using ClientData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
    public interface IDocumentTypeRepository
    {
        public List<DocumentTypeDTODetail> List();

        public DocumentTypeDTODetail GetById(int id);
        public DocumentTypeDTODetail Add(DocumentTypeDTOAdd documentTypeDTOAdd);
        public DocumentTypeDTODetail Edit(DocumentTypeDTODetail documentTypeDTODetail);
        public DocumentTypeDTODelete Delete(int id);
    }
}
