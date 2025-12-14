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
                //Validaciones de campos texto
                if (string.IsNullOrWhiteSpace(txtid_Ausencia.Text) ||
                    string.IsNullOrWhiteSpace(txt_IdEmP.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre_AUSENCIAS.Text) ||
                    string.IsNullOrWhiteSpace(txt_motivoAusencias.Text))
                {
                    MessageBox.Show("Tienes que llenar todos los campos",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                //Validación fechas
                DateTime fechaInicio = dtp_FechaInic.Value.Date;
                DateTime fechaFin = dtp_FechaFinal.Value.Date;

                if (fechaFin < fechaInicio)
                {
                    MessageBox.Show("La fecha final no puede ser menor que la fecha inicial",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validación ID AUSENCIA
                if (!int.TryParse(txtid_Ausencia.Text, out int idAusencia))
                {
                    MessageBox.Show("Id de ausencia inválido",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //Validación ID EMPLEADO
                if (!int.TryParse(txt_IdEmP.Text, out int idEmpleado))
                {
                    MessageBox.Show("Id de empleado inválido",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //Carga de datos al objeto
                MAusenicas.Id_ausencia = idAusencia;          
                MAusenicas.Id_empleado = idEmpleado;
                MAusenicas.Tipo_ausencia = txtNombre_AUSENCIAS.Text.Trim();
                MAusenicas.Fecha_inicio = fechaInicio;
                MAusenicas.Fecha_fin = fechaFin;
                MAusenicas.Motivo = txt_motivoAusencias.Text.Trim();

                //Envío a capa negocio
                int resultado = XAusencias.EditarAusencias(MAusenicas);

                if (resultado > 0)
                {
                    MessageBox.Show("✅ Ausencia actualizada correctamente",
                        "Editar Ausencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("⚠ No se encontró el registro para actualizar",
                        "Editar Ausencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ No se pudo editar la ausencia: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



    }
}
