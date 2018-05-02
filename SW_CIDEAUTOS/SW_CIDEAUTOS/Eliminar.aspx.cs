using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SW_CIDEAUTOS
{
    public partial class Eliminar : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        List<Carro> carros = new List<Carro>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Sesion session = (Sesion)Session["Sesion"];
            if (!session.iniciado)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                carros = con.verCarros();
                bindData();
            }
        }

        public void bindData()
        {
            gvCarros.DataSource = GetTableWithInitialData();
            DataBind();
        }
        public DataTable GetTableWithInitialData() // this might be your sp for select
        {
            DataTable table = new DataTable();

            table.Columns.Add("Placa", typeof(string));
            table.Columns.Add("Marca", typeof(string));
            table.Columns.Add("Linea", typeof(string));
            table.Columns.Add("Modelo", typeof(string));
            table.Columns.Add("codigo", typeof(string));
            table.Columns.Add("ruta", typeof(string));

            foreach (Carro c in carros)
            {
                String ruta = ResolveUrl("~/imagenes/vehiculos/" + c.getImagenPrincipal());
                table.Rows.Add(c.getPlaca(),c.getMarca(),c.getLinea(),c.getAnio(),c.getCodigo(),ruta);
            }

            return table;
        }

        protected void gvCarros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int codigo = Convert.ToInt32(e.CommandArgument);
                con.eliminarCarro(codigo);
                mostrarMensaje("El vehiculo seleccionado se ha eliminado!");
            }
            else if (e.CommandName == "Editar")
            {
                int codigo = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("Edicion.aspx?codigo="+codigo);
            }
            else if (e.CommandName == "EditarImg")
            {
                int codigo = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("eImagenes.aspx?codigo=" + codigo);
            }
            bindData();
        }

        public void mostrarMensaje(String msj)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message Box", "<script language='javascript'>alert('" + msj + "')</script>");
        }
    }
}