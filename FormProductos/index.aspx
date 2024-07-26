<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CrudWebForms.FormProductos.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div>
       <asp:Label ID="Label1" runat="server" Text="Lista Productos"></asp:Label>
   </div>
   <div>
       <asp:DropDownList ID="ddlProducto" runat="server"></asp:DropDownList>
   </div>
   <br>
       <div>
       <asp:Button ID="ButtonAgregar" runat="server" Text="Agregar" OnClick="ButtonAgregar_Click" />
       <asp:Button ID="ButtonDetalles" runat="server" Text="Detalles" OnClick="ButtonDetalles_Click" />
       <asp:Button ID="ButtonEditar" runat="server" Text="Editar" OnClick="ButtonEditar_Click" />
           <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
       
   </div>
   <br/>
   <div>
       <asp:GridView ID="dgvProductos" runat="server"></asp:GridView>
   </div>
</asp:Content>
