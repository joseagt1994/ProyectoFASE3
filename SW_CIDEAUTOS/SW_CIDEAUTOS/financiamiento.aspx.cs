using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace SW_CIDEAUTOS
{
    public partial class Financiamiento : System.Web.UI.Page
    {
        String merror;
        Conexion con = new Conexion();
        public Empresa empresa;

        protected void Page_Load(object sender, EventArgs e)
        {
            empresa = con.getEmpresa();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Enviar correo
            String estados;
            if (estadoCuenta.Checked)
            {
                //Esta presionado
                estados = "Si maneja.";
            }
            else
            {
                estados = "No maneja.";
            }
            String nombre = txtNombre.Text;
            String correoUsuario = txtCorreo.Text;
            String cuerpo = "Nombre completo: " + nombre +
                "\nDPI: " + txtDPI.Text +
                "\nFecha de nacimiento: " + txtNacimiento.Text +
                "\nNIT: " + txtNIT.Text + 
                "\nDirección: " + txtDireccion.Text + 
                "\nEmpresa donde labora: " + txtEmpresa.Text + 
                "\nFecha de ingreso laboral: " + txtFechaLaboral.Text +
                "\nPuesto: " + txtPuesto.Text + 
                "\nSalario: " + txtSalario.Text + 
                "\nManeja estados de cuenta: " + estados +
                "\nTelefonos: " + txtTel1.Text + ", " + txtTel2.Text + 
                "\nCorreo: " + txtCorreo.Text;

                //enviar el correo
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(correoUsuario, nombre, System.Text.Encoding.UTF8);
                correo.To.Add("cideautos@gmail.com");
                correo.Subject = "Solicitud de credito -- sitio web";
                correo.SubjectEncoding = System.Text.Encoding.UTF8;
                correo.Body = cuerpo;
                correo.BodyEncoding = System.Text.Encoding.UTF8;
                correo.IsBodyHtml = false;
                correo.Priority = MailPriority.Normal;

                SmtpClient cliente = new SmtpClient();

                //definicion tecnica del correo

                try
                {
                    cliente.Send(correo);
                    mostrarMensaje("Su solicitud ha sido enviada!");
                    txtCorreo.Text = "";
                    txtDireccion.Text = "";
                    txtDPI.Text = "";
                    txtEmpresa.Text = "";
                    txtFechaLaboral.Text = "";
                    txtNacimiento.Text = "";
                    txtNIT.Text = "";
                    txtNombre.Text = "";
                    txtPuesto.Text = "";
                    txtSalario.Text = "";
                    txtTel1.Text = "";
                    txtTel2.Text = "";
                   
                }
                catch (SmtpException ex)
                {
                    merror = ex.Message.ToString();
                    mostrarMensaje("So solicitud no se pudo enviar, intente nuevamente!");
                }

        }

        public void mostrarMensaje(String msj)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message Box", "<script language='javascript'>alert('" + msj + "')</script>");
        }

        protected void estadoCuenta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}