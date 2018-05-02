<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="SW_CIDEAUTOS.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> CIDEAUTOS :: Agregar PASO 1 </title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
	<link href="css/style.css" rel="stylesheet" type="text/css"  media="all" />	
	<link href='http://fonts.googleapis.com/css?family=PT+Sans+Narrow' rel='stylesheet' type='text/css'/>
    <style type="text/css">
        .auto-style3 {
            color: #00FFFF;
        }
        .auto-style4 {
            color: #FFFF00;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header>
			
		    <!-- Navegador de pestañas -->
		    <div class="navegabilidad">
			    <!-- Logo de CIDEAUTOS -->
			    <div class="img-logo">
				    <img src="imagenes/empresa/logo.png"/>
			    </div>
                <div>
                    <br />
                    <label>Bienvenido!</label>
                    <br />
                    <a href="Gestion.aspx">Regresar al Menu</a>
                    <br />
                </div>
	        </div>
	    </header>

        <br><br><br><br>

        <h1>Agregar carro nuevo</h1>
        <h2>Llenar formulario</h2>
        <p class="auto-style3">Generales</p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Placa     "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtPlaca" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Marca   "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Linea      "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtLinea" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Modelo"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtModelo" runat="server" TextMode="Number"></asp:TextBox>
            </p>
            <p>&nbsp;<asp:Label ID="Label5" runat="server" Text="Tipo"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p class="auto-style3">Especificos</p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp; <asp:CheckBox ID="embarcado" runat="server" Text="Embarcado" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chocado" runat="server" Text="Chocado" />
    &nbsp;
                </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="bolsas" runat="server" Text="Bolsas de aire" />
    &nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="aire" runat="server" Text="Aire acondicionado" />
            &nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cerradura" runat="server" Text="Cerradura central" />
    &nbsp;</p>
            <p>&nbsp;</p>
            <p class="auto-style3">Atributos físico</p>
            <p>
                <asp:Label ID="Label6" runat="server" Text="Color"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label7" runat="server" Text="Transmisión"></asp:Label>
    &nbsp;&nbsp;
                <asp:TextBox ID="txtTransmision" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label8" runat="server" Text="Tapiceria"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtTapiceria" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p class="auto-style3">Atributos motor</p>
            <p>
                <asp:Label ID="Label9" runat="server" Text="Motor"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtMotor" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label10" runat="server" Text="Cilindros"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCilindros" runat="server" TextMode="Number"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label11" runat="server" Text="Combustible"></asp:Label>
    &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCombustible" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label12" runat="server" Text="Km/Millas"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtKM" runat="server" TextMode="Number"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p class="auto-style3">Financiamiento</p>
            <p>
                <asp:Label ID="Label13" runat="server" Text="Cuotas desde...  ... Q."></asp:Label>
    &nbsp;<asp:TextBox ID="txtCuotas" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label14" runat="server" Text="Enganche desde... Q."></asp:Label>
    &nbsp;<asp:TextBox ID="txtEnganche" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label15" runat="server" Text="Precio de contado...Q."></asp:Label>
    &nbsp;
                <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p class="auto-style3">Otros</p>
            <p class="auto-style4">Separar por comas</p>
            <p>
                <asp:TextBox ID="txtOtros" runat="server" Width="517px"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Label ID="lblMensaje" runat="server" Font-Size="X-Large" ForeColor="Red" Visible="False"></asp:Label>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar y continuar" Width="188px" />
            </p>
            <p>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancelar" Width="188px" />
            </p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
        </div>
    </form>
    
</body>
</html>
