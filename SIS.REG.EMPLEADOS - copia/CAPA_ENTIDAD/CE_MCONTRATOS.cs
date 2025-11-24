using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_MCONTRATOS
    {

        public int Id_contrato { get; set; }

        public int Id_empleado { get; set; }

        public string Tipo_contrato { get; set; }


        public DateTime Fecha_inicio { get; set; }

        public DateTime Fecha_fin {  get; set; }


        public Decimal Salario { get; set; }

    }
}
