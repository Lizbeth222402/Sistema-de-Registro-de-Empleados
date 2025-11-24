using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDAD;

namespace CAPA_DATO
{
    public class CD_ASISTENCIAS
    {

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





    }
}
