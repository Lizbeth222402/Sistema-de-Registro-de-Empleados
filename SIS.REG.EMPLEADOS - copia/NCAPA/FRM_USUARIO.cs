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
    public partial class FRM_USUARIO : Form
    {

        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        
        public FRM_USUARIO()
        {
            InitializeComponent();
        }

        private void FRM_USUARIO_Load(object sender, EventArgs e)
        {
            LISTAR_USUARIOS();
            //Evita que no esta seleccionado por defecto//
            dataGridUsuaios.ClearSelection();
            
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            dataGridUsuaios.Columns[1].Width = 150;
            dataGridUsuaios.Columns[2].Width = 150;
            
        }



        //metodo para alistar//
        private void LISTAR_USUARIOS()
        {
            dataGridUsuaios.DataSource = cn_Procedimientos.ListarEmpleados("SP_LISTAR_USUARIO");


        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Usuario_Click(object sender, EventArgs e)
        {
            FRM_EDITAR_USUARIO eDITAR_USUARIO = new FRM_EDITAR_USUARIO();
            eDITAR_USUARIO.ShowDialog();
            
            /*CargarDatos();*/
        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NEW_USUARIO AbrirNewUsuario = new FRM_NEW_USUARIO();
            AbrirNewUsuario.ShowDialog();
        }

        /*
        private void CargarDatos()
            
        {
            try
            {
                if(dataGridUsuaios.SelectedCells.Count)
                {

                }
                else
                {
                    FRM_USUARIO AbrirUsuario = new FRM_USUARIO();
                    AbrirUsuario.txtBusqueda.Text = dataGridUsuaios.SelectedRows[0].Cells[0].Value.ToString();
                    AbrirUsuario.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el Usuario" , MessageBoxButtons.OK,MessageBoxIcon)


            }

           
        }
        */
    }
}
