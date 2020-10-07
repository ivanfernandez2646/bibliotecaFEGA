namespace Biblioteca.Frm.CRUDAutor
{
    partial class FrmAutorRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutorRead));
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.tslAnadir = new System.Windows.Forms.ToolStripLabel();
            this.tslEditar = new System.Windows.Forms.ToolStripLabel();
            this.tslBorrar = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tslFiltroApellidos = new System.Windows.Forms.ToolStripLabel();
            this.tstbFiltroApellidos = new System.Windows.Forms.ToolStripTextBox();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.AutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripCabecera
            // 
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAnadir,
            this.tslEditar,
            this.tslBorrar,
            this.tsSeparator,
            this.tslFiltroApellidos,
            this.tstbFiltroApellidos});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Size = new System.Drawing.Size(633, 33);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
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
            this.tslAnadir.ToolTipText = "Añadir Autor";
            this.tslAnadir.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslEditar
            // 
            this.tslEditar.Image = global::Biblioteca.Properties.Resources.iconEditar1;
            this.tslEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslEditar.Name = "tslEditar";
            this.tslEditar.Size = new System.Drawing.Size(27, 30);
            this.tslEditar.ToolTipText = "Editar Autor";
            this.tslEditar.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslBorrar
            // 
            this.tslBorrar.Image = global::Biblioteca.Properties.Resources.iconBorrar;
            this.tslBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslBorrar.Name = "tslBorrar";
            this.tslBorrar.Size = new System.Drawing.Size(30, 30);
            this.tslBorrar.ToolTipText = "Eliminar Autor";
            this.tslBorrar.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // tslFiltroApellidos
            // 
            this.tslFiltroApellidos.Name = "tslFiltroApellidos";
            this.tslFiltroApellidos.Size = new System.Drawing.Size(56, 30);
            this.tslFiltroApellidos.Text = "Apellidos";
            // 
            // tstbFiltroApellidos
            // 
            this.tstbFiltroApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbFiltroApellidos.Name = "tstbFiltroApellidos";
            this.tstbFiltroApellidos.Size = new System.Drawing.Size(100, 33);
            this.tstbFiltroApellidos.TextChanged += new System.EventHandler(this.TstbFiltroApellidos_TextChanged);
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutorId,
            this.Nombre,
            this.Apellidos,
            this.Libro});
            this.dgvAutores.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAutores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAutores.Location = new System.Drawing.Point(0, 33);
            this.dgvAutores.MultiSelect = false;
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutores.Size = new System.Drawing.Size(633, 238);
            this.dgvAutores.TabIndex = 1;
            this.dgvAutores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAutores_CellDoubleClick);
            this.dgvAutores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvAutores_KeyDown);
            // 
            // AutorId
            // 
            this.AutorId.DataPropertyName = "AutorId";
            this.AutorId.HeaderText = "AutorId";
            this.AutorId.Name = "AutorId";
            this.AutorId.ReadOnly = true;
            this.AutorId.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "Libro";
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            this.Libro.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 70);
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
            // FrmAutorRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 271);
            this.Controls.Add(this.dgvAutores);
            this.Controls.Add(this.toolStripCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAutorRead";
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.FrmAutorRead_Load);
            this.toolStripCabecera.ResumeLayout(false);
            this.toolStripCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripCabecera;
        private System.Windows.Forms.ToolStripLabel tslAnadir;
        private System.Windows.Forms.ToolStripLabel tslEditar;
        private System.Windows.Forms.ToolStripLabel tslBorrar;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripLabel tslFiltroApellidos;
        private System.Windows.Forms.ToolStripTextBox tstbFiltroApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}