using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;

namespace NCAPA
{
    public partial class FRM_NEW_USUARIO : Form
    {

        CE_MUSUARIOS Musuarios = new CE_MUSUARIOS();
        CN_USUARIOS cN_USUARIOS = new CN_USUARIOS();

        public FRM_NEW_USUARIO()
        {
            InitializeComponent();
        }

        private void txx_cerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            GUARDARUSUARIO();
        }

        private void GUARDARUSUARIO()
        {
            Musuarios.NOMBRE_USUARIO = txt_Nameusuario.Text.Trim();
            Musuarios.CONTRASEÑA = txtpasswork.Text.Trim();
            Musuarios.ACTIVO = chk_ACTIVO.Checked ? 1 : 0;


            cN_USUARIOS.InsertarUsuario(Musuarios);
        }


        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (como Backspace)



            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla

            }
        }
    }
}
