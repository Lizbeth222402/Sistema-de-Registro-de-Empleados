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
    public partial class FRM_NOMINAS : Frm_Base
    {


        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        public FRM_NOMINAS()
        {
            InitializeComponent();
        }

        private void FRM_NOMINAS_Load(object sender, EventArgs e)
        {
            LISTAR_NOMINAS();
            //Evita que no esta seleccionado por defecto//
            DataGridAusencias.ClearSelection();
            //PARA QUE NO APAREZCA EL ID//
            DataGridAusencias.Columns[0].Visible = false;
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridAusencias.Columns[1].Width = 130;
            DataGridAusencias.Columns[2].Width = 130;
            DataGridAusencias.Columns[3].Width = 130;
            DataGridAusencias.Columns[4].Width = 130;


        }



        //metodo para alistar AUSENCIAS//
        private void LISTAR_NOMINAS()
        {
            DataGridAusencias.DataSource = cn_Procedimientos.ListarDepartamento("SP_LISTAR_NOMINAS");


        }




        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_NOMINAS AbrirNuevaNominas = new FRM_NUEVO_NOMINAS();
            AbrirNuevaNominas.ShowDialog();
        }
    }
}
