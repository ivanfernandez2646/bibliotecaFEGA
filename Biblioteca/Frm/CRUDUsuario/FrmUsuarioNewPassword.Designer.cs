namespace Biblioteca.Frm.CRUDUsuario
{
    partial class FrmUsuarioNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioNewPassword));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbRepitaContraseña = new System.Windows.Forms.Label();
            this.lbNuevaContraseña = new System.Windows.Forms.Label();
            this.lbAntiguaContraseña = new System.Windows.Forms.Label();
            this.tbRepitaContraseña = new System.Windows.Forms.TextBox();
            this.tbNuevaContraseña = new System.Windows.Forms.TextBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.tbAntiguaContraseña = new System.Windows.Forms.TextBox();
            this.labSeparador = new System.Windows.Forms.Label();
            this.labCabecera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 42);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbRepitaContraseña);
            this.splitContainer2.Panel1.Controls.Add(this.lbNuevaContraseña);
            this.splitContainer2.Panel1.Controls.Add(this.lbAntiguaContraseña);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbRepitaContraseña);
            this.splitContainer2.Panel2.Controls.Add(this.tbNuevaContraseña);
            this.splitContainer2.Panel2.Controls.Add(this.butCancelar);
            this.splitContainer2.Panel2.Controls.Add(this.butAceptar);
            this.splitContainer2.Panel2.Controls.Add(this.tbAntiguaContraseña);
            this.splitContainer2.Size = new System.Drawing.Size(379, 125);
            this.splitContainer2.SplitterDistance = 126;
            this.splitContainer2.TabIndex = 11;
            this.splitContainer2.TabStop = false;
            // 
            // lbRepitaContraseña
            // 
            this.lbRepitaContraseña.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRepitaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepitaContraseña.Location = new System.Drawing.Point(0, 51);
            this.lbRepitaContraseña.Name = "lbRepitaContraseña";
            this.lbRepitaContraseña.Size = new System.Drawing.Size(126, 26);
            this.lbRepitaContraseña.TabIndex = 2;
            this.lbRepitaContraseña.Text = "Repita Contraseña:";
            this.lbRepitaContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNuevaContraseña
            // 
            this.lbNuevaContraseña.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevaContraseña.Location = new System.Drawing.Point(0, 29);
            this.lbNuevaContraseña.Name = "lbNuevaContraseña";
            this.lbNuevaContraseña.Size = new System.Drawing.Size(126, 22);
            this.lbNuevaContraseña.TabIndex = 1;
            this.lbNuevaContraseña.Text = "Nueva Contraseña:";
            this.lbNuevaContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAntiguaContraseña
            // 
            this.lbAntiguaContraseña.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAntiguaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAntiguaContraseña.Location = new System.Drawing.Point(0, 0);
            this.lbAntiguaContraseña.Name = "lbAntiguaContraseña";
            this.lbAntiguaContraseña.Size = new System.Drawing.Size(126, 29);
            this.lbAntiguaContraseña.TabIndex = 0;
            this.lbAntiguaContraseña.Text = "Antigua Contraseña:";
            this.lbAntiguaContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbRepitaContraseña
            // 
            this.tbRepitaContraseña.BackColor = System.Drawing.Color.White;
            this.tbRepitaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepitaContraseña.Location = new System.Drawing.Point(2, 57);
            this.tbRepitaContraseña.Name = "tbRepitaContraseña";
            this.tbRepitaContraseña.PasswordChar = '*';
            this.tbRepitaContraseña.Size = new System.Drawing.Size(235, 20);
            this.tbRepitaContraseña.TabIndex = 3;
            // 
            // tbNuevaContraseña
            // 
            this.tbNuevaContraseña.BackColor = System.Drawing.Color.White;
            this.tbNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevaContraseña.Location = new System.Drawing.Point(2, 29);
            this.tbNuevaContraseña.Name = "tbNuevaContraseña";
            this.tbNuevaContraseña.PasswordChar = '*';
            this.tbNuevaContraseña.Size = new System.Drawing.Size(235, 20);
            this.tbNuevaContraseña.TabIndex = 2;
            // 
            // butCancelar
            // 
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(81, 94);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 4;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.ButFuncionales_Click);
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(162, 94);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 5;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.ButFuncionales_Click);
            // 
            // tbAntiguaContraseña
            // 
            this.tbAntiguaContraseña.BackColor = System.Drawing.Color.White;
            this.tbAntiguaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAntiguaContraseña.Location = new System.Drawing.Point(2, 3);
            this.tbAntiguaContraseña.Name = "tbAntiguaContraseña";
            this.tbAntiguaContraseña.PasswordChar = '*';
            this.tbAntiguaContraseña.Size = new System.Drawing.Size(235, 20);
            this.tbAntiguaContraseña.TabIndex = 1;
            this.tbAntiguaContraseña.Click += new System.EventHandler(this.ButFuncionales_Click);
            // 
            // labSeparador
            // 
            this.labSeparador.BackColor = System.Drawing.SystemColors.Control;
            this.labSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.labSeparador.Location = new System.Drawing.Point(0, 24);
            this.labSeparador.Name = "labSeparador";
            this.labSeparador.Size = new System.Drawing.Size(379, 18);
            this.labSeparador.TabIndex = 9;
            // 
            // labCabecera
            // 
            this.labCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabecera.Location = new System.Drawing.Point(0, 0);
            this.labCabecera.Name = "labCabecera";
            this.labCabecera.Size = new System.Drawing.Size(379, 24);
            this.labCabecera.TabIndex = 8;
            this.labCabecera.Text = "CAMBIAR CONTRASEÑA";
            this.labCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmUsuarioNewPassword
            // 
            this.AcceptButton = this.butAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.butCancelar;
            this.ClientSize = new System.Drawing.Size(379, 167);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.labSeparador);
            this.Controls.Add(this.labCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lbAntiguaContraseña;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.TextBox tbAntiguaContraseña;
        private System.Windows.Forms.Label labSeparador;
        private System.Windows.Forms.Label labCabecera;
        private System.Windows.Forms.Label lbNuevaContraseña;
        private System.Windows.Forms.TextBox tbNuevaContraseña;
        private System.Windows.Forms.Label lbRepitaContraseña;
        private System.Windows.Forms.TextBox tbRepitaContraseña;
    }
}