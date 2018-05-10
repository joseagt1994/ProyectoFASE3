using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SW_CIDEAUTOS
{
    public partial class vehiculos : System.Web.UI.Page
    {
        public String codigoHTML;
        public Empresa empresa;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            Conexion con = new Conexion();
            List<Carro> carros = Sesion.getInstance().getVehiculos();
            if (carros == null)
            {
                carros = con.verCarros();
                Sesion.getInstance().setVehiculos(carros);
            }
            empresa = con.getEmpresa();

            ////ENCABEZADO DEL HTML OSEA EL HEADER Y EL NAVEGADOR DE PAGINAS
            //String encabezadoHTML = "<div class=\"header\">"+
            //                            "<div class=\"navegabilidad\">"+
            //                                "<div class=\"img-logo\">"+
            //                                    "<a href=\"index.html\"><img src=\"imagenes/empresa/logo_ci.png\"/></a>"+
            //                                "</div>"+
            //                                "<nav>"+
            //                                    "<ul>"+
            //                                        "<li class=\"activo\"><a href=\"index.html\">Inicio</a></li>"+
            //                                        "<li><a href=\"vehiculos.aspx\">Vehiculos</a></li>"+
            //                                        "<li><a href=\"financiamiento.aspx\">Financiamiento</a></li>"+
            //                                        "<li><a href=\"contacto.aspx\">Contacto</a></li>"+
            //                                        "<li><a href=\"informacion.html\">Acerca de</a></li>"+
            //                                    "</ul>"+
            //                                "</nav>"+
            //                            "</div>"+
            //                        "</div>";

            //CODIGO DONDE SE ALMACENA LA TABLA QUE GUARDA LOS VEHICULOS
            codigoHTML = "<div class=\"list\">" +
                                "<h1 align=\"center\">Listado de vehiculos</h1><br><br>" +
                                "<div class=\"list-vehiculos\">";
                                    //+"<table>";
            //int contador = 0;
            foreach(Carro c in carros){
                codigoHTML += "<div class=\"columna-4\">\n"+
                                   "<a href=\"vehiculo.aspx?codigo="+c.getCodigo()+"\"><img height=\"160\" src=\"imagenes/vehiculos/"+c.getImagenPrincipal()+"\"></a><br>" +
                                    "<label>"+c.getMarca() + " " + c.getLinea()+"</label><br>" +
                                    "<label>Modelo: " + c.getAnio() + "</label><a class=\"btn btn-primary\" href=\"vehiculo.aspx?codigo=" + c.getCodigo() + "\" role=\"button\">Ver</a>\n</div>";
                //contador++;
                //if (contador == 1)
                //{
                //    codigoHTML += "<tr>" +
                //                    "<td>" +
                //                        "<a href=\"vehiculo.aspx?codigo="+c.getCodigo()+"\"><img height=\"160\" src=\"imagenes/vehiculos/"+c.getImagenPrincipal()+"\"></a><br>" +
                //                        "<label>"+c.getMarca() + " " + c.getLinea()+"</label><br>" +
                //                        "<label>Modelo: " + c.getAnio() + "</label><br><br><br>" +
                //                    "</td>";
                //}
                //else if(contador == 4){
                //    codigoHTML +=   "<td>" +
                //                        "<a href=\"vehiculo.aspx?codigo=" + c.getCodigo() + "\"><img height=\"160\" src=\"imagenes/vehiculos/" + c.getImagenPrincipal() + "\"></a><br>" +
                //                        "<label>" + c.getMarca() + " " + c.getLinea() + "</label><br>" +
                //                        "<label>Modelo: " + c.getAnio() + "</label><br><br><br>" +
                //                    "</td>" +
                //                "</tr>";
                //    contador = 0;
                //}
                //else
                //{
                //    codigoHTML +=   "<td>" +
                //                        "<a href=\"vehiculo.aspx?codigo=" + c.getCodigo() + "\"><img height=\"160\" src=\"imagenes/vehiculos/" + c.getImagenPrincipal() + "\"></a><br>" +
                //                        "<label>" + c.getMarca() + " " + c.getLinea() + "</label><br>" +
                //                        "<label>Modelo: " + c.getAnio() + "</label><br><br><br>" +
                //                    "</td>";
                //}
            }

            //if (contador != 0)
            //{
            //    codigoHTML += "</tr>";
            //}

			codigoHTML +=           //"</table>"+
	                            "</div>"+
	                        "</div>";

            //codigoHTML += "<div class=\"footer-empresa\"></div><footer><p>\"Usados garantizados...\"</p></footer>";

            //Response.Write(encabezadoHTML+"\n"+codigoHTML);

        }
    }
}