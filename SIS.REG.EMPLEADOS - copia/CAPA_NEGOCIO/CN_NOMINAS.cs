using CAPA_DATO;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
