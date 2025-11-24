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

namespace NCAPA
{
    public partial class FRM_ASISTENCIAS : Frm_Base
    {

        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        public FRM_ASISTENCIAS()
        {
            InitializeComponent();
        }

        private void FRM_ASISTENCIAS_Load(object sender, EventArgs e)
        {
            LISTAR_ASISTENCIA();
            //Evita que no esta seleccionado por defecto//
            DataGridAsistencia.ClearSelection();
            //PARA QUE NO APAREZCA EL ID//
            DataGridAsistencia.Columns[0].Visible = false;
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridAsistencia.Columns[1].Width = 130;
            DataGridAsistencia.Columns[2].Width = 200;
            DataGridAsistencia.Columns[3].Width = 200;
            DataGridAsistencia.Columns[4].Width = 205;
            
        }




        //metodo para alistar//
        private void LISTAR_ASISTENCIA()
        {
            DataGridAsistencia.DataSource = cn_Procedimientos.ListarAsistencias("SP_LISTAR_ASISTENCIAS");


        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_ASISTENCIA AbrirNuevoAsistencia = new FRM_NUEVO_ASISTENCIA();
            AbrirNuevoAsistencia.ShowDialog();
        }
    }
}
