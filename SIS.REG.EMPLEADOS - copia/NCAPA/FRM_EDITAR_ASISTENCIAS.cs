using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCAPA
{
    public partial class FRM_EDITAR_ASISTENCIAS : Frm_Base
    {
        public FRM_EDITAR_ASISTENCIAS()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_ASISTENCIAS_Load(object sender, EventArgs e)
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

        private void txx_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
