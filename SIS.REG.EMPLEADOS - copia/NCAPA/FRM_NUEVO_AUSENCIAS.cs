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
    public partial class FRM_NUEVO_AUSENCIAS : Form
    {
        
        CN_AUSENCIAS cN_AUSENCIAS = new CN_AUSENCIAS();
        CE_MAUSENCIAS MAusencias = new CE_MAUSENCIAS();

        public FRM_NUEVO_AUSENCIAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void GUARDARAsistencia()
        {
            MAusencias.Id_empleado = Convert.ToInt32(txt_IdEmP.Text);
            MAusencias.Tipo_ausencia = txtNombre_AUSENCIAS.Text.Trim();
            MAusencias.Fecha_inicio = Convert.ToDateTime(dtp_FechaInic.Value);
            MAusencias.Fecha_fin = Convert.ToDateTime(dtp_FechaFinal.Value);
            MAusencias.Motivo = txt_DescripcionAusencias.Text.Trim();

            cN_AUSENCIAS.InsertarAusencias(MAusencias);

            // Mostrar mensaje de éxito
            MessageBox.Show("La Ausencia se ingresó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void FRM_NUEVO_AUSENCIAS_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarAusencias_Click(object sender, EventArgs e)
        {
            GUARDARAsistencia();
        }
    }
}
