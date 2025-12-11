using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_MNOMINAS
    {


        public int Id_nomina {  get; set; }
        public string Nombres { get; set; }   
        public string Apellidos { get; set; } 
        public int Id_empleado { get; set; }
        public DateTime Fecha_pago { get; set; }
        public Decimal Salario_bruto { get; set; }
        public Decimal Deducciones { get; set; }
        public Decimal Salario_neto {  get; set; }

    }
}
