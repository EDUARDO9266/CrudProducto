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
    public partial class Delete : System.Web.UI.Page
    { Dproducto dproducto= new Dproducto(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int productoID;
                if (int.TryParse(Request.QueryString["ID"], out productoID))
                {
                    CargarDetallesProducto(productoID);
                }
                else
                {
                    // Manejar el caso en el que no se pasó un ID válido
                    Response.Redirect("index.aspx");

                }
            }

        }
        protected void CargarDetallesProducto(int productoID)
        {
            Producto producto = dproducto.Consultar(productoID);
            if (producto != null)
            {
                LblProductoIDP.Text = producto.ProductoID.ToString();
                LblNombreP.Text = producto.Nombre;
                LblPrecioP.Text = producto.Precio.ToString("C");
                LblStockP.Text = producto.Stock.ToString();
                LblCategoriaIDP.Text = producto.CategoriaID.ToString();
                LblProveedorIDP.Text = producto.ProveedorID.ToString();
            }
            else
            {
                // Manejar el caso en el que no se encontró el producto
                Response.Redirect("index.aspx");
            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LblProductoIDP.Text);
            dproducto.Eliminar(id);
            Response.Redirect("index.aspx");


        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}