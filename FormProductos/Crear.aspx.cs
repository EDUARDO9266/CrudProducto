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
    public partial class Crear : System.Web.UI.Page
    {
        Dproducto dProducto = new Dproducto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGuardar_Click1(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {

                Nombre = TxtNombre.Text,
                Precio = Convert.ToDecimal(TxtPrecio.Text),
                Stock = Convert.ToInt32(TxtStock.Text),
                CategoriaID = Convert.ToInt32(TxtCategoriaID.Text),
                ProveedorID = Convert.ToInt32(TxtProveedorID.Text)

            };
            dProducto.Agregar(producto);
            Response.Redirect("index");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index");
        }
    }
}