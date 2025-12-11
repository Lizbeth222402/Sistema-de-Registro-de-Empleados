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
    public class CN_NOMINAS
    {

        CD_NOMINAS CD_nominas = new CD_NOMINAS();


        //metodo para listar //

        public List<CE_MNOMINAS> ListarNominas()

        {
            return CD_nominas.ListarNominas();
        }

        //Insertar///
        public void InsertarNominas(CE_MNOMINAS cE_MNOMINAS)
        {
            CD_nominas.InsertarNominas(cE_MNOMINAS);

        }


        public void EditarNominas(CE_MNOMINAS cE_MNOMINAS)
        {
            CD_nominas.EditarNominas(cE_MNOMINAS);
            
        }


        public DataTable FiltrarNominaPorEmpleado(string empleado)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT n.Id_nomina, e.Nombres, e.Apellidos, n.Fecha_pago, n.Salario_bruto, n.Deducciones, n.Salario_neto " +
                "FROM Nominas n " +
                "INNER JOIN Empleados e ON n.Id_empleado = e.Id_empleado " +
                "WHERE e.Nombres LIKE @empleado + '%'",
                new CD_CONEXION().Abrir());

            da.SelectCommand.Parameters.AddWithValue("@empleado", empleado);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




    }
}
