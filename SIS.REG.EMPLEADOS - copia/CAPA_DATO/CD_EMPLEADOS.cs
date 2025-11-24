using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CAPA_DATO
{
    
    public class CD_EMPLEADOS
    {

        CD_CONEXION Con = new CD_CONEXION();


        #region LISTAR EMPLEADOS
        public List<CE_MEMPLEADOS> ListarEmpleados()
        {
            var oList = new List<CE_MEMPLEADOS>();

            using (SqlCommand cmd = new SqlCommand("Sp_ListarEmpleados", Con.Abrir()))
            {

                cmd.CommandType = CommandType.StoredProcedure; 
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        oList.Add(new CE_MEMPLEADOS()
                        {

                            Id_empleado = Convert.ToInt32(dr["Id_empleado"]),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Nombres"].ToString(),
                            Fecha_nacimiento = Convert.ToDateTime(dr["Fecha_nacimiento"]),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Email = dr["Email"].ToString(),
                            Fecha_ingreso = Convert.ToDateTime(dr["Fecha_ingreso"]),
                            Id_departamento = Convert.ToInt32(dr["Id_departamento"]),
                            Id_puesto = Convert.ToInt32(dr["Id_puesto"])


                        });


                    }
                }
            }
            return oList;

        }

        #endregion LISTAR EMPLEADOS


        #region INSERTAR EMPLEADOS

        public void InsertarEmpleados(CE_MEMPLEADOS cE_MEMPLEADOS)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("Sp_InsertarEmpleados", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Nombres", cE_MEMPLEADOS.Nombres));
                    cmd.Parameters.Add(new SqlParameter("@Apellidos", cE_MEMPLEADOS.Apellidos));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_nacimiento", cE_MEMPLEADOS.Fecha_nacimiento));
                    cmd.Parameters.Add(new SqlParameter("@Direccion", cE_MEMPLEADOS.Direccion));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", cE_MEMPLEADOS.Telefono));
                    cmd.Parameters.Add(new SqlParameter("@Email", cE_MEMPLEADOS.Email));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_ingreso", cE_MEMPLEADOS.Fecha_ingreso));

                    cmd.ExecuteNonQuery();
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups no se Ingreso por el error: {ex.Message}", "Error al Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Cerrar();
            }
        }

        #endregion INSERTAR EMPLEADOS

    }
}
