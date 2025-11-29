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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            GUARDARUSUARIO();
        }


        private void GUARDARUSUARIO ()
        {
            Musuarios.NOMBRE_USUARIO = txtNombre_usuario.Text.Trim();
            Musuarios.CONTRASEÑA = txtpassUsuario.Text.Trim();
            Musuarios.ACTIVO = txtUsuarioActivo.Text.Trim();


            cN_USUARIOS.InsertarUsuario(Musuarios);

        }

        private void txtUsuarioActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }
    }
}
