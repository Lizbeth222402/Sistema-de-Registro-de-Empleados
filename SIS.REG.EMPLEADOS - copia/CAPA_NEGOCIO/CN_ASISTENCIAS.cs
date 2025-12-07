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


        //metodo editar//

        
        public void EditarAsistencia(CE_MASISTENCIAS cE_MASISTENCIAS)
        {
            cD_ASISTENCIAS.EditarAsistencia(cE_MASISTENCIAS);
        }


        public void ELIMINARASISTENCIA(CE_MASISTENCIAS cE_MASISTENCIAS)
        {

           cD_ASISTENCIAS.ELIMINARASISTENCIA(cE_MASISTENCIAS);


        }
    }
}