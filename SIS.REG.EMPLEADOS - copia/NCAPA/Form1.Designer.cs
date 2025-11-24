namespace NCAPA
{
    partial class Frm_Presentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Presentacion));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pUESTOToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aUSENCIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTRATOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1157, 12);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(58, 46);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 530);
            this.panel3.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.asistenciaToolStripMenuItem,
            this.nominasToolStripMenuItem,
            this.uSUAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(226, 530);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuprincipal";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem});
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoRegistroToolStripMenuItem.Image")));
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(295, 40);
            this.nuevoRegistroToolStripMenuItem.Text = "Nuevo Registro";
            this.nuevoRegistroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoToolStripMenuItem1,
            this.pUESTOToolStripMenuItem2});
            this.departamentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("departamentoToolStripMenuItem.Image")));
            this.departamentoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // departamentoToolStripMenuItem1
            // 
            this.departamentoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("departamentoToolStripMenuItem1.Image")));
            this.departamentoToolStripMenuItem1.Name = "departamentoToolStripMenuItem1";
            this.departamentoToolStripMenuItem1.Size = new System.Drawing.Size(284, 40);
            this.departamentoToolStripMenuItem1.Text = "Departamento";
            this.departamentoToolStripMenuItem1.Click += new System.EventHandler(this.departamentoToolStripMenuItem1_Click);
            // 
            // pUESTOToolStripMenuItem2
            // 
            this.pUESTOToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("pUESTOToolStripMenuItem2.Image")));
            this.pUESTOToolStripMenuItem2.Name = "pUESTOToolStripMenuItem2";
            this.pUESTOToolStripMenuItem2.Size = new System.Drawing.Size(284, 40);
            this.pUESTOToolStripMenuItem2.Text = "PUESTO";
            this.pUESTOToolStripMenuItem2.Click += new System.EventHandler(this.pUESTOToolStripMenuItem2_Click);
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem1,
            this.aUSENCIASToolStripMenuItem});
            this.asistenciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("asistenciaToolStripMenuItem.Image")));
            this.asistenciaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            this.asistenciaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // asistenciaToolStripMenuItem1
            // 
            this.asistenciaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("asistenciaToolStripMenuItem1.Image")));
            this.asistenciaToolStripMenuItem1.Name = "asistenciaToolStripMenuItem1";
            this.asistenciaToolStripMenuItem1.Size = new System.Drawing.Size(270, 40);
            this.asistenciaToolStripMenuItem1.Text = "Asistencia";
            this.asistenciaToolStripMenuItem1.Click += new System.EventHandler(this.asistenciaToolStripMenuItem1_Click);
            // 
            // aUSENCIASToolStripMenuItem
            // 
            this.aUSENCIASToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aUSENCIASToolStripMenuItem.Image")));
            this.aUSENCIASToolStripMenuItem.Name = "aUSENCIASToolStripMenuItem";
            this.aUSENCIASToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.aUSENCIASToolStripMenuItem.Text = "AUSENCIAS";
            this.aUSENCIASToolStripMenuItem.Click += new System.EventHandler(this.aUSENCIASToolStripMenuItem_Click);
            // 
            // nominasToolStripMenuItem
            // 
            this.nominasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nominasToolStripMenuItem1,
            this.cONTRATOToolStripMenuItem});
            this.nominasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nominasToolStripMenuItem.Image")));
            this.nominasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nominasToolStripMenuItem.Name = "nominasToolStripMenuItem";
            this.nominasToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.nominasToolStripMenuItem.Text = "Nominas";
            this.nominasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nominasToolStripMenuItem1
            // 
            this.nominasToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("nominasToolStripMenuItem1.Image")));
            this.nominasToolStripMenuItem1.Name = "nominasToolStripMenuItem1";
            this.nominasToolStripMenuItem1.Size = new System.Drawing.Size(270, 40);
            this.nominasToolStripMenuItem1.Text = "Nominas";
            this.nominasToolStripMenuItem1.Click += new System.EventHandler(this.nominasToolStripMenuItem1_Click);
            // 
            // cONTRATOToolStripMenuItem
            // 
            this.cONTRATOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cONTRATOToolStripMenuItem.Image")));
            this.cONTRATOToolStripMenuItem.Name = "cONTRATOToolStripMenuItem";
            this.cONTRATOToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.cONTRATOToolStripMenuItem.Text = "CONTRATO";
            this.cONTRATOToolStripMenuItem.Click += new System.EventHandler(this.cONTRATOToolStripMenuItem_Click);
            // 
            // uSUAToolStripMenuItem
            // 
            this.uSUAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUsuarioToolStripMenuItem});
            this.uSUAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uSUAToolStripMenuItem.Image")));
            this.uSUAToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uSUAToolStripMenuItem.Name = "uSUAToolStripMenuItem";
            this.uSUAToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.uSUAToolStripMenuItem.Text = "Usuario";
            this.uSUAToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newUsuarioToolStripMenuItem
            // 
            this.newUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newUsuarioToolStripMenuItem.Image")));
            this.newUsuarioToolStripMenuItem.Name = "newUsuarioToolStripMenuItem";
            this.newUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.newUsuarioToolStripMenuItem.Text = "New Usuario";
            this.newUsuarioToolStripMenuItem.Click += new System.EventHandler(this.newUsuarioToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 76);
            this.panel2.TabIndex = 7;
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(1070, 12);
            this.btn_Minimizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(62, 46);
            this.btn_Minimizar.TabIndex = 6;
            this.btn_Minimizar.UseVisualStyleBackColor = true;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_Minimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 63);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1251, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE REGISTRO DE EMPLEADOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pUESTOToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aUSENCIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cONTRATOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUsuarioToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

