<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Financiamiento.aspx.cs" Inherits="SW_CIDEAUTOS.Financiamiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> CIDEAUTOS :: Financiamiento </title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link href='http://fonts.googleapis.com/css?family=PT+Sans+Narrow' rel='stylesheet' type='text/css'/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
	    <div class="area-credito">
            
		    <h1>Quieres aplicar al credito?</h1>
		    <h3>Llena el siguiente formulario para calificar al credito..</h3>
		    <br><br>
		
	    </div>

	
        <asp:Panel ID="Panel1" runat="server">
            <div class="columna">
                <table>
                    <tr>
                        <td><asp:Label ID="Label13" runat="server" CssClass="label" ForeColor="#183e62" Text="Nombre Completo"></asp:Label></td>
                        <td><asp:TextBox ID="txtNombre" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label1" runat="server" CssClass="label" ForeColor="#183e62" Text="Fecha de ingreso laboral"></asp:Label></td>
                        <td><asp:TextBox ID="txtFechaLaboral" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label3" runat="server" CssClass="label" ForeColor="#183e62" Text="DPI"></asp:Label></td>
                        <td><asp:TextBox ID="txtDPI" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label4" runat="server" CssClass="label" ForeColor="#183e62" Text="Puesto"></asp:Label></td>
                        <td><asp:TextBox ID="txtPuesto" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label5" runat="server" CssClass="label" ForeColor="#183e62" Text="Fecha de Nacimiento"></asp:Label></td>
                        <td><asp:TextBox ID="txtNacimiento" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label6" runat="server" CssClass="label" ForeColor="#183e62" Text="Salario"></asp:Label></td>
                        <td><asp:TextBox ID="txtSalario" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                </table>
            </div>

            <div class="columna">
                <table>
                    <tr>
                        <td><asp:Label ID="Label7" runat="server" CssClass="label" ForeColor="#183e62" Text="NIT"></asp:Label></td>
                        <td><asp:TextBox ID="txtNIT" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label8" runat="server" CssClass="label" ForeColor="#183e62" Text="Estados de cuenta"></asp:Label></td>
                        <td><asp:CheckBox ID="estadoCuenta" runat="server"  Text="Si, manejo estados de cuenta" ForeColor="White" OnCheckedChanged="estadoCuenta_CheckedChanged" CssClass="h5"/></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label9" runat="server" CssClass="label" ForeColor="#183e62" Text="Dirección"></asp:Label></td>
                        <td><asp:TextBox ID="txtDireccion" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label10" runat="server" CssClass="label" ForeColor="#183e62" Text="Telefonos"></asp:Label></td>
                        <td><asp:TextBox ID="txtTel1" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:TextBox ID="txtTel2" runat="server"  Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label11" runat="server" CssClass="label" ForeColor="#183e62" Text="Empresa donde labora"></asp:Label></td>
                        <td><asp:TextBox ID="txtEmpresa" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label12" runat="server" CssClass="label" ForeColor="#183e62" Text="Correo"></asp:Label></td>
                        <td><asp:TextBox ID="txtCorreo" runat="server" Width="276px"></asp:TextBox></td>
                    </tr>
                </table>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Height="55px" OnClick="Button1_Click" Text="Enviar datos para solicitar credito" CssClass="btn btn-primary btn-left" Width="340px" />
                <br />
                <br />
                <br />
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
	        <!-- Script del javascript del slider -->
	        <script type="text/javascript">
	            $(function () {
	                $('#banner div:gt(0)').hide();
	                setInterval(function () {
	                    $('#banner div:first-child').fadeOut(500).next('div').fadeIn(1000).end().appendTo('#banner');
	                }, 5000);
	            })
	        </script>

        </asp:Panel>
        </div>
</asp:Content>
