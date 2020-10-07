namespace Biblioteca.Frm
{
    partial class FrmPpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPpal));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuArchivos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditorial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAuxiliares = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClasificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripProyectoWinForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.statusStripProyectoWinForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivos,
            this.menuPrestamos,
            this.menuAyuda,
            this.menuPersonal});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipal.TabIndex = 1;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // menuArchivos
            // 
            this.menuArchivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLibros,
            this.menuItemAutores,
            this.menuItemEditorial,
            this.menuItemUsuarios,
            this.toolStripSeparator1,
            this.menuItemAuxiliares,
            this.toolStripSeparator2,
            this.menuItemSalir});
            this.menuArchivos.Name = "menuArchivos";
            this.menuArchivos.Size = new System.Drawing.Size(65, 20);
            this.menuArchivos.Text = "Archivos";
            // 
            // menuItemLibros
            // 
            this.menuItemLibros.Name = "menuItemLibros";
            this.menuItemLibros.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.menuItemLibros.Size = new System.Drawing.Size(157, 22);
            this.menuItemLibros.Text = "Libros";
            this.menuItemLibros.Click += new System.EventHandler(this.MenuArchivos_Click);
            // 
            // menuItemAutores
            // 
            this.menuItemAutores.Name = "menuItemAutores";
            this.menuItemAutores.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.menuItemAutores.Size = new System.Drawing.Size(157, 22);
            this.menuItemAutores.Text = "Autores";
            this.menuItemAutores.Click += new System.EventHandler(this.MenuArchivos_Click);
            // 
            // menuItemEditorial
            // 
            this.menuItemEditorial.Name = "menuItemEditorial";
            this.menuItemEditorial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.menuItemEditorial.Size = new System.Drawing.Size(157, 22);
            this.menuItemEditorial.Text = "Editorial";
            this.menuItemEditorial.Click += new System.EventHandler(this.MenuArchivos_Click);
            // 
            // menuItemUsuarios
            // 
            this.menuItemUsuarios.Name = "menuItemUsuarios";
            this.menuItemUsuarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.menuItemUsuarios.Size = new System.Drawing.Size(157, 22);
            this.menuItemUsuarios.Text = "Usuarios";
            this.menuItemUsuarios.Click += new System.EventHandler(this.MenuArchivos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // menuItemAuxiliares
            // 
            this.menuItemAuxiliares.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGenero,
            this.menuItemClasificacion,
            this.menuItemConfiguracion});
            this.menuItemAuxiliares.Name = "menuItemAuxiliares";
            this.menuItemAuxiliares.Size = new System.Drawing.Size(157, 22);
            this.menuItemAuxiliares.Text = "Auxiliares";
            // 
            // menuItemGenero
            // 
            this.menuItemGenero.Name = "menuItemGenero";
            this.menuItemGenero.Size = new System.Drawing.Size(150, 22);
            this.menuItemGenero.Text = "Género";
            this.menuItemGenero.Click += new System.EventHandler(this.MenuArchivos_Click);
            // 
            // menuItemClasificacion
            // 
            this.menuItemClasificacion.Name = "menuItemClasificacion";
            this.menuItemClasificacion.Size = new System.Drawing.Size(150, 22);
            this.menuItemClasificacion.Text = "Clasificación";
            this.menuItemClasificacion.Click += new System.EventHandler(this.MenuArchivos_Click);
            // 
            // menuItemConfiguracion
            // 
            this.menuItemConfiguracion.Name = "menuItemConfiguracion";
            this.menuItemConfiguracion.Size = new System.Drawing.Size(150, 22);
            this.menuItemConfiguracion.Text = "Configuración";
            this.menuItemConfiguracion.Click += new System.EventHandler(this.MenuArchivos_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // menuItemSalir
            // 
            this.menuItemSalir.Name = "menuItemSalir";
            this.menuItemSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemSalir.ShowShortcutKeys = false;
            this.menuItemSalir.Size = new System.Drawing.Size(157, 22);
            this.menuItemSalir.Text = "Salir";
            this.menuItemSalir.Click += new System.EventHandler(this.MenuArchivos_Click);
            // 
            // menuPrestamos
            // 
            this.menuPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPrestamos,
            this.menuItemHistorico});
            this.menuPrestamos.Name = "menuPrestamos";
            this.menuPrestamos.Size = new System.Drawing.Size(74, 20);
            this.menuPrestamos.Text = "Préstamos";
            // 
            // menuItemPrestamos
            // 
            this.menuItemPrestamos.Name = "menuItemPrestamos";
            this.menuItemPrestamos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.menuItemPrestamos.Size = new System.Drawing.Size(166, 22);
            this.menuItemPrestamos.Text = "Préstamos";
            this.menuItemPrestamos.Click += new System.EventHandler(this.menuPrestamos_Click);
            // 
            // menuItemHistorico
            // 
            this.menuItemHistorico.Name = "menuItemHistorico";
            this.menuItemHistorico.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.menuItemHistorico.Size = new System.Drawing.Size(166, 22);
            this.menuItemHistorico.Text = "Histórico";
            this.menuItemHistorico.Click += new System.EventHandler(this.menuPrestamos_Click);
            // 
            // menuPersonal
            // 
            this.menuPersonal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuPersonal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCambiarContraseña});
            this.menuPersonal.Name = "menuPersonal";
            this.menuPersonal.Size = new System.Drawing.Size(64, 20);
            this.menuPersonal.Text = "Personal";
            this.menuPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuItemCambiarContraseña
            // 
            this.menuItemCambiarContraseña.Name = "menuItemCambiarContraseña";
            this.menuItemCambiarContraseña.Size = new System.Drawing.Size(180, 22);
            this.menuItemCambiarContraseña.Text = "Cambiar contraseña";
            this.menuItemCambiarContraseña.Click += new System.EventHandler(this.MenuItemCambiarContraseña_Click);
            // 
            // statusStripProyectoWinForm
            // 
            this.statusStripProyectoWinForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusBar});
            this.statusStripProyectoWinForm.Location = new System.Drawing.Point(0, 428);
            this.statusStripProyectoWinForm.Name = "statusStripProyectoWinForm";
            this.statusStripProyectoWinForm.Size = new System.Drawing.Size(800, 22);
            this.statusStripProyectoWinForm.TabIndex = 2;
            this.statusStripProyectoWinForm.Text = "statusStrip1";
            // 
            // toolStripStatusBar
            // 
            this.toolStripStatusBar.Name = "toolStripStatusBar";
            this.toolStripStatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // menuAyuda
            // 
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAcercaDe});
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "Ayuda";
            // 
            // menuItemAcercaDe
            // 
            this.menuItemAcercaDe.Name = "menuItemAcercaDe";
            this.menuItemAcercaDe.Size = new System.Drawing.Size(180, 22);
            this.menuItemAcercaDe.Text = "Acerca de...";
            this.menuItemAcercaDe.Click += new System.EventHandler(this.menuAyuda_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStripProyectoWinForm);
            this.Controls.Add(this.menuStripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FrmPpal";
            this.Text = "Biblioteca FEGA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.SizeChanged += new System.EventHandler(this.FrmPpal_SizeChanged);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.statusStripProyectoWinForm.ResumeLayout(false);
            this.statusStripProyectoWinForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuArchivos;
        private System.Windows.Forms.ToolStripMenuItem menuItemLibros;
        private System.Windows.Forms.ToolStripMenuItem menuItemAutores;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditorial;
        private System.Windows.Forms.ToolStripMenuItem menuItemUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemAuxiliares;
        private System.Windows.Forms.ToolStripMenuItem menuItemGenero;
        private System.Windows.Forms.ToolStripMenuItem menuItemClasificacion;
        private System.Windows.Forms.ToolStripMenuItem menuItemConfiguracion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemSalir;
        private System.Windows.Forms.ToolStripMenuItem menuPrestamos;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrestamos;
        private System.Windows.Forms.ToolStripMenuItem menuItemHistorico;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuItemAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem menuPersonal;
        private System.Windows.Forms.ToolStripMenuItem menuItemCambiarContraseña;
        private System.Windows.Forms.StatusStrip statusStripProyectoWinForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusBar;
    }
}