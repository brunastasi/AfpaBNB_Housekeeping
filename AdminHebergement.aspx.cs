using AFPABNBADMIN.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNBADMIN
{
    public partial class AdminHebergement : Page
    {
        DaoHebergement daoHebergement;
        protected void Page_Load(object sender, EventArgs e)
        {
            daoHebergement = new DaoHebergement();

            if (!IsPostBack)
            {
              
                this.lvwHebergement.DataSource = daoHebergement.GetHebergements();
                this.lvwHebergement.DataBind();
            }
        }

        protected void btnDesactiver_Click(object sender, EventArgs e)
        {
            string arg = ((Button)sender).CommandArgument;
            int idhebergement = Convert.ToInt32(arg);

            //afpaBNBEntities.Hebergements.Where(h => h.IdHebergement => idhebergement).First();
            DataAccess dataaccess = new DataAccess();

            Hebergement hebergement = dataaccess.afpaBNBEntities.Hebergements.Find(idhebergement);
            hebergement.Etat = false;
            dataaccess.afpaBNBEntities.SaveChanges();


        }

        protected void btnActiver_Click(object sender, EventArgs e)
        {
            string arg = ((Button)sender).CommandArgument;
            int idhebergement = Convert.ToInt32(arg);

            DataAccess dataaccess = new DataAccess();

            Hebergement hebergement = dataaccess.afpaBNBEntities.Hebergements.Find(idhebergement);
            hebergement.Etat = true;
            dataaccess.afpaBNBEntities.SaveChanges();


        }

        //protected void lvwHebergement_ItemDataBound(object sender, ListViewItemEventArgs e)
        //{
        //    if(e.Item.ItemType == ListViewItemType.DataItem)
        //    {
        //        Button btnDesactiver = (Button)e.Item.FindControl("Button1");

        //        Hebergement hebergement = (Hebergement)e.Item.DataItem;

        //        if(hebergement.Etat != false)
        //        {
        //            //btnDesactiver.cssClass = "btn btn-success";
        //            btnDesactiver.Text = "Désactivé";
        //        }
        //        else
        //        {
        //            //btnDesactiver.cssClass = "btn btn-danger";
        //            btnDesactiver.Text = "Activé";
        //        }
        //    }
        //}
    }
}