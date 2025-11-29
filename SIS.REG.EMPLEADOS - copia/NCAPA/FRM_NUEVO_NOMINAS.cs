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
    public partial class FRM_NUEVO_NOMINAS : Form
    {


        CN_NOMINAS cN_NOMINAS = new CN_NOMINAS();
        CE_MNOMINAS Mnominas = new CE_MNOMINAS();

        public FRM_NUEVO_NOMINAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Salari_Neto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewNominas_Click(object sender, EventArgs e)
        {
            GUARDARNominas();
        }


        private void GUARDARNominas()
        {
            Mnominas.Id_empleado = Convert.ToInt32(txt_IdemplNominas.Text);
            Mnominas.Fecha_pago = Convert.ToDateTime(dtp_FechaPago.Value);
            Mnominas.Salario_bruto = Convert.ToDecimal(txt_Salario_Bru.Text);
            Mnominas.Deducciones = Convert.ToDecimal(txt_Deducc.Text);
            Mnominas.Salario_neto = Convert.ToDecimal(txt_Salari_Neto.Text);


            cN_NOMINAS.InsertarNominas(Mnominas);

        }
    }
}
