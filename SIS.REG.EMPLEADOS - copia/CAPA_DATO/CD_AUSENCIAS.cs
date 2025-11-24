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
    public class CD_AUSENCIAS
    {

        CD_CONEXION Con = new CD_CONEXION();

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



    }
}
