namespace Biblioteca.Frm.CRUDPrestamo
{
    partial class FrmPrestamoRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamoRead));
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCabecera = new System.Windows.Forms.ToolStrip();
            this.tslAnadir = new System.Windows.Forms.ToolStripLabel();
            this.tslDevolverLibro = new System.Windows.Forms.ToolStripLabel();
            this.tslAmpliarPrestamo = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tslFiltro = new System.Windows.Forms.ToolStripLabel();
            this.tstbFiltro = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tsCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombreApellidos,
            this.libro,
            this.fechaInicio,
            this.fechaFin});
            this.dgvPrestamo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamo.Location = new System.Drawing.Point(0, 33);
            this.dgvPrestamo.MultiSelect = false;
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.ReadOnly = true;
            this.dgvPrestamo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPrestamo.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamo.Size = new System.Drawing.Size(800, 417);
            this.dgvPrestamo.TabIndex = 3;
            this.dgvPrestamo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPrestamo_CellFormatting);
            this.dgvPrestamo.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPrestamo_RowPrePaint);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 43;
            // 
            // nombreApellidos
            // 
            this.nombreApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nombreApellidos.DataPropertyName = "nombreApellidos";
            this.nombreApellidos.HeaderText = "Nombre y Apellidos";
            this.nombreApellidos.Name = "nombreApellidos";
            this.nombreApellidos.ReadOnly = true;
            this.nombreApellidos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreApellidos.Width = 112;
            // 
            // libro
            // 
            this.libro.DataPropertyName = "libro";
            this.libro.HeaderText = "Libro";
            this.libro.Name = "libro";
            this.libro.ReadOnly = true;
            this.libro.Width = 55;
            // 
            // fechaInicio
            // 
            this.fechaInicio.DataPropertyName = "fechaInicio";
            this.fechaInicio.HeaderText = "Fecha de Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.Width = 74;
            // 
            // fechaFin
            // 
            this.fechaFin.DataPropertyName = "fechaFin";
            this.fechaFin.HeaderText = "Fecha de Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            this.fechaFin.Width = 74;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.devolverToolStripMenuItem,
            this.ampliarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 70);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.devolverToolStripMenuItem.Text = "Devolver";
            this.devolverToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // ampliarToolStripMenuItem
            // 
            this.ampliarToolStripMenuItem.Name = "ampliarToolStripMenuItem";
            this.ampliarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ampliarToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ampliarToolStripMenuItem.Text = "Ampliar";
            this.ampliarToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tsCabecera
            // 
            this.tsCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAnadir,
            this.tslDevolverLibro,
            this.tslAmpliarPrestamo,
            this.tsSeparator,
            this.tslFiltro,
            this.tstbFiltro});
            this.tsCabecera.Location = new System.Drawing.Point(0, 0);
            this.tsCabecera.Name = "tsCabecera";
            this.tsCabecera.Size = new System.Drawing.Size(800, 33);
            this.tsCabecera.TabIndex = 2;
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
            this.tslAnadir.ToolTipText = "Añadir Prestamo";
            this.tslAnadir.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslDevolverLibro
            // 
            this.tslDevolverLibro.Image = global::Biblioteca.Properties.Resources.devolverLibro;
            this.tslDevolverLibro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslDevolverLibro.Name = "tslDevolverLibro";
            this.tslDevolverLibro.Size = new System.Drawing.Size(30, 30);
            this.tslDevolverLibro.ToolTipText = "Devolver Libro";
            this.tslDevolverLibro.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslAmpliarPrestamo
            // 
            this.tslAmpliarPrestamo.Image = global::Biblioteca.Properties.Resources.fechaHasta2;
            this.tslAmpliarPrestamo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslAmpliarPrestamo.Name = "tslAmpliarPrestamo";
            this.tslAmpliarPrestamo.Size = new System.Drawing.Size(30, 30);
            this.tslAmpliarPrestamo.ToolTipText = "Ampliar Fecha";
            this.tslAmpliarPrestamo.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // tslFiltro
            // 
            this.tslFiltro.Name = "tslFiltro";
            this.tslFiltro.Size = new System.Drawing.Size(112, 30);
            this.tslFiltro.Text = "Nombre y Apellidos";
            // 
            // tstbFiltro
            // 
            this.tstbFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbFiltro.Name = "tstbFiltro";
            this.tstbFiltro.Size = new System.Drawing.Size(100, 33);
            this.tstbFiltro.TextChanged += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // FrmPrestamoRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.tsCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrestamoRead";
            this.Text = "Préstamo";
            this.Load += new System.EventHandler(this.FrmPrestamoRead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tsCabecera.ResumeLayout(false);
            this.tsCabecera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.ToolStrip tsCabecera;
        private System.Windows.Forms.ToolStripLabel tslAnadir;
        private System.Windows.Forms.ToolStripLabel tslDevolverLibro;
        private System.Windows.Forms.ToolStripLabel tslAmpliarPrestamo;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripLabel tslFiltro;
        private System.Windows.Forms.ToolStripTextBox tstbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliarToolStripMenuItem;
    }
}