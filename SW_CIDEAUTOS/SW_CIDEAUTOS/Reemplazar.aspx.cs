using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace SW_CIDEAUTOS
{
    public partial class Reemplazar : System.Web.UI.Page
    {
        int cod_carro, cod_imagen;
        Conexion con = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            Sesion session = (Sesion)Session["Sesion"];
            if (!session.iniciado)
            {
                Response.Redirect("Login.aspx");
            }
            cod_imagen = Convert.ToInt32(Request.QueryString["codi"]);
            cod_carro = Convert.ToInt32(Request.QueryString["codc"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Guardar Imagen y Reemplzarla
            if (cargaImagen.PostedFile != null && cargaImagen.PostedFile.ContentLength > 0)
            {
                String nombre = cargaImagen.PostedFile.FileName;

                //CARGAR IMAGEN

                Byte[] bytes = cargaImagen.FileBytes;

                String path = Path.Combine(Server.MapPath("~/imagenes/vehiculos"));
                String rC = path + "\\" + nombre;
                File.WriteAllBytes(rC, bytes);
                con.reemplazarImagen(cod_imagen,nombre);
                Response.Redirect("eImagenes.aspx?codigo=" + cod_carro);
            }
            else
            {
                //No hay imagen para cargar
            }
        }
    }
}