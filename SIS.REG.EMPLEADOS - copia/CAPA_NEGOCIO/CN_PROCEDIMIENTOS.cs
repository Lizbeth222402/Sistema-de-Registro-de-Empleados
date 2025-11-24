using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;

namespace CAPA_NEGOCIO
{
    public class CN_PROCEDIMIENTOS
    {

        CD_PROCEDIMIENTOS CDProcedimiento = new CD_PROCEDIMIENTOS();

        //metodo para listar Empleados//

        public DataTable ListarEmpleados(string procedure)

        {
           return CDProcedimiento.ListarEmpleados(procedure);
                
        }

        //metodo para listar Departamento//

        public DataTable ListarDepartamento(string procedure)

        {
            return CDProcedimiento.ListarDepartamento(procedure);

        }

        //metodo para listar Puesto//

        public DataTable ListarPuestos(string procedure)

        {
            return CDProcedimiento.ListarPuestos(procedure);

        }

        //metodo para listar CONTRATOS//

        public DataTable ListarContratos(string procedure)

        {
            return CDProcedimiento.ListarContratos(procedure);

        }


        //metodo para listar Asistencias//

        public DataTable ListarAsistencias(string procedure)

        {
            return CDProcedimiento.ListarAsistencias(procedure);

        }


        //metodo para listar Ausencias//

        public DataTable ListarAusencias(string procedure)

        {
            return CDProcedimiento.ListarAusencias(procedure);

        }



        //metodo para listar Usuarios//

        public DataTable ListarUsuarios(string procedure)

        {
            return CDProcedimiento.ListarUsuarios(procedure);

        }


    }
}
