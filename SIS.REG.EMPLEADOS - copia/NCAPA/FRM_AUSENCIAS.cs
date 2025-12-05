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
            
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridAUSENCIAS.Columns[1].Width = 130;
            DataGridAUSENCIAS.Columns[2].Width = 200;
            DataGridAUSENCIAS.Columns[3].Width = 200;
            DataGridAUSENCIAS.Columns[4].Width = 195;
            



            // Cabecera
            DataGridAUSENCIAS.EnableHeadersVisualStyles = false;
            DataGridAUSENCIAS.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGridAUSENCIAS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridAUSENCIAS.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            DataGridAUSENCIAS.BackgroundColor = Color.White;

            // Filas alternadas
            DataGridAUSENCIAS.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            DataGridAUSENCIAS.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGridAUSENCIAS.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGridAUSENCIAS.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGridAUSENCIAS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridAUSENCIAS.GridColor = Color.LightGray;

        }


        //metodo para alistar AUSENCIAS//
        private void LISTAR_AUSENCIAS()
        {
            DataGridAUSENCIAS.DataSource = cn_Procedimientos.ListarAusencias("SP_LISTAR_AUSENCIAS");


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
            Editar();
        }

                                        private void DataGridAUSENCIAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
                                        {

                                        }

        private void Editar()
        {
            if (DataGridAUSENCIAS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Asistencia");

            }
            else
            {
                try
                {
                    FRM_EDITAR_AUSENCIAS eDITAR_Ausencias = new FRM_EDITAR_AUSENCIAS();

                    eDITAR_Ausencias.txtidausencias.Text = DataGridAUSENCIAS.SelectedRows[0].Cells[0].Value.ToString();

                    eDITAR_Ausencias.txt_IdEmP.Text = DataGridAUSENCIAS.SelectedRows[0].Cells[1].Value.ToString();
                    eDITAR_Ausencias.txtNombre_AUSENCIAS.Text = DataGridAUSENCIAS.SelectedRows[0].Cells[2].Value.ToString();
                    eDITAR_Ausencias.dtp_FechaInic.Value = Convert.ToDateTime(DataGridAUSENCIAS.SelectedRows[0].Cells[3].Value);
                    eDITAR_Ausencias.dtp_FechaFinal.Value = Convert.ToDateTime(DataGridAUSENCIAS.SelectedRows[0].Cells[4].Value);


                    eDITAR_Ausencias.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se selecciono por el error : {ex.Message}", "Editar Ausencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
    }
}
