using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SW_CIDEAUTOS
{
    public class Banner
    {
        public int codigo;
        public String ruta;
        public Banner(int cod,String ruta)
        {
            this.codigo = cod;
            this.ruta = ruta;
        }
    }
}