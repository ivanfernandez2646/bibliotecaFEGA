namespace Biblioteca.Frm.CRUDClasificacion
{
    partial class FrmClasificacionRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClasificacionRead));
            this.tsCabecera = new System.Windows.Forms.ToolStrip();
            this.tslAnadir = new System.Windows.Forms.ToolStripLabel();
            this.tslEditar = new System.Windows.Forms.ToolStripLabel();
            this.tslBorrar = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tslFiltro = new System.Windows.Forms.ToolStripLabel();
            this.tstbFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.dgvClasificaciones = new System.Windows.Forms.DataGridView();
            this.ClasificacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificaciones)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCabecera
            // 
            this.tsCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAnadir,
            this.tslEditar,
            this.tslBorrar,
            this.tsSeparator,
            this.tslFiltro,
            this.tstbFiltro});
            this.tsCabecera.Location = new System.Drawing.Point(0, 0);
            this.tsCabecera.Name = "tsCabecera";
            this.tsCabecera.Size = new System.Drawing.Size(633, 33);
            this.tsCabecera.TabIndex = 0;
            this.tsCabecera.Text = "toolStrip1";
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
            this.tslAnadir.ToolTipText = "Añadir Clasificación";
            this.tslAnadir.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslEditar
            // 
            this.tslEditar.Image = global::Biblioteca.Properties.Resources.iconEditar1;
            this.tslEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslEditar.Name = "tslEditar";
            this.tslEditar.Size = new System.Drawing.Size(27, 30);
            this.tslEditar.ToolTipText = "Editar Clasificación";
            this.tslEditar.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslBorrar
            // 
            this.tslBorrar.Image = global::Biblioteca.Properties.Resources.iconBorrar;
            this.tslBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslBorrar.Name = "tslBorrar";
            this.tslBorrar.Size = new System.Drawing.Size(30, 30);
            this.tslBorrar.ToolTipText = "Eliminar Clasificación";
            this.tslBorrar.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // tslFiltro
            // 
            this.tslFiltro.Name = "tslFiltro";
            this.tslFiltro.Size = new System.Drawing.Size(69, 30);
            this.tslFiltro.Text = "Descripción";
            // 
            // tstbFiltro
            // 
            this.tstbFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbFiltro.Name = "tstbFiltro";
            this.tstbFiltro.Size = new System.Drawing.Size(100, 33);
            this.tstbFiltro.TextChanged += new System.EventHandler(this.tstbFiltro_TextChanged);
            // 
            // dgvClasificaciones
            // 
            this.dgvClasificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClasificacionId,
            this.Descripción,
            this.Libro});
            this.dgvClasificaciones.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvClasificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClasificaciones.Location = new System.Drawing.Point(0, 33);
            this.dgvClasificaciones.MultiSelect = false;
            this.dgvClasificaciones.Name = "dgvClasificaciones";
            this.dgvClasificaciones.ReadOnly = true;
            this.dgvClasificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasificaciones.Size = new System.Drawing.Size(633, 238);
            this.dgvClasificaciones.TabIndex = 1;
            this.dgvClasificaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClasificacion_CellDoubleClick);
            this.dgvClasificaciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvClasificacion_KeyDown);
            // 
            // ClasificacionId
            // 
            this.ClasificacionId.DataPropertyName = "ClasificacionId";
            this.ClasificacionId.HeaderText = "ClasificacionId";
            this.ClasificacionId.Name = "ClasificacionId";
            this.ClasificacionId.ReadOnly = true;
            this.ClasificacionId.Visible = false;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
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
            // FrmClasificacionRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 271);
            this.Controls.Add(this.dgvClasificaciones);
            this.Controls.Add(this.tsCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClasificacionRead";
            this.Text = "Clasificaciones";
            this.Load += new System.EventHandler(this.FrmClasificacionRead_Load);
            this.tsCabecera.ResumeLayout(false);
            this.tsCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificaciones)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCabecera;
        private System.Windows.Forms.ToolStripLabel tslAnadir;
        private System.Windows.Forms.ToolStripLabel tslEditar;
        private System.Windows.Forms.ToolStripLabel tslBorrar;
        private System.Windows.Forms.DataGridView dgvClasificaciones;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripLabel tslFiltro;
        private System.Windows.Forms.ToolStripTextBox tstbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClasificacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}