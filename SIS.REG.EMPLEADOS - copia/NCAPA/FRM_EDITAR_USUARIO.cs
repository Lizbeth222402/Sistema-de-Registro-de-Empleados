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
    public partial class FRM_EDITAR_USUARIO : Form
    {
        CN_USUARIOS xUSUARIO = new CN_USUARIOS();
        CE_MUSUARIOS Musuario = new CE_MUSUARIOS();

        public FRM_EDITAR_USUARIO()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_USUARIO_Load(object sender, EventArgs e)
        {

        }

        private void txx_cerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {

            try
            {

                if (string.IsNullOrWhiteSpace(txt_Nameusuario.Text) ||
                    string.IsNullOrWhiteSpace(txtpasswork.Text) 
                    || string.IsNullOrWhiteSpace(chk_ACTIVO.Text))
                {
                    MessageBox.Show("Tienes que llenar todos los campos", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    Musuario.ID_USUARIO = Convert.ToInt32(txtid_usuario.Text);
                    Musuario.NOMBRE_USUARIO = txt_Nameusuario.Text;
                    Musuario.CONTRASEÑA = txtpasswork.Text;
                    Musuario.ACTIVO = chk_ACTIVO.Checked ? 1 : 0;

                    xUSUARIO.EditarUsuario(Musuario);
                    MessageBox.Show("Se actualizo correctamente", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo Editar Usuario" + ex.Message, "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void chk_ACTIVO_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
