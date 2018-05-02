using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SW_CIDEAUTOS
{
    public class Conexion
    {
        SqlCommand comando;
        SqlDataReader respuesta;
        SqlConnection sqlConn = new SqlConnection("Data Source=184.168.194.78;Initial Catalog=cideautos;User ID=josegt;Password=C1d34ut0S");
        public Conexion()
        {
            
        }

        //Login de usuarios
        public bool login(String usuario,String pass)
        {
            bool iniciar = false;

            String consulta = "SELECT * FROM Usuario WHERE usuario = '"+usuario+"' AND contrasenia = '"+pass+"'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    respuesta = comando.ExecuteReader();

                    if (respuesta.HasRows)
                    {
                        iniciar = true;
                    }

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

            }

            return iniciar;
        }

        //Devolver Empresa
        public Empresa getEmpresa()
        {
            Empresa empresa = new Empresa();

            String consulta = "SELECT * FROM Empresa;";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    respuesta = comando.ExecuteReader();

                    if (respuesta.Read())
                    {
                        empresa.codigo = respuesta.GetInt32(0);
                        empresa.logo = respuesta.GetString(1);
                        empresa.slogan = respuesta.GetString(2);
                        empresa.historia = respuesta.GetString(3);
                        empresa.mision = respuesta.GetString(4);
                        empresa.vision = respuesta.GetString(5);
                        empresa.modulo1 = respuesta.GetString(6);
                        empresa.ruta1 = respuesta.GetString(7);
                        empresa.modulo2 = respuesta.GetString(8);
                        empresa.ruta2 = respuesta.GetString(9);
                        empresa.modulo3 = respuesta.GetString(10);
                        empresa.ruta3 = respuesta.GetString(11);
                        empresa.modulo4 = respuesta.GetString(12);
                        empresa.ruta4 = respuesta.GetString(13);
                        empresa.modulo5 = respuesta.GetString(14);
                        empresa.ruta5 = respuesta.GetString(15);
                        empresa.link = respuesta.GetString(16);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

            }
            return empresa;
        }

        //Modificar datos de empresa
        public void editarEmpresa(Empresa empresa)
        {
            //Modificar empresa
            String consulta = "UPDATE Empresa SET "+
                "slogan = '" + empresa.slogan + "," +
                "historia = '" + empresa.historia + "," +
                "mision = '" + empresa.mision + "," +
                "vision = '" + empresa.vision + "," +
                "' WHERE codigo = '" + empresa.codigo + "'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Modificar logo de la empresa
        public void editarLogo(String logo,int codigo)
        {
            String consulta = "UPDATE Empresa SET " +
                "logo = '" + logo +
                "' WHERE codigo = '" + codigo + "'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Modificar modulo1
        public void modificarImagenModulo(int modulo,String imagen,int codigo)
        {
            String consulta = "UPDATE Empresa SET " +
                "ruta" + modulo + " = '" + imagen +
                "' WHERE codigo = '" + codigo + "'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        public void modificarTituloModulo(int modulo, String nombre, int codigo)
        {
            String consulta = "UPDATE Empresa SET " +
                "modulo" + modulo + " = '" + nombre +
                "' WHERE codigo = '" + codigo + "'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Devolver imagenes de Slider
        public List<ImagenSlider> getSlider()
        {
            List<ImagenSlider> imagenes = new List<ImagenSlider>();

            String consulta = "SELECT * FROM Slider;";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    respuesta = comando.ExecuteReader();

                    while (respuesta.Read())
                    {
                        ImagenSlider img = new ImagenSlider();
                        img.codigo = respuesta.GetInt32(0);
                        img.ruta = respuesta.GetString(1);
                        imagenes.Add(img);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

            }
            return imagenes;
        }

        //Crear imagen de Slider
        public void insertarImagenSlider(String ruta)
        {
            String consulta = "INSERT INTO Slider VALUES ('" + ruta + "');";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Eliminar imagen de Slider
        public void eliminarSlider(int cod)
        {
            String consulta = "DELETE Slider WHERE codigo = '" + cod + "'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Devolver imagenes de Enlaces
        public List<Enlace> getEnlaces()
        {
            List<Enlace> enlaces = new List<Enlace>();

            String consulta = "SELECT * FROM Enlace;";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    respuesta = comando.ExecuteReader();

                    while (respuesta.Read())
                    {
                        Enlace enlace = new Enlace();
                        enlace.codigo = respuesta.GetInt32(0);
                        enlace.nombre = respuesta.GetString(1);
                        enlace.ruta = respuesta.GetString(2);
                        enlaces.Add(enlace);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

            }
            return enlaces;
        }

        //Crear enlace
        public void insertarEnlace(String nombre,String ruta)
        {
            String consulta = "INSERT INTO Enlace VALUES ('" + nombre + "','" + ruta + "');";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Eliminar enlace
        public void eliminarEnlace(int cod)
        {
            String consulta = "DELETE Enlace WHERE codigo = '" + cod + "'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Devolver valores
        public List<Valor> getValores()
        {
            List<Valor> valores = new List<Valor>();

            String consulta = "SELECT * FROM Valor;";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    respuesta = comando.ExecuteReader();

                    while (respuesta.Read())
                    {
                        Valor val = new Valor();
                        val.codigo = respuesta.GetInt32(0);
                        val.valor = respuesta.GetString(1);
                        valores.Add(val);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

            }
            return valores;
        }

        //Eliminar Valores
        public void eliminarValores()
        {
            String consulta = "DELETE FROM Valor;";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Insertar valores
        public void insertarValores(String valores)
        {
            eliminarValores();
            String[] vals = valores.Split(',');
            foreach (String v in vals)
            {
                String consulta = "INSERT INTO Valor VALUES('" + v + "');";
                if (abrir())
                {
                    try
                    {
                        comando = new SqlCommand(consulta, sqlConn);
                        comando.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sqlConn.Close();
                    }
                }
            }
        }

        //Devolver listado de vehiculos
        public List<Carro> verCarros()
        {
            List<Carro> carros = new List<Carro>();

            String consulta = "SELECT cod_carro,marca,modelo,anio,placa FROM Carro WHERE desplegar = '1'";
            if (abrir())
            {
                //Hacer la consulta a la base de datos
                try
                {
                    comando = new SqlCommand(consulta,sqlConn);
                    respuesta = comando.ExecuteReader();

                    while (respuesta.Read())
                    {
                        //Vehiculo para guardar
                        int codigo = respuesta.GetInt32(0);
                        String marca = respuesta.GetString(1);
                        //linea
                        String linea = respuesta.GetString(2);
                        int anio = respuesta.GetInt32(3);
                        String placa = respuesta.GetString(4);
                        Carro car = new Carro();
                        car.setCodigo(codigo);
                        car.setMarca(marca);
                        car.setLinea(linea);
                        car.setAnio(anio);
                        car.setPlaca(placa);

                        carros.Add(car);
                    }

                    foreach (Carro c in carros)
                    {
                        //BUSCAR IMAGEN PRINCIPAL
                        consulta = "SELECT TOP 1 ruta_imagen FROM Imagen WHERE cod_carro = '" + c.getCodigo() + "'";
                        comando = new SqlCommand(consulta,sqlConn);
                        respuesta.Close();
                        respuesta = comando.ExecuteReader();

                        while (respuesta.Read())
                        {
                            String ruta = respuesta.GetString(0);
                            c.setImagenPrincipal(ruta);
                            break;
                        }

                    }

                    sqlConn.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            return carros;
        }

        //Devolver lista de vehiculos recientes! Hasta 6!
        public List<Carro> verRecientes()
        {
            List<Carro> carros = new List<Carro>();

            String consulta = "SELECT TOP 6 cod_carro,marca,modelo,anio,placa FROM Carro WHERE desplegar = '1' ORDER BY cod_carro ASC;";
            if (abrir())
            {
                //Hacer la consulta a la base de datos
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    respuesta = comando.ExecuteReader();

                    while (respuesta.Read())
                    {
                        //Vehiculo para guardar
                        int codigo = respuesta.GetInt32(0);
                        String marca = respuesta.GetString(1);
                        //linea
                        String linea = respuesta.GetString(2);
                        int anio = respuesta.GetInt32(3);
                        String placa = respuesta.GetString(4);
                        Carro car = new Carro();
                        car.setCodigo(codigo);
                        car.setMarca(marca);
                        car.setLinea(linea);
                        car.setAnio(anio);
                        car.setPlaca(placa);

                        carros.Add(car);
                    }

                    foreach (Carro c in carros)
                    {
                        //BUSCAR IMAGEN PRINCIPAL
                        consulta = "SELECT TOP 1 ruta_imagen FROM Imagen WHERE cod_carro = '" + c.getCodigo() + "'";
                        comando = new SqlCommand(consulta, sqlConn);
                        respuesta.Close();
                        respuesta = comando.ExecuteReader();

                        while (respuesta.Read())
                        {
                            String ruta = respuesta.GetString(0);
                            c.setImagenPrincipal(ruta);
                            break;
                        }

                    }

                    sqlConn.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return carros;
        }

        //Devolver Carro
        public Carro getCarro(int codigo)
        {
            Carro carro = new Carro();

            if (abrir())
            {
                //HACER LA CONSULTA A LA BASE DE DATOS
                String consulta = "SELECT * FROM Carro WHERE cod_carro = '"+Convert.ToString(codigo)+"' AND desplegar = '1'";
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    respuesta = comando.ExecuteReader();

                    while (respuesta.Read())
                    {
                        /*Vehiculo para guardar
                         ***********************/
                        String placa = respuesta.GetString(1);
                        String desc = respuesta.GetString(2);
                        String marca = respuesta.GetString(3);
                        //linea
                        String linea = respuesta.GetString(4);
                        int anio = respuesta.GetInt32(5);
                        String tipo = respuesta.GetString(6);
                        String embarcado = respuesta.GetString(7);
                        String chocado = respuesta.GetString(8);
                        String bolsas = respuesta.GetString(9);
                        String cerradura = respuesta.GetString(10);
                        String vidrios = respuesta.GetString(11);
                        String aire = respuesta.GetString(12);
                        String timon = respuesta.GetString(13);
                        String tapiceria = respuesta.GetString(14);
                        String motor = respuesta.GetString(15);
                        int cilindros = respuesta.GetInt32(16);
                        String combustible = respuesta.GetString(17);
                        String km = respuesta.GetString(18);
                        double enganche = respuesta.GetDouble(19);
                        String cuota = respuesta.GetString(20);
                        double precio = respuesta.GetDouble(21);

                        carro.setPlaca(placa);
                        carro.setCodigo(codigo);
                        carro.setDescripcion(desc);
                        carro.setMarca(marca);
                        carro.setLinea(linea);
                        carro.setAnio(anio);
                        carro.setTipo(tipo);
                        carro.setEmbarcado(embarcado);
                        carro.setChocado(chocado);
                        carro.setBolsas(bolsas);
                        carro.setCerradura(cerradura);
                        carro.setVidrios(vidrios);
                        carro.setAire(aire);
                        carro.setTimon(timon);
                        carro.setTapiceria(tapiceria);
                        carro.setMotor(motor);
                        carro.setCilindros(cilindros);
                        carro.setCombustible(combustible);
                        carro.setKilometraje(km);
                        carro.setEnganche(enganche);
                        carro.setCuotas(cuota);
                        carro.setPrecio(precio);
                        
                    }

                    //LLENAR LISTA DE IMAGENES
                    consulta = "SELECT ruta_imagen, cod_imagen FROM Imagen WHERE cod_carro = '" + Convert.ToString(codigo) + "'";
                    try
                    {
                        comando = new SqlCommand(consulta,sqlConn);
                        respuesta.Close();
                        respuesta = comando.ExecuteReader();

                        while(respuesta.Read()){
                            //GUARDAR IMAGEN EN IMAGENES DEL CARRO
                            String ruta = respuesta.GetString(0);
                            int cod = respuesta.GetInt32(1);
                            Imagen img = new Imagen(ruta,cod);
                            carro.agregarImagen(img);
                        }

                        sqlConn.Close();

                    }
                    catch(SqlException ex2){
                        Console.WriteLine(ex2.Message);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return carro;
        }

        //Abrir conexion
        public bool abrir()
        {
            bool abierta;
            try
            {
                sqlConn.Open();
                abierta = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                abierta = false;
            }

            return abierta;
        }

        //Eliminar Imagen
        public void eliminarImagen(int cod_imagen)
        {
            //Modificar carro
            String consulta = "DELETE Imagen WHERE cod_imagen = '"+cod_imagen+"'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Modificar Imagen
        public void reemplazarImagen(int cod_imagen,String nombre)
        {
            //Modificar carro
            String consulta = "UPDATE Imagen SET ruta_imagen = '"+nombre+"' WHERE cod_imagen = '" + cod_imagen + "'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Insertar Carro
        public void insertarCarro(Carro carro)
        {
             //INSERTAR CARRO
            String consulta = "INSERT INTO Carro VALUES (" +
            "'"+carro.getPlaca()+"'," +
            "'"+carro.getDescripcion()+"'," +
            "'"+carro.getMarca()+"'," +
            "'"+carro.getLinea()+"'," +
            "'"+carro.getAnio()+"'," +
            "'"+carro.getTipo()+"'," +
            "'"+carro.getEmbarcado()+"'," +
            "'"+carro.getChocado()+"'," +
            "'"+carro.getBolsas()+"'," +
            "'"+carro.getCerradura()+"'," +
            "'"+carro.getVidrios()+"'," +
            "'"+carro.getAire()+"'," +
            "'"+carro.getTimon()+"'," +
            "'"+carro.getTapiceria()+"'," +
            "'"+carro.getMotor()+"'," +
            "'"+carro.getCilindros()+"'," +
            "'"+carro.getCombustible()+"'," +
            "'"+carro.getKilometraje()+"'," +
            "'"+carro.getEnganche()+"'," +
            "'"+carro.getCuotas()+"'," +
            "'"+carro.getPrecio()+"'," +
            "'1')";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Modificar Carro
        public void modificarCarro(Carro carro)
        {
            //Modificar carro
            String consulta = "UPDATE Carro SET " +
            "placa = '" + carro.getPlaca() + "'," +
            "descripcion = '" + carro.getDescripcion() + "'," +
            "marca = '" + carro.getMarca() + "'," +
            "modelo = '" + carro.getLinea() + "'," +
            "anio = '" + carro.getAnio() + "'," +
            "tipo = '" + carro.getTipo() + "'," +
            "embarcado = '" + carro.getEmbarcado() + "'," +
            "chocado = '" + carro.getChocado() + "'," +
            "bolsas = '" + carro.getBolsas() + "'," +
            "cerradura = '" + carro.getCerradura() + "'," +
            "vidrios = '" + carro.getVidrios() + "'," +
            "aire = '" + carro.getAire() + "'," +
            "timon = '" + carro.getTimon() + "'," +
            "tapiceria = '" + carro.getTapiceria() + "'," +
            "motor = '" + carro.getMotor() + "'," +
            "cilindros = '" + carro.getCilindros() + "'," +
            "combustible = '" + carro.getCombustible() + "'," +
            "kilometraje = '" + carro.getKilometraje() + "'," +
            "enganche = '" + carro.getEnganche() + "'," +
            "cuotas = '" + carro.getCuotas() + "'," +
            "precio = '" + carro.getPrecio() + "'" +
            " WHERE cod_carro = '"+ carro.getCodigo()+"';";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }
        public int getCodigoCarro(String placa)
        {
            int codigo = 0;

            String consulta = "SELECT cod_carro FROM Carro WHERE placa = '"+placa+"' AND desplegar = '1'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    respuesta = comando.ExecuteReader();

                    if (respuesta.Read())
                    {
                        codigo = respuesta.GetInt32(0);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

            }

            return codigo;
        }

        //Agregar imagen
        public void insertarImagen(int codigo,String nombre)
        {
            String consulta = "INSERT INTO Imagen VALUES ('"+nombre+"',' ','"+codigo+"');";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Eliminar carro
        public void eliminarCarro(int codigo)
        {
            String consulta = "UPDATE Carro SET desplegar = '0' WHERE cod_carro = '" + codigo + "'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta,sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Ingresar Banner
        public void insertarBanner(String ruta)
        {
            String consulta = "INSERT INTO Banner VALUES ('" + ruta + "');";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Eliminar Banner
        public void eliminarBanner(int cod)
        {
            String consulta = "DELETE Banner WHERE cod_banner = '" + cod + "'";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        //Get Banners
        public List<Banner> getBanners()
        {
            List<Banner> banners = new List<Banner>();

            String consulta = "SELECT * FROM Banner;";
            if (abrir())
            {
                try
                {
                    comando = new SqlCommand(consulta, sqlConn);
                    respuesta = comando.ExecuteReader();

                    while (respuesta.Read())
                    {
                        banners.Add(new Banner(respuesta.GetInt32(0),respuesta.GetString(1)));
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

            }
            return banners;
        } 
    }
}