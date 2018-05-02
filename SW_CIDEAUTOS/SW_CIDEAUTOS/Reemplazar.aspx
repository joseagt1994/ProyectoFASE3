<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reemplazar.aspx.cs" Inherits="SW_CIDEAUTOS.Reemplazar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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

        <br /><br /><br /><br /><br /><br /><br />
    </div>
    <h1>Reemplazar Imagen</h1>
    <h2>Seleccione imagen...  Requiere 213*160</h2>
        <p>&nbsp;</p>
        <p>
            <asp:FileUpload ID="cargaImagen" runat="server" />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reemplazar imagen" />
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
    </form>
    </body>
</html>
