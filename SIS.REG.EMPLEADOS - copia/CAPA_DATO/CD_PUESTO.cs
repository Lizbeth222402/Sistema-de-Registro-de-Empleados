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
    public class CD_PUESTO
    {

        CD_CONEXION Con = new CD_CONEXION();

        #region LISTAR PUESTO
        public List<CE_MPUESTOS> ListarPuesto()
        {
            var oList = new List<CE_MPUESTOS>();

            using (SqlCommand cmd = new SqlCommand("Sp_ListarPuestos", Con.Abrir()))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        oList.Add(new CE_MPUESTOS()
                        {

                            Id_puesto = Convert.ToInt32(dr["Id_puesto"]),
                            Nombre_puesto = dr["Nombre_puesto"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            Salario_base = Convert.ToDecimal(dr["Salario_base"]),
                            
                        });


                    }
                }
            }
            return oList;

        }

        #endregion LISTAR PUESTO

        #region INSERTAR PUESTO

        public void InsertarPuesto(CE_MPUESTOS cE_MPUESTOS)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("Sp_InsertarPuestos", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Nombre_puesto", cE_MPUESTOS.Nombre_puesto));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", cE_MPUESTOS.Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@Salario_base", cE_MPUESTOS.Salario_base));

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

        #endregion INSERTAR PUESTO


    }
}
