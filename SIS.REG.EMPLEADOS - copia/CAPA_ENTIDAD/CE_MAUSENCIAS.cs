using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_MAUSENCIAS
    {

        public int Id_ausencia {  get; set; }
        public int Id_empleado { get; set; }
        public string Tipo_ausencia { get; set; }

        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin {  get; set; }
        public string Motivo {  get; set; }


    }
}
