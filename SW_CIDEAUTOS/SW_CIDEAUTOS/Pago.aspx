<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Pago.aspx.cs" Inherits="SW_CIDEAUTOS.Pago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Comprar Vehiculo</h1>
    <br />
    <label>Nombre:</label><br />
    <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
    <br /><br />
    <label>No. de tarjeta:</label><br />
    <asp:TextBox runat="server" ID="txtNoTarjeta"></asp:TextBox>
    <br /><br />
    <label>Codigo:</label><br />
    <asp:TextBox runat="server" ID="txtCodigo" TextMode="Password"></asp:TextBox>
    <br /><br />
    <asp:Button runat="server" ID="btEnviar" Text="Comprar" OnClick="btEnviar_Click" />
</asp:Content>
