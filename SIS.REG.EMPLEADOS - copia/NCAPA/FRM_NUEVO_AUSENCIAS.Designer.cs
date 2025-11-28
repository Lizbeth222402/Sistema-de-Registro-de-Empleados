namespace NCAPA
{
    partial class FRM_NUEVO_AUSENCIAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NUEVO_AUSENCIAS));
            this.txtNombre_AUSENCIAS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DescripcionAusencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_FechaInic = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardarAusencias = new System.Windows.Forms.Button();
            this.txt_IdEmP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre_AUSENCIAS
            // 
            this.txtNombre_AUSENCIAS.BackColor = System.Drawing.Color.Silver;
            this.txtNombre_AUSENCIAS.Location = new System.Drawing.Point(279, 111);
            this.txtNombre_AUSENCIAS.Name = "txtNombre_AUSENCIAS";
            this.txtNombre_AUSENCIAS.Size = new System.Drawing.Size(277, 26);
            this.txtNombre_AUSENCIAS.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(66, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "TIPO AUSENCIAS";
            // 
            // txt_DescripcionAusencias
            // 
            this.txt_DescripcionAusencias.BackColor = System.Drawing.Color.Silver;
            this.txt_DescripcionAusencias.Location = new System.Drawing.Point(279, 318);
            this.txt_DescripcionAusencias.Name = "txt_DescripcionAusencias";
            this.txt_DescripcionAusencias.Size = new System.Drawing.Size(277, 26);
            this.txt_DescripcionAusencias.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(66, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "DESCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(66, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "FECHA INICIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(66, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "FECHA FINAL";
            // 
            // dtp_FechaInic
            // 
            this.dtp_FechaInic.Location = new System.Drawing.Point(279, 177);
            this.dtp_FechaInic.Name = "dtp_FechaInic";
            this.dtp_FechaInic.Size = new System.Drawing.Size(277, 26);
            this.dtp_FechaInic.TabIndex = 38;
            // 
            // dtp_FechaFinal
            // 
            this.dtp_FechaFinal.Location = new System.Drawing.Point(279, 240);
            this.dtp_FechaFinal.Name = "dtp_FechaFinal";
            this.dtp_FechaFinal.Size = new System.Drawing.Size(277, 26);
            this.dtp_FechaFinal.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(366, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 43);
            this.button1.TabIndex = 41;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardarAusencias
            // 
            this.btnGuardarAusencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarAusencias.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuardarAusencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAusencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarAusencias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAusencias.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAusencias.Image")));
            this.btnGuardarAusencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarAusencias.Location = new System.Drawing.Point(95, 402);
            this.btnGuardarAusencias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAusencias.Name = "btnGuardarAusencias";
            this.btnGuardarAusencias.Size = new System.Drawing.Size(141, 43);
            this.btnGuardarAusencias.TabIndex = 42;
            this.btnGuardarAusencias.Text = "GUARDAR";
            this.btnGuardarAusencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAusencias.UseVisualStyleBackColor = false;
            this.btnGuardarAusencias.Click += new System.EventHandler(this.btnGuardarAusencias_Click);
            // 
            // txt_IdEmP
            // 
            this.txt_IdEmP.BackColor = System.Drawing.Color.Silver;
            this.txt_IdEmP.Location = new System.Drawing.Point(279, 53);
            this.txt_IdEmP.Name = "txt_IdEmP";
            this.txt_IdEmP.Size = new System.Drawing.Size(277, 26);
            this.txt_IdEmP.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(66, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Id Empleado";
            // 
            // FRM_NUEVO_AUSENCIAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(675, 487);
            this.Controls.Add(this.txt_IdEmP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardarAusencias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_FechaFinal);
            this.Controls.Add(this.dtp_FechaInic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DescripcionAusencias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre_AUSENCIAS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_NUEVO_AUSENCIAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_NUEVO_AUSENCIAS";
            this.Load += new System.EventHandler(this.FRM_NUEVO_AUSENCIAS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNombre_AUSENCIAS;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_DescripcionAusencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DateTimePicker dtp_FechaInic;
        public System.Windows.Forms.DateTimePicker dtp_FechaFinal;
        public System.Windows.Forms.Button btnGuardarAusencias;
        public System.Windows.Forms.TextBox txt_IdEmP;
        private System.Windows.Forms.Label label5;
    }
}