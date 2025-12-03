using CAPA_DATO;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class CE_USUARIOS
    {


        CD_USUARIOS objDatos = new CD_USUARIOS();

        public CE_MUSUARIOS Login(string usuario, string clave)
        {
            return objDatos.Login(usuario, clave);
        }
    }
}
