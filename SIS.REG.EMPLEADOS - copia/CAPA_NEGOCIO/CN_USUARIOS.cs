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

        public void EditarUsuario(CE_MUSUARIOS cE_MUSUARIOS)
        {

            CD_usuario.EditarUsuario(cE_MUSUARIOS);
        }


        public DataTable ListarUsuario()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SP_LISTAR_USUARIO",
                new CD_CONEXION().Abrir());

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Método para filtrar SOLO por nombre de usuario
        public DataTable FiltrarPorNombre(string valor)
        {
            if (string.IsNullOrEmpty(valor)) return new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "SP_FILTRAR_USUARIOS",
                new CD_CONEXION().Abrir());

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Nombre", valor);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



    }
}
