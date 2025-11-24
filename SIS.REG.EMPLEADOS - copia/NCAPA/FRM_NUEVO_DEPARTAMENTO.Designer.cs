namespace NCAPA
{
    partial class FRM_NUEVO_DEPARTAMENTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NUEVO_DEPARTAMENTO));
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre_DEPA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoDepa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_descrip
            // 
            this.txt_descrip.BackColor = System.Drawing.Color.Silver;
            this.txt_descrip.Location = new System.Drawing.Point(184, 120);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(290, 26);
            this.txt_descrip.TabIndex = 16;
            this.txt_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descrip_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "DESCRIPCION";
            // 
            // txtNombre_DEPA
            // 
            this.txtNombre_DEPA.BackColor = System.Drawing.Color.Silver;
            this.txtNombre_DEPA.Location = new System.Drawing.Point(184, 54);
            this.txtNombre_DEPA.Name = "txtNombre_DEPA";
            this.txtNombre_DEPA.Size = new System.Drawing.Size(290, 26);
            this.txtNombre_DEPA.TabIndex = 0;
            this.txtNombre_DEPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_DEPA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "NOMBRE";
            // 
            // btnNuevoDepa
            // 
            this.btnNuevoDepa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoDepa.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevoDepa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoDepa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoDepa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDepa.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoDepa.Image")));
            this.btnNuevoDepa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoDepa.Location = new System.Drawing.Point(64, 204);
            this.btnNuevoDepa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoDepa.Name = "btnNuevoDepa";
            this.btnNuevoDepa.Size = new System.Drawing.Size(141, 43);
            this.btnNuevoDepa.TabIndex = 27;
            this.btnNuevoDepa.Text = "GUARDAR";
            this.btnNuevoDepa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoDepa.UseVisualStyleBackColor = false;
            this.btnNuevoDepa.Click += new System.EventHandler(this.btnNuevoDepa_Click);
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
            this.button1.Location = new System.Drawing.Point(470, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_NUEVO_DEPARTAMENTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(656, 275);
            this.Controls.Add(this.btnNuevoDepa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_descrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre_DEPA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_NUEVO_DEPARTAMENTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_NUEVO_DEPARTAMENTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNombre_DEPA;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnNuevoDepa;
        public System.Windows.Forms.Button button1;
    }
}