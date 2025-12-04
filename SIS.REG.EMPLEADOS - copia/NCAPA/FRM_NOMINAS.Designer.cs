namespace NCAPA
{
    partial class FRM_NOMINAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NOMINAS));
            this.DataGridAusencias = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuveo = new System.Windows.Forms.Button();
            this.BtncerrarD = new System.Windows.Forms.Button();
            this.textboxNOMINAS = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAusencias)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(1434, 712);
            // 
            // DataGridAusencias
            // 
            this.DataGridAusencias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridAusencias.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridAusencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAusencias.Location = new System.Drawing.Point(36, 149);
            this.DataGridAusencias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridAusencias.Name = "DataGridAusencias";
            this.DataGridAusencias.ReadOnly = true;
            this.DataGridAusencias.RowHeadersVisible = false;
            this.DataGridAusencias.RowHeadersWidth = 62;
            this.DataGridAusencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridAusencias.Size = new System.Drawing.Size(1086, 361);
            this.DataGridAusencias.TabIndex = 17;
            this.DataGridAusencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAusencias_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(213, 547);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 40);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(402, 547);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 40);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuveo
            // 
            this.btnNuveo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuveo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuveo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuveo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuveo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuveo.Image")));
            this.btnNuveo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuveo.Location = new System.Drawing.Point(36, 547);
            this.btnNuveo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuveo.Name = "btnNuveo";
            this.btnNuveo.Size = new System.Drawing.Size(124, 40);
            this.btnNuveo.TabIndex = 25;
            this.btnNuveo.Text = "Nuevo";
            this.btnNuveo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuveo.UseVisualStyleBackColor = false;
            this.btnNuveo.Click += new System.EventHandler(this.btnNuveo_Click);
            // 
            // BtncerrarD
            // 
            this.BtncerrarD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtncerrarD.BackColor = System.Drawing.Color.LightBlue;
            this.BtncerrarD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtncerrarD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtncerrarD.Image = ((System.Drawing.Image)(resources.GetObject("BtncerrarD.Image")));
            this.BtncerrarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtncerrarD.Location = new System.Drawing.Point(981, 541);
            this.BtncerrarD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtncerrarD.Name = "BtncerrarD";
            this.BtncerrarD.Size = new System.Drawing.Size(141, 51);
            this.BtncerrarD.TabIndex = 24;
            this.BtncerrarD.Text = "CERRAR";
            this.BtncerrarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtncerrarD.UseVisualStyleBackColor = false;
            this.BtncerrarD.Click += new System.EventHandler(this.BtncerrarD_Click);
            // 
            // textboxNOMINAS
            // 
            this.textboxNOMINAS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textboxNOMINAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxNOMINAS.ForeColor = System.Drawing.SystemColors.Window;
            this.textboxNOMINAS.Location = new System.Drawing.Point(36, 74);
            this.textboxNOMINAS.Name = "textboxNOMINAS";
            this.textboxNOMINAS.Size = new System.Drawing.Size(319, 39);
            this.textboxNOMINAS.TabIndex = 34;
            this.textboxNOMINAS.Text = "GESTION DE NOMINAS";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBusqueda.Location = new System.Drawing.Point(767, 74);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(355, 29);
            this.txtBusqueda.TabIndex = 36;
            // 
            // cboBuscar
            // 
            this.cboBuscar.BackColor = System.Drawing.Color.White;
            this.cboBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Departamento"});
            this.cboBuscar.Location = new System.Drawing.Point(548, 74);
            this.cboBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(200, 39);
            this.cboBuscar.TabIndex = 35;
            // 
            // FRM_NOMINAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 667);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.textboxNOMINAS);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuveo);
            this.Controls.Add(this.BtncerrarD);
            this.Controls.Add(this.DataGridAusencias);
            this.Name = "FRM_NOMINAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_NOMINAS";
            this.Load += new System.EventHandler(this.FRM_NOMINAS_Load);
            this.Controls.SetChildIndex(this.btncerrar, 0);
            this.Controls.SetChildIndex(this.DataGridAusencias, 0);
            this.Controls.SetChildIndex(this.BtncerrarD, 0);
            this.Controls.SetChildIndex(this.btnNuveo, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.textboxNOMINAS, 0);
            this.Controls.SetChildIndex(this.cboBuscar, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAusencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnNuveo;
        public System.Windows.Forms.Button BtncerrarD;
        private System.Windows.Forms.TextBox textboxNOMINAS;
        public System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBuscar;
        public System.Windows.Forms.DataGridView DataGridAusencias;
    }
}