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
        CN_NOMINAS cN_nominas = new CN_NOMINAS();
        CE_MNOMINAS cE_MNOMINAS = new CE_MNOMINAS();

        public FRM_NOMINAS()
        {
            InitializeComponent();
        }

        private void FRM_NOMINAS_Load(object sender, EventArgs e)
        {
            LISTAR_NOMINAS();
            //Evita que no esta seleccionado por defecto//
            DataGridNominas.ClearSelection();
           
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridNominas.Columns[1].Width = 130;
            DataGridNominas.Columns[2].Width = 130;
            DataGridNominas.Columns[3].Width = 130;
            DataGridNominas.Columns[4].Width = 130;


            // Cabecera
            DataGridNominas.EnableHeadersVisualStyles = false;
            DataGridNominas.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGridNominas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridNominas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            DataGridNominas.BackgroundColor = Color.White;

            // Filas alternadas
            DataGridNominas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            DataGridNominas.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGridNominas.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGridNominas.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGridNominas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridNominas.GridColor = Color.LightGray;


        }



        //metodo para alistar AUSENCIAS//
        private void LISTAR_NOMINAS()
        {
            DataGridNominas.DataSource = cn_Procedimientos.ListarDepartamento("SP_LISTAR_NOMINAS");


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


            if (DataGridNominas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Nomina");

            }
            else
            {
                try
                {
                    FRM_EDITAR_NOMINAS eDITAR_NOMINAS = new FRM_EDITAR_NOMINAS();

                    eDITAR_NOMINAS.txtid_Nmina.Text = DataGridNominas.SelectedRows[0].                  Cells[0].Value.ToString();
                    eDITAR_NOMINAS.txt_IdemplNominas.Text = DataGridNominas.SelectedRows[0].      Cells[0].Value.ToString();
                    eDITAR_NOMINAS.dtp_FechaPago.Text = DataGridNominas.SelectedRows[0].          Cells[1].Value.ToString();
                    eDITAR_NOMINAS.txt_Salario_Bru.Text = DataGridNominas.SelectedRows[0].        Cells[2].Value.ToString();
                    eDITAR_NOMINAS.txt_Deducc.Text = DataGridNominas.SelectedRows[0].             Cells[3].Value.ToString();
                    eDITAR_NOMINAS.txt_Salari_Neto.Text = DataGridNominas.SelectedRows[0].        Cells[4].Value.ToString();


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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ELIMINARNominas();

        }

        private void ELIMINARNominas()

        {
            if (DataGridNominas.Rows.Count == 0)
            {
                MessageBox.Show("Mira bien , tienes que seleccionar un Nomianas", "Eliminar Nomianas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    if (DataGridNominas.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Deseas eliminar Nomianas", "Eliminar Nominas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            cE_MNOMINAS.Id_nomina = Convert.ToInt32(DataGridNominas.SelectedRows[0].Cells[0].Value.ToString());
                            cN_nominas.ELIMINARNominas(cE_MNOMINAS);
                            MessageBox.Show("Muy bien!! Se elimino corretamente", "Eliminar Nominas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show("No se Elimino", "Eliminar Nominas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
