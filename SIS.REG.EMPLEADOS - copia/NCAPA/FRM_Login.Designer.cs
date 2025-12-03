namespace NCAPA
{
    partial class FRM_Login
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
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.gb_todo = new System.Windows.Forms.GroupBox();
            this.CHK_MOSTRAR = new System.Windows.Forms.CheckBox();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.TXT_CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LV_RESTRINGIDO = new System.Windows.Forms.Label();
            this.gb_todo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.BackColor = System.Drawing.SystemColors.Highlight;
            this.BTN_INGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_INGRESAR.Location = new System.Drawing.Point(237, 397);
            this.BTN_INGRESAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(159, 57);
            this.BTN_INGRESAR.TabIndex = 4;
            this.BTN_INGRESAR.Text = "Ingresar";
            this.BTN_INGRESAR.UseVisualStyleBackColor = false;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click_1);
            // 
            // gb_todo
            // 
            this.gb_todo.BackColor = System.Drawing.Color.White;
            this.gb_todo.Controls.Add(this.CHK_MOSTRAR);
            this.gb_todo.Controls.Add(this.BTN_SALIR);
            this.gb_todo.Controls.Add(this.BTN_INGRESAR);
            this.gb_todo.Controls.Add(this.TXT_CONTRASEÑA);
            this.gb_todo.Controls.Add(this.TXT_USUARIO);
            this.gb_todo.Controls.Add(this.label2);
            this.gb_todo.Controls.Add(this.label1);
            this.gb_todo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_todo.Location = new System.Drawing.Point(68, 141);
            this.gb_todo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_todo.Name = "gb_todo";
            this.gb_todo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_todo.Size = new System.Drawing.Size(1062, 482);
            this.gb_todo.TabIndex = 7;
            this.gb_todo.TabStop = false;
            this.gb_todo.Text = "Ingrese los datos requeridos";
            // 
            // CHK_MOSTRAR
            // 
            this.CHK_MOSTRAR.AutoSize = true;
            this.CHK_MOSTRAR.Location = new System.Drawing.Point(766, 215);
            this.CHK_MOSTRAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CHK_MOSTRAR.Name = "CHK_MOSTRAR";
            this.CHK_MOSTRAR.Size = new System.Drawing.Size(153, 44);
            this.CHK_MOSTRAR.TabIndex = 6;
            this.CHK_MOSTRAR.Text = "Mostrar";
            this.CHK_MOSTRAR.UseVisualStyleBackColor = true;
            this.CHK_MOSTRAR.CheckedChanged += new System.EventHandler(this.CHK_MOSTRAR_CheckedChanged_1);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.BackColor = System.Drawing.Color.Red;
            this.BTN_SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SALIR.Location = new System.Drawing.Point(648, 397);
            this.BTN_SALIR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(159, 57);
            this.BTN_SALIR.TabIndex = 5;
            this.BTN_SALIR.Text = "Salir";
            this.BTN_SALIR.UseVisualStyleBackColor = false;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click_1);
            // 
            // TXT_CONTRASEÑA
            // 
            this.TXT_CONTRASEÑA.Location = new System.Drawing.Point(402, 209);
            this.TXT_CONTRASEÑA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_CONTRASEÑA.Name = "TXT_CONTRASEÑA";
            this.TXT_CONTRASEÑA.PasswordChar = '*';
            this.TXT_CONTRASEÑA.Size = new System.Drawing.Size(304, 45);
            this.TXT_CONTRASEÑA.TabIndex = 3;
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(402, 123);
            this.TXT_USUARIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(304, 45);
            this.TXT_USUARIO.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Usuario";
            // 
            // LV_RESTRINGIDO
            // 
            this.LV_RESTRINGIDO.AutoSize = true;
            this.LV_RESTRINGIDO.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_RESTRINGIDO.Location = new System.Drawing.Point(290, 67);
            this.LV_RESTRINGIDO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LV_RESTRINGIDO.Name = "LV_RESTRINGIDO";
            this.LV_RESTRINGIDO.Size = new System.Drawing.Size(538, 65);
            this.LV_RESTRINGIDO.TabIndex = 6;
            this.LV_RESTRINGIDO.Text = "ACCESO RESTRINGIDO";
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 691);
            this.Controls.Add(this.gb_todo);
            this.Controls.Add(this.LV_RESTRINGIDO);
            this.Name = "FRM_Login";
            this.Text = "FRM_Login";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.gb_todo.ResumeLayout(false);
            this.gb_todo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.GroupBox gb_todo;
        private System.Windows.Forms.CheckBox CHK_MOSTRAR;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.TextBox TXT_CONTRASEÑA;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LV_RESTRINGIDO;
    }
}