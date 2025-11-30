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
    public class CD_USUARIOS
    {

        CD_CONEXION Con = new CD_CONEXION();

        #region LISTAR USUARIOS

        public List<CE_MUSUARIOS> ListarUsuarios()
        {
            var oList = new List<CE_MUSUARIOS>();

            using (SqlCommand cmd = new SqlCommand("SP_LISTAR_USUARIO", Con.Abrir()))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        oList.Add(new CE_MUSUARIOS()
                        {

                            ID_USUARIO = Convert.ToInt32(dr["ID_USUARIO"]),
                            NOMBRE_USUARIO = dr["NOMBRE_USUARIO"].ToString(),
                            CONTRASEÑA = dr["CONTRASEÑA"].ToString(),
                            ACTIVO = dr["ACTIVO"].ToString(),

                        });


                    }
                }
            }
            return oList;

        }

        #endregion LISTAR USUARIO

        #region INSERTAR USUARIOS

        public void InsertarUsuario(CE_MUSUARIOS cE_MUSUARIOS)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_INSERTAR_USUARIO", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@NOMBRE_USUARIO", cE_MUSUARIOS.NOMBRE_USUARIO));
                    cmd.Parameters.Add(new SqlParameter("@CONTRASEÑA", cE_MUSUARIOS.CONTRASEÑA));
                    cmd.Parameters.Add(new SqlParameter("@ACTIVO", cE_MUSUARIOS.ACTIVO));
                   
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

        #endregion INSERTAR USUARIOS

    }
}
