using CAPA_DATO;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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








    }
}
