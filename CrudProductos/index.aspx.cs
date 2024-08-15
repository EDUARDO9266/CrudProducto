using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudProductos
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaProducto();
            }
        }
        protected void CargaProducto()
        {

            string connstr = ConfigurationManager.ConnectionStrings["BdProductos"].ConnectionString;
            using(SqlConnection conn = new SqlConnection(connstr))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Productos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agregar.aspx");
        }
    }
}