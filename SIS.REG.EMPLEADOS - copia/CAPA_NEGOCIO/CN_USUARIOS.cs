using CAPA_DATO;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class CN_USUARIOS
    {

        CD_USUARIOS CD_usuario = new CD_USUARIOS();

        //metodo para listar puesto//

        public List<CE_MUSUARIOS> ListarUsuarios()

        {
            return CD_usuario.ListarUsuarios();
        }

        //Insertar Puesto///
        public void InsertarUsuario(CE_MUSUARIOS cE_MUSUARIOS)
        {
            CD_usuario.InsertarUsuario(cE_MUSUARIOS);

        }

    }
}
