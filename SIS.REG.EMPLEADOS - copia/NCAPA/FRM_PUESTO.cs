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
    public partial class FRM_PUESTO : Frm_Base
    {


        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        public FRM_PUESTO()
        {
            InitializeComponent();
        }

        private void FRM_PUESTO_Load(object sender, EventArgs e)
        {
            LISTAR_PUESTO();
            
            //Evita que no esta seleccionado por defecto//
            DataGridPuesto.ClearSelection();
            //PARA QUE NO APAREZCA EL ID//
            DataGridPuesto.Columns[0].Visible = false;
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridPuesto.Columns[1].Width = 130;
            DataGridPuesto.Columns[2].Width = 130;
            DataGridPuesto.Columns[3].Width = 130;

        }


        //metodo para alistar Puesto//
        private void LISTAR_PUESTO()
        {
            DataGridPuesto.DataSource = cn_Procedimientos.ListarPuestos("Sp_ListarPuestos");

        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void DataGridPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_PUESTO AbrirNuevopuesto = new FRM_NUEVO_PUESTO();
            AbrirNuevopuesto.ShowDialog();
        }
    }
}
