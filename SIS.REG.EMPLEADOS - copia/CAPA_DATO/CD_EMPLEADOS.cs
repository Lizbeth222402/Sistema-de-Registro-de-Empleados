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
                            Id_departamento = Convert.ToInt32(dr["Id_departamento"]),
                            Id_puesto = Convert.ToInt32(dr["Id_puesto"]),
                            Id_empleado = Convert.ToInt32(dr["Id_empleado"]),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            Fecha_nacimiento = Convert.ToDateTime(dr["Fecha_nacimiento"]),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Email = dr["Email"].ToString(),
                            Fecha_ingreso = Convert.ToDateTime(dr["Fecha_ingreso"]),
                            


                        });


                    }
                }
            }
            return oList;

        }

        #endregion LISTAR EMPLEADOS


        #region INSERTAR EMPLEADOS

        public void InsertarEmpleados(CE_MEMPLEADOS cE)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_InsertarEmpleados", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = cE.Nombres;
                    cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = cE.Apellidos;
                    cmd.Parameters.Add("@Fecha_nacimiento", SqlDbType.Date).Value = cE.Fecha_nacimiento;
                    cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = cE.Direccion;
                    cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = cE.Telefono;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = cE.Email;
                    cmd.Parameters.Add("@Fecha_ingreso", SqlDbType.Date).Value = cE.Fecha_ingreso;

                    // VALIDAR FK
                    cmd.Parameters.Add("@Id_departamento", SqlDbType.Int).Value =
                        cE.Id_departamento == 0 ? (object)DBNull.Value : cE.Id_departamento;

                    cmd.Parameters.Add("@Id_puesto", SqlDbType.Int).Value =
                        cE.Id_puesto == 0 ? (object)DBNull.Value : cE.Id_puesto;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado ingresado correctamente");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups no se Ingreso por el error: {ex.Message}",
                    "Error al Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Cerrar();
            }
        }


        #endregion INSERTAR EMPLEADOS


        #region EDITAR EMPLEADOS

        public void EditarEmpleados(CE_MEMPLEADOS cE_MEMPLEADOS)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("Sp_EditarEmpleados", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(new SqlParameter("@Id_departamento", cE_MEMPLEADOS.Id_departamento));
                    cmd.Parameters.Add(new SqlParameter("@Id_puesto", cE_MEMPLEADOS.Id_puesto));
                    cmd.Parameters.Add(new SqlParameter("@Id_empleado", cE_MEMPLEADOS.Id_empleado));
                    cmd.Parameters.Add(new SqlParameter("@Nombres", cE_MEMPLEADOS.Nombres));
                    cmd.Parameters.Add(new SqlParameter("@Apellidos", cE_MEMPLEADOS.Apellidos));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_nacimiento", cE_MEMPLEADOS.Fecha_nacimiento));
                    cmd.Parameters.Add(new SqlParameter("@Direccion", cE_MEMPLEADOS.Direccion));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", cE_MEMPLEADOS.Telefono));
                    cmd.Parameters.Add(new SqlParameter("@Email", cE_MEMPLEADOS.Email));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_ingreso", cE_MEMPLEADOS.Fecha_ingreso));
                    //cmd.Parameters.Add(new SqlParameter("@Id_departamento", cE_MEMPLEADOS.Id_departamento));
                    //cmd.Parameters.Add(new SqlParameter("@Id_puesto", cE_MEMPLEADOS.Id_puesto));

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

        #endregion EDITAR EMPLEADOS


        #region ELIMINAR EMPLEADOS
        public void ELIMINAREmpleados(CE_MEMPLEADOS cE_MEMPLEADOS)
        {

            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_EliminarEmpleado", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id_empleado", cE_MEMPLEADOS.Id_empleado));
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show($"Ups no se Elimino por el error {ex.Message}", "Elimiar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Cerrar();
            }


        }

        #endregion ELIMINAR EMPLEADOS
    }
}
