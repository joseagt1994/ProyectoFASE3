<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="SW_CIDEAUTOS.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> CIDEAUTOS :: Eliminar </title>
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
    <p>
        &nbsp;</p>
    <h1>Listado de Vehiculos</h1>
    <h2>Informacion</h2>
        <p>&nbsp;</p>
        
        <asp:GridView runat="server" ID="gvCarros" AutoGenerateColumns="false" EmptyDataText="No hay imagenes."
            GridLines="None" Width="100%" CellPadding="5" ShowFooter="true" DataKeyNames="codigo"
            OnRowCommand="gvCarros_RowCommand">
            <HeaderStyle HorizontalAlign="Left" BackColor="Blue" ForeColor="AliceBlue" />
            <FooterStyle HorizontalAlign="Right" BackColor="Yellow" ForeColor="Aqua" />
            <AlternatingRowStyle BackColor="Azure" />
            <Columns>
                <asp:BoundField DataField="Placa" HeaderText="Placa" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                <asp:BoundField DataField="Linea" HeaderText="Linea" />
                <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                <asp:ImageField HeaderText="Imagen" DataImageUrlField="ruta" ControlStyle-Width="30%" />
                <asp:TemplateField HeaderText=" ">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="btnEditarImg" Text="Editar Imagenes" CommandName="EditarImg"
                            CommandArgument='<%# Eval("codigo") %>' Style="font-size: 24px;"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText=" ">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="btnEditar" Text="Editar" CommandName="Editar"
                            CommandArgument='<%# Eval("codigo") %>' Style="font-size: 24px;"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText=" ">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="btnEliminar" Text="Eliminar" CommandName="Eliminar"
                            CommandArgument='<%# Eval("codigo") %>' Style="font-size: 24px;"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
            
</body>
</html>
