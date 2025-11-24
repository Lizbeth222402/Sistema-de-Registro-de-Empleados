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

namespace CAPA_NEGOCIO
{
    public class CN_DEPARTAMENTO
    {

        CD_DEPARTAMENTO CD_departamento = new CD_DEPARTAMENTO();

        //metodo para listar Departamento//

        public List<CE_MDEPARTAMENTOS> ListarDepartamento()

        {
            return CD_departamento.ListarDepartamento();
        }

        //Insertar///
        public void InsertarDepartamento(CE_MDEPARTAMENTOS cE_MDEPARTAMENTOS)
        {
            CD_departamento.InsertarDepartamento(cE_MDEPARTAMENTOS);

        }

    }
}
