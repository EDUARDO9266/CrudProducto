<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="CrudProductos.Agregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:TextBox ID="TXTID" runat="server" Text="Ingrese EL ID" />
    <asp:TextBox ID="txtNOMBRE" runat="server" Text="Ingrese NOMBRE del Producto" />
<asp:TextBox ID="txtexitencia" runat="server" Text="Ingrese cantidad" />
<asp:TextBox ID="txtfactura" runat="server" Text="Ingrese numero de Factura" />
<asp:TextBox ID="txtfecha" runat="server" Text="Ingrese la fecha" />
    <asp:TextBox ID="Txttotal" runat="server" Text="Ingrese el total" />
<asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
</asp:Content>
