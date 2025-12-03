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
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {

        }
        

        private void BTN_SALIR_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CHK_MOSTRAR_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CHK_MOSTRAR.Checked)
            {
                // Mostrar texto normal
                TXT_CONTRASEÑA.PasswordChar = '\0';
            }
            else
            {
                // Ocultar con asteriscos
                TXT_CONTRASEÑA.PasswordChar = '*';
            }

        }


        private void BTN_INGRESAR_Click_1(object sender, EventArgs e)
        {
            string usuario = TXT_USUARIO.Text.Trim();
            string clave = TXT_CONTRASEÑA.Text.Trim();

            // Validaciones básicas
            if (usuario == "Ingresar usuario" || usuario == "")
            {
                MessageBox.Show("⚠ Por favor ingrese un usuario.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clave == "Ingresar contraseña" || clave == "")
            {
                MessageBox.Show("⚠ Por favor ingrese una contraseña.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Llamar CAPA NEGOCIO
            CE_USUARIOS negocio = new CE_USUARIOS();
            CE_MUSUARIOS user = negocio.Login(usuario, clave);

            if (user == null)
            {
                MessageBox.Show("❌ Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user.ACTIVO != "True")
            {
                MessageBox.Show("🔒 Este usuario está inactivo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Usuario válido
            MessageBox.Show($"✔ Bienvenido {user.NOMBRE_USUARIO}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir formulario principal
            Frm_Presentacion principal = new Frm_Presentacion();
            principal.Show();

            // Ocultar formulario de login
            this.Hide();
        }

    }

}
