using AFPABNBADMIN.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNBADMIN
{
    public partial class AdminClient : PageBase
    {
        DaoClient daoClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            daoClient = new DaoClient();

            if (!IsPostBack)
            {
                this.gdvClient.DataSource = daoClient.GetClients();
                this.gdvClient.DataBind();
            }
        }

        protected void btnDesactiver_Click(object sender, EventArgs e)
        {
            string arg = ((Button)sender).CommandArgument;
            int idclient = Convert.ToInt32(arg);

            //afpaBNBEntities.Hebergements.Where(h => h.IdHebergement => idhebergement).First();
            AfpaBNBEntities afpaBNBEntities = new AfpaBNBEntities();

            Client client = afpaBNBEntities.Clients.Find(idclient);
            client.Etat = false;
            afpaBNBEntities.SaveChanges();


        }
        protected void btnActiver_Click(object sender, EventArgs e)
        {
            string arg = ((Button)sender).CommandArgument;
            int idclient = Convert.ToInt32(arg);

            AfpaBNBEntities afpaBNBEntities = new AfpaBNBEntities();

            Client client = afpaBNBEntities.Clients.Find(idclient);
            client.Etat = true;
            afpaBNBEntities.SaveChanges();


        }

    }
}