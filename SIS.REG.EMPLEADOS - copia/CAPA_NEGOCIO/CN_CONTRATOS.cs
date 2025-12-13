using CAPA_DATO;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
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
    public class CN_CONTRATOS
    {

        CD_CONTRATOS cD_CONTRATOS = new CD_CONTRATOS();


        //metodo para listar //

        public List<CE_MCONTRATOS> ListarContratos()

        {
            return cD_CONTRATOS.ListarContratos();
        }

        //Insertar///
        public void InsertarContrato(CE_MCONTRATOS cE_MCONTRATOS)
        {
            cD_CONTRATOS.InsertarContrato(cE_MCONTRATOS);

        }

        
        //editar/contrato/
        public void EditarContrato(CE_MCONTRATOS cE_Mcontratos)
        {
            cD_CONTRATOS.EditarContrato(cE_Mcontratos);
            
        }

        //eliminar
        public void ELIMINARCONTRATO(CE_MCONTRATOS cE_MCONTRATOS)
        {

           cD_CONTRATOS.ELIMINARCONTRATO(cE_MCONTRATOS);

        }

        public DataTable ListarContrato()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "Sp_ListarContratos",
                new CD_CONEXION().Abrir());

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Método para filtrar SOLO por tipo de contrato
        public DataTable FiltrarPorTipo(string valor)
        {
            if (string.IsNullOrEmpty(valor)) return new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "SP_FILTRAR_CONTRATOS",
                new CD_CONEXION().Abrir());

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Tipo", valor);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
