using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SW_CIDEAUTOS
{
    public partial class Agregar : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            Sesion session = (Sesion)Session["Sesion"];
            if (!session.iniciado)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gestion.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Guardar y pasar a imagenes
            Carro carro = new Carro();

            lblMensaje.Text = "";
            lblMensaje.Visible = false;

            if(txtCilindros.Text == "" || txtColor.Text == "" || txtCombustible.Text == "" || txtCuotas.Text == "" ||
                txtKM.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtMotor.Text == "" || txtPlaca.Text == "" ||
                txtTapiceria.Text == "" || txtTipo.Text == "")
            {
                //Faltan campos por llenar!
                lblMensaje.Text = "Faltan campos por llenar...";
                lblMensaje.Visible = true;
            }
            else
            {
                int vehiculo = con.getCodigoCarro(txtPlaca.Text);
                if (vehiculo == 0)
                {
                    //Guardar vehiculo
                    //GENERALES
                    carro.setPlaca(txtPlaca.Text);
                    carro.setMarca(txtMarca.Text);
                    carro.setLinea(txtLinea.Text);
                    carro.setAnio(Convert.ToInt32(txtModelo.Text));
                    carro.setTipo(txtTipo.Text);

                    //ESPECIFICOS
                    if (aire.Checked)
                    {
                        carro.setAire("si");
                    }
                    else
                    {
                        carro.setAire("no");
                    }
                    if (embarcado.Checked)
                    {
                        carro.setEmbarcado("si");
                    }
                    else
                    {
                        carro.setEmbarcado("no");
                    }
                    if (chocado.Checked)
                    {
                        carro.setChocado("si");
                    }
                    else
                    {
                        carro.setChocado("no");
                    }
                    if (bolsas.Checked)
                    {
                        carro.setBolsas("si");
                    }
                    else
                    {
                        carro.setBolsas("no");
                    }
                    if (cerradura.Checked)
                    {
                        carro.setCerradura("si");
                    }
                    else
                    {
                        carro.setCerradura("no");
                    }

                    //FISICOS
                    carro.setVidrios(txtColor.Text); //color
                    carro.setTimon(txtTransmision.Text); //transmision
                    carro.setTapiceria(txtTapiceria.Text);

                    //MOTOR
                    carro.setMotor(txtMotor.Text);
                    carro.setCilindros(Convert.ToInt32(txtCilindros.Text));
                    carro.setCombustible(txtCombustible.Text);
                    carro.setKilometraje(txtKM.Text);

                    //FINANCIAMIENTO
                    carro.setCuotas(txtCuotas.Text);
                    carro.setEnganche(Convert.ToDouble(txtEnganche.Text));
                    carro.setPrecio(Convert.ToDouble(txtPrecio.Text));

                    //OTROS
                    carro.setDescripcion(txtOtros.Text);

                    con.insertarCarro(carro);
                    int codigo = con.getCodigoCarro(carro.getPlaca());
                    if (codigo > 0)
                    {
                        //GUARDAR CARRO e ir a PASO 2
                        Response.Redirect("Imagenes.aspx?codigo=" + Convert.ToString(codigo));
                    }
                    else
                    {
                        lblMensaje.Text = "ERROR: Ocurrio un error al insertar el carro...";
                        lblMensaje.Visible = true;
                    }
                    
                }
                else
                {
                    lblMensaje.Text = "ERROR: La placa ingresada ya existe!";
                    lblMensaje.Visible = true;
                }
            }

        }
    }
}