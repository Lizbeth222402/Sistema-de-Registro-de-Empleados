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
    public partial class FRM_EDITAR_DEPA : Frm_Base
    {

        CN_DEPARTAMENTO Xdepa = new CN_DEPARTAMENTO();
        CE_MDEPARTAMENTOS MDEPARTAMENTOS = new CE_MDEPARTAMENTOS();

        public FRM_EDITAR_DEPA()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_DEPA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /* EL PRIMERO QUE ME ACTUALIZA QUIERO LLORAR*/
        private void btnActualizarDepa_Click(object sender, EventArgs e)
        {
            ActualizarDepartamento();

        }

        private void ActualizarDepartamento()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtNombre_DEPA.Text) || string.IsNullOrWhiteSpace(txt_descrip.Text))
                {
                    MessageBox.Show("Tienes que llenar todos los campos", "Editar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    MDEPARTAMENTOS.Id_departamento = Convert.ToInt32(txtid_.Text);
                    MDEPARTAMENTOS.Nombre = txtNombre_DEPA.Text;
                    MDEPARTAMENTOS.Descripcion = txt_descrip.Text;

                    Xdepa.EditarDepartamento(MDEPARTAMENTOS);

                    MessageBox.Show("Se actualizo correctamente", "Editar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo Editar El Departamento" + ex.Message, "Editar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
