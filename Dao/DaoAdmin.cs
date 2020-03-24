using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNBADMIN.Dao
{
    public class DaoAdmin : DataAccess
    {
        public DaoAdmin() : base()
        {

        }

        public Admin GetAdmin(string login, string password)
        {
            Admin admin = null;

            // Requete LINQ
            var requeteAdmin = from a in afpaBNBEntities.Admins
                               where a.Login == login && a.Password == password
                               select a;

            if (requeteAdmin != null && requeteAdmin.Count() > 0)
            {
                admin = requeteAdmin.First();
            }

            return admin;
        }
    }
}