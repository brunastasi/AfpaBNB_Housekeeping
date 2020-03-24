using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNBADMIN.Dao
{

    public class DaoHebergement : DataAccess
    {
        public DaoHebergement() : base()
        {

        }

        public List<Hebergement> GetHebergements()
        {
            List<Hebergement> hebergements = new List<Hebergement>();
            hebergements = afpaBNBEntities.Hebergements.ToList();

            return hebergements;
        }

        //public void UpdateHebergement(int idHebergement)
        //{

        //    try
        //    {
        //        //on va chercher un hebergement dans tripledoubleEntities grace
        //        Hebergement hebergement = afpaBNBEntities.Hebergements.Find(idHebergement);
        //        // on change l'etat Statut de l'hebergement
        //        hebergement.Etat = !hebergement.Etat;
        //        afpaBNBEntities.SaveChanges();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

    }

}