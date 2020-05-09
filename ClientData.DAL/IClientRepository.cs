using ClientData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.DAL
{
    public interface IClientRepository
    {
        List<Client> List();
        Client GetById(decimal id);
    }
}
