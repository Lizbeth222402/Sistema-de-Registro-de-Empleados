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
    public class CN_PUESTO
    {


        CD_PUESTO CD_puesto= new CD_PUESTO();

        //metodo para listar puesto//

        public List<CE_MPUESTOS> ListarPuesto()

        {
            return CD_puesto.ListarPuesto();
        }

        //Insertar Puesto///
        public void InsertarPuesto(CE_MPUESTOS cE_MPUESTOS)
        {
            CD_puesto.InsertarPuesto(cE_MPUESTOS);

        }

       
        public void EditarPuesto(CE_MPUESTOS cE_MPUESTOS)
        {

            CD_puesto.EditarPuesto(cE_MPUESTOS);
        }

        public DataTable FiltrarPorNombre(string valor)
        {
            if (string.IsNullOrEmpty(valor)) return new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Id_puesto, Nombre_puesto, Descripcion, Salario_base " +
                "FROM Puestos " +
                "WHERE Nombre_puesto LIKE @valor + '%'",
                new CD_CONEXION().Abrir());

            da.SelectCommand.Parameters.AddWithValue("@valor", valor);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




    }
}
