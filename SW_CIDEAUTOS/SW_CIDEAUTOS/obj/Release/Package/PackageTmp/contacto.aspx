<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="SW_CIDEAUTOS.contacto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> CIDEAUTOS :: Contacto </title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link href='http://fonts.googleapis.com/css?family=PT+Sans+Narrow' rel='stylesheet' type='text/css'/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap-content">
	        <!-- Encabezado de la pagina web -->
	        <header>

	            <!-- Navegador de pestañas -->
	            <div class="navegabilidad">
	                <!-- Logo de CIDEAUTOS -->
	                
	                <nav class="navbar navbar-fixed-top bg-inverse">
	                    <button class="navbar-toggle" type="button" data-toggle="collapse" data-target="#navbars" aria-controls="navbars" aria-expanded="false" aria-label="Toggle navigation">
	                        <span class="navbar-toggler-icon"></span>
	                    </button>
	                    <div class="img-logo">
	                        <a href="index.aspx"><img src="imagenes/empresa/<%= empresa.logo %>"></a>
	                    </div>
	                    <div class="collapse navbar-collapse" id="navbars">
	                        <ul class="navbar-nav mr-auto">

	                            <li class="activo"><a href="index.aspx">Inicio</a></li>
	                            <li><a href="vehiculos.aspx">Vehiculos</a></li>
	                            <li><a href="financiamiento.aspx">Financiamiento</a></li>
	                            <li><a href="contacto.aspx">Contacto</a></li>
	                            <li><a href="Informacion.aspx">Acerca de</a></li>
	                        </ul>
	                    </div>
	                    
	                </nav>
	            </div>
	        </header>

	        <div class="contacto">
	        	<h1>Contactanos</h1>
	        	<!-- Area de Mapa -->
		        <div class="columna">
		        	<!-- Mapa -->
			    	<div class="map">
				    	<iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d1930.1852118305208!2d-90.5985097!3d14.6349022!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x0!2zMTTCsDM4JzA1LjUiTiA5MMKwMzUnNTMuNyJX!5e0!3m2!1ses-419!2sgt!4v1470708036525" height="450" frameborder="0" style="border-style: none; border-color: inherit; border-width: 0; width: 622px;" allowfullscreen></iframe>
				    </div>
				    <div class="info">
		        		<h2>Correo</h2></br>
	                    <h3>cideautos@gmail.com</h3></br>
					    <h2>Direccion</h2></br>
	                    <h3>C​alzada Roosevelt Km.15.5 0-32 zona 2
	                   Mixco, Guatemala</h3></br>
					    <h2>Telefonos:</h2></br>
	                    <h3>2435-5181, 4421-1312, 3460-3101, 5218-5457</h3>
		        	</div>
			    </div>
		        <!-- Formulario de contacto -->
		        <div class="columna">
		        		<h3>Nombre</h3>
		        		<asp:TextBox ID="txtNombre" runat="server" style="margin-left: 23px" Width="415px"></asp:TextBox>
		        		<h3>Correo</h3>
		        		<asp:TextBox ID="txtCorreo" runat="server" style="margin-left: 22px" Width="415px"></asp:TextBox>
		        		<h3>Cuerpo</h3>
		        		<asp:TextBox ID="txtCuerpo" runat="server" Height="202px" style="margin-left: 21px" TextMode="MultiLine" Width="421px"></asp:TextBox>
		        		<asp:Button ID="Button1" runat="server" CssClass="btn btn-primary btn-left" ForeColor="Black" OnClick="Button1_Click" Text="ENVIAR" Width="274px" />
		        	
		        	<div class="enlaces">
		        		<div class="image-fb">
	        				<a href="https://www.facebook.com/predio.cideautos/"><img src="imagenes/empresa/fb.png" width="50%" height="50%"></a>
	        			</div>
	        			<a href="https://www.facebook.com/predio.cideautos/"><h3>Siguenos en facebook!</h3></a>
		        	</div>
		        </div>

	        </div>

        </div>
        <!-- Google Analytics -->
        <script>
            (function (i, s, o, g, r, a, m) {
                i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                    (i[r].q = i[r].q || []).push(arguments)
                }, i[r].l = 1 * new Date(); a = s.createElement(o),
                m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
            })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

            ga('create', 'UA-94106742-1', 'auto');
            ga('send', 'pageview');

        </script>
        <script src="js/jquery-1.11.2.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js" integrity="sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb" crossorigin="anonymous"></script>
        <script src="js/bootstrap.min.js"></script>

    </form>
    
</body>
</html>
