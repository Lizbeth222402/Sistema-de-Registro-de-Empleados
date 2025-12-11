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

                if (string.IsNullOrWhiteSpace(txtid_CONTRATO.Text) || string.IsNullOrWhiteSpace(txtNombreCon.Text)
                    || string.IsNullOrWhiteSpace(dtp_fechaInicio.Text) || string.IsNullOrWhiteSpace(dtp_FechaFin.Text)
                    || string.IsNullOrWhiteSpace(txt_sALARIO.Text))
                {
                    MessageBox.Show("Tienes que llenar todos los campos", "Editar Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int idContrato, idEmpleado;
                    decimal salario;

                    if (!int.TryParse(txtid_CONTRATO.Text, out idContrato))
                    {
                        MessageBox.Show("El Id del contrato no es válido.");
                        return;
                    }

                    if (!int.TryParse(txt_IdeMPLEADO.Text, out idEmpleado))
                    {
                        MessageBox.Show("El Id del empleado no es válido.");
                        return;
                    }

                    if (!decimal.TryParse(txt_sALARIO.Text, out salario))
                    {
                        MessageBox.Show("El salario no tiene un formato correcto.");
                        return;
                    }

                    MContrato.Id_contrato = idContrato;
                    MContrato.Id_empleado = idEmpleado;
                    MContrato.Salario = salario;

                    XContrato.EditarContrato(MContrato);

                    MessageBox.Show("Se actualizo correctamente", "Editar Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo Editar El Contrato" + ex.Message, "Editar Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
