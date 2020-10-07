namespace Biblioteca.Frm.CRUDPrestamo
{
    partial class FrmPrestamoCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamoCreate));
            this.labSeparador = new System.Windows.Forms.Label();
            this.cbLibros = new System.Windows.Forms.ComboBox();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.lbLibro = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tbFechaInicio = new System.Windows.Forms.TextBox();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.tbFechaFin = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labSeparador
            // 
            this.labSeparador.BackColor = System.Drawing.SystemColors.Control;
            this.labSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.labSeparador.Location = new System.Drawing.Point(0, 0);
            this.labSeparador.Name = "labSeparador";
            this.labSeparador.Size = new System.Drawing.Size(684, 24);
            this.labSeparador.TabIndex = 11;
            // 
            // cbLibros
            // 
            this.cbLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbLibros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLibros.FormattingEnabled = true;
            this.cbLibros.Location = new System.Drawing.Point(12, 57);
            this.cbLibros.Name = "cbLibros";
            this.cbLibros.Size = new System.Drawing.Size(297, 25);
            this.cbLibros.TabIndex = 12;
            this.cbLibros.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxes_DrawItem);
            this.cbLibros.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(366, 57);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(297, 25);
            this.cbUsuarios.TabIndex = 13;
            this.cbUsuarios.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxes_DrawItem);
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // lbLibro
            // 
            this.lbLibro.AutoSize = true;
            this.lbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibro.Location = new System.Drawing.Point(12, 19);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(54, 20);
            this.lbLibro.TabIndex = 14;
            this.lbLibro.Text = "Libro:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(362, 19);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(76, 20);
            this.lbUsuario.TabIndex = 15;
            this.lbUsuario.Text = "Usuario:";
            // 
            // tbFechaInicio
            // 
            this.tbFechaInicio.Enabled = false;
            this.tbFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaInicio.Location = new System.Drawing.Point(139, 105);
            this.tbFechaInicio.Name = "tbFechaInicio";
            this.tbFechaInicio.Size = new System.Drawing.Size(173, 24);
            this.tbFechaInicio.TabIndex = 16;
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaInicio.Location = new System.Drawing.Point(12, 109);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(121, 20);
            this.lbFechaInicio.TabIndex = 17;
            this.lbFechaInicio.Text = "Fecha de Inicio:";
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFin.Location = new System.Drawing.Point(362, 109);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(106, 20);
            this.lbFechaFin.TabIndex = 19;
            this.lbFechaFin.Text = "Fecha de Fin:";
            // 
            // tbFechaFin
            // 
            this.tbFechaFin.Enabled = false;
            this.tbFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaFin.Location = new System.Drawing.Point(490, 105);
            this.tbFechaFin.Name = "tbFechaFin";
            this.tbFechaFin.Size = new System.Drawing.Size(173, 24);
            this.tbFechaFin.TabIndex = 18;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(588, 160);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 20;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.butFuncionales_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(507, 160);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 21;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.butFuncionales_Click);
            // 
            // FrmPrestamoCreate
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(684, 197);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.tbFechaFin);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.tbFechaInicio);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbLibro);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.cbLibros);
            this.Controls.Add(this.labSeparador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrestamoCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prestar Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labSeparador;
        private System.Windows.Forms.ComboBox cbLibros;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label lbLibro;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbFechaInicio;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.TextBox tbFechaFin;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
    }
}