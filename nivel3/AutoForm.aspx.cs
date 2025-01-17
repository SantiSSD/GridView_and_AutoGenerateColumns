using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
namespace nivel3
{
    public partial class AutoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            ddlColores.Items.Add("Negro");
            ddlColores.Items.Add("Blanco");
            ddlColores.Items.Add("Rojo");
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto a = new Auto();
            a.Id = int.Parse(txtId.Text);
            a.Color = ddlColores.SelectedValue;
            a.Modelo = txtModelo.Text;
            a.Descripcion = txtDescripcion.Text;
            a.Fecha = DateTime.Parse(txtFecha.Text);
            a.Usado = chkUsado.Checked;

            if (rdbImportado.Checked)
                a.Importado = true;
            else if (rdbNacional.Checked)
                a.Importado = false;
          
            
            ((List<Auto>)Session["listaAutos"]).Add(a);
            Response.Redirect("Default.aspx", false);
        }

        protected void rdbImportado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
