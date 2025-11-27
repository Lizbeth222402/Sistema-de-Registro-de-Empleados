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
    public partial class Frm_EMPLEADOS : Frm_Base
    {

        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();

        public Frm_EMPLEADOS()
        {
            InitializeComponent();
        }

        private void Frm_EMPLEADOS_Load(object sender, EventArgs e)
        {
            LISTAR_EMPLEADOS();
            //Evita que no esta seleccionado por defecto//
            DataGriEmpleados.ClearSelection();
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGriEmpleados.Columns[1].Width = 130;
            DataGriEmpleados.Columns[2].Width = 130;
            DataGriEmpleados.Columns[3].Width = 130;
            DataGriEmpleados.Columns[4].Width = 130;
            DataGriEmpleados.Columns[5].Width = 130;
            DataGriEmpleados.Columns[6].Width = 130;
            DataGriEmpleados.Columns[7].Width = 130;
            DataGriEmpleados.Columns[8].Width = 130;
            DataGriEmpleados.Columns[9].Width = 130;



        }

        //metodo para alistar//
        private void LISTAR_EMPLEADOS()
        {
            DataGriEmpleados.DataSource = cn_Procedimientos.ListarEmpleados("Sp_ListarEmpleados");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void DataGriEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_EMPLEADO AbrirVentanaNuevoempleado = new FRM_NUEVO_EMPLEADO();
            AbrirVentanaNuevoempleado.ShowDialog();
        }
    }
}
