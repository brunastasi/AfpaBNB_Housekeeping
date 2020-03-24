using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFPABNBADMIN.Dao
{
    public class DaoReservation : DataAccess
    {
        public DaoReservation() : base()
        {

        }

        public List<Reservation> GetReservations()
        {
            List<Reservation> reservations = new List<Reservation>();
            reservations = afpaBNBEntities.Reservations.ToList();

            return reservations;
        }
    }
}