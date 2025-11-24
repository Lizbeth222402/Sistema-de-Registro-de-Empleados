using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CAPA_ENTIDAD
{
    public class CE_MEMPLEADOS
    {
        public int Id_empleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public int Id_departamento { get; set; }
        public int Id_puesto { get; set; }



    }


    
}
