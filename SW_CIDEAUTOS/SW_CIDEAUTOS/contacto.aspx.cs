using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace SW_CIDEAUTOS
{
    public partial class contacto : System.Web.UI.Page
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
            String nombre = txtNombre.Text;
            String correoUsuario = txtCorreo.Text;
            String cuerpo = txtCuerpo.Text + "\n\nCorreo del remitente: " + correoUsuario;

            if (!(nombre.Equals("") && correoUsuario.Equals("")))
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(correoUsuario, nombre, System.Text.Encoding.UTF8);

                message.To.Add(new MailAddress("cideautos@gmail.com"));

                message.Subject = "Contacto -- sitio web";
                message.Body = cuerpo;

                SmtpClient cliente = new SmtpClient();

                try
                {
                    System.Net.ServicePointManager.ServerCertificateValidationCallback += 
                        delegate
                        {
                            return true; // **** Always accept
                        };
                    cliente.Send(message);
                    // JAVASCRIPT
                    mostrarMensaje("Mensaje enviado!");
                    txtCorreo.Text = "";
                    txtCuerpo.Text = "";
                    txtNombre.Text = "";
                }
                catch (SmtpException ex)
                {
                    merror = ex.Message.ToString() + " " + ex.StatusCode.ToString() + " " + ex.ToString();
                    mostrarMensaje("Mensaje no enviado, intente nuevamente!");
                }

            }
        }

        public void mostrarMensaje(String msj)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message Box", "<script language='javascript'>alert('" + msj + "')</script>");
        }

    }
}
//enviar el correo
//MailMessage correo = new MailMessage();
//correo.From = new MailAddress(correoUsuario, nombre, System.Text.Encoding.UTF8);
//correo.To.Add("cideautos@gmail.com");
//correo.Subject = "Contacto -- sitio web";
//correo.SubjectEncoding = System.Text.Encoding.UTF8;
//correo.Body = cuerpo;
//correo.BodyEncoding = System.Text.Encoding.UTF8;
//correo.IsBodyHtml = false;
//correo.Priority = MailPriority.Normal;

//SmtpClient cliente = new SmtpClient();

////definicion tecnica del correo

//cliente.Credentials = new System.Net.NetworkCredential("cideautos@gmail.com", "cideautos2014");
//cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
//cliente.UseDefaultCredentials = true;
//cliente.Port = 587; // sino 587 o 465,... GODADDY -> 25
//cliente.Host = "smtp.gmail.com";
//cliente.EnableSsl = false;