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
    public class CN_EMPLEADOS
    {
        
 CD_EMPLEADOS CD_empleados = new CD_EMPLEADOS();

 //metodo para listar Departamento//

 public List<CE_MEMPLEADOS> ListarEmpleados()

 {
     return CD_empleados.ListarEmpleados();
 }

 //Insertar///
 public void InsertarEmpleados(CE_MEMPLEADOS cE_Empleados)
 {
     CD_empleados.InsertarEmpleados(cE_Empleados);

 }


       

        public void EditarEmpleados(CE_MEMPLEADOS cE_MEMPLEADOS)
        {

            CD_empleados.EditarEmpleados(cE_MEMPLEADOS);
           
        }

        

    }
}
