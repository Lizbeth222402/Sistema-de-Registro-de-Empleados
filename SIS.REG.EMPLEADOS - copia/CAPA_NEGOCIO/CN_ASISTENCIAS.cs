using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class CN_ASISTENCIAS
    {
        CD_ASISTENCIAS cD_ASISTENCIAS = new CD_ASISTENCIAS();

        //metodo para listar Asistencia//

        public List<CE_MASISTENCIAS> ListarAsistencias()

        {
            return cD_ASISTENCIAS.ListarAsistencias();
        }

        //Insertar///
        public void InsertarAsistencia(CE_MASISTENCIAS cE_MASISTENCIAS)
        {
            cD_ASISTENCIAS.InsertarAsistencia(cE_MASISTENCIAS);

        }

    }
}