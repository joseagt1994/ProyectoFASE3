using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SW_CIDEAUTOS
{
    public class Carro
    {
        private int codigo,anio,cilindros;
        private double precio,enganche;
        private String marca,linea,tipo,descripcion,embarcado,chocado,bolsas,cerradura,vidrios,aire,timon,tapiceria,
            motor,combustible,kilometraje,cuotas,rutaprincipal,placa;
        private List<Imagen> imagenes;

        public Carro()
        {
            imagenes = new List<Imagen>();
        }

        public void setImagenPrincipal(String img)
        {
            this.rutaprincipal = img;
        }

        public void setPlaca(String p)
        {
            this.placa = p;
        }

        public String getPlaca()
        {
            return this.placa;
        }

        public String getImagenPrincipal()
        {
            return this.rutaprincipal;
        }
        public void agregarImagen(Imagen img)
        {
            imagenes.Add(img);
        }

        public List<Imagen> getImagenes()
        {
            return this.imagenes;
        }

        public void setEnganche(double l)
        {
            this.enganche = l;
        }

        public double getEnganche()
        {
            return this.enganche;
        }

        public void setPrecio(double l)
        {
            this.precio = l;
        }

        public double getPrecio()
        {
            return this.precio;
        }

        public void setTipo(String l)
        {
            this.tipo = l;
        }

        public String getTipo()
        {
            return this.tipo;
        }

        public void setCuotas(String l)
        {
            this.cuotas = l;
        }

        public String getCuotas()
        {
            return this.cuotas;
        }

        public void setKilometraje(String l)
        {
            this.kilometraje = l;
        }

        public String getKilometraje()
        {
            return this.kilometraje;
        }

        public void setCombustible(String l)
        {
            this.combustible = l;
        }

        public String getCombustible()
        {
            return this.combustible;
        }

        public void setMotor(String l)
        {
            this.motor = l;
        }

        public String getMotor()
        {
            return this.motor;
        }

        public void setTapiceria(String l)
        {
            this.tapiceria = l;
        }

        public String getTapiceria()
        {
            return this.tapiceria;
        }

        public void setTimon(String l)
        {
            this.timon = l;
        }

        public String getTimon()
        {
            return this.timon;
        }

        public void setAire(String l)
        {
            this.aire = l;
        }

        public String getAire()
        {
            return this.aire;
        }

        public void setVidrios(String l)
        {
            this.vidrios = l;
        }

        public String getVidrios()
        {
            return this.vidrios;
        }

        public void setCerradura(String l)
        {
            this.cerradura = l;
        }

        public String getCerradura()
        {
            return this.cerradura;
        }

        public void setBolsas(String l)
        {
            this.bolsas = l;
        }

        public String getBolsas()
        {
            return this.bolsas;
        }

        public void setChocado(String l)
        {
            this.chocado = l;
        }

        public String getChocado()
        {
            return this.chocado;
        }

        public void setEmbarcado(String l)
        {
            this.embarcado = l;
        }

        public String getEmbarcado()
        {
            return this.embarcado;
        }

        public void setDescripcion(String l)
        {
            this.descripcion = l;
        }

        public String getDescripcion()
        {
            return this.descripcion;
        }

        public void setCilindros(int cod)
        {
            this.cilindros = cod;
        }

        public int getCilindros()
        {
            return this.cilindros;
        }

        public void setCodigo(int cod){
            this.codigo = cod;
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public void setAnio(int a)
        {
            this.anio = a;
        }

        public int getAnio()
        {
            return this.anio;
        }

        public void setMarca(String m)
        {
            this.marca = m;
        }

        public String getMarca()
        {
            return this.marca;
        }

        public void setLinea(String l)
        {
            this.linea = l;
        }

        public String getLinea()
        {
            return this.linea;
        }

    }
}