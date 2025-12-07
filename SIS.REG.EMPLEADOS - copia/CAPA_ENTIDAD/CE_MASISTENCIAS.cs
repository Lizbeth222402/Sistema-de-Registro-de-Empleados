using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_MASISTENCIAS
    {

        public int Id_asistencia {  get; set; }
        public int Id_empleado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan? Hora_entrada { get; set; }
        public TimeSpan? Hora_salida { get; set; }
        public string Estado { get; set; }


    }
}
