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



        //Editar Ausencias//

        /* public void EditarAusencias(CE_MAUSENCIAS cE_MAUSENCIAS)
         {

             cD_AUSENCIAS.EditarAusencias(cE_MAUSENCIAS);
         }*/



    }
}
