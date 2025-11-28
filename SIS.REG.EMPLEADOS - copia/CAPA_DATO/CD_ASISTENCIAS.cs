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
    public class CD_ASISTENCIAS
    {
        #region LISTAR ASISTENCIAS

        CD_CONEXION Con = new CD_CONEXION();

        public List<CE_MASISTENCIAS> ListarAsistencias()
        {
            var oList = new List<CE_MASISTENCIAS>();

            using (SqlCommand cmd = new SqlCommand("SP_LISTAR_ASISTENCIAS", Con.Abrir()))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        oList.Add(new CE_MASISTENCIAS()
                        {

                            Id_asistencia = Convert.ToInt32(dr["Id_asistencia"]),
                            Id_empleado = Convert.ToInt32(dr["Id_empleado"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            Hora_entrada = Convert.ToDateTime(dr["Hora_entrada"]),
                            Hora_salida = Convert.ToDateTime(dr["Hora_salida"]),
                            Estado = dr["Estado"].ToString(),

                        });


                    }
                }
            }
            return oList;

        }

        #endregion LISTAR ASISTENCIA

        #region INSERTAR ASISTENCIA

        public void InsertarAsistencia(CE_MASISTENCIAS cE_MASISTENCIAS)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("SP_INSERTAR_ASISTENCIAS", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id_empleado ", cE_MASISTENCIAS.Id_empleado));
                    cmd.Parameters.Add(new SqlParameter("@Fecha", cE_MASISTENCIAS.Fecha));
                    cmd.Parameters.Add(new SqlParameter("@Hora_entrada ", cE_MASISTENCIAS.Hora_entrada));
                    cmd.Parameters.Add(new SqlParameter("@Hora_salida ", cE_MASISTENCIAS.Hora_salida));
                    cmd.Parameters.Add(new SqlParameter("@Estado", cE_MASISTENCIAS.Estado));

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

        #endregion INSERTAR ASISTENCIA



    }
}
