using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAPA_DATO
{
    public class CD_NOMINAS  
    {
        CD_CONEXION Con = new CD_CONEXION();

    public List<CE_MNOMINAS> ListarNominas()
    {
        var oList = new List<CE_MNOMINAS>();

        using (SqlCommand cmd = new SqlCommand("SP_LISTAR_NOMINAS", Con.Abrir()))
        {

            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    oList.Add(new CE_MNOMINAS()
                    {

                        Id_nomina = Convert.ToInt32(dr["Id_nomina"]),
                        Id_empleado = Convert.ToInt32(dr["Id_empleado"]),
                        Fecha_pago = Convert.ToDateTime(dr["Fecha_pago"]),
                        Salario_bruto = Convert.ToDecimal(dr["Salario_bruto"]),
                        Deducciones = Convert.ToDecimal(dr["Deducciones"]),
                        Salario_neto = Convert.ToDecimal(dr["Salario_neto"])

                    });


                }
            }
        }
        return oList;

    }




}
}
