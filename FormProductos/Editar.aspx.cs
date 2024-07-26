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
    public partial class Editar : System.Web.UI.Page
    { Dproducto dproducto = new Dproducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["ID"]);
                Producto producto = dproducto.Consultar(id);
              
                TextBoxID.Text = producto.ProductoID.ToString();
                TextBoxNombre.Text = producto.Nombre;
                TextBoxPrecio.Text = producto.Precio.ToString();
                TextBoxStock.Text = producto.Stock.ToString();
                TextBoxCategoriaID.Text = producto.CategoriaID.ToString();
                TextBoxProveedorID.Text = producto.ProveedorID.ToString();
            
            }
        }

        protected void ButtonActualizar_Click(object sender, EventArgs e)
        {
        
            try
            {
                Producto producto = new Producto();
                producto.ProductoID = Convert.ToInt16(TextBoxID.Text);
                producto.Nombre = TextBoxNombre.Text;
                producto.Precio = Convert.ToDecimal(TextBoxPrecio.Text);
                producto.Stock = Convert.ToInt16(TextBoxStock.Text);
                producto.CategoriaID = Convert.ToInt16(TextBoxCategoriaID.Text);
                producto.ProveedorID = Convert.ToInt16(TextBoxProveedorID.Text);

                dproducto.Actualizar(producto);
                Response.Redirect("Index.aspx");
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
    
}