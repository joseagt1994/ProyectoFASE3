<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eEnlaces.aspx.cs" Inherits="SW_CIDEAUTOS.eEnlaces" %>

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
    <p>&nbsp;</p>
    <h1>Editar Enlaces de CIDEAUTOS</h1>
    <h2>Seleccione imagen del Enlace... Tiene que ser de 29*29 pixeles</h2>
        <p>&nbsp;</p>
        <p class="txt-center">
        <asp:FileUpload ID="cargaImagen" runat="server" Width="299px" />
        </p>
        <p class="txt-center">
            <br />
        <asp:Label ID="Label1" runat="server" Text="Link: "></asp:Label><asp:TextBox ID="txtNombre" runat="server" Width="208px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar enlace" />
        </p>
        <p>&nbsp;</p>
        <h3> Imagenes nuevas</h3><br />
        <p>
            <asp:GridView runat="server" ID="gvImagenes" AutoGenerateColumns="false" EmptyDataText="No hay imagenes."
            GridLines="None" Width="100%" CellPadding="5" ShowFooter="true" DataKeyNames="nombre"
            OnRowCommand="gvImagenes_RowCommand">
            <HeaderStyle HorizontalAlign="Left" BackColor="Blue" ForeColor="AliceBlue" />
            <FooterStyle HorizontalAlign="Right" BackColor="Yellow" ForeColor="Aqua" />
            <AlternatingRowStyle BackColor="Azure" />
            <Columns>
                <asp:ImageField HeaderText="Imagen" DataImageUrlField="ruta" ControlStyle-Width="40%" />
                <asp:BoundField DataField="nombre" HeaderText="Link" />
                <asp:TemplateField HeaderText=" ">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="btnEliminar" Text="Eliminar" CommandName="Eliminar"
                            CommandArgument='<%# Eval("nombre") %>' Style="font-size: 24px;"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </p>
        <p>&nbsp;</p><br /><br />
        <h3> Imagenes viejas</h3><br />
        <p>
            <asp:GridView runat="server" ID="gvImagenesViejas" AutoGenerateColumns="false" EmptyDataText="No hay imagenes."
            GridLines="None" Width="100%" CellPadding="5" ShowFooter="true" DataKeyNames="nombre"
            OnRowCommand="gvImagenesViejas_RowCommand">
            <HeaderStyle HorizontalAlign="Left" BackColor="Blue" ForeColor="AliceBlue" />
            <FooterStyle HorizontalAlign="Right" BackColor="Yellow" ForeColor="Aqua" />
            <AlternatingRowStyle BackColor="Azure" />
            <Columns>
                <asp:ImageField HeaderText="Imagen" DataImageUrlField="ruta" ControlStyle-Width="40%" />
                <asp:BoundField DataField="nombre" HeaderText="Link" />
                <asp:TemplateField HeaderText=" ">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="btnEliminar" Text="Eliminar" CommandName="Eliminar"
                            CommandArgument='<%# Eval("cod_enlace") %>' Style="font-size: 24px;"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </p>
        <p>&nbsp;</p>
        <p class="txt-center">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Actualizar enlaces" Width="368px" />
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
    </form>
</body>
</html>
