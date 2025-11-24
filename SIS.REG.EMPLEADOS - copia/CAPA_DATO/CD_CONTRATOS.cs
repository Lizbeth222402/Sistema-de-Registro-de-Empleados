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
    public class CD_CONTRATOS
    {

        CD_CONEXION Con = new CD_CONEXION();

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



    }
}
