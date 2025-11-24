using CAPA_DATO;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
