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
    public partial class eImagenes : System.Web.UI.Page
    {
        public static List<string> imagenes = new List<string>();
        int cod_carro;
        Conexion con = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            Sesion session = (Sesion)Session["Sesion"];
            if (!session.iniciado)
            {
                Response.Redirect("Login.aspx");
            }
            cod_carro = Convert.ToInt32(Request.QueryString["codigo"]);
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

                String path = Path.Combine(Server.MapPath("~/imagenes/vehiculos"));
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
            if (cod_carro > 0)
            {
                foreach (String nombre in imagenes)
                {
                    con.insertarImagen(cod_carro, nombre);
                }
                //Mensaje de que se guardaron los datos
                imagenes = new List<string>();
                Response.Redirect("Eliminar.aspx");
            }
        }

        public void bindData()
        {
            gvImagenes.DataSource = GetTableWithInitialData();
            gvImagenesViejas.DataSource = GetTablaCarro();
            DataBind();
        }
        public DataTable GetTableWithInitialData() // this might be your sp for select
        {
            DataTable table = new DataTable();

            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("ruta", typeof(string));

            foreach (String i in imagenes)
            {
                String ruta = ResolveUrl("~/imagenes/vehiculos/" + i);
                table.Rows.Add(i, ruta);
            }

            return table;
        }

        public DataTable GetTablaCarro()
        {
            Carro carro = con.getCarro(cod_carro);
            DataTable table = new DataTable();

            table.Columns.Add("cod_imagen", typeof(string));
            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("ruta", typeof(string));

            foreach (Imagen img in carro.getImagenes())
            {
                String ruta = ResolveUrl("~/imagenes/vehiculos/" + img.ruta);
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
                con.eliminarImagen(cod_imagen);
                bindData();
            }
            else if (e.CommandName == "Reemplazar")
            {
                int cod_imagen = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("Reemplazar.aspx?codi="+cod_imagen+"&codc="+cod_carro);
            }
            
        }
    }
}