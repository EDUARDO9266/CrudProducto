using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudProductos
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["BdProductos"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connstr))
            {

                string query = "INSERT INTO Productos(ID,NOMBRE,exitencia,factura,fecha,total) values (@ID,@NOMBRE,@exitencia,@factura,@fecha,@total)";
                using(SqlCommand cmd = new SqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@ID", TXTID.Text);
                    cmd.Parameters.AddWithValue("@NOMBRE", txtNOMBRE.Text);
                    cmd.Parameters.AddWithValue("@exitencia", txtexitencia.Text);
                    cmd.Parameters.AddWithValue("@factura", txtfactura.Text);
                    cmd.Parameters.AddWithValue("@fecha", txtfecha.Text);
                    cmd.Parameters.AddWithValue("@total", Txttotal.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }


            }
            Response.Redirect("index.aspx");

        }
    }
}