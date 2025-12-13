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
            //dataGridUsuaios.Columns[3].Width = 150;



            // Cabecera
            dataGridUsuaios.EnableHeadersVisualStyles = false;
            dataGridUsuaios.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dataGridUsuaios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridUsuaios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            dataGridUsuaios.BackgroundColor = Color.White;

            // Filas alternadas
            dataGridUsuaios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            dataGridUsuaios.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridUsuaios.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            dataGridUsuaios.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            dataGridUsuaios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridUsuaios.GridColor = Color.LightGray;

        }



        //metodo para alistar//
        private void LISTAR_USUARIOS()
        {
            dataGridUsuaios.DataSource = cn_Procedimientos.ListarUsuarios("SP_LISTAR_USUARIO");


        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Usuario_Click(object sender, EventArgs e)
        {

            Editar();
        }

        private void Editar()
        {

            if (dataGridUsuaios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Usuario");

            }
            else
            {
                try
                {
                    FRM_EDITAR_USUARIO eDITAR_USUARIO = new FRM_EDITAR_USUARIO();


                    eDITAR_USUARIO.txtid_usuario.Text =
                    dataGridUsuaios.SelectedRows[0].Cells[0].Value.ToString();

                    eDITAR_USUARIO.txt_Nameusuario.Text = 
                        dataGridUsuaios.SelectedRows[0].Cells[1].Value.ToString();

                    eDITAR_USUARIO.txtpasswork.Text =
                        dataGridUsuaios.SelectedRows[0].Cells[2].Value.ToString();

                    eDITAR_USUARIO.chk_ACTIVO.Checked =
                        Convert.ToBoolean(dataGridUsuaios.SelectedRows[0].Cells[3].Value);

                   

                    eDITAR_USUARIO.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se selecciono por el error : {ex.Message}", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void dataGridUsuaios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FRM_NEW_USUARIO AbrirNuevoUsuario = new FRM_NEW_USUARIO();
            AbrirNuevoUsuario.ShowDialog();
        }

        private void dataGridUsuaios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

