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
    public partial class FRM_NUEVO_DEPARTAMENTO : Form
    {
        CN_DEPARTAMENTO cN_DEPARTAMENTO = new CN_DEPARTAMENTO();
        CE_MDEPARTAMENTOS Mdepartamentos = new CE_MDEPARTAMENTOS();

        public FRM_NUEVO_DEPARTAMENTO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_DEPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Enter)
            {
                txtNombre_DEPA.Focus();
                e.Handled = true;

            }
        }

        private void txt_descrip_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnNuevoDepa.Focus();
                e.Handled = true;

            }

        }

        private void btnNuevoDepa_Click(object sender, EventArgs e)
        {
            GUARDARDEPA();
        }

        private void GUARDARDEPA()
        {


            Mdepartamentos.Nombre = txtNombre_DEPA.Text.Trim();
            Mdepartamentos.Descripcion = txt_descrip.Text.Trim();

            /*MDEPARTAMENTOS.FechaINGRESO = Convert.ToDateTime(dptFecha.Value);*/


            cN_DEPARTAMENTO.InsertarDepartamento(Mdepartamentos);
        }

    }
}
