using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SW_CIDEAUTOS
{
    public partial class Index : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        public List<Banner> banners;
        public List<ImagenSlider> imagenes;
        public List<Enlace> enlaces;
        public Empresa empresa;

        protected void Page_Load(object sender, EventArgs e)
        {
            banners = con.getBanners();
            imagenes = con.getSlider();
            empresa = con.getEmpresa();
            enlaces = con.getEnlaces();
        }
    }
}