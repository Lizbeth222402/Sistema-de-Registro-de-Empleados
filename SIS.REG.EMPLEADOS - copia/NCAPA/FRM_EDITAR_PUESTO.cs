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
    public partial class FRM_EDITAR_PUESTO : Frm_Base
    {

        /*NO HAY QUE RENDIRSCE FACILMENTE SIGUE ADELANTE*/

        CN_PUESTO xPUESTO = new CN_PUESTO();
        CE_MPUESTOS Mpuesto = new CE_MPUESTOS();
      

        public FRM_EDITAR_PUESTO()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_PUESTO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarPuesto_Click(object sender, EventArgs e)
        {
            ActualizarPuesto();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
        }

        private void ActualizarPuesto()
        {

            try
            {

                if (string.IsNullOrWhiteSpace(txtNombre_Puesto.Text) || 
                    string.IsNullOrWhiteSpace(txt_des_puesto.Text) ||
                    string.IsNullOrWhiteSpace(txt_Salar_base.Text))
                    
                {
                    MessageBox.Show("Tienes que llenar todos los campos", "Editar Puesto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Mpuesto.Id_puesto = Convert.ToInt32(txtid_puesto.Text);
                    Mpuesto.Nombre_puesto = txtNombre_Puesto.Text;
                    Mpuesto.Descripcion = txt_des_puesto.Text;
                    Mpuesto.Salario_base = Convert.ToDecimal(txt_Salar_base.Text);


                    xPUESTO.EditarPuesto(Mpuesto);

                    MessageBox.Show("Se actualizo correctamente", "Editar Puesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo Editar Puesto" + ex.Message, "Editar Puesto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
