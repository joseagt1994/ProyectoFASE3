using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SW_CIDEAUTOS
{
    public partial class Informacion : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        public Empresa empresa;
        public List<Valor> valores;

        protected void Page_Load(object sender, EventArgs e)
        {
            empresa = con.getEmpresa();
            valores = con.getValores();
        }
    }
}