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
    public partial class FRM_AUSENCIAS : Frm_Base
    {

        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        public FRM_AUSENCIAS()
        {
            InitializeComponent();
        }

        private void FRM_AUSENCIAS_Load(object sender, EventArgs e)
        {
            LISTAR_AUSENCIAS();

            //Evita que no esta seleccionado por defecto//
            DataGridAUSENCIAS.ClearSelection();
            //PARA QUE NO APAREZCA EL ID//
            DataGridAUSENCIAS.Columns[0].Visible = false;
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridAUSENCIAS.Columns[1].Width = 130;
            DataGridAUSENCIAS.Columns[2].Width = 200;
            DataGridAUSENCIAS.Columns[3].Width = 200;
            DataGridAUSENCIAS.Columns[4].Width = 195;
        }


        //metodo para alistar AUSENCIAS//
        private void LISTAR_AUSENCIAS()
        {
            DataGridAUSENCIAS.DataSource = cn_Procedimientos.ListarDepartamento("SP_LISTAR_AUSENCIAS");


        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_AUSENCIAS AbrirNuevaAusencias = new FRM_NUEVO_AUSENCIAS();
            AbrirNuevaAusencias.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FRM_EDITAR_AUSENCIAS eDITAR_AUSENCIAS = new FRM_EDITAR_AUSENCIAS();
            eDITAR_AUSENCIAS.ShowDialog();
        }
    }
}
