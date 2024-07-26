using CrudWebForms.Datos;
using CrudWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudWebForms.FormProductos
{
    public partial class WebForm1 : System.Web.UI.Page
    {  Dproducto dproducto= new Dproducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Producto> listaProductos = dproducto.Consultar();
                ddlProducto.DataSource = listaProductos;
                ddlProducto.DataTextField = "Nombre";
                ddlProducto.DataValueField = "ProductoID";
                ddlProducto.DataBind();
                dgvProductos.DataSource = listaProductos;
                dgvProductos.DataBind();

            }
           
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Crear.aspx");
        }

        protected void ButtonDetalles_Click(object sender, EventArgs e)
        {
            string id = ddlProducto.SelectedValue;
            Response.Redirect($"Detalles.aspx?id={id}");

        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            string id = ddlProducto.SelectedValue;
            Response.Redirect($"Editar.ASPX?ID={id}");
 
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            string id = ddlProducto.SelectedValue;
            Response.Redirect($"Eliminar.ASPX?ID={id}");

        }
    }
}