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
    public class CN_DEPARTAMENTO
    {

        CD_DEPARTAMENTO CD_departamento = new CD_DEPARTAMENTO();

        //metodo para listar Departamento//

        public List<CE_MDEPARTAMENTOS> ListarDepartamento()

        {
            return CD_departamento.ListarDepartamento();
        }

        //Insertar///
        public void InsertarDepartamento(CE_MDEPARTAMENTOS cE_MDEPARTAMENTOS)
        {
            CD_departamento.InsertarDepartamento(cE_MDEPARTAMENTOS);

        }


        

        public void EditarDepartamento(CE_MDEPARTAMENTOS cE_MDEPARTAMENTOS)
        {

            CD_departamento.EditarDepartamento(cE_MDEPARTAMENTOS);
        }

       
        public void ELIMINARDEPARTAMENTO(CE_MDEPARTAMENTOS cE_MDEPARTAMENTOS)
        {

            CD_departamento.ELIMINARDEPARTAMENTO(cE_MDEPARTAMENTOS);


        }


        public DataTable FiltrarPorNombre(string valor)
        {
            if (string.IsNullOrEmpty(valor)) return new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Id_departamento, Nombre, Descripcion " +
                "FROM Departamentos " +
                "WHERE Nombre LIKE @valor + '%'",
                new CD_CONEXION().Abrir());

            da.SelectCommand.Parameters.AddWithValue("@valor", valor);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }








    }
}
