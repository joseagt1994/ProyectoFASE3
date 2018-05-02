<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eDatos.aspx.cs" Inherits="SW_CIDEAUTOS.eDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> CIDEAUTOS :: Agregar PASO 2 </title>
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
				    <img src="imagenes/empresa/<%= empresa.logo %>"/>
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

        <br /><br /><br /><br /><br /><br /><br />
    </div>
    <h1>Editar Logo de CIDEAUTOS</h1>
    <img src="imagenes/empresa/<%= empresa.logo %>"/>
    <h2>Seleccione imagen... Requiere 200*77 pixeles</h2>
        <p>&nbsp;</p>
        <p class="txt-center">
            <asp:FileUpload ID="cargaImagen" runat="server" Width="299px" />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Modificar Logo" />
        </p>
        <p>&nbsp;</p>
    <p>&nbsp;</p>
    <h1>Editar Informacion de CIDEAUTOS</h1>
    <br />
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Slogan: "></asp:Label></td>
            <td><asp:TextBox ID="txtSlogan" runat="server" Width="630px"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Historia: "></asp:Label></td>
            <td><asp:TextBox ID="txtHistoria" runat="server" Width="630px" Height="85px" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Mision: "></asp:Label></td>
            <td><asp:TextBox ID="txtMision" runat="server" Width="630px" Height="79px" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label4" runat="server" Text="Vision: "></asp:Label></td>
            <td><asp:TextBox ID="txtVision" runat="server" Width="630px" Height="86px" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Valores: "></asp:Label></td>
            <td><asp:TextBox ID="txtValores" runat="server" Width="630px" Height="42px" TextMode="MultiLine"></asp:TextBox><h2>Colocar entre comillas...</h2></td>
        </tr>
    </table>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modificar Datos" />
        
    <p>&nbsp;</p>
    <h1>Editar Modulos de Inicio</h1>
    <h2>Modulo 1</h2><br />
    <img src="imagenes/empresa/<%= empresa.ruta1 %>"/>
    <h2>Seleccione imagen... Con que sea de ancho 225 pixeles</h2>
    <asp:FileUpload ID="Carga1" runat="server" Width="299px" />&nbsp;
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Modificar Imagen" /><br />
    <asp:TextBox ID="txtTitulo1" runat="server" Width="315px"></asp:TextBox>
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Modificar Titulo" />
    <p>&nbsp;</p>
    <h2>Modulo 2</h2><br />
    <img src="imagenes/empresa/<%= empresa.ruta2 %>"/>
    <h2>Seleccione imagen...  Con que sea de ancho 225 pixeles</h2>
    <asp:FileUpload ID="Carga2" runat="server" Width="299px" />&nbsp;
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Modificar Imagen" /><br />
    <asp:TextBox ID="txtTitulo2" runat="server" Width="317px"></asp:TextBox>
    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Modificar Titulo" />
    <p>&nbsp;</p>
    <h2>Modulo 3</h2><br />
    <img src="imagenes/empresa/<%= empresa.ruta3 %>"/>
    <h2>Seleccione imagen...  Con que sea de ancho 225 pixeles</h2>
    <asp:FileUpload ID="Carga3" runat="server" Width="299px" />&nbsp;
    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Modificar Imagen" /><br />
    <asp:TextBox ID="txtTitulo3" runat="server" Width="315px"></asp:TextBox>
    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Modificar Titulo" />
    <p>&nbsp;</p>
    <h2>Modulo 4</h2><br />
    <img src="imagenes/empresa/<%= empresa.ruta4 %>"/>
    <h2>Seleccione imagen...  Con que sea de ancho 225 pixeles</h2>
    <asp:FileUpload ID="Carga4" runat="server" Width="299px" />&nbsp;
    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Modificar Imagen" /><br />
    <asp:TextBox ID="txtTitulo4" runat="server" Width="316px"></asp:TextBox>
    <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Modificar Titulo" />
    <p>&nbsp;</p>
    <h2>Modulo 5</h2><br />
    <img src="imagenes/empresa/<%= empresa.ruta5 %>"/>
    <h2>Seleccione imagen...  Con que sea de ancho 225 pixeles</h2>
    <asp:FileUpload ID="Carga5" runat="server" Width="299px" />&nbsp;
    <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Modificar Imagen" /><br />
    <asp:TextBox ID="txtTitulo5" runat="server" Width="315px"></asp:TextBox>
    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Modificar Titulo" />
    <p>&nbsp;</p>
    </form>
</body>
</html>
