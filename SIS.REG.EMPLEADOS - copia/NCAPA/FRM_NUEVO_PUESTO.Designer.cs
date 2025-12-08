namespace NCAPA
{
    partial class FRM_NUEVO_PUESTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NUEVO_PUESTO));
            this.btnGuardarPuesto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre_Puesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Salar_base = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_des_puesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarPuesto
            // 
            this.btnGuardarPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarPuesto.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuardarPuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarPuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPuesto.Image")));
            this.btnGuardarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPuesto.Location = new System.Drawing.Point(56, 282);
            this.btnGuardarPuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarPuesto.Name = "btnGuardarPuesto";
            this.btnGuardarPuesto.Size = new System.Drawing.Size(141, 43);
            this.btnGuardarPuesto.TabIndex = 28;
            this.btnGuardarPuesto.Text = "GUARDAR";
            this.btnGuardarPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPuesto.UseVisualStyleBackColor = false;
            this.btnGuardarPuesto.Click += new System.EventHandler(this.btnGuardarPuesto_Click);
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
            this.button1.Location = new System.Drawing.Point(527, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre_Puesto
            // 
            this.txtNombre_Puesto.BackColor = System.Drawing.Color.Silver;
            this.txtNombre_Puesto.Location = new System.Drawing.Point(265, 70);
            this.txtNombre_Puesto.Name = "txtNombre_Puesto";
            this.txtNombre_Puesto.Size = new System.Drawing.Size(290, 26);
            this.txtNombre_Puesto.TabIndex = 31;
            this.txtNombre_Puesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_Puesto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "NOMBRE DEL PUESTO";
            // 
            // txt_Salar_base
            // 
            this.txt_Salar_base.BackColor = System.Drawing.Color.Silver;
            this.txt_Salar_base.Location = new System.Drawing.Point(265, 205);
            this.txt_Salar_base.Name = "txt_Salar_base";
            this.txt_Salar_base.Size = new System.Drawing.Size(290, 26);
            this.txt_Salar_base.TabIndex = 35;
            this.txt_Salar_base.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Salar_base_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(52, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "SALARIO BASE";
            // 
            // txt_des_puesto
            // 
            this.txt_des_puesto.BackColor = System.Drawing.Color.Silver;
            this.txt_des_puesto.Location = new System.Drawing.Point(265, 129);
            this.txt_des_puesto.Name = "txt_des_puesto";
            this.txt_des_puesto.Size = new System.Drawing.Size(290, 26);
            this.txt_des_puesto.TabIndex = 33;
            this.txt_des_puesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_des_puesto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(52, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "DESCRIPCION";
            // 
            // FRM_NUEVO_PUESTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 359);
            this.Controls.Add(this.txt_Salar_base);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_des_puesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre_Puesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarPuesto);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_NUEVO_PUESTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_NUEVO_PUESTO";
            this.Load += new System.EventHandler(this.FRM_NUEVO_PUESTO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardarPuesto;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtNombre_Puesto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Salar_base;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_des_puesto;
        private System.Windows.Forms.Label label3;
    }
}