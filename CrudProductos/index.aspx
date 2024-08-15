<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CrudProductos.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID">
  <Columns>
   
    <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" />
    <asp:BoundField DataField="exitencia" HeaderText="exitencia" />
    <asp:BoundField DataField="factura" HeaderText="Factura" />
        <asp:BoundField DataField="fecha" HeaderText="fecha" />
   <asp:BoundField DataField="total" HeaderText="total" />
  </Columns>
</asp:GridView>
<asp:Button ID="Button1" runat="server" Text="Agregar Producto" OnClick="Button1_Click" />
</asp:Content>
