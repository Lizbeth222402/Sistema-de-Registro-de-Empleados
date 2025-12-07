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
                            ACTIVO = Convert.ToInt32(dr["ACTIVO"]),

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


        #region EDITAR USUARIOS

        public void EditarUsuario(CE_MUSUARIOS cE_MUSUARIOS)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_EDITAR_USUARIO", Con.Abrir()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ID_USUARIO", cE_MUSUARIOS.ID_USUARIO));
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

        #endregion EDITAR USUARIOS


        #region LOGIN
        public CE_MUSUARIOS Login(string usuario, string clave)
        {
            CE_MUSUARIOS obj = null;

            using (SqlCommand cmd = new SqlCommand("SP_LOGIN", Con.Abrir()))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        obj = new CE_MUSUARIOS()
                        {
                            ID_USUARIO = Convert.ToInt32(dr["ID_USUARIO"]),
                            NOMBRE_USUARIO = dr["NOMBRE_USUARIO"].ToString(),
                            ACTIVO = Convert.ToInt32(dr["ACTIVO"]),  
                        };
                    }
                }
            }

            Con.Cerrar();
            return obj;
        }

        #endregion LOGIN  
    }
}
