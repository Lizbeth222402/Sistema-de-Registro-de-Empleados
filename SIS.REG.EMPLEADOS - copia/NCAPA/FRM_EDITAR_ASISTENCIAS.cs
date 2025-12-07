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

            // FECHA normal
            dtp_FechaAsis.Format = DateTimePickerFormat.Short;

            // HORA ENTRADA
            dtp_HoraEntra.Format = DateTimePickerFormat.Custom;
            dtp_HoraEntra.CustomFormat = "HH:mm";
            dtp_HoraEntra.ShowUpDown = true;

            // HORA SALIDA
            dtp_HoraSalidadAsistencia.Format = DateTimePickerFormat.Custom;
            dtp_HoraSalidadAsistencia.CustomFormat = "HH:mm";
            dtp_HoraSalidadAsistencia.ShowUpDown = true;
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
                // validar estado
                if (string.IsNullOrWhiteSpace(txtEstado.Text))
                {
                    MessageBox.Show("Debes ingresar el estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // validar horas
                TimeSpan horaEntrada = dtp_HoraEntra.Value.TimeOfDay;
                TimeSpan horaSalida = dtp_HoraSalidadAsistencia.Value.TimeOfDay;
                if (horaSalida <= horaEntrada)
                {
                    MessageBox.Show("La hora de salida debe ser mayor que la hora de entrada.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // parsear IDs — Id_asistencia (PK) y Id_empleado
                if (!int.TryParse(txtIdAsistencia.Text, out int idAsistencia))
                {
                    MessageBox.Show("Id de asistencia inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtid_emp_asistencia.Text, out int idEmpleado))
                {
                    MessageBox.Show("Id de empleado inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MasistenciA.Id_asistencia = idAsistencia;
                MasistenciA.Id_empleado = idEmpleado;
                MasistenciA.Fecha = dtp_FechaAsis.Value.Date;
                MasistenciA.Hora_entrada = dtp_HoraEntra.Value.TimeOfDay;
                MasistenciA.Hora_salida = dtp_HoraSalidadAsistencia.Value.TimeOfDay;
                MasistenciA.Estado = txtEstado.Text.Trim();

                // ✅ Enviar a la capa negocio
                xAsistencia.EditarAsistencia(MasistenciA);

                // ✅ Confirmación
                MessageBox.Show("✅ Asistencia actualizada correctamente",
                    "Editar Asistencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // ✅ Cerrar formulario
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ No se pudo editar la asistencia: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}