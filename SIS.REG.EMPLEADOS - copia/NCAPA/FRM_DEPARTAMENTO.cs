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
    public partial class FRM_DEPARTAMENTO : Frm_Base
    {

        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        CN_DEPARTAMENTO cN_DEPARTAMENTO = new CN_DEPARTAMENTO();
        CE_MDEPARTAMENTOS cE_MDEPARTAMENTOS = new CE_MDEPARTAMENTOS();
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


            // Cabecera
            DataGridDepartamento.EnableHeadersVisualStyles = false;
            DataGridDepartamento.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGridDepartamento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridDepartamento.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            DataGridDepartamento.BackgroundColor = Color.White;

            // Filas alternadas
            DataGridDepartamento.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            DataGridDepartamento.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGridDepartamento.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGridDepartamento.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGridDepartamento.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridDepartamento.GridColor = Color.LightGray;


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
            Editar(); 
        }





        private void Editar()
        {


            if (DataGridDepartamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Asistencia");

            }
            else
            {
                try
                {
                    FRM_EDITAR_DEPA eDITAR_DEPA = new FRM_EDITAR_DEPA();


                    eDITAR_DEPA.txtid_.Text = DataGridDepartamento.SelectedRows[0].          Cells[0].Value.ToString();
                    eDITAR_DEPA.txtNombre_DEPA.Text = DataGridDepartamento.SelectedRows[0]. Cells[1].Value.ToString();
                    eDITAR_DEPA.txt_descrip.Text = DataGridDepartamento.SelectedRows[0].    Cells[2].Value.ToString();

                    eDITAR_DEPA.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se selecciono por el error : {ex.Message}", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void DataGridDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAsistencia();
        }

        private void EliminarAsistencia()

        {
            if (DataGridDepartamento.Rows.Count == 0)
            {
                MessageBox.Show("Mira bien , tienes que seleccionar un Departamento", "Eliminar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    if (DataGridDepartamento.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Deseas Eliminar", "Eliminar Departamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            cE_MDEPARTAMENTOS.Id_departamento = Convert.ToInt32(DataGridDepartamento.SelectedRows[0].Cells[0].Value.ToString());
                            cN_DEPARTAMENTO.ELIMINARDEPARTAMENTO(cE_MDEPARTAMENTOS);
                            MessageBox.Show("Muy bien!! Se elimino corretamente", "Eliminar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show("No se pudo Eliminar", "Eliminar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


    }
}
