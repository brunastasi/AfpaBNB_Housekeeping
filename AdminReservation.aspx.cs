using AFPABNBADMIN.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNBADMIN
{
    public partial class AdminReservation : PageBase
    {
        DaoReservation daoReservation;
        protected void Page_Load(object sender, EventArgs e)
        {
            daoReservation = new DaoReservation();

            if (!IsPostBack)
            {

                this.gdvReservation.DataSource = daoReservation.GetReservations();
                this.gdvReservation.DataBind();
            }

        }
    }
}