using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDB
{
    public class Conexion_DB
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-NKI4B61;Initial Catalog=FarmaciaProyect;Integrated Security=True;");
   
    
        public SqlConnection OpenConection ()
        {
            if(conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CloseConection ()
        {
            if(conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    
    }

}
