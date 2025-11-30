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
    public partial class FRM_CONTRATO : Frm_Base
    {
        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();

        public FRM_CONTRATO()
        {
            InitializeComponent();
        }

        private void FRM_CONTRATO_Load(object sender, EventArgs e)
        {
            LISTAR_CONTRATOS();
            //Evita que no esta seleccionado por defecto//
            DataGriContratos.ClearSelection();
            
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGriContratos.Columns[1].Width = 145;
            DataGriContratos.Columns[2].Width = 170;
            DataGriContratos.Columns[3].Width = 170;
            DataGriContratos.Columns[4].Width = 170;

        }


        //metodo para alistar//
        private void LISTAR_CONTRATOS()
        {
            DataGriContratos.DataSource = cn_Procedimientos.ListarContratos("Sp_ListarContratos");


        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_CONTRATO AbrirNuevoContrato = new FRM_NUEVO_CONTRATO();
            AbrirNuevoContrato.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FRM_EDITAR_CONTRATO eDITAR_CONTRATO = new FRM_EDITAR_CONTRATO();
            eDITAR_CONTRATO.ShowDialog();
        }
    }
}
