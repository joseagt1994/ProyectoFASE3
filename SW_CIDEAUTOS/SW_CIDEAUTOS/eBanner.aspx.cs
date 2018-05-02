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
    public partial class eBanner : System.Web.UI.Page
    {
        public static List<string> imagenes = new List<string>();
        Conexion con = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            Sesion session = (Sesion)Session["Sesion"];
            if (!session.iniciado)
            {
                Response.Redirect("Login.aspx");
            }
            bindData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Guardar imagen subida
            if (cargaImagen.PostedFile != null && cargaImagen.PostedFile.ContentLength > 0)
            {
                String nombre = cargaImagen.PostedFile.FileName;

                //CARGAR IMAGEN

                Byte[] bytes = cargaImagen.FileBytes;

                String path = Path.Combine(Server.MapPath("~/imagenes/banner"));
                String rC = path + "\\" + nombre;
                File.WriteAllBytes(rC, bytes);
                imagenes.Add(nombre);
                bindData();
            }
            else
            {
                //No hay imagen para cargar
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Recorrer las imagenes del LinkedList y guardarlas
            foreach (String nombre in imagenes)
            {
                con.insertarBanner(nombre);
            }
            //Mensaje de que se guardaron los datos
            imagenes = new List<string>();
            Response.Redirect("Gestion.aspx");
        }

        public void bindData()
        {
            gvImagenes.DataSource = GetTableWithInitialData();
            gvImagenesViejas.DataSource = GetTablaBanner();
            DataBind();
        }
        public DataTable GetTableWithInitialData() // this might be your sp for select
        {
            DataTable table = new DataTable();

            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("ruta", typeof(string));

            foreach (String i in imagenes)
            {
                String ruta = ResolveUrl("~/imagenes/banner/" + i);
                table.Rows.Add(i, ruta);
            }

            return table;
        }

        public DataTable GetTablaBanner()
        {
            DataTable table = new DataTable();

            table.Columns.Add("cod_banner", typeof(string));
            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("ruta", typeof(string));

            foreach (Banner ban in con.getBanners())
            {
                String ruta = ResolveUrl("~/imagenes/banner/" + ban.ruta);
                table.Rows.Add(ban.codigo, ban.ruta, ruta);
            }

            return table;
        }

        protected void gvImagenes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                String img_name = Convert.ToString(e.CommandArgument);
                imagenes.Remove(img_name);
            }
            bindData();
        }

        protected void gvImagenesViejas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int cod_banner = Convert.ToInt32(e.CommandArgument);
                con.eliminarBanner(cod_banner);
                bindData();
            }
            
        }
    }
}