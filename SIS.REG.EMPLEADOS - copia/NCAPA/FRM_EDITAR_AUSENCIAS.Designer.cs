namespace NCAPA
{
    partial class FRM_EDITAR_AUSENCIAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EDITAR_AUSENCIAS));
            this.txt_IdEmP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizarAusencias = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaInic = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_motivoAusencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre_AUSENCIAS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid_Ausencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(1122, 603);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(3);
            // 
            // txt_IdEmP
            // 
            this.txt_IdEmP.BackColor = System.Drawing.Color.Silver;
            this.txt_IdEmP.Location = new System.Drawing.Point(274, 152);
            this.txt_IdEmP.Name = "txt_IdEmP";
            this.txt_IdEmP.Size = new System.Drawing.Size(277, 26);
            this.txt_IdEmP.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(62, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Id Empleado";
            // 
            // btnActualizarAusencias
            // 
            this.btnActualizarAusencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizarAusencias.BackColor = System.Drawing.Color.LightBlue;
            this.btnActualizarAusencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarAusencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarAusencias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAusencias.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarAusencias.Image")));
            this.btnActualizarAusencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarAusencias.Location = new System.Drawing.Point(662, 255);
            this.btnActualizarAusencias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarAusencias.Name = "btnActualizarAusencias";
            this.btnActualizarAusencias.Size = new System.Drawing.Size(141, 43);
            this.btnActualizarAusencias.TabIndex = 54;
            this.btnActualizarAusencias.Text = "Actualizar";
            this.btnActualizarAusencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarAusencias.UseVisualStyleBackColor = false;
            this.btnActualizarAusencias.Click += new System.EventHandler(this.btnGuardarAusencias_Click);
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
            this.button1.Location = new System.Drawing.Point(662, 417);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 53;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_FechaFinal
            // 
            this.dtp_FechaFinal.Location = new System.Drawing.Point(274, 338);
            this.dtp_FechaFinal.Name = "dtp_FechaFinal";
            this.dtp_FechaFinal.Size = new System.Drawing.Size(277, 26);
            this.dtp_FechaFinal.TabIndex = 52;
            // 
            // dtp_FechaInic
            // 
            this.dtp_FechaInic.Location = new System.Drawing.Point(274, 275);
            this.dtp_FechaInic.Name = "dtp_FechaInic";
            this.dtp_FechaInic.Size = new System.Drawing.Size(277, 26);
            this.dtp_FechaInic.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(62, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "FECHA FINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "FECHA INICIO";
            // 
            // txt_motivoAusencias
            // 
            this.txt_motivoAusencias.BackColor = System.Drawing.Color.Silver;
            this.txt_motivoAusencias.Location = new System.Drawing.Point(274, 417);
            this.txt_motivoAusencias.Name = "txt_motivoAusencias";
            this.txt_motivoAusencias.Size = new System.Drawing.Size(277, 26);
            this.txt_motivoAusencias.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(62, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "DESCRIPCION";
            // 
            // txtNombre_AUSENCIAS
            // 
            this.txtNombre_AUSENCIAS.BackColor = System.Drawing.Color.Silver;
            this.txtNombre_AUSENCIAS.Location = new System.Drawing.Point(274, 209);
            this.txtNombre_AUSENCIAS.Name = "txtNombre_AUSENCIAS";
            this.txtNombre_AUSENCIAS.Size = new System.Drawing.Size(277, 26);
            this.txtNombre_AUSENCIAS.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "TIPO AUSENCIAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(138, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Id";
            this.label6.Visible = false;
            // 
            // txtid_Ausencia
            // 
            this.txtid_Ausencia.Location = new System.Drawing.Point(274, 100);
            this.txtid_Ausencia.Name = "txtid_Ausencia";
            this.txtid_Ausencia.Size = new System.Drawing.Size(42, 26);
            this.txtid_Ausencia.TabIndex = 59;
            // 
            // FRM_EDITAR_AUSENCIAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(862, 558);
            this.Controls.Add(this.txtid_Ausencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_IdEmP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnActualizarAusencias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_FechaFinal);
            this.Controls.Add(this.dtp_FechaInic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_motivoAusencias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre_AUSENCIAS);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_EDITAR_AUSENCIAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EDITAR_AUSENCIAS";
            this.Load += new System.EventHandler(this.FRM_EDITAR_AUSENCIAS_Load);
            this.Controls.SetChildIndex(this.btncerrar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNombre_AUSENCIAS, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_motivoAusencias, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtp_FechaInic, 0);
            this.Controls.SetChildIndex(this.dtp_FechaFinal, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnActualizarAusencias, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txt_IdEmP, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtid_Ausencia, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_IdEmP;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnActualizarAusencias;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DateTimePicker dtp_FechaFinal;
        public System.Windows.Forms.DateTimePicker dtp_FechaInic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_motivoAusencias;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNombre_AUSENCIAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtid_Ausencia;
    }
}