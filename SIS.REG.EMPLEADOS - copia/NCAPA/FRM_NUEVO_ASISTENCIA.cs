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
    public partial class FRM_NUEVO_ASISTENCIA : Form
    {


        CN_ASISTENCIAS cN_ASISTENCIAS = new CN_ASISTENCIAS();
        CE_MASISTENCIAS Masistencias = new CE_MASISTENCIAS();

        public FRM_NUEVO_ASISTENCIA()
        {
            InitializeComponent();
        }

        private void FRM_NUEVO_ASISTENCIA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarAsistencia_Click(object sender, EventArgs e)
        {
            GUARDARAISTENCIAS();
        }

        public void GUARDARAISTENCIAS()
        {

            Masistencias.Fecha = Convert.ToDateTime(dtp_FechaAsis.Text);
            Masistencias.Hora_entrada = Convert.ToDateTime(dtp_HoraEntrada.Text);
            Masistencias.Hora_salida = Convert.ToDateTime(dtp_HoraSalida.Text);
            Masistencias.Estado = txtEstado.Text.Trim();


        }
    }
}
