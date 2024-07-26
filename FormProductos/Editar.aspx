<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="CrudWebForms.FormProductos.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div>
    <asp:Label ID="LabelActualizar" runat="server" Text="Actualizar Producto"></asp:Label>
</div>
     <div>
     <asp:Label ID="Label6" runat="server" Text="ID"></asp:Label>
     <asp:TextBox ID="TextBoxID" runat="server" Enabled="False"></asp:TextBox>
     <br />
 </div>
<div>
    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
    <br />
</div>
<div>
    <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label> 
    <asp:TextBox ID="TextBoxPrecio" runat="server"></asp:TextBox>
    <br />
</div>
    <div>
    <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label>
    <asp:TextBox ID="TextBoxStock" runat="server"></asp:TextBox>
    <br />
</div>
    
    <div>
    <asp:Label ID="Label1" runat="server" Text="Categoria"></asp:Label>
    <asp:TextBox ID="TextBoxCategoriaID" runat="server"></asp:TextBox>
    <br />
</div>
        
    <div>
    <asp:Label ID="Label5" runat="server" Text="Proveedor"></asp:Label>
    <asp:TextBox ID="TextBoxProveedorID" runat="server"></asp:TextBox>
    <br />
</div>
<br />
<div>
 <asp:Button ID="ButtonActualizar" runat="server" Text="Actualizar" OnClick="ButtonActualizar_Click" />
</div>
<div>
    <asp:Label ID="LabelResultado" runat="server" Text="Label"></asp:Label>
</div>

</asp:Content>
