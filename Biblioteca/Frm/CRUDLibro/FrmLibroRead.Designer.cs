namespace Biblioteca.Frm.CRUDLibro
{
    partial class FrmLibroRead
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibroRead));
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tslFiltroTitulo = new System.Windows.Forms.ToolStripLabel();
            this.tstbFiltroTitulo = new System.Windows.Forms.ToolStripTextBox();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.LibroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutorAutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClasificacionClasificacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroGeneroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditorialEditorialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.tslAnadir = new System.Windows.Forms.ToolStripLabel();
            this.tslEditar = new System.Windows.Forms.ToolStripLabel();
            this.tslBorrar = new System.Windows.Forms.ToolStripLabel();
            this.tslImagen = new System.Windows.Forms.ToolStripLabel();
            this.toolStripCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripCabecera
            // 
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAnadir,
            this.tslEditar,
            this.tslBorrar,
            this.tslImagen,
            this.tsSeparator,
            this.tslFiltroTitulo,
            this.tstbFiltroTitulo});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Size = new System.Drawing.Size(633, 33);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // tslFiltroTitulo
            // 
            this.tslFiltroTitulo.Name = "tslFiltroTitulo";
            this.tslFiltroTitulo.Size = new System.Drawing.Size(37, 30);
            this.tslFiltroTitulo.Text = "Título";
            // 
            // tstbFiltroTitulo
            // 
            this.tstbFiltroTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbFiltroTitulo.Name = "tstbFiltroTitulo";
            this.tstbFiltroTitulo.Size = new System.Drawing.Size(100, 33);
            this.tstbFiltroTitulo.TextChanged += new System.EventHandler(this.TstbFiltroTitulo_TextChanged);
            // 
            // dgvLibro
            // 
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagen,
            this.LibroId,
            this.Titulo,
            this.Descripcion,
            this.Stock,
            this.Libro,
            this.AutorAutorId,
            this.ClasificacionClasificacionId,
            this.GeneroGeneroId,
            this.EditorialEditorialId,
            this.Autor,
            this.Clasificacion,
            this.Genero,
            this.Editorial,
            this.Prestamo});
            this.dgvLibro.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibro.Location = new System.Drawing.Point(0, 33);
            this.dgvLibro.MultiSelect = false;
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.ReadOnly = true;
            this.dgvLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibro.Size = new System.Drawing.Size(633, 238);
            this.dgvLibro.TabIndex = 1;
            this.dgvLibro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibro_CellDoubleClick);
            // 
            // LibroId
            // 
            this.LibroId.DataPropertyName = "LibroId";
            this.LibroId.HeaderText = "LibroId";
            this.LibroId.Name = "LibroId";
            this.LibroId.ReadOnly = true;
            this.LibroId.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripción";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "StockDisponible";
            this.Libro.HeaderText = "Stock Disponible";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // AutorAutorId
            // 
            this.AutorAutorId.DataPropertyName = "AutorAutorId";
            this.AutorAutorId.HeaderText = "AutorAutorId";
            this.AutorAutorId.Name = "AutorAutorId";
            this.AutorAutorId.ReadOnly = true;
            this.AutorAutorId.Visible = false;
            // 
            // ClasificacionClasificacionId
            // 
            this.ClasificacionClasificacionId.DataPropertyName = "ClasificacionClasificacionId";
            this.ClasificacionClasificacionId.HeaderText = "ClasificacionClasificacionId";
            this.ClasificacionClasificacionId.Name = "ClasificacionClasificacionId";
            this.ClasificacionClasificacionId.ReadOnly = true;
            this.ClasificacionClasificacionId.Visible = false;
            // 
            // GeneroGeneroId
            // 
            this.GeneroGeneroId.DataPropertyName = "GeneroGeneroId";
            this.GeneroGeneroId.HeaderText = "GeneroGeneroId";
            this.GeneroGeneroId.Name = "GeneroGeneroId";
            this.GeneroGeneroId.ReadOnly = true;
            this.GeneroGeneroId.Visible = false;
            // 
            // EditorialEditorialId
            // 
            this.EditorialEditorialId.DataPropertyName = "EditorialEditorialId";
            this.EditorialEditorialId.HeaderText = "EditorialEditorialId";
            this.EditorialEditorialId.Name = "EditorialEditorialId";
            this.EditorialEditorialId.ReadOnly = true;
            this.EditorialEditorialId.Visible = false;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Visible = false;
            // 
            // Clasificacion
            // 
            this.Clasificacion.DataPropertyName = "Clasificacion";
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            this.Clasificacion.Visible = false;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Visible = false;
            // 
            // Editorial
            // 
            this.Editorial.DataPropertyName = "Editorial";
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            this.Editorial.Visible = false;
            // 
            // Prestamo
            // 
            this.Prestamo.DataPropertyName = "Prestamo";
            this.Prestamo.HeaderText = "Prestamo";
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.ReadOnly = true;
            this.Prestamo.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.imagenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 92);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.imagenToolStripMenuItem.Text = "Imagen";
            this.imagenToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.DataPropertyName = "Imagen";
            this.dataGridViewImageColumn1.HeaderText = "Imagen";
            this.dataGridViewImageColumn1.Image = global::Biblioteca.Properties.Resources.devolverLibro;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 67;
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Imagen.DataPropertyName = "Imagen";
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Image = global::Biblioteca.Properties.Resources.devolverLibro;
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 67;
            // 
            // tslAnadir
            // 
            this.tslAnadir.AutoSize = false;
            this.tslAnadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tslAnadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslAnadir.Image = global::Biblioteca.Properties.Resources.iconAnadir1;
            this.tslAnadir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslAnadir.Name = "tslAnadir";
            this.tslAnadir.Size = new System.Drawing.Size(30, 30);
            this.tslAnadir.ToolTipText = "Añadir Libro";
            this.tslAnadir.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslEditar
            // 
            this.tslEditar.Image = global::Biblioteca.Properties.Resources.iconEditar1;
            this.tslEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslEditar.Name = "tslEditar";
            this.tslEditar.Size = new System.Drawing.Size(27, 30);
            this.tslEditar.ToolTipText = "Editar Libro";
            this.tslEditar.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslBorrar
            // 
            this.tslBorrar.Image = global::Biblioteca.Properties.Resources.iconBorrar;
            this.tslBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslBorrar.Name = "tslBorrar";
            this.tslBorrar.Size = new System.Drawing.Size(30, 30);
            this.tslBorrar.ToolTipText = "Eliminar Libro";
            this.tslBorrar.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslImagen
            // 
            this.tslImagen.Image = global::Biblioteca.Properties.Resources.imagenVerFotoFinal;
            this.tslImagen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslImagen.Name = "tslImagen";
            this.tslImagen.Size = new System.Drawing.Size(30, 30);
            this.tslImagen.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // FrmLibroRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 271);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.toolStripCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLibroRead";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmLibroRead_Load);
            this.toolStripCabecera.ResumeLayout(false);
            this.toolStripCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripCabecera;
        private System.Windows.Forms.ToolStripLabel tslAnadir;
        private System.Windows.Forms.ToolStripLabel tslEditar;
        private System.Windows.Forms.ToolStripLabel tslBorrar;
        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripLabel tslFiltroTitulo;
        private System.Windows.Forms.ToolStripTextBox tstbFiltroTitulo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorAutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClasificacionClasificacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroGeneroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditorialEditorialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
        private System.Windows.Forms.ToolStripLabel tslImagen;
    }
}