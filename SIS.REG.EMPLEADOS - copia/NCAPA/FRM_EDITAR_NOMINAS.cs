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
    public partial class FRM_EDITAR_NOMINAS : Frm_Base
    {
        CN_NOMINAS Xnominas = new CN_NOMINAS();
        CE_MNOMINAS Mnominas = new CE_MNOMINAS();
        
        /*LLORE MAS OTRO QUE SE ACTUALIZA SIN COMPLICARME LA CABEZA*/

        public FRM_EDITAR_NOMINAS()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_NOMINAS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarNominas_Click(object sender, EventArgs e)
        {
            ActualizarNomina();
        }

        private void ActualizarNomina()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_IdemplNominas.Text) || string.IsNullOrWhiteSpace(dtp_FechaPago.Text) || string.IsNullOrWhiteSpace(txt_Salario_Bru.Text)
                    || string.IsNullOrWhiteSpace(txt_Deducc.Text) || string.IsNullOrWhiteSpace(txt_Salari_Neto.Text))
                {
                    MessageBox.Show("Tienes que llenar todos los campos", "Editar Nominas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    Mnominas.Id_nomina = Convert.ToInt32(txtid_Nmina.Text);
                    Mnominas.Id_empleado = Convert.ToInt32(txt_IdemplNominas.Text);
                    Mnominas.Fecha_pago = dtp_FechaPago.Value;
                    Mnominas.Salario_bruto = Convert.ToDecimal(txt_Salario_Bru.Text);
                    Mnominas.Deducciones = Convert.ToDecimal(txt_Deducc.Text);
                    Mnominas.Salario_neto = Convert.ToDecimal(txt_Salari_Neto.Text);

                    Xnominas.EditarNominas(Mnominas);

                    MessageBox.Show("Se actualizo correctamente", "Editar Nominas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo Editar Nominas" + ex.Message, "Editar Nominas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
