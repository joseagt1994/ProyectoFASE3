using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SW_CIDEAUTOS
{
    public partial class vehiculo : System.Web.UI.Page
    {
        public String codigoHTML;
        public Empresa empresa;
        public Imagen imagen;
        public Carro actual;

        protected void Page_Load(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(Request.QueryString["codigo"]);
            Conexion con = new Conexion();
            empresa = con.getEmpresa();
            actual = con.getCarro(cod);

            //PRIMER DIV EL CUAL LLEVA LO SIGUIENTE: GALERIA DE IMAGENES DEL CARRO SELECCIONADO Y LA INFORMACION
            String galeriaImagenes = "<p>" +
                                        "&nbsp;</p>" +
                                    "<p>" +
                                        "&nbsp;</p>" +
                                    "<p>" +
                                        "&nbsp;</p>" +
                                    "<p>" +
                                        "&nbsp;</p>" +
                                    "<p>" +
                                        "&nbsp;</p>" +
                                    "<p>" +
                                        "&nbsp;</p>" +
                                    "<p>" +
                                        "&nbsp;</p>" +
                                    "<p>" +
                                        "&nbsp;</p>" +
                                    "<h1 class=\"color1\">"+actual.getMarca()+" "+actual.getLinea()+" "+actual.getAnio()+"</h1>" +
                                    "<p>" +
                                        "&nbsp;</p>" +

                                    "<div class=\"columna\">" +

                                        "<div id=\"gallery\">";

            //SE RECCORE LA LISTA DE VEHICULOS PARA GUARDARLOS
            foreach(Imagen img in actual.getImagenes()){
                galeriaImagenes += "<img src=\"imagenes/vehiculos/"+img.ruta+"\"/>" + "\n";
            }
                
            //Hasta aqui llega
            galeriaImagenes += "<script>"+
                                "(function () {"+
                                    "Galleria.loadTheme('https://cdnjs.cloudflare.com/ajax/libs/galleria/1.4.5/themes/classic/galleria.classic.min.js');"+
                                    "Galleria.run('.galleria');"+
                                "}());"+
                               "</script>";

            galeriaImagenes += "</div>" +

                            "<br/><br/><br/><h1 class=\"color1\">Plan de Financiamiento</h1>" +

                            "<table class=\"infor\">" +
                                "<tr>" +
                                    "<td class=\"auto-style1\">" +
                                        "<h2>Enganche desde</h2>" +
                                    "</td>" +
                                    "<td>";

            if (actual.getEnganche() > 0)
            {
                galeriaImagenes += "<h3> Q." + String.Format(CultureInfo.InvariantCulture,
                                 "{0:0,0.00}", actual.getEnganche()) + "</h3>";
            }
            else
            {
                galeriaImagenes += "<h3>Q. 0.00</h3>";
            }

            galeriaImagenes += "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td class=\"auto-style1\">" +
                                            "<h2>Cuotas desde</h2>" +
                                        "</td>" +
                                        "<td>";

            //double cuotas = Double.Parse(actual.getCuotas());
            galeriaImagenes += "<h3> Q." + String.Format(CultureInfo.InvariantCulture,
                                 "{0:0,0.00}", actual.getCuotas()) + "</h3>";
                
            galeriaImagenes += "</td>"+
                                        "</tr>"+
                                        "<tr>"+
                                            "<td class=\"auto-style1\">"+
                                                "<h2>Precio de contado</h2>"+
                                            "</td>"+
                                            "<td>"+
                                                "<h3> Q."+ String.Format(CultureInfo.InvariantCulture,
                                 "{0:0,0.00}", actual.getPrecio()) + "</h3>"+  //PRECIO CONTADO
                                            "</td>"+
                                        "</tr>"+
                                    "</table>"+
                                "</div>";

            //TABLA DE INFORMACION

            String informacion = "<div class=\"columna\">"+
			"&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"+
            "<h1 class=\"color1\">Características</h1>" +
                "<br />"+
                "<table class=\"infor\">"+
                    "<tr>"+
                        "<td style=\"text-align: left\">" +
                            "<h2>Tipo</h2>"+
                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getTipo()+"</h3>"+

                        "</td>"+
                        "<td align=\"left\">" +

                            "<h2>Embarcado</h2>"+

                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getEmbarcado()+"</h3>"+

                        "</td>"+
                    "</tr>"+
                    "<tr>"+
                        "<td align=\"left\">" +
                            "<h2>Marca</h2>"+
                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getMarca()+"</h3>"+

                        "</td>"+
                        "<td align=\"left\">" +

                            "<h2>Linea</h2>"+

                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getLinea()+"</h3>"+

                        "</td>"+
                    "</tr>"+
                    "<tr>"+
                        "<td align=\"left\">" +
                            "<h2>Modelo</h2>"+
                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getAnio()+"</h3>"+

                        "</td>"+
                        "<td align=\"left\">" +

                            "<h2>Chocado</h2>"+

                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getChocado()+"</h3>"+

                        "</td>"+
                    "</tr>"+
                    "<tr>"+
                        "<td align=\"left\">" +
                            "<h2>Km/Millas</h2>"+
                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getKilometraje()+"</h3>"+

                        "</td>"+
                        "<td align=\"left\">" +

                            "<h2>Color</h2>"+

                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getVidrios()+"</h3>"+   //EN VIDRIOS VA COLOR

                        "</td>"+
                    "</tr>"+
                    "<tr>"+
                        "<td align=\"left\">" +
                            "<h2>C.C.</h2>"+
                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getMotor()+"</h3>"+

                        "</td>"+
                        "<td align=\"left\">" +

                            "<h2>Cilindros</h2>"+

                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getCilindros()+"</h3>"+

                        "</td>"+
                    "</tr>"+
                    "<tr>"+
                        "<td align=\"left\">" +
                            "<h2>Combustible</h2>"+
                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getCombustible()+"</h3>"+

                        "</td>"+
                        "<td align=\"left\">" +

                            "<h2>Tapiceria</h2>"+

                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getTapiceria()+"</h3>"+

                        "</td>"+
                    "</tr>"+
                    "<tr>"+
                        "<td align=\"left\">" +
                            "<h2>Transmisión</h2>"+
                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getTimon()+"</h3>"+  // TRANSMISION EN VEZ DE TIMON

                        "</td>"+
                        "<td align=\"left\">" +

                            "<h2>Aire Acondicionado</h2>"+

                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getAire()+"</h3>"+

                        "</td>"+
                    "</tr>"+
                    "<tr>"+
                        "<td align=\"left\">" +
                            "<h2>Bolsas de Aire</h2>"+
                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getBolsas()+"</h3>"+

                        "</td>"+
                        "<td align=\"left\">" +

                            "<h2>Cerradura Central</h2>"+

                        "</td>"+
                        "<td>"+

                            "<h3>"+actual.getCerradura()+"</h3>"+

                        "</td>"+
                    "</tr>"+
                "</table>"+
                "<h2>Otros..</h2>"+
                "<h3>"+actual.getDescripcion()+"</h3>"+
		"</div>";

            codigoHTML = "\n" + galeriaImagenes + "\n" + informacion;
        }

        protected void btn_comprar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pago.aspx");
        }
    }
}