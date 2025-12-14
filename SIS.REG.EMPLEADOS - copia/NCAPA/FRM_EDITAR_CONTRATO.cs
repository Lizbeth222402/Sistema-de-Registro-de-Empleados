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
    public partial class FRM_EDITAR_CONTRATO : Frm_Base
    {
        CN_CONTRATOS XContrato = new CN_CONTRATOS();
        CE_MCONTRATOS MContrato = new CE_MCONTRATOS();

        public FRM_EDITAR_CONTRATO()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_CONTRATO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarNew_Contrato_Click(object sender, EventArgs e)//actualizar
        {
            ActualizarContrato();
        }


        private void ActualizarContrato() 
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtid_CONTRATO.Text) || 
                    string.IsNullOrWhiteSpace(txt_IdeMPLEADO.Text)
                    || string.IsNullOrWhiteSpace(txtNombreCon.Text) 
                    || string.IsNullOrWhiteSpace(dtp_fechaInicio.Text)
                    || string.IsNullOrWhiteSpace(dtp_FechaFin.Text)
                    || string.IsNullOrWhiteSpace(txt_sALARIO.Text))
                {
                    MessageBox.Show("Tienes que llenar todos los campos",
                         "Validación",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
                    return;

                }


                //Validación fechas
                DateTime fechainicio = dtp_fechaInicio.Value.Date;
                DateTime fechafin = dtp_FechaFin.Value.Date;

                if (fechafin < fechainicio)
                {
                    MessageBox.Show("La fecha final no puede ser menor que la fecha inicial",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                //Validación ID contrato
                if (!int.TryParse(txtid_CONTRATO.Text, out int idcontrato))
                {
                    MessageBox.Show("Id de contrato inválido",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //Validación ID EMPLEADO contrato
                if (!int.TryParse(txt_IdeMPLEADO.Text, out int idempleado))
                {
                    MessageBox.Show("Id de empleado inválido",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }


                //Carga de datos al objeto
                MContrato.Id_contrato = idcontrato;
                MContrato.Id_empleado = idempleado;
                MContrato.Tipo_contrato = txtNombreCon.Text.Trim();
                MContrato.Fecha_inicio = fechainicio;
                MContrato.Fecha_fin = fechafin;
                MContrato.Salario = Convert.ToDecimal(txt_sALARIO.Text.Trim());


                //Envío a capa negocio
                XContrato.EditarContrato(MContrato);

                MessageBox.Show(" ✅ Se actualizo correctamente", "Editar Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ No se pudo editar la contrato: " + ex.Message,
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);

            }

        }
    }
}
