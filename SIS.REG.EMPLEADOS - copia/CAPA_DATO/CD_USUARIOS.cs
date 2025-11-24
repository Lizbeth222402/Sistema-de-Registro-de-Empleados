using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATO
{
    public class CD_USUARIOS
    {

        CD_CONEXION Con = new CD_CONEXION();

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




    }
}
