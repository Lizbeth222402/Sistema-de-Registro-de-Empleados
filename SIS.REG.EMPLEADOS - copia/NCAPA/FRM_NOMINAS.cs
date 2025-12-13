using CAPA_ENTIDAD;
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
        CN_NOMINAS cN_Nomina = new CN_NOMINAS();
        public FRM_NOMINAS()
        {
            InitializeComponent();
        }

        private void FRM_NOMINAS_Load(object sender, EventArgs e)
        {
            LISTAR_NOMINAS();
            //Evita que no esta seleccionado por defecto//
            DataGridNomina.ClearSelection();
           
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridNomina.Columns[1].Width = 130;
            DataGridNomina.Columns[2].Width = 130;
            DataGridNomina.Columns[3].Width = 130;
            DataGridNomina.Columns[4].Width = 130;


            // Cabecera
            DataGridNomina.EnableHeadersVisualStyles = false;
            DataGridNomina.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGridNomina.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridNomina.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            DataGridNomina.BackgroundColor = Color.White;

            // Filas alternadas
            DataGridNomina.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            DataGridNomina.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGridNomina.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGridNomina.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGridNomina.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridNomina.GridColor = Color.LightGray;




        }



        //metodo para alistar AUSENCIAS//
        private void LISTAR_NOMINAS()
        {
            DataGridNomina.DataSource = cn_Procedimientos.ListarDepartamento("SP_LISTAR_NOMINAS");


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


            if (DataGridNomina.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Nomina");
            }
            else
            {
                try
                {
                    FRM_EDITAR_NOMINAS eDITAR_NOMINAS = new FRM_EDITAR_NOMINAS();

                    eDITAR_NOMINAS.txtid_Nmina.Text = DataGridNomina.SelectedRows[0].                  Cells[0].Value.ToString();
                    eDITAR_NOMINAS.txt_IdemplNominas.Text = DataGridNomina.SelectedRows[0].      Cells[0].Value.ToString();
                    eDITAR_NOMINAS.dtp_FechaPago.Text = DataGridNomina.SelectedRows[0].          Cells[1].Value.ToString();
                    eDITAR_NOMINAS.txt_Salario_Bru.Text = DataGridNomina.SelectedRows[0].        Cells[2].Value.ToString();
                    eDITAR_NOMINAS.txt_Deducc.Text = DataGridNomina.SelectedRows[0].             Cells[3].Value.ToString();
                    eDITAR_NOMINAS.txt_Salari_Neto.Text = DataGridNomina.SelectedRows[0].        Cells[4].Value.ToString();


                    eDITAR_NOMINAS.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se selecciono por el error : {ex.Message}", "Editar Nomina", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }





        }




        private void DataGridAusencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string criterio = cboBuscar.Text; // ComboBox con opción "Empleado"
            string valor = txtBusqueda.Text.Trim();

            if (criterio == "Empleado")
            {
                DataGridNomina.DataSource = cN_Nomina.FiltrarNominaPorEmpleado(valor);
            }
        }
    }
}
