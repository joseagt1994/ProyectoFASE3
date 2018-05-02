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
    public partial class eEnlaces : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        public static List<Enlace> enlaces = new List<Enlace>();

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

                String path = Path.Combine(Server.MapPath("~/imagenes/empresa"));
                String rC = path + "\\" + nombre;
                File.WriteAllBytes(rC, bytes);
                Enlace en = new Enlace();
                en.ruta = nombre;
                en.nombre = txtNombre.Text;
                enlaces.Add(en);
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
            foreach (Enlace en in enlaces)
            {
                con.insertarEnlace(en.nombre, en.ruta);
            }
            //Mensaje de que se guardaron los datos
            enlaces = new List<Enlace>();
            Response.Redirect("Gestion.aspx");
        }

        public void bindData()
        {
            gvImagenes.DataSource = GetTableWithInitialData();
            gvImagenesViejas.DataSource = GetTablaEnlaces();
            DataBind();
        }
        public DataTable GetTableWithInitialData() // this might be your sp for select
        {
            DataTable table = new DataTable();

            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("ruta", typeof(string));

            foreach (Enlace en in enlaces)
            {
                String ruta = ResolveUrl("~/imagenes/empresa/" + en.ruta);
                table.Rows.Add(en.nombre, ruta);
            }

            return table;
        }

        public DataTable GetTablaEnlaces()
        {
            DataTable table = new DataTable();

            table.Columns.Add("cod_enlace", typeof(string));
            table.Columns.Add("nombre", typeof(string)); //link
            table.Columns.Add("ruta", typeof(string));

            foreach (Enlace img in con.getEnlaces())
            {
                String ruta = ResolveUrl("~/imagenes/empresa/" + img.ruta);
                table.Rows.Add(img.codigo, img.nombre, ruta);
            }

            return table;
        }

        protected void gvImagenes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {

                String img_name = Convert.ToString(e.CommandArgument);
                foreach(Enlace en in enlaces)
                {
                    if (en.nombre.Equals(img_name))
                    {
                        enlaces.Remove(en);
                    }
                }
            }
            bindData();
        }

        protected void gvImagenesViejas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int cod_enlace = Convert.ToInt32(e.CommandArgument);
                con.eliminarEnlace(cod_enlace);
                bindData();
            }

        }
    }
}