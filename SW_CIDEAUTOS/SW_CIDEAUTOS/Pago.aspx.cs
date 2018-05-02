using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SW_CIDEAUTOS
{
    //Nombre txtNombre
    //No de tarjeta txtNoTarjeta
    //Codigo txtCodigo
    public partial class Pago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btEnviar_Click(object sender, EventArgs e)
        {
            ServicioTarjeta.WebServiceBancoSoapClient cliente = new ServicioTarjeta.WebServiceBancoSoapClient();
            var respuesta = cliente.ConsultarTarjeta();
            if (respuesta)
            {
                mostrarMensaje("Transaccion realizada con exito!");
            }
            else
            {
                mostrarMensaje("No se pudo realizar la transaccion!");
            }
        }

        public void mostrarMensaje(String msj)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message Box", "<script language='javascript'>alert('" + msj + "')</script>");
        }
    }
}