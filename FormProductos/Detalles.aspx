<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="CrudWebForms.FormProductos.Detalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">   
        <div>
            <h2>Detalles del Producto</h2>

               <asp:Label ID="LblProductoID" runat="server" Text="ID"></asp:Label>
            <asp:Label ID="LblProductoIDP" runat="server" Text=""></asp:Label>
            <br />
          
            <asp:Label ID="LblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:Label ID="LblNombreP" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="LblPrecio" runat="server" Text="Precio"></asp:Label>
            <asp:Label ID="LblPrecioP" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="LblStock" runat="server" Text="Stock"></asp:Label>
            <asp:Label ID="LblStockP" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="LblCategoriaID" runat="server" Text="Categoría"></asp:Label>
            <asp:Label ID="LblCategoriaIDP" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="LblProveedorID" runat="server" Text="Proveedor"></asp:Label>
            <asp:Label ID="LblProveedorIDP" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" />
        </div>
</asp:Content>
