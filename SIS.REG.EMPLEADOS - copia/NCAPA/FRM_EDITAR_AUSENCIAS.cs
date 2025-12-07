using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CAPA_ENTIDAD;

namespace NCAPA
{
    public partial class FRM_EDITAR_AUSENCIAS : Frm_Base
    {

        CN_AUSENCIAS XAusencias = new CN_AUSENCIAS();
        CE_MAUSENCIAS MAusenicas = new CE_MAUSENCIAS();   

        public FRM_EDITAR_AUSENCIAS()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_AUSENCIAS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarAusencias_Click(object sender, EventArgs e)
        {
            ActualizarAusencia();
        }

        private void ActualizarAusencia()

        {

            try
            {

                if(string.IsNullOrWhiteSpace(txt_IdEmP.Text) || string.IsNullOrWhiteSpace(txtNombre_AUSENCIAS.Text) || string.IsNullOrWhiteSpace(dtp_FechaInic.Text) || string.IsNullOrWhiteSpace(dtp_FechaFinal.Text)
                    || string.IsNullOrWhiteSpace(txt_motivoAusencias.Text))
                {
                    MessageBox.Show("Tienes que llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else

                {
                   
                    MAusenicas.Id_empleado = Convert.ToInt32(txt_IdEmP.Text);
                    MAusenicas.Tipo_ausencia = txtNombre_AUSENCIAS.Text;
                    MAusenicas.Fecha_inicio = dtp_FechaInic.Value;
                    MAusenicas.Fecha_fin = dtp_FechaFinal.Value;
                    MAusenicas.Motivo = txt_motivoAusencias.Text;


                    /*XAusencias.EditarAusencias(MAusenicas);*/
                    int resultado = XAusencias.EditarAusencias(MAusenicas);

                    if (resultado > 0)
                    {

                        MessageBox.Show("Se actualizo correctamente", "Editar Ausencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();

                    }
                    else
                    {

                        MessageBox.Show("No se encontró el registro para actualizar", "Editar Ausencias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se puedo Editar El Cliente" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }
    }
}
