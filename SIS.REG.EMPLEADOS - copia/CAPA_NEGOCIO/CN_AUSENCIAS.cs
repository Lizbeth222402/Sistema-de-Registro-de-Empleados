using CAPA_DATO;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class CN_AUSENCIAS
    {

        CD_AUSENCIAS cD_AUSENCIAS = new CD_AUSENCIAS();

        //metodo para listar Asencias//

        public List<CE_MAUSENCIAS> ListarAusencias()

        {
            return cD_AUSENCIAS.ListarAusencias();
        }

        //Insertar Asencias///
        public void InsertarAusencias(CE_MAUSENCIAS cE_MAUSENCIAS)
        {
            cD_AUSENCIAS.InsertarAusencias(cE_MAUSENCIAS);

        }


        public int EditarAusencias(CE_MAUSENCIAS cE_MAUSENCIAS)
        {
            return cD_AUSENCIAS.EditarAusencias(cE_MAUSENCIAS);
        }


        
        public void ELIMINARAUSENSIA(CE_MAUSENCIAS cE_MAUSENCIAS)
        {

           cD_AUSENCIAS.ELIMINARAUSENSIA(cE_MAUSENCIAS);


        }




        //Editar Ausencias//

        /* public void EditarAusencias(CE_MAUSENCIAS cE_MAUSENCIAS)
         {

             cD_AUSENCIAS.EditarAusencias(cE_MAUSENCIAS);
         }*/


        public DataTable FiltrarAusencias(string criterio, string valor)
        {
            SqlDataAdapter da;

            if (criterio == "Tipo")
            {
                da = new SqlDataAdapter(
                    "SELECT a.Id_ausencia, e.Nombres, e.Apellidos, a.Tipo_ausencia, a.Fecha_inicio, a.Fecha_fin, a.Motivo " +
                    "FROM Ausencias a " +
                    "INNER JOIN Empleados e ON a.Id_empleado = e.Id_empleado " +
                    "WHERE a.Tipo_ausencia LIKE @valor + '%'",
                    new CD_CONEXION().Abrir());
            }

            else
            {
                da = new SqlDataAdapter(
                    "SELECT a.Id_ausencia, e.Nombres, e.Apellidos, a.Tipo_ausencia, a.Fecha_inicio, a.Fecha_fin, a.Motivo " +
                    "FROM Ausencias a " +
                    "INNER JOIN Empleados e ON a.Id_empleado = e.Id_empleado",
                    new CD_CONEXION().Abrir());
            }

            da.SelectCommand.Parameters.AddWithValue("@valor", valor);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




    }
}
