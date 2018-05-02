<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informacion.aspx.cs" Inherits="SW_CIDEAUTOS.Informacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> CIDEAUTOS :: Informacion </title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link href='http://fonts.googleapis.com/css?family=PT+Sans+Narrow' rel='stylesheet' type='text/css' />
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
                        <a href="index.aspx"><img src="imagenes/empresa/<%= empresa.logo %>" /></a>
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

        <div class="titulo-acerca">

        </div>

        <!-- Historia de CIDEAUTOS -->
        <div class="historia">
            <h2>Historia</h2><br />
            <p>
                <%= empresa.historia %>
            </p><br />
        </div>

        <!-- Mision, Vision y Valores de CIDEAUTOS -->
        <div class="parrafo">
            <h2>Mision</h2><br />
            <p>
                <%= empresa.mision %>
            </p>
        </div>
        <div class="parrafo">
            <h2>Vision</h2><br />
            <p>
                <%= empresa.vision %>
            </p>
        </div>
        <div class="parrafo">
            <h2>Valores</h2><br>
            <p>
                <% for (int i = 0; i < valores.Count; i++) { %>
                    - <%= valores.ElementAt(i).valor %> <br />
                <% } %>
            </p>
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
