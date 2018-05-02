using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SW_CIDEAUTOS
{
    public partial class Login : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Login para gestion de vehiculos
            lblMensaje.Visible = false;
            lblMensaje.Text = "";
            String usuario = txtUsuario.Text;
            String pass = txtPass.Text;

            if (con.login(usuario,pass))
            {
                Sesion session = Sesion.getInstance();
                session.setSesion(usuario,pass);
                Session["Sesion"] = session;
                //Redirigir a menu de gestion de carros
                txtUsuario.Text = "";
                txtPass.Text = "";
                Response.Redirect("Gestion.aspx");
            }
            else
            {
                //Error al ingresar
                lblMensaje.Text = "Usuario o contraseña incorrecta, vuelva a intentar..";
                lblMensaje.Visible = true;
                txtUsuario.Text = "";
                txtPass.Text = "";
            }

        }
    }
}