namespace Biblioteca.Frm.CRUDClasificacion
{
    partial class FrmClasificacionCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClasificacionCreate));
            this.labApellidos = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.labSeparador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labApellidos
            // 
            this.labApellidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.labApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellidos.Location = new System.Drawing.Point(0, 0);
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(266, 41);
            this.labApellidos.TabIndex = 3;
            this.labApellidos.Text = "Nombre:";
            this.labApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(0, 15);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.labDescripcion);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel2.Controls.Add(this.butAceptar);
            this.splitContainer2.Panel2.Controls.Add(this.butCancelar);
            this.splitContainer2.Panel2.Controls.Add(this.rtbDescripcion);
            this.splitContainer2.Size = new System.Drawing.Size(666, 259);
            this.splitContainer2.SplitterDistance = 158;
            this.splitContainer2.TabIndex = 7;
            this.splitContainer2.TabStop = false;
            // 
            // labDescripcion
            // 
            this.labDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescripcion.Location = new System.Drawing.Point(0, 0);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(158, 34);
            this.labDescripcion.TabIndex = 0;
            this.labDescripcion.Text = "Descripción:";
            this.labDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(404, 222);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 3;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.ButFuncionales_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(323, 222);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 2;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.ButFuncionales_Click);
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.rtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescripcion.Location = new System.Drawing.Point(2, 3);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(477, 196);
            this.rtbDescripcion.TabIndex = 1;
            this.rtbDescripcion.Text = "";
            // 
            // labSeparador
            // 
            this.labSeparador.BackColor = System.Drawing.Color.Transparent;
            this.labSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.labSeparador.Location = new System.Drawing.Point(0, 0);
            this.labSeparador.Name = "labSeparador";
            this.labSeparador.Size = new System.Drawing.Size(666, 15);
            this.labSeparador.TabIndex = 5;
            // 
            // FrmClasificacionCreate
            // 
            this.AcceptButton = this.butAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.butCancelar;
            this.ClientSize = new System.Drawing.Size(666, 272);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.labSeparador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClasificacionCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Añadir Clasificación";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labDescripcion;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label labSeparador;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
    }
}