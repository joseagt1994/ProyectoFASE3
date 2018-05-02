using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Timers;

namespace SW_CIDEAUTOS
{
    public partial class Edicion : System.Web.UI.Page
    {
        Conexion con;
        String placa = "";
        int codigo;
        int segundo = 1;
        System.Timers.Timer timer = new System.Timers.Timer();

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Conexion();
            Sesion session = (Sesion)Session["Sesion"];
            if (!session.iniciado)
            {
                Response.Redirect("Login.aspx");
            }
            int cod = Convert.ToInt32(Request.QueryString["codigo"]);
            Carro actual = con.getCarro(cod);

            placa = actual.getPlaca();
            codigo = cod;
            // Texto
            if (!IsPostBack)
            {
                timer.Interval = 1000;
                timer.Start();
                txtPlaca.Text = actual.getPlaca();
                txtCilindros.Text = actual.getCilindros().ToString();
                txtColor.Text = actual.getVidrios();
                txtCombustible.Text = actual.getCombustible();
                txtCuotas.Text = actual.getCuotas();
                txtEnganche.Text = actual.getEnganche().ToString();
                txtKM.Text = actual.getKilometraje().Replace(",", "");
                txtLinea.Text = actual.getLinea();
                txtMarca.Text = actual.getMarca();
                txtModelo.Text = actual.getAnio().ToString();
                txtMotor.Text = actual.getMotor();
                txtOtros.Text = actual.getDescripcion();
                txtPlaca.Text = actual.getPlaca();
                txtPrecio.Text = actual.getPrecio().ToString();
                txtTapiceria.Text = actual.getTapiceria();
                txtTipo.Text = actual.getTipo();
                txtTransmision.Text = actual.getTimon();

                //Checkbox
                if (actual.getEmbarcado().ToLower().Equals("si"))
                {
                    embarcado.Checked = true;
                }
                if (actual.getChocado().ToLower().Equals("si"))
                {
                    chocado.Checked = true;
                }
                if (actual.getBolsas().ToLower().Equals("si"))
                {
                    bolsas.Checked = true;
                }
                if (actual.getAire().ToLower().Equals("si"))
                {
                    aire.Checked = true;
                }
                if (actual.getCerradura().ToLower().Equals("si"))
                {
                    cerradura.Checked = true;
                }
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            segundo = segundo + 1;
            if (segundo >= 10)
            {
                timer.Stop();
                Sesion session = Sesion.getInstance();
                session.iniciado = false;
                session.nombre = session.pass = "";
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new Conexion();
            int vehiculo = con.getCodigoCarro(txtPlaca.Text);
            if (vehiculo == 0 || txtPlaca.Text.Equals(placa))
            {
                //Guardar vehiculo
                Carro carro = new Carro();
                carro.setCodigo(codigo);
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

                //MODIFICAR DATOS DEL CARRO
                con = new Conexion();
                con.modificarCarro(carro);
                Response.Redirect("Eliminar.aspx");
            }
            else
            {
                lblMensaje.Text = "ERROR: La placa ingresada ya existe!";
                lblMensaje.Visible = true;
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Eliminar.aspx");
        }
    }
}