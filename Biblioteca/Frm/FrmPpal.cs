using AccesoDatos.Model;
using Biblioteca.Frm.CRUDPrestamo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmPpal : Form
    {

        private AccesoDatos.Model.Usuario usuarioIniciado;

        public FrmPpal()
        {
            InitializeComponent();
        }

        public Usuario UsuarioIniciado { get => usuarioIniciado; set => usuarioIniciado = value; }

        //Diferentes listeners para los diferentes ToolStripMenuItem
        private void MenuArchivos_Click(object sender, EventArgs e)
        {
            if (sender == menuItemSalir)
            {
                if (MessageBox.Show("¿Está seguro de que desea salir?", "Salir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if (sender == menuItemAutores)
            {
                CRUDAutor.FrmAutorRead frmReadAutores = new CRUDAutor.FrmAutorRead();
                frmReadAutores.MdiParent = this;
                frmReadAutores.Show();
            }
            else if (sender == menuItemClasificacion)
            {
                CRUDClasificacion.FrmClasificacionRead frmReadCalificaciones = new CRUDClasificacion.FrmClasificacionRead();
                frmReadCalificaciones.MdiParent = this;
                frmReadCalificaciones.Show();
            }
            else if (sender == menuItemGenero)
            {
                CRUDGenero.FrmGeneroRead frmReadGenero = new CRUDGenero.FrmGeneroRead();
                frmReadGenero.MdiParent = this;
                frmReadGenero.Show();
            }
            else if (sender == menuItemEditorial)
            {
                CRUDEditorial.FrmEditorialRead frmReadEditorial = new CRUDEditorial.FrmEditorialRead();
                frmReadEditorial.MdiParent = this;
                frmReadEditorial.Show();
            }
            else if (sender == menuItemLibros)
            {
                CRUDLibro.FrmLibroRead frmLibroRead = new CRUDLibro.FrmLibroRead();
                frmLibroRead.MdiParent = this;
                frmLibroRead.Show();
            }
            else if (sender == menuItemUsuarios)
            {
                CRUDUsuario.FrmUsuarioRead frmUsuarioRead = new CRUDUsuario.FrmUsuarioRead();
                frmUsuarioRead.MdiParent = this;
                frmUsuarioRead.Show();
            }
            else if (sender == menuItemConfiguracion)
            {
                FrmConfiguracionUpdate frmConfiguracionUpdate = new FrmConfiguracionUpdate();
                if (frmConfiguracionUpdate.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Configuración actualizada correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuPrestamos_Click(object sender, EventArgs e)
        {
            if (sender == menuItemPrestamos)
            {
                FrmPrestamoRead frmPrestamoRead = new FrmPrestamoRead();
                frmPrestamoRead.MdiParent = this;
                frmPrestamoRead.Show();
            }
            else if (sender == menuItemHistorico)
            {
                CRUDPrestamo.FrmPrestamoHistoricoRead frmPrestamoHistoricoRead = new CRUDPrestamo.FrmPrestamoHistoricoRead();
                frmPrestamoHistoricoRead.MdiParent = this;
                frmPrestamoHistoricoRead.Show();
            }
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        private void MenuItemCambiarContraseña_Click(object sender, EventArgs e)
        {
            CRUDUsuario.FrmUsuarioNewPassword frmUsuarioNewPassword = new CRUDUsuario.FrmUsuarioNewPassword(this.usuarioIniciado);
            if(frmUsuarioNewPassword.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Contraseña actualizada para usuario: " + usuarioIniciado.DNI, this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //Mostramos el diálogo FrmLogin al cargar este formulario
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                    Mdi.BackColor = Color.FromArgb(255, 169, 95);
                    Mdi.BackgroundImageLayout = ImageLayout.Stretch;
                    Mdi.BackgroundImage = Biblioteca.Properties.Resources.imagenFondoPpal1;

                }
                catch (Exception a)
                {
                }
            }

            FrmLogin frmLogin = new FrmLogin(this);


            if (frmLogin.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                menuPersonal.Text = usuarioIniciado.Apellidos + ", " + usuarioIniciado.Nombre;
            }
        }


        //Controlamos si hay algún formulario abierto y preguntamos al usuario si quiere cerrar
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Hay formularios abiertos. Si sale se cerrarán, ¿está seguro de que quiere salir?",
                    this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }


        //Organiza los contenedores cada vez que se maximiza o minimiza
        private void FrmPpal_SizeChanged(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        public void refreshAllTables()
        {
            Form[] form = this.MdiChildren;

            for(int i = 0;i < form.Length; i++)
            {
                ((RefreshTables)form[i]).refreshAllTables();
            }
        }
    }
}
