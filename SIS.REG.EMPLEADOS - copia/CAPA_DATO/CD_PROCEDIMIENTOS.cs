using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CAPA_DATO
{
    public class CD_PROCEDIMIENTOS
    {
        CD_CONEXION Con = new CD_CONEXION();

        //metodo para listar empleados//
        public DataTable  ListarEmpleados(string procedure)
        {

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new  SqlCommand (procedure,Con.Abrir()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);   
                }
            }
            return dt;


        }


        //metodo para listar departamento//
        public DataTable ListarDepartamento(string procedure)
        {

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(procedure, Con.Abrir()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;


        }

        //metodo para listar puesto//
        public DataTable ListarPuestos(string procedure)
        {

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(procedure, Con.Abrir()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;


        }

        //metodo para listar CONTRATO//
        public DataTable ListarContratos(string procedure)
        {

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(procedure, Con.Abrir()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;


        }


        //metodo para listar Asistencias//
        public DataTable ListarAsistencias(string procedure)
        {

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(procedure, Con.Abrir()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;


        }


        //metodo para listar AUSENCIAS//
        public DataTable ListarAusencias(string procedure)
        {

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(procedure, Con.Abrir()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;


        }

        //metodo para listar NOMINAS//
        public DataTable ListarNominas(string procedure)
        {

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(procedure, Con.Abrir()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;


        }



        //metodo para listar USUARIOS//
        public DataTable ListarUsuarios(string procedure)
        {

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(procedure, Con.Abrir()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;


        }

    }
}
