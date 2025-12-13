using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
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
    public partial class FRM_NUEVO_PUESTO : Form
    {

        CN_PUESTO cE_MPUESTOS = new CN_PUESTO();
        CE_MPUESTOS MPUESTOS = new CE_MPUESTOS();


        public FRM_NUEVO_PUESTO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_Puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)Keys.Enter)
            {
                txtNombre_Puesto.Focus();
                e.Handled = true;
            }

        }

        private void txt_des_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_des_puesto.Focus();
                e.Handled = true;
            }
        }

        private void txt_Salar_base_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_Salar_base.Focus();
                e.Handled = true;
            }

        }

        private void btnGuardarPuesto_Click(object sender, EventArgs e)
        {
            GUARDARPUESTO();
        }


        private void GUARDARPUESTO()
        {


            MPUESTOS.Nombre_puesto = txtNombre_Puesto.Text.Trim();
            MPUESTOS.Descripcion = txt_des_puesto.Text.Trim();
            MPUESTOS.Salario_base = Convert.ToDecimal(txt_Salar_base.Text);

            /*MDEPARTAMENTOS.FechaINGRESO = Convert.ToDateTime(dptFecha.Value);*/


            cE_MPUESTOS.InsertarPuesto(MPUESTOS);
            // Mostrar mensaje de éxito
            MessageBox.Show("El Puesto se ingresó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FRM_NUEVO_PUESTO_Load(object sender, EventArgs e)
        {

        }
    }
}
