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
    public class CD_AUSENCIAS
    {

        CD_CONEXION Con = new CD_CONEXION();

        #region LISTAR AUSENCIAS
        public List<CE_MAUSENCIAS> ListarAusencias()
        {
            var oList = new List<CE_MAUSENCIAS>();

            using (SqlCommand cmd = new SqlCommand("SP_LISTAR_AUSENCIAS", Con.Abrir()))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        oList.Add(new CE_MAUSENCIAS()
                        {

                            Id_ausencia = Convert.ToInt32(dr["Id_ausencia"]),
                            Id_empleado = Convert.ToInt32(dr["Id_empleado"]),
                            Tipo_ausencia = dr["Tipo_ausencia"].ToString(),
                            Fecha_inicio = Convert.ToDateTime(dr["Fecha_inicio"]),
                            Fecha_fin = Convert.ToDateTime(dr["Fecha_fin"]),
                            Motivo = dr["Motivo"].ToString()

                        });


                    }
                }
            }
            return oList;

        }

        #endregion LISTAR LISTAR AUSENCIAS


        #region INSERTAR ASENCIAS

        public void InsertarAusencias(CE_MAUSENCIAS cE_MAUSENCIAS)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("SP_INSERTAR_AUSENCIAS", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id_empleado", cE_MAUSENCIAS.Id_empleado));
                    cmd.Parameters.Add(new SqlParameter("@Tipo_ausencia", cE_MAUSENCIAS.Tipo_ausencia));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_inicio", cE_MAUSENCIAS.Fecha_inicio));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_fin", cE_MAUSENCIAS.Fecha_fin));
                    cmd.Parameters.Add(new SqlParameter("@Motivo", cE_MAUSENCIAS.Motivo));

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

        #endregion INSERTAR AUSENCIAS

    }
}
