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
            this.Load += FRM_NUEVO_ASISTENCIA_Load;
        }




        private void FRM_NUEVO_ASISTENCIA_Load(object sender, EventArgs e)
        {
            // Fecha normal
            dtp_FechaAsis.Format = DateTimePickerFormat.Short;

            // Hora entrada
            dtp_HoraEntrada.Format = DateTimePickerFormat.Custom;
            dtp_HoraEntrada.CustomFormat = "HH:mm:ss";
            dtp_HoraEntrada.ShowUpDown = true;

            // Hora salida
            dtp_HoraSalida.Format = DateTimePickerFormat.Custom;
            dtp_HoraSalida.CustomFormat = "HH:mm:ss";
            dtp_HoraSalida.ShowUpDown = true;
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
            // Fecha correcta (solo la fecha sin hora)
            Masistencias.Fecha = dtp_FechaAsis.Value.Date;

            // Hora entrada (solo time)
            Masistencias.Hora_entrada = dtp_HoraEntrada.Value.TimeOfDay;

            // Hora salida (solo time)
            Masistencias.Hora_salida = dtp_HoraSalida.Value.TimeOfDay;

            // Estado (texto)
            Masistencias.Estado = txtEstado.Text.Trim();

            // Guardar
            cN_ASISTENCIAS.InsertarAsistencia(Masistencias);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
