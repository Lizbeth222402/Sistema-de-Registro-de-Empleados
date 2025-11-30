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
    public partial class FRM_DEPARTAMENTO : Frm_Base
    {

        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        public FRM_DEPARTAMENTO()
        {
            InitializeComponent();
        }

        private void FRM_DEPARTAMENTO_Load(object sender, EventArgs e)
        {
            LISTAR_DEPARTAMENTOS();
            //Evita que no esta seleccionado por defecto//
            DataGridDepartamento.ClearSelection();
            
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridDepartamento.Columns[1].Width = 170;
            DataGridDepartamento.Columns[2].Width = 400;
           

        }



        //metodo para alistar Departamento//
        private void LISTAR_DEPARTAMENTOS()
        {
            DataGridDepartamento.DataSource = cn_Procedimientos.ListarDepartamento("Sp_ListarDepartamentos");


        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_DEPARTAMENTO AbrirNuevoDepartamento = new FRM_NUEVO_DEPARTAMENTO();
            AbrirNuevoDepartamento.ShowDialog();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FRM_EDITAR_DEPA eDITAR_DEPA = new FRM_EDITAR_DEPA();
            eDITAR_DEPA.ShowDialog();
        }
    }
}
