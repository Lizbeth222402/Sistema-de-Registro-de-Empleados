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
    public class CD_DEPARTAMENTO
    {

        CD_CONEXION Con = new CD_CONEXION();

        #region LISTAR DEPARTAMENTOS
        public List<CE_MDEPARTAMENTOS> ListarDepartamento()
        {
            var oList = new List<CE_MDEPARTAMENTOS>();

            using (SqlCommand cmd = new SqlCommand("Sp_ListarDepartamentos", Con.Abrir()))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        oList.Add(new CE_MDEPARTAMENTOS()
                        {

                            Id_departamento = Convert.ToInt32(dr["Id_departamento"]),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString()
                           
                        });


                    }
                }
            }
            return oList;

        }

        #endregion LISTAR DEPARTAMENTO

        #region INSERTAR DEPARTAMENTOS

        public void InsertarDepartamento (CE_MDEPARTAMENTOS cE_MDEPARTAMENTOS)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("Sp_InsertarDepartamentos", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Nombre", cE_MDEPARTAMENTOS.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", cE_MDEPARTAMENTOS.Descripcion));

                    cmd.ExecuteNonQuery();
                  

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups no se Ingreso por el error: {ex.Message}", "Error al Ingresar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                Con.Cerrar();
            }
        }

        #endregion INSERTAR DEPARTAMENTOS

        #region EDITAR DEPARTAMENTOS

        public void EditarDepartamento(CE_MDEPARTAMENTOS cE_MDEPARTAMENTOS)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("Sp_EditarDepartamentos", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id_departamento", cE_MDEPARTAMENTOS.Id_departamento));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", cE_MDEPARTAMENTOS.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", cE_MDEPARTAMENTOS.Descripcion));

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

        #endregion EDITAR DEPARTAMENTOS

        #region ELIMINAR DEPARTAMENTO
        public void ELIMINARDEPARTAMENTO(CE_MDEPARTAMENTOS cE_MDEPARTAMENTOS)
        {

            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_EliminarDepartamento", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id", cE_MDEPARTAMENTOS.Id_departamento));
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show($"Ups no se Elimino por el error {ex.Message}", "Elimiar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Cerrar();
            }


        }

        #endregion ELIMINAR DEPARTAMENTO


        #region FILTRAR DEPARTAMENTO



        #endregion  FILTRAR DEPARTAMENTO

    }
}
