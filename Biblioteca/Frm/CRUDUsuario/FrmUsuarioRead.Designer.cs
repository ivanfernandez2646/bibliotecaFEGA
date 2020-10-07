namespace Biblioteca.Frm.CRUDUsuario
{
    partial class FrmUsuarioRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioRead));
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.tslAnadir = new System.Windows.Forms.ToolStripLabel();
            this.tslEditar = new System.Windows.Forms.ToolStripLabel();
            this.tslBorrar = new System.Windows.Forms.ToolStripLabel();
            this.tslResetPassword = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslFiltroApellido = new System.Windows.Forms.ToolStripLabel();
            this.tstbFiltroApellido = new System.Windows.Forms.ToolStripTextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicioSesion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poblacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripCabecera
            // 
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAnadir,
            this.tslEditar,
            this.tslBorrar,
            this.tslResetPassword,
            this.toolStripSeparator1,
            this.tslFiltroApellido,
            this.tstbFiltroApellido});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Size = new System.Drawing.Size(1043, 33);
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
            this.tslAnadir.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslEditar
            // 
            this.tslEditar.Image = global::Biblioteca.Properties.Resources.iconEditar1;
            this.tslEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslEditar.Name = "tslEditar";
            this.tslEditar.Size = new System.Drawing.Size(27, 30);
            this.tslEditar.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslBorrar
            // 
            this.tslBorrar.Image = global::Biblioteca.Properties.Resources.iconBorrar;
            this.tslBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslBorrar.Name = "tslBorrar";
            this.tslBorrar.Size = new System.Drawing.Size(30, 30);
            this.tslBorrar.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // tslResetPassword
            // 
            this.tslResetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tslResetPassword.Image = global::Biblioteca.Properties.Resources.resetPassword1;
            this.tslResetPassword.Name = "tslResetPassword";
            this.tslResetPassword.Size = new System.Drawing.Size(16, 30);
            this.tslResetPassword.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tslFiltroApellido
            // 
            this.tslFiltroApellido.Name = "tslFiltroApellido";
            this.tslFiltroApellido.Size = new System.Drawing.Size(51, 30);
            this.tslFiltroApellido.Text = "Apellido";
            // 
            // tstbFiltroApellido
            // 
            this.tstbFiltroApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbFiltroApellido.Name = "tstbFiltroApellido";
            this.tstbFiltroApellido.Size = new System.Drawing.Size(100, 33);
            this.tstbFiltroApellido.TextChanged += new System.EventHandler(this.TstbFiltroDni_TextChanged);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Prestamo,
            this.Salt,
            this.Nombre,
            this.Apellidos,
            this.InicioSesion,
            this.Direccion,
            this.Poblacion,
            this.CodigoPostal,
            this.Provincia,
            this.Telefono1,
            this.Telefono2});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 33);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1043, 238);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellDoubleClick);
            this.dgvUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvUsuarios_KeyDown);
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Prestamo
            // 
            this.Prestamo.DataPropertyName = "Prestamo";
            this.Prestamo.HeaderText = "Prestamo";
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.ReadOnly = true;
            this.Prestamo.Visible = false;
            // 
            // Salt
            // 
            this.Salt.DataPropertyName = "Salt";
            this.Salt.HeaderText = "Salt";
            this.Salt.Name = "Salt";
            this.Salt.ReadOnly = true;
            this.Salt.Visible = false;
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
            // InicioSesion
            // 
            this.InicioSesion.DataPropertyName = "InicioSesion";
            this.InicioSesion.HeaderText = "InicioDeSesion";
            this.InicioSesion.Name = "InicioSesion";
            this.InicioSesion.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Poblacion
            // 
            this.Poblacion.DataPropertyName = "Poblacion";
            this.Poblacion.HeaderText = "Poblacion";
            this.Poblacion.Name = "Poblacion";
            this.Poblacion.ReadOnly = true;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.DataPropertyName = "CodigoPostal";
            this.CodigoPostal.HeaderText = "Codigo Postal";
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Telefono1
            // 
            this.Telefono1.DataPropertyName = "Telefono1";
            this.Telefono1.HeaderText = "Telefono1";
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            // 
            // Telefono2
            // 
            this.Telefono2.DataPropertyName = "Telefono2";
            this.Telefono2.HeaderText = "Telefono2";
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.reiniciarContraseñaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 92);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // reiniciarContraseñaToolStripMenuItem
            // 
            this.reiniciarContraseñaToolStripMenuItem.Name = "reiniciarContraseñaToolStripMenuItem";
            this.reiniciarContraseñaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reiniciarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.reiniciarContraseñaToolStripMenuItem.Text = "Reiniciar Contraseña";
            this.reiniciarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLabelsFuncionales_Click);
            // 
            // FrmUsuarioRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 271);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.toolStripCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarioRead";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarioRead_Load);
            this.toolStripCabecera.ResumeLayout(false);
            this.toolStripCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripCabecera;
        private System.Windows.Forms.ToolStripLabel tslAnadir;
        private System.Windows.Forms.ToolStripLabel tslEditar;
        private System.Windows.Forms.ToolStripLabel tslBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslFiltroApellido;
        private System.Windows.Forms.ToolStripTextBox tstbFiltroApellido;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ToolStripLabel tslResetPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InicioSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poblacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarContraseñaToolStripMenuItem;
    }
}