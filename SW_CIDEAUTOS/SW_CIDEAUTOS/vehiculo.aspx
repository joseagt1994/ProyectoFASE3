<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vehiculo.aspx.cs" Inherits="SW_CIDEAUTOS.vehiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> CIDEAUTOS :: Vehiculos </title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link href='http://fonts.googleapis.com/css?family=PT+Sans+Narrow' rel='stylesheet' type='text/css'/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    
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

        <%--<%= codigoHTML %>--%>
        <div class="titulo">
            <h1 class="color1"><%= actual.getMarca()+" "+actual.getLinea()+" "+actual.getAnio() %></h1>
        </div>
        <div class="info-vehiculo">
            <!-- Slider de Imagenes -->
            <div class="columna">
                <div id="gallery">
                    <%foreach(SW_CIDEAUTOS.Imagen img in actual.getImagenes()){%>
                        <img src="imagenes/vehiculos"<%= img.ruta %>"/>
                    <%}%>
                    <script>
                        (function () {
                        Galleria.loadTheme('https://cdnjs.cloudflare.com/ajax/libs/galleria/1.4.5/themes/classic/galleria.classic.min.js');
                        Galleria.run('.galleria');
                        }());
                    </script>
                </div>
            </div>
            <!-- Informacion del vehiculo -->
            <div class="columna">
                <div class="lista-items">
                    <ul style="padding: 0;">
                        <li>One</li>
                        <li>Two</li>
                        <li>Three</li>
                    </ul>
                </div>
                <div class="lista-items">

                </div>
            </div>
        </div>

        <script src="js/jquery-1.11.2.min.js"></script>
        <script>window.jQuery || document.write("<script src='jquery.min.js'>\x3C/script>")</script>
        <script src="myscripts.js" type="text/javascript"></script>

        <script src="galleria/galleria-1.4.7.min.js"></script>

        <script src="galleria/themes/classic/galleria.classic.min.js" ></script>
        
        <script src="https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js" integrity="sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb" crossorigin="anonymous"></script>
        <script src="js/bootstrap.min.js"></script>
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
        <script>
            $(document).ready(function () {
                $('#gallery').galleria({
                    transition: 'fadeslide',
                    width: 600,
                    height: 400
                });
            });
        </script>
    </div>
</body>
</html>
