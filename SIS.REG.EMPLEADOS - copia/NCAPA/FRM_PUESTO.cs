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



            // Cabecera
            DataGridPuesto.EnableHeadersVisualStyles = false;
            DataGridPuesto.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGridPuesto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridPuesto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            DataGridPuesto.BackgroundColor = Color.White;

            // Filas alternadas
            DataGridPuesto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            DataGridPuesto.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGridPuesto.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGridPuesto.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGridPuesto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridPuesto.GridColor = Color.LightGray;

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }


        private void Editar()
        {
            if (DataGridPuesto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Puesto", "Editar Puesto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                try
                {
                    FRM_EDITAR_PUESTO eDITAR_PUESTO = new FRM_EDITAR_PUESTO();


                    eDITAR_PUESTO.txtid_puesto.Text = DataGridPuesto.SelectedRows[0].           Cells[0].Value.ToString();
                    eDITAR_PUESTO.txtNombre_Puesto.Text = DataGridPuesto.SelectedRows[0].       Cells[1].Value.ToString();
                    eDITAR_PUESTO.txt_des_puesto.Text = DataGridPuesto.SelectedRows[0].         Cells[2].Value.ToString();
                    eDITAR_PUESTO.txt_Salar_base.Text = DataGridPuesto.SelectedRows[0].         Cells[3].Value.ToString();


                    eDITAR_PUESTO.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se selecciono por el error : {ex.Message}", "Editar Puesto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }




        }




    }
}
