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
    public partial class FRM_EDITAR_ASISTENCIAS : Frm_Base
    {

        CN_ASISTENCIAS xAsistencia = new CN_ASISTENCIAS();
        CE_MASISTENCIAS MasistenciA = new CE_MASISTENCIAS();

        public FRM_EDITAR_ASISTENCIAS()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_ASISTENCIAS_Load(object sender, EventArgs e)
        {
          

        }

        

        private void txx_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnActualizarAsistencia_Click(object sender, EventArgs e)
        {
            ACTUALIZAR();
        }

        private void ACTUALIZAR()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dtp_FechaAsis.Text) 
                    || string.IsNullOrWhiteSpace(dtp_HoraEntra.Text) 
                    || string.IsNullOrWhiteSpace(dtp_HoraSalidadAsistencia.Text) 
                    || string.IsNullOrWhiteSpace(txtEstado.Text))
                {
                    MessageBox.Show("Tienes que llenar todos los campos", "Editar Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MasistenciA.Id_asistencia = Convert.ToInt32(txtid_emp_asistencia.Text);
                    MasistenciA.Fecha =                 dtp_FechaAsis.Value.Date;
                    MasistenciA.Hora_entrada =          dtp_HoraEntra.Value.TimeOfDay;
                    MasistenciA.Hora_salida =           dtp_HoraSalidadAsistencia.Value.TimeOfDay;
                    MasistenciA.Estado =                txtEstado.Text;

                    xAsistencia.EditarAsistencia(MasistenciA);

                    int idAsistencia;
                    if (!int.TryParse(txtid_emp_asistencia.Text, out idAsistencia))
                    {
                        MessageBox.Show("El Id de la asistencia no es válido. Verifica la selección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MasistenciA.Id_asistencia = idAsistencia;



                }


            }
            catch (Exception ex)
            {


                MessageBox.Show("No se editó la asistencia. Error: " + ex.Message,
                 "Editar Asistencia",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);

            }

        }
    }
}
