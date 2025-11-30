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
    public class CD_CONTRATOS
    {

        CD_CONEXION Con = new CD_CONEXION();


        #region LISTAR CONTRATOS
        public List<CE_MCONTRATOS> ListarContratos()
        {
            var oList = new List<CE_MCONTRATOS>();

            using (SqlCommand cmd = new SqlCommand("Sp_ListarContratos", Con.Abrir()))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        oList.Add(new CE_MCONTRATOS()
                        {

                            Id_contrato = Convert.ToInt32(dr["Id_contrato"]),
                            Id_empleado = Convert.ToInt32(dr["Id_empleado"]),
                            Tipo_contrato = dr["Tipo_contrato"].ToString(),
                            Fecha_inicio = Convert.ToDateTime(dr["Fecha_inicio"]),
                            Fecha_fin = Convert.ToDateTime(dr["Fecha_fin"]),
                            Salario = Convert.ToDecimal(dr["Salario"])

                        });


                    }
                }
            }
            return oList;

        }

        #endregion LISTAR CONTRATOS


        #region INSERTAR CONTRATOS

        public void InsertarContrato(CE_MCONTRATOS cE_Mcontratos)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("Sp_InsertarContratos", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id_empleado", cE_Mcontratos.Id_empleado));
                    cmd.Parameters.Add(new SqlParameter("@Tipo_contrato", cE_Mcontratos.Tipo_contrato));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_inicio", cE_Mcontratos.Fecha_inicio));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_fin", cE_Mcontratos.Fecha_fin));
                    cmd.Parameters.Add(new SqlParameter("@Salario", cE_Mcontratos.Salario));

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

        #endregion INSERTAR CONTRATOS


        #region EDITAR CONTRATOS

        public void EditarContrato(CE_MCONTRATOS cE_Mcontratos)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("Sp_EditarContratos", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id_contrato", cE_Mcontratos.Id_contrato));
                    cmd.Parameters.Add(new SqlParameter("@Id_empleado", cE_Mcontratos.Id_empleado));
                    cmd.Parameters.Add(new SqlParameter("@Tipo_contrato", cE_Mcontratos.Tipo_contrato));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_inicio", cE_Mcontratos.Fecha_inicio));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_fin", cE_Mcontratos.Fecha_fin));
                    cmd.Parameters.Add(new SqlParameter("@Salario", cE_Mcontratos.Salario));

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

        #endregion EDITAR CONTRATOS

    }
}
