using CrudWebFomsProveedor.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CrudWebFomsProveedor.Datos
{
    public class DProveedor
    { 
        private string cadena;
      public  DProveedor() { cadena = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString(); }

        public void Agregar(Proveedor proveedor)
        {
            string query = $"insert Proveedor ( Nombre,Telefono,Correo) values  ('{proveedor.Nombre}','{proveedor.Telefono},'{proveedor.Correo}')";
            SqlConnection sqlConnection= new SqlConnection(cadena);
            SqlCommand cmd =   new SqlCommand (query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Eliminar( int id)
        {

            string query = $"delete Proveedor where ProveedorID={id}";
            SqlConnection sqlConnection = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand (query, sqlConnection);
            sqlConnection .Open();
            cmd.ExecuteNonQuery();
            sqlConnection .Close();

        }

        public void Actualizar(Proveedor proveedor)
        {
            string query = $"update Proveedor set Nombre= '{proveedor.Nombre}',Telefono = '{proveedor.Telefono}',Correo = '{proveedor.Correo}' where ProveedorID={proveedor.ProveedorID}";
            SqlConnection sqlConnection = new SqlConnection(cadena) ;
            SqlCommand cmd = new SqlCommand (query, sqlConnection);
            sqlConnection .Open();
            cmd.ExecuteNonQuery();
            sqlConnection .Close();
        }
        public Proveedor Consultar(int id)
        {
            Proveedor proveedor = new Proveedor();
            string query = $"select*from Proveedor where ProveedorID = {id}";
            SqlConnection sqlConnection = new SqlConnection(cadena);
            SqlCommand cmd =new SqlCommand (query, sqlConnection);  
            sqlConnection .Open();
           SqlDataReader ConsultarProveedor = cmd.ExecuteReader ();
            ConsultarProveedor.Read();
            proveedor.ProveedorID = Convert.ToInt32(ConsultarProveedor["ProveedorID"]);
            proveedor.Nombre = Convert.ToString(ConsultarProveedor["Nombre"]);
            proveedor.Telefono = Convert.ToString(ConsultarProveedor["Telefono"]);
            proveedor.Correo = Convert.ToString(ConsultarProveedor["Correo"]);
            return proveedor;   
             } 

        public List<Proveedor>Consultar()
        {
            List<Proveedor> lstproveedor = new List<Proveedor>();
            string query = $"select*from Proveedor ";
            SqlConnection sqlConnection = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand(query, sqlConnection);  
            sqlConnection .Open();
            SqlDataReader sqlData = cmd.ExecuteReader ();
            while (sqlData.Read())
            {
                Proveedor proveedor = new Proveedor();
                proveedor.ProveedorID = Convert.ToInt32(sqlData["ProveedorID"]);
                proveedor.Nombre = Convert.ToString(sqlData["Nombre"]);
                proveedor.Telefono = Convert.ToString(sqlData["Telefono"]);
                proveedor.Correo = Convert.ToString(sqlData["Correo"]);
                lstproveedor.Add(proveedor);
            };

                return lstproveedor;   
                
;
            }

        }
    }
   


