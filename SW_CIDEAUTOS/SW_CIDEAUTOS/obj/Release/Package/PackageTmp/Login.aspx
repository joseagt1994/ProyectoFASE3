<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SW_CIDEAUTOS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> CIDEAUTOS :: Login </title>
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
				<a href="index.aspx"><img src="imagenes/empresa/logo_ci.png"/></a>
			</div>
	    </div>
	</header>

    <br><br><br><br><br><br><br>
        <br />
        <br>

    </div>
        <h1>Iniciar sesion</h1>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Usuario    "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsuario" runat="server" Width="270px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Contraseña   "></asp:Label>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="270px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblMensaje" runat="server" Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" Width="209px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
