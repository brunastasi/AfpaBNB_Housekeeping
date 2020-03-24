using AFPABNBADMIN.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFPABNBADMIN
{
    public partial class _Default : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValider_Click(object sender, EventArgs e)
        {
            string login = this.txtLogin.Text;
            string password = this.txtPassword.Text;

            if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(password))
            {

                DaoAdmin daoAdmin = new DaoAdmin();
                Admin admin = daoAdmin.GetAdmin(login, password);
               

                if (admin != null)
                {
                    Session["admin"] = admin;
                    Response.Redirect("HomeAdmin.aspx");
                }


            }
        }
    }
}
