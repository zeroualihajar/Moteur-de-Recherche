using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recherche
{
    public partial class Liens : System.Web.UI.Page
    {
        //----------Configuration de la connexion à la BDD : BD -------
        String strConnection = ConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString;

        //---------- Créer un DataSet --------
        DataSet test = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {

            //--------------  Rechercher ------------------------------------
            if (IsPostBack)
            {
                ScriptManager1.Controls.Remove(ScriptManager1);
                string rch = TextBox1.Text;
                //------------- Si le TextBox est vide => rien à faire --------------
                if (rch.Equals("")) 
                { 
                    lblRes.Visible = false;
                    Label2.Visible = true;
                }
                //------------- Sinon : Effectuer une Recherche  -----------------
                else
                {
                    TextBox1.Text = rch;
                    Label1.Visible = false;
                    New(rch);
                    Label2.Visible = false;
                }
            }
            else
            {
                //------- S'il s'agit de  la recherche de la 1 ère page -------
                String rech = (String)Session["rch"];
                TextBox1.Text = rech;
                New(rech);
                Label2.Visible = false;

            }
            
        }
     
        //-----------------| La fonction de Recherche |-------------------------
            private void New(string rech)
            {
                //--------- Créer la requete d'affichage le titre des URL correspond à la recherche effectueé par l'utilisateur  --------
                String Requete = "select final.title from((select res.IdLien, Url , title from(select top 100 r.IdLien, COUNT(IdLien) as click from(select distinct top 100 h.IdHistorique, h.Date, h.IdSearch from Historique h order by h.Date desc)hi inner join Search r on hi.IdSearch = r.IdSearch group by IdLien order by click desc)res inner join Lien l on res.IdLien = l.IdLien)union all select IdLien, Url, title from Lien where IdLien not in(select res.IdLien from (select top 100 r.IdLien, COUNT(IdLien) as click from(select distinct top 100 h.IdHistorique, h.Date, h.IdSearch from Historique h order by h.Date desc) hi inner join Search r on hi.IdSearch = r.IdSearch group by IdLien order by click desc)res inner join Lien l on res.IdLien = l.IdLien))final where final.Url like '%" + rech + "%'";  
           
                SqlConnection Connect = new SqlConnection(strConnection);
                SqlDataAdapter command = new SqlDataAdapter(Requete, Connect);
                Connect.Open();
                SqlDataReader Reader = command.SelectCommand.ExecuteReader();

                //-------- Lire le résultat en le rendre sous la forma de linkButton ----------
                while (Reader.Read())
                {
                    //------- Créer le linkButton ------
                    LinkButton link = new LinkButton();
                    String temp = (String)Reader.GetValue(0);
                     link.Text = temp;
                    ScriptManager1.Controls.Add(link);
                    ScriptManager1.Controls.Add(new LiteralControl("<br /> <br />"));
                    link.CommandArgument = temp;
                    link.Click += new EventHandler(LinkButton_Click);
                }
                    Reader.Close();

                //------ Vérifier  s'il existe des URL qui correspond à la recherche effectuée -------
                    if (ScriptManager1.Controls.Count != 0)
                    {
                    lblRes.Visible = true;
                    //----- S'il existe des URL => Inserer le contenu de TextBox à la table Mot dans la BDD s'il n'existe pas dans la table Mot ------
                        String Requete1 = "if not exists(select * From Mot where Text = '" + rech + "') insert into Mot(Text) VALUES('" + rech + "') ";

                        SqlDataAdapter command1 = new SqlDataAdapter(Requete1, Connect);
                        command1.Fill(test);

                        Label1.Visible = false;
                    }

                    //------ S'il n'existe aucun résultat => Afficher le contenu de Label indiquant l'inexistence d'aucun URL correspond à la recherche effectué ------
                    else
                    {
                        Label1.Visible = true;
                    }
                    Connect.Close();
            }



        //------- Définir l'action  de linkButton => diriger l'utilisateur vers le lien cliqué ---------
        void LinkButton_Click(Object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)(sender);
            string myValue = btn.CommandArgument;

            SqlConnection Con = new SqlConnection(strConnection);
            String Req2 = "select Url from Lien where Title = '" + myValue + "' ";
            SqlDataAdapter comm = new SqlDataAdapter(Req2, Con);
            Con.Open();
            comm.Fill(test);

            SqlDataReader reade = comm.SelectCommand.ExecuteReader();
            reade.Read();

            String url = (String)reade.GetValue(0);
            reade.Close();

            //------- Créer la requete d'insertion de  la recherche effectuée si cette recherche n'existe pas dans la teble de Search  ------
            String Req5 = "if not exists(select IdMot, IdLien from Search where IdMot = (select IdMot from Mot where Text = '" + TextBox1.Text + "') AND IdLien = (select IdLien from Lien where Url LIKE '" + url + "')) insert into Search(IdMot, IdLien) values((select IdMot from Mot where Text = '" + TextBox1.Text + "'), (select IdLien from Lien where Url LIKE '" + url + "'))";
            SqlDataAdapter comn = new SqlDataAdapter(Req5, Con);
            comn.Fill(test);

            //-------- Créer la requete d'insertion chaque recherche effecuée dans la table Historique qui existe dans la BDD --------
            String Req3 = "insert into Historique (Date, IdSearch) values ('" + DateTime.UtcNow.Date.ToString("yyyy-MM-dd") + "', (select IdSearch from Search where IdMot = (select IdMot from Mot where Text = '" + TextBox1.Text + "') AND IdLien =  (select IdLien from Lien where Url LIKE '%" + url + "%')))";
            SqlDataAdapter command2 = new SqlDataAdapter(Req3, Con);
            command2.Fill(test);

            //-------- Redirection vers le lien choisis par LinkButton ----------
            Response.Redirect(url);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void ImageButton7_Click1(object sender, ImageClickEventArgs e)
        {
            
           
        }
    }
}