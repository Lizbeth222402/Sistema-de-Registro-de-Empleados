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


            // Cabecera
            DataGridAusencias.EnableHeadersVisualStyles = false;
            DataGridAusencias.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGridAusencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridAusencias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            DataGridAusencias.BackgroundColor = Color.White;

            // Filas alternadas
            DataGridAusencias.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            DataGridAusencias.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGridAusencias.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGridAusencias.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGridAusencias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridAusencias.GridColor = Color.LightGray;


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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }




        private void Editar()
        {


            if (DataGridAusencias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Nomina", "Editar Nomina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                try
                {
                    FRM_EDITAR_NOMINAS eDITAR_NOMINAS = new FRM_EDITAR_NOMINAS();

                    eDITAR_NOMINAS.txtid.Text = DataGridAusencias.SelectedRows[0].Cells[1].Value.ToString();
                    eDITAR_NOMINAS.txt_IdemplNominas.Text = DataGridAusencias.SelectedRows[0].Cells[1].Value.ToString();
                    eDITAR_NOMINAS.dtp_FechaPago.Text = DataGridAusencias.SelectedRows[0].Cells[1].Value.ToString();
                    eDITAR_NOMINAS.txt_Salario_Bru.Text = DataGridAusencias.SelectedRows[0].Cells[1].Value.ToString();
                    eDITAR_NOMINAS.txt_Deducc.Text = DataGridAusencias.SelectedRows[0].Cells[1].Value.ToString();
                    eDITAR_NOMINAS.txt_Salari_Neto.Text = DataGridAusencias.SelectedRows[0].Cells[1].Value.ToString();


                    eDITAR_NOMINAS.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tienes que seleccionar una Nomina", "Editar Nomina", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }





        }




        private void DataGridAusencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
