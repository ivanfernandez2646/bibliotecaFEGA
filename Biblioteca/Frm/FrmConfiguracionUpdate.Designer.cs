namespace Biblioteca.Frm
{
    partial class FrmConfiguracionUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracionUpdate));
            this.labNumDiasPrestamo1 = new System.Windows.Forms.Label();
            this.labNumDiasPrestamo2 = new System.Windows.Forms.Label();
            this.labMaxPrestamoUsuario = new System.Windows.Forms.Label();
            this.spNumDiasPrestamo1 = new System.Windows.Forms.NumericUpDown();
            this.spNumDiasPrestamo2 = new System.Windows.Forms.NumericUpDown();
            this.spMaxPrestamoUsuario = new System.Windows.Forms.NumericUpDown();
            this.butAceptar = new System.Windows.Forms.Button();
            this.labCabecera = new System.Windows.Forms.Label();
            this.butCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spNumDiasPrestamo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spNumDiasPrestamo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMaxPrestamoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // labNumDiasPrestamo1
            // 
            this.labNumDiasPrestamo1.Location = new System.Drawing.Point(23, 38);
            this.labNumDiasPrestamo1.Name = "labNumDiasPrestamo1";
            this.labNumDiasPrestamo1.Size = new System.Drawing.Size(139, 23);
            this.labNumDiasPrestamo1.TabIndex = 0;
            this.labNumDiasPrestamo1.Text = "Días Prestamo 1:";
            this.labNumDiasPrestamo1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labNumDiasPrestamo2
            // 
            this.labNumDiasPrestamo2.Location = new System.Drawing.Point(23, 66);
            this.labNumDiasPrestamo2.Name = "labNumDiasPrestamo2";
            this.labNumDiasPrestamo2.Size = new System.Drawing.Size(139, 23);
            this.labNumDiasPrestamo2.TabIndex = 1;
            this.labNumDiasPrestamo2.Text = "Días Préstamo 2:";
            this.labNumDiasPrestamo2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labMaxPrestamoUsuario
            // 
            this.labMaxPrestamoUsuario.AutoSize = true;
            this.labMaxPrestamoUsuario.Location = new System.Drawing.Point(23, 92);
            this.labMaxPrestamoUsuario.Name = "labMaxPrestamoUsuario";
            this.labMaxPrestamoUsuario.Size = new System.Drawing.Size(139, 13);
            this.labMaxPrestamoUsuario.TabIndex = 2;
            this.labMaxPrestamoUsuario.Text = "Máximo Préstamos/Usuario:";
            // 
            // spNumDiasPrestamo1
            // 
            this.spNumDiasPrestamo1.Location = new System.Drawing.Point(168, 36);
            this.spNumDiasPrestamo1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spNumDiasPrestamo1.Name = "spNumDiasPrestamo1";
            this.spNumDiasPrestamo1.Size = new System.Drawing.Size(120, 20);
            this.spNumDiasPrestamo1.TabIndex = 1;
            this.spNumDiasPrestamo1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spNumDiasPrestamo2
            // 
            this.spNumDiasPrestamo2.Location = new System.Drawing.Point(168, 64);
            this.spNumDiasPrestamo2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spNumDiasPrestamo2.Name = "spNumDiasPrestamo2";
            this.spNumDiasPrestamo2.Size = new System.Drawing.Size(120, 20);
            this.spNumDiasPrestamo2.TabIndex = 2;
            this.spNumDiasPrestamo2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spMaxPrestamoUsuario
            // 
            this.spMaxPrestamoUsuario.Location = new System.Drawing.Point(168, 90);
            this.spMaxPrestamoUsuario.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spMaxPrestamoUsuario.Name = "spMaxPrestamoUsuario";
            this.spMaxPrestamoUsuario.Size = new System.Drawing.Size(120, 20);
            this.spMaxPrestamoUsuario.TabIndex = 3;
            this.spMaxPrestamoUsuario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // butAceptar
            // 
            this.butAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butAceptar.Location = new System.Drawing.Point(213, 116);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 4;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.ButAceptar_Click);
            // 
            // labCabecera
            // 
            this.labCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.labCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabecera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labCabecera.Location = new System.Drawing.Point(0, 0);
            this.labCabecera.Name = "labCabecera";
            this.labCabecera.Size = new System.Drawing.Size(296, 24);
            this.labCabecera.TabIndex = 6;
            this.labCabecera.Text = "CONFIGURACIÓN";
            this.labCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butCancelar
            // 
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(132, 116);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 7;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Visible = false;
            // 
            // FrmConfiguracionUpdate
            // 
            this.AcceptButton = this.butAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.butCancelar;
            this.ClientSize = new System.Drawing.Size(296, 142);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.labCabecera);
            this.Controls.Add(this.spMaxPrestamoUsuario);
            this.Controls.Add(this.spNumDiasPrestamo2);
            this.Controls.Add(this.spNumDiasPrestamo1);
            this.Controls.Add(this.labMaxPrestamoUsuario);
            this.Controls.Add(this.labNumDiasPrestamo2);
            this.Controls.Add(this.labNumDiasPrestamo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 185);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(316, 185);
            this.Name = "FrmConfiguracionUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.spNumDiasPrestamo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spNumDiasPrestamo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMaxPrestamoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumDiasPrestamo1;
        private System.Windows.Forms.Label labNumDiasPrestamo2;
        private System.Windows.Forms.Label labMaxPrestamoUsuario;
        private System.Windows.Forms.NumericUpDown spNumDiasPrestamo1;
        private System.Windows.Forms.NumericUpDown spNumDiasPrestamo2;
        private System.Windows.Forms.NumericUpDown spMaxPrestamoUsuario;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Label labCabecera;
        private System.Windows.Forms.Button butCancelar;
    }
}