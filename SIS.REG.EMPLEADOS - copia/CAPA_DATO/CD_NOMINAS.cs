using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CAPA_DATO
{
    public class CD_NOMINAS
    {
        CD_CONEXION Con = new CD_CONEXION();



        #region LISTAR NOMINAS
        public List<CE_MNOMINAS> ListarNominas()
        {
            var oList = new List<CE_MNOMINAS>();

            using (SqlCommand cmd = new SqlCommand("SP_LISTAR_NOMINAS", Con.Abrir()))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        oList.Add(new CE_MNOMINAS()
                        {

                            Id_nomina = Convert.ToInt32(dr["Id_nomina"]),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            Fecha_pago = Convert.ToDateTime(dr["Fecha_pago"]),
                            Salario_bruto = Convert.ToDecimal(dr["Salario_bruto"]),
                            Deducciones = Convert.ToDecimal(dr["Deducciones"]),
                            Salario_neto = Convert.ToDecimal(dr["Salario_neto"])

                        });


                    }
                }
            }
            return oList;

        }
        #endregion LISTAR NOMINAS


        #region INSERTAR NOMINAS

        public void InsertarNominas(CE_MNOMINAS cE_MNOMINAS)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("SP_INSERTAR_NOMINAS", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id_empleado", cE_MNOMINAS.Id_empleado));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_pago", cE_MNOMINAS.Fecha_pago));
                    cmd.Parameters.Add(new SqlParameter("@Salario_bruto", cE_MNOMINAS.Salario_bruto));
                    cmd.Parameters.Add(new SqlParameter("@Deducciones", cE_MNOMINAS.Deducciones));
                    cmd.Parameters.Add(new SqlParameter("@Salario_neto", cE_MNOMINAS.Salario_neto));

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

        #endregion INSERTAR NOMINAS

        #region EDITAR NOMINAS

        public void EditarNominas(CE_MNOMINAS cE_MNOMINAS)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("SP_EDITAR_NOMINAS", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(new SqlParameter("@Id_nomina", cE_MNOMINAS.Id_nomina));
                    cmd.Parameters.Add(new SqlParameter("@Id_empleado", cE_MNOMINAS.Id_empleado));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_pago", cE_MNOMINAS.Fecha_pago));
                    cmd.Parameters.Add(new SqlParameter("@Salario_bruto", cE_MNOMINAS.Salario_bruto));
                    cmd.Parameters.Add(new SqlParameter("@Deducciones", cE_MNOMINAS.Deducciones));
                    cmd.Parameters.Add(new SqlParameter("@Salario_neto", cE_MNOMINAS.Salario_neto));

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

        #endregion EDITAR NOMINAS

        #region ELIMINAR NOMINAS
        public void ELIMINARNominas(CE_MNOMINAS cE_MNOMINAS)
        {

            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_ELIMINAR_NOMINAS", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id_nomina", cE_MNOMINAS.Id_nomina));
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups no se Elimino por el error {ex.Message}", "Elimiar Nominas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Cerrar();
            }


        }

        #endregion ELIMINAR NOMINAS

    }
}

