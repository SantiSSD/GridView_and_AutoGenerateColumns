using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace nivel3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["listaAutos"] == null)
                {
                    AutoNegocio negocio = new AutoNegocio();
                    Session.Add("listaAutos",negocio.listar());
                }

             
                dgvAutos.DataSource = Session["listaAutos"];
                dgvAutos.DataBind();
            }

        }
    }
}