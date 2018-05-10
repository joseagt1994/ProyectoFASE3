<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SW_CIDEAUTOS.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
	<title> CIDEAUTOS :: Inicio </title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link href='http://fonts.googleapis.com/css?family=PT+Sans+Narrow' rel='stylesheet' type='text/css'/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<link rel="stylesheet" href="css/nivo-slider.css" />
	<link rel="stylesheet" href="css/mi-slider.css" />

	<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js" type="text/javascript"></script>
	<script src="js/jquery.nivo.slider.js"></script>

	<script type="text/javascript">
	    $(window).on('load', function () {
	        $('#slider').nivoSlider();
	    });
	</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
                    <a href="index.aspx"><img class="logo" src="imagenes/empresa/<%= empresa.logo%>" /></a>
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

    <div class="banner">
		<div class="slider-wrapper theme-mi-slider">
			<div id="slider" class="nivoSlider">     
                <% for (int i = 0; i < banners.Count; i++) { %>
                    <img src="imagenes/banner/<%= banners[i].ruta %>" alt="" title="#htmlcaption<%= i+1 %>" />
                <% } %>
			</div> 
		</div>
	</div>

	<br /><br />

	<%--<div class="list">
		<div class="columna-5">
            <!-- IMAGEN -->
            <div>
            	<img src="imagenes/empresa/<%= empresa.ruta1 %>" />
            </div>
            <!-- TITUTLO -->
            <div>
            	<h3 align="center" style="color: #ffffff"><%= empresa.modulo1 %></h3>
            </div>
            <!-- Opciones -->
            <div>
                <ul>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                </ul>
            </div>
        </div>
        <div class="columna-5">
            <!-- IMAGEN -->
            <div>
            	<img src="imagenes/empresa/<%= empresa.ruta2 %>" />
            </div>
            <!-- TITUTLO -->
            <div>
            	<h3 align="center" style="color: #ffffff"><%= empresa.modulo2 %></h3>
            </div>
            <!-- Opciones -->
            <div>
                <ul>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                </ul>
            </div>
        </div>
        <div class="columna-5">
            <!-- IMAGEN -->
            <div>
            	<img src="imagenes/empresa/<%= empresa.ruta3 %>" />
            </div>
            <!-- TITUTLO -->
            <div>
            	<h3 align="center" style="color: #ffffff"><%= empresa.modulo3 %></h3>
            </div>
            <!-- Opciones -->
            <div>
                <ul>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                </ul>
            </div>
        </div>
        <div class="columna-5">
            <!-- IMAGEN -->
            <div>
            	<img src="imagenes/empresa/<%= empresa.ruta4 %>" />
            </div>
            <!-- TITUTLO -->
            <div>
            	<h3 align="center" style="color: #ffffff"><%= empresa.modulo4 %></h3>
            </div>
            <!-- Opciones -->
            <div>
                <ul>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                </ul>
            </div>
        </div>
        <div class="columna-5">
            <!-- IMAGEN -->
            <div>
            	<img src="imagenes/empresa/<%= empresa.ruta5 %>" />
            </div>
            <!-- TITUTLO -->
            <div>
            	<h3 align="center" style="color: #ffffff"><% = empresa.modulo5 %></h3>
            </div>
            <!-- Opciones -->
            <div>
                <ul>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                    <li><a><h5 align="center" style="color: #ffffff">...</h5></a></li>
                </ul>
            </div>
        </div>
	</div>--%>


	<%--<div class="list-multimedia">
		<!-- VIDEOS -->
		<br />
		<div class="columna-2">
			<h3 align="center"></h3>
			<iframe width="600" height="350" src="" frameborder="0" allowfullscreen></iframe>
		</div>
		<!-- Imagenes -->
		<div class="columna-2">
			<h3 align="center"></h3>
			<div id="banner">
	            <!-- Listado de Imagenes -->
                <% for (int i = 0; i < imagenes.Count; i++) { %>
                    <div><img src="imagenes/slider/<%= imagenes.ElementAt(i).ruta%>"></div>
                <% } %>
	        </div>
		</div>
	</div>--%>

    <div class="slogan">
	    <br/>
	    <h1 class="animation-jelly">"Importados garantizados..."</h1>
    </div>
    <div class="list-carros">
	    <div class="columna-3">
		    <h2 class="animation-show">Hola</h2>
		
		    <img src="audi.jpg" class="animation-jelly" />
		    <div class="precio animation-show"><h1>Q.140,000.00</h1></div>
		    <button class="animation-show">Mas Informacion</button>
	    </div>
	    <div class="columna-3">
		    <h2 class="animation-show">Hola</h2>
		
		    <img src="audi.jpg" class="animation-jelly" />
		    <div class="precio animation-show"><h1>Q.140,000.00</h1></div>
		    <button class="animation-show">Mas Informacion</button>
	    </div>
	    <div class="columna-3">
		    <h2 class="animation-show">Hola</h2>
		
		    <img src="audi.jpg" class="animation-jelly" />
		    <div class="precio animation-show"><h1>Q.140,000.00</h1></div>
		    <button class="animation-show">Mas Informacion</button>
	    </div>
	    <br/>
	    <br/>
	    <div class="columna-3">
		    <h2 class="animation-show">Hola</h2>
		
		    <img src="audi.jpg" class="animation-jelly" />
		    <div class="precio animation-show"><h1>Q.140,000.00</h1></div>
		    <button class="animation-show">Mas Informacion</button>
	    </div>
	    <div class="columna-3">
		    <h2 class="animation-show">Hola</h2>
		
		    <img src="audi.jpg" class="animation-jelly" />
		    <div class="precio animation-show"><h1>Q.140,000.00</h1></div>
		    <button class="animation-show">Mas Informacion</button>
	    </div>
	    <div class="columna-3">
		    <h2 class="animation-show">Hola</h2>
		
		    <img src="audi.jpg" class="animation-jelly" />
		    <div class="precio animation-show"><h1>Q.140,000.00</h1></div>
		    <button class="animation-show">Mas Informacion</button>
	    </div>
	    <a href="#" style="color: #fff; font-size: 30pt;" class="animation-show">Ver mas vehiculos</a>
    </div>
    <div class="form-contacto">
	    <div class="col-form-1">
		    <h1 style="color: #fff;">Comunicate con un Asesor</h1>
		    <h4 style="color: #fff;">Campos marcados con <span>*</span> son requeridos</h4>
		    <div class="campo-form">
			    <h3>Nombre<span> *</span></h3>
			    <input type="text" name="txtNombre" />
		    </div>
		    <div class="campo-form">
			    <h3>Apellido<span> *</span></h3>
			    <input type="text" name="txtApe" />
		    </div>
		    <div class="campo-form">
			    <h3>Email<span> *</span></h3>
			    <input type="text" name="txtEmail" />
		    </div>
		    <div class="campo-form">
			    <h3>Telefono<span> *</span></h3>
			    <input type="text" name="txtTel" />
		    </div>
		    <div style="margin-top: 200px;">
			    <h3 style="color: #fff;">En que podemos servirte?<span> *</span></h3>
			    <textarea style="width:95%; height:85px;"></textarea>
			    <br/>
			    <br/>
			    <button>Enviar</button>
		    </div>
	    </div>
	    <div class="col-form-2">
		    <h1 style="color: #fff;">Encuentranos en...</h1>
		    <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d1930.1852118305208!2d-90.5985097!3d14.6349022!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x0!2zMTTCsDM4JzA1LjUiTiA5MMKwMzUnNTMuNyJX!5e0!3m2!1ses-419!2sgt!4v1470708036525" height="450" frameborder="0" class="mapa" allowfullscreen></iframe>

	    </div>
    </div>

	<div class="list-footer">
		<div class="footer">
			<table>
                <tr>
				    <td>
					    <h3 >Buscanos en</h3>
					    <ul class="nav navbar-nav">
                            <% for (int i = 0; i < enlaces.Count; i++) { %>
                                <li><a href="<%= enlaces[i].codigo %>"><img align="center" src="imagenes/empresa/<%= enlaces[i].ruta %>"></a></li>
                            <% } %>
					    </ul>
				    </td>
				    <td align="right">
					    <br />
					    <a href="Login.aspx"><img style="width: 10%" src="imagenes/empresa/<%= empresa.logo %>"></a>
				    </td>
                </tr>
			</table>
		</div>
	</div>

	<div class="lil-footer">
		<h4 style="color: #ffffff">Copyright@ 2017-2018. All rights reserved.</h4>
	</div>

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
	<!-- Script del javascript del slider -->
    <script type="text/javascript">
        $(function () {
            $('#banner div:gt(0)').hide();
            setInterval(function () {
                $('#banner div:first-child').fadeOut(0).next('div').fadeIn(0).end().appendTo('#banner');
            }, 15000);
        })
    </script>
    </div>
    </form>
</body>
</html>
