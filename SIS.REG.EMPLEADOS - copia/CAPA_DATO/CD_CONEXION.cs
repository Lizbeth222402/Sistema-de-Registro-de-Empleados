using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATO
{
    public class CD_CONEXION
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=LIZ;Initial Catalog=Sistema_Empleados;Integrated Security=True");

        public SqlConnection Abrir()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();    
            return Conexion;

        }
        public SqlConnection Cerrar()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }


    }
}
