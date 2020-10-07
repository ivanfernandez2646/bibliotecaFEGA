namespace Biblioteca.Frm.CRUDPrestamo
{
    partial class FrmPrestamoHistoricoRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamoHistoricoRead));
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsCabecera = new System.Windows.Forms.ToolStrip();
            this.tslFiltro = new System.Windows.Forms.ToolStripLabel();
            this.tstbFiltro = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
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
            this.fechaFin,
            this.fechaDevolucion});
            this.dgvPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamo.Location = new System.Drawing.Point(0, 25);
            this.dgvPrestamo.MultiSelect = false;
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.ReadOnly = true;
            this.dgvPrestamo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPrestamo.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamo.Size = new System.Drawing.Size(800, 425);
            this.dgvPrestamo.TabIndex = 5;
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
            // fechaDevolucion
            // 
            this.fechaDevolucion.DataPropertyName = "fechaDevolucion";
            this.fechaDevolucion.HeaderText = "Fecha de Devolución";
            this.fechaDevolucion.Name = "fechaDevolucion";
            this.fechaDevolucion.ReadOnly = true;
            this.fechaDevolucion.Width = 123;
            // 
            // tsCabecera
            // 
            this.tsCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFiltro,
            this.tstbFiltro});
            this.tsCabecera.Location = new System.Drawing.Point(0, 0);
            this.tsCabecera.Name = "tsCabecera";
            this.tsCabecera.Size = new System.Drawing.Size(800, 25);
            this.tsCabecera.TabIndex = 4;
            this.tsCabecera.Text = "toolStrip1";
            // 
            // tslFiltro
            // 
            this.tslFiltro.Name = "tslFiltro";
            this.tslFiltro.Size = new System.Drawing.Size(112, 22);
            this.tslFiltro.Text = "Nombre y Apellidos";
            // 
            // tstbFiltro
            // 
            this.tstbFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbFiltro.Name = "tstbFiltro";
            this.tstbFiltro.Size = new System.Drawing.Size(100, 25);
            this.tstbFiltro.TextChanged += new System.EventHandler(this.tstbFiltro_TextChanged);
            // 
            // FrmPrestamoHistoricoRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.tsCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrestamoHistoricoRead";
            this.Text = "Histórico Préstamos";
            this.Load += new System.EventHandler(this.FrmPrestamoHistoricoRead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.tsCabecera.ResumeLayout(false);
            this.tsCabecera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.ToolStrip tsCabecera;
        private System.Windows.Forms.ToolStripLabel tslFiltro;
        private System.Windows.Forms.ToolStripTextBox tstbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucion;
    }
}