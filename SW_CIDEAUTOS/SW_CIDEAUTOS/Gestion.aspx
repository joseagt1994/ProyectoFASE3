<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gestion.aspx.cs" Inherits="SW_CIDEAUTOS.Gestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> CIDEAUTOS :: Gestion </title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
	<link href="css/style.css" rel="stylesheet" type="text/css"  media="all" />	
	<link href='http://fonts.googleapis.com/css?family=PT+Sans+Narrow' rel='stylesheet' type='text/css'/>
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
        <br />
    </div>
    <h1>Gestion de Sitio Web</h1>
        <p>&nbsp;</p>
        <table style="width:100%">
            <tr>
                <td style="text-align: center"><asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" Text="Agregar carro" Width="265px" /></td>
            </tr>
            <tr>
                <td style="text-align: center"><asp:Button ID="Button2" runat="server" Font-Size="Large" OnClick="Button2_Click" Text="Gestionar carros" Width="265px" /></td>
            </tr>
            <tr>
                <td style="text-align: center"><asp:Button ID="Button4" runat="server" Font-Size="Large" OnClick="Button4_Click" Text="Gestionar banner" Width="265px" /></td>
            </tr>
            <tr>
                <td style="text-align: center"><asp:Button ID="Button5" runat="server" Font-Size="Large" OnClick="Button5_Click" Text="Gestionar modulos" Width="265px" /></td>
            </tr>
            <tr>
                <td style="text-align: center"><asp:Button ID="Button6" runat="server" Font-Size="Large" OnClick="Button6_Click" Text="Gestionar multimedia" Width="265px" /></td>
            </tr>
            <tr>
                <td style="text-align: center"><asp:Button ID="Button7" runat="server" Font-Size="Large" OnClick="Button7_Click" Text="Gestionar enlaces" Width="265px" /></td>
            </tr>
            <tr>
                <td style="text-align: center"><asp:Button ID="Button3" runat="server" Font-Size="Large" OnClick="Button3_Click" Text="Cerrar sesion" Width="265px" /></td>
            </tr>
        </table>
        <p>&nbsp;</p>
    </form>
    </body>
</html>
