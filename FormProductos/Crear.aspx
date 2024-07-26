<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="CrudWebForms.FormProductos.Crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
        <asp:Label ID="LblAgregar" runat="server" Text="Agregar Producto"></asp:Label>
    </div>
    <div>
        <asp:Label ID="LblNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
        <br />
    </div>
        <div>
        <asp:Label ID="LblPrecio" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox ID="TxtPrecio" runat="server"></asp:TextBox>
        <br />
    </div>
    <br />
    <div>
        <asp:Label ID="LblStock" runat="server" Text="Stock"></asp:Label>
        <asp:TextBox ID="TxtStock" runat="server"></asp:TextBox>
        <br />
    </div>
    <br />
            <div>
        <asp:Label ID="LblCategoriaID" runat="server" Text="Categoria"></asp:Label>
        <asp:TextBox ID="TxtCategoriaID" runat="server"></asp:TextBox>
        <br />
    </div>
    <br />

            <div>
    <asp:Label ID="LblProveedorID" runat="server" Text="Proveedor"></asp:Label>
    <asp:TextBox ID="TxtProveedorID" runat="server"></asp:TextBox>
    <br />
</div>
<br />

    <div>
     <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click1" />
         <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                    
    </div>
    <div>
        <asp:Label ID="LabelResultado" runat="server" Text="Label"></asp:Label>
    </div>



<div>
        <a href="index.aspx">Regresar a la lista</a>
</div>
</asp:Content>
