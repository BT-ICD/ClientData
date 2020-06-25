using ClientData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
    public interface IDocumentTypeRepository
    {
        public List<DocumentTypeDTODetail> List();
    }
}
