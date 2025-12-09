namespace NCAPA
{
    partial class FRM_USUARIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_USUARIO));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtncerrarD = new System.Windows.Forms.Button();
            this.dataGridUsuaios = new System.Windows.Forms.DataGridView();
            this.btnEditar_Usuario = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuaios)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-7, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(986, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "                                             GESTION DE USUARIOS";
            // 
            // BtncerrarD
            // 
            this.BtncerrarD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtncerrarD.BackColor = System.Drawing.Color.LightBlue;
            this.BtncerrarD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtncerrarD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtncerrarD.Image = ((System.Drawing.Image)(resources.GetObject("BtncerrarD.Image")));
            this.BtncerrarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtncerrarD.Location = new System.Drawing.Point(797, 563);
            this.BtncerrarD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtncerrarD.Name = "BtncerrarD";
            this.BtncerrarD.Size = new System.Drawing.Size(141, 51);
            this.BtncerrarD.TabIndex = 9;
            this.BtncerrarD.Text = "CERRAR";
            this.BtncerrarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtncerrarD.UseVisualStyleBackColor = false;
            this.BtncerrarD.Click += new System.EventHandler(this.BtncerrarD_Click);
            // 
            // dataGridUsuaios
            // 
            this.dataGridUsuaios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuaios.Location = new System.Drawing.Point(39, 218);
            this.dataGridUsuaios.Name = "dataGridUsuaios";
            this.dataGridUsuaios.ReadOnly = true;
            this.dataGridUsuaios.RowHeadersVisible = false;
            this.dataGridUsuaios.RowHeadersWidth = 62;
            this.dataGridUsuaios.RowTemplate.Height = 28;
            this.dataGridUsuaios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuaios.Size = new System.Drawing.Size(729, 383);
            this.dataGridUsuaios.TabIndex = 10;
            this.dataGridUsuaios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuaios_CellContentClick_1);
            // 
            // btnEditar_Usuario
            // 
            this.btnEditar_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar_Usuario.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditar_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar_Usuario.Image")));
            this.btnEditar_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar_Usuario.Location = new System.Drawing.Point(805, 301);
            this.btnEditar_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar_Usuario.Name = "btnEditar_Usuario";
            this.btnEditar_Usuario.Size = new System.Drawing.Size(133, 45);
            this.btnEditar_Usuario.TabIndex = 36;
            this.btnEditar_Usuario.Text = "Editar";
            this.btnEditar_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar_Usuario.UseVisualStyleBackColor = false;
            this.btnEditar_Usuario.Click += new System.EventHandler(this.btnEditar_Usuario_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(805, 394);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 50);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBusqueda.Location = new System.Drawing.Point(312, 73);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(355, 39);
            this.txtBusqueda.TabIndex = 38;
            // 
            // cboBuscar
            // 
            this.cboBuscar.BackColor = System.Drawing.Color.White;
            this.cboBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Nombre usuario"});
            this.cboBuscar.Location = new System.Drawing.Point(39, 73);
            this.cboBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(200, 39);
            this.cboBuscar.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox2.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(44, 162);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 35);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "Detalles de Usuarios";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoUsuario.Image")));
            this.btnNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(805, 205);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(133, 40);
            this.btnNuevoUsuario.TabIndex = 40;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // FRM_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 672);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.btnEditar_Usuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridUsuaios);
            this.Controls.Add(this.BtncerrarD);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_USUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_USUARIO";
            this.Load += new System.EventHandler(this.FRM_USUARIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuaios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button BtncerrarD;
        public System.Windows.Forms.Button btnEditar_Usuario;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBuscar;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.DataGridView dataGridUsuaios;
        public System.Windows.Forms.Button btnNuevoUsuario;
    }
}