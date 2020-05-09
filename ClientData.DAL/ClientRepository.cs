using ClientData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientData.DAL
{
    public class ClientRepository : IClientRepository
    {
        private  ClientDataDbContext _context;
        public ClientRepository(ClientDataDbContext context)
        {
            _context = context;
        }
        List<Client> IClientRepository.List()
        {
            var result = _context.Client.ToList();
            return result;
        }

        Client IClientRepository.GetById(decimal id)
        {
            var result = _context.Client.Where(c => c.ClientId == id).FirstOrDefault();
            return result;
        }
    }
}
