using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNBADMIN
{
    public partial class Administration : System.Web.UI.MasterPage
    {
        public Admin Administrateur { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            Admin admin = (Admin)Session["admin"];

            if (admin != null)
            {
                 //this.lblAdmin.Text = admin.Login + " " + admin.Password;

                //((SiteMaster)Page.Master).Nom = admin.Nom + " " + admin.Prenom;
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("default.aspx");
        }
    }
}