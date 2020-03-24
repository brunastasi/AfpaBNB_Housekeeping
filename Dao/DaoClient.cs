using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNBADMIN.Dao
{
    public class DaoClient : DataAccess
    {
        public DaoClient() : base()
        {

        }

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            clients = afpaBNBEntities.Clients.ToList();

            return clients;
        }

    }
}