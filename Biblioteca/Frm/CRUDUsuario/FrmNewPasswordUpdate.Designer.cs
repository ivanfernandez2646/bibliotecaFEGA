namespace Biblioteca.Frm.CRUDUsuario
{
    partial class FrmNewPasswordUpdate
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
            this.tbRepitaContraseña = new System.Windows.Forms.TextBox();
            this.labNuevaContraseña = new System.Windows.Forms.Label();
            this.labRepitaContraseña = new System.Windows.Forms.Label();
            this.tbNuevaContraseña = new System.Windows.Forms.TextBox();
            this.butAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRepitaContraseña
            // 
            this.tbRepitaContraseña.Location = new System.Drawing.Point(141, 71);
            this.tbRepitaContraseña.Name = "tbRepitaContraseña";
            this.tbRepitaContraseña.PasswordChar = '*';
            this.tbRepitaContraseña.Size = new System.Drawing.Size(135, 20);
            this.tbRepitaContraseña.TabIndex = 2;
            // 
            // labNuevaContraseña
            // 
            this.labNuevaContraseña.AutoSize = true;
            this.labNuevaContraseña.Location = new System.Drawing.Point(33, 48);
            this.labNuevaContraseña.Name = "labNuevaContraseña";
            this.labNuevaContraseña.Size = new System.Drawing.Size(92, 13);
            this.labNuevaContraseña.TabIndex = 1;
            this.labNuevaContraseña.Text = "Nueva contrseña:";
            this.labNuevaContraseña.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labRepitaContraseña
            // 
            this.labRepitaContraseña.AutoSize = true;
            this.labRepitaContraseña.Location = new System.Drawing.Point(28, 78);
            this.labRepitaContraseña.Name = "labRepitaContraseña";
            this.labRepitaContraseña.Size = new System.Drawing.Size(97, 13);
            this.labRepitaContraseña.TabIndex = 2;
            this.labRepitaContraseña.Text = "Repita contraseña:";
            this.labRepitaContraseña.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbNuevaContraseña
            // 
            this.tbNuevaContraseña.Location = new System.Drawing.Point(141, 45);
            this.tbNuevaContraseña.Name = "tbNuevaContraseña";
            this.tbNuevaContraseña.PasswordChar = '*';
            this.tbNuevaContraseña.Size = new System.Drawing.Size(135, 20);
            this.tbNuevaContraseña.TabIndex = 1;
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(201, 104);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 3;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.ButAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Introduzca la nueva conrtaseña para el usuario:";
            // 
            // FrmNewPasswordUpdate
            // 
            this.AcceptButton = this.butAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(299, 139);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.tbNuevaContraseña);
            this.Controls.Add(this.labRepitaContraseña);
            this.Controls.Add(this.labNuevaContraseña);
            this.Controls.Add(this.tbRepitaContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewPasswordUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Introduzca contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRepitaContraseña;
        private System.Windows.Forms.Label labNuevaContraseña;
        private System.Windows.Forms.Label labRepitaContraseña;
        private System.Windows.Forms.TextBox tbNuevaContraseña;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Label label3;
    }
}