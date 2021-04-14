using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recherche
{
    public partial class Chercher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //-------------- la variable de session : recuperation de la valeur entré par l'utilisateur ----------
            Session["rch"] = bxRecherche.Text;
        }

        protected void btnRecherche_Click(object sender, EventArgs e)
        {
            //------------ Si le TextBox est vide => L'affichage d'un Label --------

            if (bxRecherche.Text.Equals(""))
            { 
                lblR.Visible = true; 
            }
            //------------ Sinon => Redireger  vers la page Liens.aspx ------------
            else
            {
                lblR.Visible = false;
                Response.Redirect("~/Liens.aspx");
            }
        }
    }
}