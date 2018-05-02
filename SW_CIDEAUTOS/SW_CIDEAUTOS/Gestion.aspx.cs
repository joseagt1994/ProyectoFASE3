using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SW_CIDEAUTOS
{
    public partial class Gestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verificar si hay alguna sesion iniciada sino redirigir a index.html
            Sesion session = (Sesion)Session["Sesion"];
            if (!session.iniciado)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Agregar carro
            Response.Redirect("Agregar.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Eliminar carro
            Response.Redirect("Eliminar.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Cerrar sesion
            Sesion session = Sesion.getInstance();
            session.iniciado = false;
            session.nombre = session.pass = "";
            Response.Redirect("Login.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Gestionar Banner
            Response.Redirect("eBanner.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // Modulos
            Response.Redirect("eDatos.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            // Multimedia
            Response.Redirect("eMultimedia.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            // Paginas
            Response.Redirect("eEnlaces.aspx");
        }
    }
}