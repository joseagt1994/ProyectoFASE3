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
    public partial class eMultimedia : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        public static List<string> imagenes = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Sesion session = (Sesion)Session["Sesion"];
            if (!session.iniciado)
            {
                Response.Redirect("Login.aspx");
            }
            bindData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Modificar link del listado de videos de YouTube
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Guardar imagen subida
            if (cargaImagen.PostedFile != null && cargaImagen.PostedFile.ContentLength > 0)
            {
                String nombre = cargaImagen.PostedFile.FileName;

                //CARGAR IMAGEN

                Byte[] bytes = cargaImagen.FileBytes;

                String path = Path.Combine(Server.MapPath("~/imagenes/slider"));
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
            foreach (String s in imagenes)
            {
                con.insertarImagenSlider(s);
            }
            //Mensaje de que se guardaron los datos
            Response.Redirect("Gestion.aspx");
        }

        public void bindData()
        {
            gvImagenes.DataSource = GetTableWithInitialData();
            gvImagenesViejas.DataSource = GetTablaSlider();
            DataBind();
        }
        public DataTable GetTableWithInitialData() // this might be your sp for select
        {
            DataTable table = new DataTable();

            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("ruta", typeof(string));

            foreach (String en in imagenes)
            {
                String ruta = ResolveUrl("~/imagenes/slider/" + en);
                table.Rows.Add(en, ruta);
            }

            return table;
        }

        public DataTable GetTablaSlider()
        {
            DataTable table = new DataTable();

            table.Columns.Add("cod_imagen", typeof(string));
            table.Columns.Add("nombre", typeof(string)); //link
            table.Columns.Add("ruta", typeof(string));

            foreach (ImagenSlider img in con.getSlider())
            {
                String ruta = ResolveUrl("~/imagenes/slider/" + img.ruta);
                table.Rows.Add(img.codigo, img.ruta, ruta);
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
                int cod_imagen = Convert.ToInt32(e.CommandArgument);
                con.eliminarSlider(cod_imagen);
                bindData();
            }

        }
    }
}