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

            DataGridAsistencia.ClearSelection();
            //Evita que no esta seleccionado por defecto//
            DataGridAsistencia.ClearSelection();
            //PARA QUE NO APAREZCA EL ID//
            DataGridAsistencia.Columns[0].Visible = false;
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridAsistencia.Columns[1].Width = 130;
            DataGridAsistencia.Columns[2].Width = 200;
            DataGridAsistencia.Columns[3].Width = 200;
            DataGridAsistencia.Columns[4].Width = 205;



               // Cabecera
            DataGridAsistencia.EnableHeadersVisualStyles = false;
            DataGridAsistencia.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGridAsistencia.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridAsistencia.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                
            // Color de fondo de la tabla
            DataGridAsistencia.BackgroundColor = Color.White;

            // Filas alternadas
            DataGridAsistencia.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                
            // Color selección de fila
            DataGridAsistencia.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGridAsistencia.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGridAsistencia.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGridAsistencia.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridAsistencia.GridColor = Color.LightGray;



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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {


            if (DataGridAsistencia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Asistencia");

            }
            else
            {
                try
                {
                    FRM_EDITAR_ASISTENCIAS eDITAR_ASISTENCIAS = new FRM_EDITAR_ASISTENCIAS();


                    eDITAR_ASISTENCIAS.txtid.Text = DataGridAsistencia.SelectedRows[0].             Cells[0].Value.ToString();
                    eDITAR_ASISTENCIAS.dtp_FechaAsis.Text = DataGridAsistencia.SelectedRows[0].     Cells[1].Value.ToString();
                    eDITAR_ASISTENCIAS.dtp_HoraEntra.Text = DataGridAsistencia.SelectedRows[0].   Cells[2].Value.ToString();
                    eDITAR_ASISTENCIAS.dtp_HoraSalidadAsistencia.Text = DataGridAsistencia.SelectedRows[0].    Cells[3].Value.ToString();
                    eDITAR_ASISTENCIAS.txtEstado.Text = DataGridAsistencia.SelectedRows[0].         Cells[4].Value.ToString();


                    eDITAR_ASISTENCIAS.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se selecciono por el error : {ex.Message}", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
    }
}
