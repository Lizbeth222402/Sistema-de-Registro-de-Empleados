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
    public partial class FRM_NUEVO_CONTRATO : Form
    {

        CN_CONTRATOS cN_CONTRATOS = new CN_CONTRATOS(); 
        CE_MCONTRATOS Mcontratos = new CE_MCONTRATOS();

        public FRM_NUEVO_CONTRATO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarNew_Contrato_Click(object sender, EventArgs e)
        {
            GUARDARContrato();
        }



        private void GUARDARContrato()
        {
            Mcontratos.Id_empleado =  Convert.ToInt32(txt_IdeMPLEADO.Text);
            Mcontratos.Tipo_contrato = txtNombreCon.Text.Trim();
            Mcontratos.Fecha_inicio = Convert.ToDateTime(dtp_fechaInicio.Value);
            Mcontratos.Fecha_fin = Convert.ToDateTime(dtp_FechaFin.Value);
            Mcontratos.Salario = Convert.ToDecimal(txt_sALARIO.Text);



        }
    }
}
