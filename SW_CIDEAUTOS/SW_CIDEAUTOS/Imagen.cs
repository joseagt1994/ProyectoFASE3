using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SW_CIDEAUTOS
{
    public class Imagen
    {
        public String ruta;
        public int codigo;

        public Imagen(String nom,int cod)
        {
            this.codigo = cod;
            this.ruta = nom;
        }
    }
}