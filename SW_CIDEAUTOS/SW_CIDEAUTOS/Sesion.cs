﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SW_CIDEAUTOS
{
    public class Sesion
    {
        public String nombre, pass;
        //Sirve para diferenciar imagenes a donde se redirige
        public Boolean editandoImagenes = false;
        public bool iniciado = false;
        private static Sesion sesion = null;

        private List<Carro> vehiculos = null;


        private Sesion()
        {

        }

        public static Sesion getInstance()
        {
            if (sesion == null)
            {
                sesion = new Sesion();
            }
            return sesion;
        }

        public void setSesion(String nombre,String pass)
        {
            this.nombre = nombre;
            this.pass = pass;
            this.iniciado = true;
        }

        public List<Carro> getVehiculos()
        {
            return vehiculos;
        }

        public void setVehiculos(List<Carro> vehiculos)
        {
            this.vehiculos = vehiculos;
        }

        public Carro getVehiculo(int codigo)
        {
            foreach(Carro v in vehiculos)
            {
                if(v.getCodigo() == codigo)
                {
                    return v;
                }
            }
            return null;
        }
    }
}