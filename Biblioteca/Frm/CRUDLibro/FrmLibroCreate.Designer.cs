namespace Biblioteca.Frm.CRUDLibro
{
    partial class FrmLibroCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibroCreate));
            this.labApellidos = new System.Windows.Forms.Label();
            this.labSeparador = new System.Windows.Forms.Label();
            this.labGénero = new System.Windows.Forms.Label();
            this.labClasificación = new System.Windows.Forms.Label();
            this.labAutor = new System.Windows.Forms.Label();
            this.labStock = new System.Windows.Forms.Label();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.pbImagenLibro = new System.Windows.Forms.PictureBox();
            this.cbEditorial = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labEditorial = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.spStock = new System.Windows.Forms.NumericUpDown();
            this.butBorrarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenLibro)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spStock)).BeginInit();
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
            // labSeparador
            // 
            this.labSeparador.BackColor = System.Drawing.SystemColors.Control;
            this.labSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.labSeparador.Location = new System.Drawing.Point(0, 0);
            this.labSeparador.Name = "labSeparador";
            this.labSeparador.Size = new System.Drawing.Size(695, 15);
            this.labSeparador.TabIndex = 5;
            // 
            // labGénero
            // 
            this.labGénero.Dock = System.Windows.Forms.DockStyle.Top;
            this.labGénero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGénero.Location = new System.Drawing.Point(0, 170);
            this.labGénero.Name = "labGénero";
            this.labGénero.Size = new System.Drawing.Size(159, 34);
            this.labGénero.TabIndex = 7;
            this.labGénero.Text = "Género:";
            this.labGénero.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labClasificación
            // 
            this.labClasificación.Dock = System.Windows.Forms.DockStyle.Top;
            this.labClasificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClasificación.Location = new System.Drawing.Point(0, 136);
            this.labClasificación.Name = "labClasificación";
            this.labClasificación.Size = new System.Drawing.Size(159, 34);
            this.labClasificación.TabIndex = 6;
            this.labClasificación.Text = "Clasificación:";
            this.labClasificación.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labAutor
            // 
            this.labAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAutor.Location = new System.Drawing.Point(0, 102);
            this.labAutor.Name = "labAutor";
            this.labAutor.Size = new System.Drawing.Size(159, 34);
            this.labAutor.TabIndex = 5;
            this.labAutor.Text = "Autor:";
            this.labAutor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labStock
            // 
            this.labStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.labStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStock.Location = new System.Drawing.Point(0, 68);
            this.labStock.Name = "labStock";
            this.labStock.Size = new System.Drawing.Size(159, 34);
            this.labStock.TabIndex = 4;
            this.labStock.Text = "Stock:";
            this.labStock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labDescripcion
            // 
            this.labDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescripcion.Location = new System.Drawing.Point(0, 34);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(159, 34);
            this.labDescripcion.TabIndex = 2;
            this.labDescripcion.Text = "Descripción:";
            this.labDescripcion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labTitulo
            // 
            this.labTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(0, 0);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(159, 34);
            this.labTitulo.TabIndex = 0;
            this.labTitulo.Text = "Título:";
            this.labTitulo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbImagenLibro
            // 
            this.pbImagenLibro.Image = global::Biblioteca.Properties.Resources.iconImagen;
            this.pbImagenLibro.Location = new System.Drawing.Point(398, 68);
            this.pbImagenLibro.Name = "pbImagenLibro";
            this.pbImagenLibro.Size = new System.Drawing.Size(126, 125);
            this.pbImagenLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenLibro.TabIndex = 15;
            this.pbImagenLibro.TabStop = false;
            this.pbImagenLibro.Click += new System.EventHandler(this.PbImagenLibro_Click);
            this.pbImagenLibro.MouseEnter += new System.EventHandler(this.PbImagenLibro_MouseEnter);
            this.pbImagenLibro.MouseLeave += new System.EventHandler(this.PbImagenLibro_MouseLeave);
            // 
            // cbEditorial
            // 
            this.cbEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.cbEditorial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditorial.FormattingEnabled = true;
            this.cbEditorial.Location = new System.Drawing.Point(3, 202);
            this.cbEditorial.Name = "cbEditorial";
            this.cbEditorial.Size = new System.Drawing.Size(353, 25);
            this.cbEditorial.TabIndex = 7;
            this.cbEditorial.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxes_DrawItem);
            this.cbEditorial.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.cbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(3, 168);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(353, 25);
            this.cbGenero.TabIndex = 6;
            this.cbGenero.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxes_DrawItem);
            this.cbGenero.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.cbClasificacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(3, 134);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(353, 25);
            this.cbClasificacion.TabIndex = 5;
            this.cbClasificacion.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxes_DrawItem);
            this.cbClasificacion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // cbAutor
            // 
            this.cbAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.cbAutor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(3, 100);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(353, 25);
            this.cbAutor.TabIndex = 4;
            this.cbAutor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxes_DrawItem);
            this.cbAutor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // butCancelar
            // 
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(368, 250);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 8;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.ButFuncionales_Click);
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(449, 249);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 9;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.ButFuncionales_Click);
            // 
            // tbTitulo
            // 
            this.tbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(3, 0);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(521, 24);
            this.tbTitulo.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Imágenes | *.jpg; *.png";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labEditorial);
            this.panel1.Controls.Add(this.labGénero);
            this.panel1.Controls.Add(this.labClasificación);
            this.panel1.Controls.Add(this.labAutor);
            this.panel1.Controls.Add(this.labStock);
            this.panel1.Controls.Add(this.labDescripcion);
            this.panel1.Controls.Add(this.labTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 285);
            this.panel1.TabIndex = 8;
            // 
            // labEditorial
            // 
            this.labEditorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.labEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEditorial.Location = new System.Drawing.Point(0, 204);
            this.labEditorial.Name = "labEditorial";
            this.labEditorial.Size = new System.Drawing.Size(159, 34);
            this.labEditorial.TabIndex = 8;
            this.labEditorial.Text = "Editorial:";
            this.labEditorial.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbDescripcion);
            this.panel2.Controls.Add(this.spStock);
            this.panel2.Controls.Add(this.butBorrarImagen);
            this.panel2.Controls.Add(this.pbImagenLibro);
            this.panel2.Controls.Add(this.cbEditorial);
            this.panel2.Controls.Add(this.cbGenero);
            this.panel2.Controls.Add(this.cbClasificacion);
            this.panel2.Controls.Add(this.cbAutor);
            this.panel2.Controls.Add(this.butCancelar);
            this.panel2.Controls.Add(this.butAceptar);
            this.panel2.Controls.Add(this.tbTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(159, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 285);
            this.panel2.TabIndex = 9;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(3, 34);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(521, 24);
            this.tbDescripcion.TabIndex = 2;
            // 
            // spStock
            // 
            this.spStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.spStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spStock.Location = new System.Drawing.Point(3, 67);
            this.spStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spStock.Name = "spStock";
            this.spStock.Size = new System.Drawing.Size(353, 24);
            this.spStock.TabIndex = 3;
            this.spStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // butBorrarImagen
            // 
            this.butBorrarImagen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butBorrarImagen.Location = new System.Drawing.Point(398, 202);
            this.butBorrarImagen.Name = "butBorrarImagen";
            this.butBorrarImagen.Size = new System.Drawing.Size(126, 23);
            this.butBorrarImagen.TabIndex = 7;
            this.butBorrarImagen.Text = "Borrar Imagen";
            this.butBorrarImagen.UseVisualStyleBackColor = true;
            this.butBorrarImagen.Click += new System.EventHandler(this.ButBorrarImagen_Click);
            // 
            // FrmLibroCreate
            // 
            this.AcceptButton = this.butAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.butCancelar;
            this.ClientSize = new System.Drawing.Size(695, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labSeparador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLibroCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insertar Libro";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenLibro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.Label labSeparador;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Label labDescripcion;
        private System.Windows.Forms.Label labGénero;
        private System.Windows.Forms.Label labClasificación;
        private System.Windows.Forms.Label labAutor;
        private System.Windows.Forms.Label labStock;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbEditorial;
        private System.Windows.Forms.PictureBox pbImagenLibro;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butBorrarImagen;
        private System.Windows.Forms.NumericUpDown spStock;
        private System.Windows.Forms.Label labEditorial;
        private System.Windows.Forms.TextBox tbDescripcion;
    }
}