namespace Biblioteca.Frm.CRUDLibro
{
    partial class FrmLibroUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibroUpdate));
            this.labApellidos = new System.Windows.Forms.Label();
            this.labSeparador = new System.Windows.Forms.Label();
            this.labEditorial = new System.Windows.Forms.Label();
            this.labGenero = new System.Windows.Forms.Label();
            this.labClasificacion = new System.Windows.Forms.Label();
            this.labAutor = new System.Windows.Forms.Label();
            this.labStockDisponible = new System.Windows.Forms.Label();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.pbImagenLibro = new System.Windows.Forms.PictureBox();
            this.cbEditorial = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.tbStockDisponible = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butBorrarImagen = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenLibro)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // labEditorial
            // 
            this.labEditorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.labEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEditorial.Location = new System.Drawing.Point(0, 204);
            this.labEditorial.Name = "labEditorial";
            this.labEditorial.Size = new System.Drawing.Size(159, 34);
            this.labEditorial.TabIndex = 7;
            this.labEditorial.Text = "Género:";
            this.labEditorial.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labGenero
            // 
            this.labGenero.Dock = System.Windows.Forms.DockStyle.Top;
            this.labGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGenero.Location = new System.Drawing.Point(0, 170);
            this.labGenero.Name = "labGenero";
            this.labGenero.Size = new System.Drawing.Size(159, 34);
            this.labGenero.TabIndex = 6;
            this.labGenero.Text = "Clasificación:";
            this.labGenero.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labClasificacion
            // 
            this.labClasificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClasificacion.Location = new System.Drawing.Point(0, 136);
            this.labClasificacion.Name = "labClasificacion";
            this.labClasificacion.Size = new System.Drawing.Size(159, 34);
            this.labClasificacion.TabIndex = 5;
            this.labClasificacion.Text = "Autor::";
            this.labClasificacion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labAutor
            // 
            this.labAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAutor.Location = new System.Drawing.Point(0, 102);
            this.labAutor.Name = "labAutor";
            this.labAutor.Size = new System.Drawing.Size(159, 34);
            this.labAutor.TabIndex = 4;
            this.labAutor.Text = "Stock disponible.";
            this.labAutor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labStockDisponible
            // 
            this.labStockDisponible.Dock = System.Windows.Forms.DockStyle.Top;
            this.labStockDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStockDisponible.Location = new System.Drawing.Point(0, 68);
            this.labStockDisponible.Name = "labStockDisponible";
            this.labStockDisponible.Size = new System.Drawing.Size(159, 34);
            this.labStockDisponible.TabIndex = 3;
            this.labStockDisponible.Text = "Stock :";
            this.labStockDisponible.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.pbImagenLibro.Location = new System.Drawing.Point(398, 102);
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
            this.cbEditorial.Location = new System.Drawing.Point(3, 236);
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
            this.cbGenero.Location = new System.Drawing.Point(3, 202);
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
            this.cbClasificacion.Location = new System.Drawing.Point(3, 168);
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
            this.cbAutor.Location = new System.Drawing.Point(3, 134);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(353, 25);
            this.cbAutor.TabIndex = 4;
            this.cbAutor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxes_DrawItem);
            this.cbAutor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // tbStockDisponible
            // 
            this.tbStockDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.tbStockDisponible.Enabled = false;
            this.tbStockDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockDisponible.Location = new System.Drawing.Point(3, 102);
            this.tbStockDisponible.Name = "tbStockDisponible";
            this.tbStockDisponible.Size = new System.Drawing.Size(336, 24);
            this.tbStockDisponible.TabIndex = 3;
            // 
            // tbStock
            // 
            this.tbStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.tbStock.Enabled = false;
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.Location = new System.Drawing.Point(3, 66);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(521, 24);
            this.tbStock.TabIndex = 2;
            // 
            // butCancelar
            // 
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(368, 283);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 10;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.ButFuncionales_Click);
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(449, 283);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 11;
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
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.labEditorial);
            this.panel1.Controls.Add(this.labGenero);
            this.panel1.Controls.Add(this.labClasificacion);
            this.panel1.Controls.Add(this.labAutor);
            this.panel1.Controls.Add(this.labStockDisponible);
            this.panel1.Controls.Add(this.labDescripcion);
            this.panel1.Controls.Add(this.labTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 318);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbDescripcion);
            this.panel2.Controls.Add(this.butBorrarImagen);
            this.panel2.Controls.Add(this.pbImagenLibro);
            this.panel2.Controls.Add(this.cbEditorial);
            this.panel2.Controls.Add(this.cbGenero);
            this.panel2.Controls.Add(this.cbClasificacion);
            this.panel2.Controls.Add(this.cbAutor);
            this.panel2.Controls.Add(this.tbStockDisponible);
            this.panel2.Controls.Add(this.tbStock);
            this.panel2.Controls.Add(this.butCancelar);
            this.panel2.Controls.Add(this.butAceptar);
            this.panel2.Controls.Add(this.tbTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(159, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 318);
            this.panel2.TabIndex = 9;
            // 
            // butBorrarImagen
            // 
            this.butBorrarImagen.Location = new System.Drawing.Point(398, 236);
            this.butBorrarImagen.Name = "butBorrarImagen";
            this.butBorrarImagen.Size = new System.Drawing.Size(126, 23);
            this.butBorrarImagen.TabIndex = 9;
            this.butBorrarImagen.Text = "Borrar Imagen";
            this.butBorrarImagen.UseVisualStyleBackColor = true;
            this.butBorrarImagen.Click += new System.EventHandler(this.ButBorrarImagen_Click);
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(0, 238);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(159, 34);
            this.label.TabIndex = 8;
            this.label.Text = "Editorial:";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(124)))));
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(3, 32);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(521, 24);
            this.tbDescripcion.TabIndex = 16;
            // 
            // FrmLibroUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(695, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labSeparador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLibroUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Libro";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenLibro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label labEditorial;
        private System.Windows.Forms.Label labGenero;
        private System.Windows.Forms.Label labClasificacion;
        private System.Windows.Forms.Label labAutor;
        private System.Windows.Forms.Label labStockDisponible;
        private System.Windows.Forms.TextBox tbStockDisponible;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbEditorial;
        private System.Windows.Forms.PictureBox pbImagenLibro;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butBorrarImagen;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbDescripcion;
    }
}