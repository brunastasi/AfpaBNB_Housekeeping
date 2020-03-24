using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNBADMIN.Dao
{
    public class DataAccess
    {
        public AfpaBNBEntities afpaBNBEntities;
        public DataAccess()
        {
            afpaBNBEntities = new AfpaBNBEntities();
        }
    }
}