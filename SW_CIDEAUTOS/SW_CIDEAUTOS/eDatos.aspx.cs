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
    public partial class eDatos : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        public static Empresa empresa;

        protected void Page_Load(object sender, EventArgs e)
        {
            Sesion session = (Sesion)Session["Sesion"];
            if (!session.iniciado)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                empresa = con.getEmpresa();
                txtSlogan.Text = empresa.slogan;
                txtHistoria.Text = empresa.historia;
                txtMision.Text = empresa.mision;
                txtVision.Text = empresa.vision;
                txtValores.Text = valores(con.getValores());
                txtTitulo1.Text = empresa.modulo1;
                txtTitulo2.Text = empresa.modulo2;
                txtTitulo3.Text = empresa.modulo3;
                txtTitulo4.Text = empresa.modulo4;
                txtTitulo5.Text = empresa.modulo5;
            }
        }

        public String valores(List<Valor> valores)
        {
            String temp = "";
            for(int i = 0; i < valores.Count; i++)
            {
                if(i == 0)
                {
                    temp = valores.ElementAt(i).valor;
                }
                else
                {
                    temp += "," + valores.ElementAt(i).valor;
                }
            }
            return temp;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Modificar logo
            //Guardar imagen subida
            if (cargaImagen.PostedFile != null && cargaImagen.PostedFile.ContentLength > 0)
            {
                String nombre = cargaImagen.PostedFile.FileName;

                //CARGAR IMAGEN

                Byte[] bytes = cargaImagen.FileBytes;

                String path = Path.Combine(Server.MapPath("~/imagenes/empresa"));
                String rC = path + "\\" + nombre;
                File.WriteAllBytes(rC, bytes);
                con.editarLogo(nombre,empresa.codigo);
            }
            else
            {
                //No hay imagen para cargar
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Modificar datos
            //Datos normales
            empresa.slogan = txtSlogan.Text;
            empresa.historia = txtHistoria.Text;
            empresa.mision = txtMision.Text;
            empresa.vision = txtVision.Text;
            con.editarEmpresa(empresa);
            //Valores
            con.insertarValores(txtValores.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Modificar imagen modulo 1
            //Guardar imagen subida
            if (Carga1.PostedFile != null && Carga1.PostedFile.ContentLength > 0)
            {
                String nombre = Carga1.PostedFile.FileName;

                //CARGAR IMAGEN

                Byte[] bytes = Carga1.FileBytes;

                String path = Path.Combine(Server.MapPath("~/imagenes/empresa"));
                String rC = path + "\\" + nombre;
                File.WriteAllBytes(rC, bytes);
                con.modificarImagenModulo(1, nombre, empresa.codigo);
                empresa.ruta1 = nombre;
            }
            else
            {
                //No hay imagen para cargar
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Modificar imagen modulo 2
            //Guardar imagen subida
            if (Carga2.PostedFile != null && Carga2.PostedFile.ContentLength > 0)
            {
                String nombre = Carga2.PostedFile.FileName;

                //CARGAR IMAGEN

                Byte[] bytes = Carga2.FileBytes;

                String path = Path.Combine(Server.MapPath("~/imagenes/empresa"));
                String rC = path + "\\" + nombre;
                File.WriteAllBytes(rC, bytes);
                con.modificarImagenModulo(2, nombre, empresa.codigo);
                empresa.ruta2 = nombre;
            }
            else
            {
                //No hay imagen para cargar
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //Modificar imagen modulo 3
            //Guardar imagen subida
            if (Carga3.PostedFile != null && Carga3.PostedFile.ContentLength > 0)
            {
                String nombre = Carga3.PostedFile.FileName;

                //CARGAR IMAGEN

                Byte[] bytes = Carga3.FileBytes;

                String path = Path.Combine(Server.MapPath("~/imagenes/empresa"));
                String rC = path + "\\" + nombre;
                File.WriteAllBytes(rC, bytes);
                con.modificarImagenModulo(3, nombre, empresa.codigo);
                empresa.ruta3 = nombre;
            }
            else
            {
                //No hay imagen para cargar
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //Modificar imagen modulo 4
            //Guardar imagen subida
            if (Carga4.PostedFile != null && Carga4.PostedFile.ContentLength > 0)
            {
                String nombre = Carga4.PostedFile.FileName;

                //CARGAR IMAGEN

                Byte[] bytes = Carga4.FileBytes;

                String path = Path.Combine(Server.MapPath("~/imagenes/empresa"));
                String rC = path + "\\" + nombre;
                File.WriteAllBytes(rC, bytes);
                con.modificarImagenModulo(4, nombre, empresa.codigo);
                empresa.ruta4 = nombre;
            }
            else
            {
                //No hay imagen para cargar
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            //Modificar imagen modulo 5
            //Guardar imagen subida
            if (Carga5.PostedFile != null && Carga5.PostedFile.ContentLength > 0)
            {
                String nombre = Carga5.PostedFile.FileName;

                //CARGAR IMAGEN

                Byte[] bytes = Carga5.FileBytes;

                String path = Path.Combine(Server.MapPath("~/imagenes/empresa"));
                String rC = path + "\\" + nombre;
                File.WriteAllBytes(rC, bytes);
                con.modificarImagenModulo(5, nombre, empresa.codigo);
                empresa.ruta5 = nombre;
            }
            else
            {
                //No hay imagen para cargar
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.modificarTituloModulo(1, txtTitulo1.Text, empresa.codigo);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            con.modificarTituloModulo(2, txtTitulo2.Text, empresa.codigo);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            con.modificarTituloModulo(3, txtTitulo3.Text, empresa.codigo);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            con.modificarTituloModulo(4, txtTitulo4.Text, empresa.codigo);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            con.modificarTituloModulo(5, txtTitulo5.Text, empresa.codigo);
        }
    }
}