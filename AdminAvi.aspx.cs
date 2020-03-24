using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNBADMIN
{
    public partial class AdminAvi : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                AfpaBNBEntities afpaBNBEntities = new AfpaBNBEntities();

                this.gdvAvi.DataSource = afpaBNBEntities.Avis.ToList();
                this.gdvAvi.DataBind();
            }
        }

        protected void btnDesactiver_Click(object sender, EventArgs e)
        {
            string arg = ((Button)sender).CommandArgument;
            int idavis = Convert.ToInt32(arg);

            //afpaBNBEntities.Hebergements.Where(h => h.IdHebergement => idhebergement).First();

            AfpaBNBEntities afpaBNBEntities = new AfpaBNBEntities();

            Avi avi = afpaBNBEntities.Avis.Find(idavis);
            avi.Etat = false;
            afpaBNBEntities.SaveChanges();


        }

        protected void btnActiver_Click(object sender, EventArgs e)
        {
            string arg = ((Button)sender).CommandArgument;
            int idavis = Convert.ToInt32(arg);

            //afpaBNBEntities.Hebergements.Where(h => h.IdHebergement => idhebergement).First();

            AfpaBNBEntities afpaBNBEntities = new AfpaBNBEntities();

            Avi avi = afpaBNBEntities.Avis.Find(idavis);
            avi.Etat = true;
            afpaBNBEntities.SaveChanges();


        }
    }
}