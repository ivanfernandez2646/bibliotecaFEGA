using AccesoDatos.Model;
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
    public partial class FrmLogin : Form
    {
        private int contadorEntradasErroneas;
        private FrmPpal frmPpal;

        //Es para si se abre un diálogo de error que no cuente como error al darle click al Aceptar del diálogo
        private bool aceptarCorrecto = true;


        public FrmLogin(FrmPpal frmPpal)
        {
            InitializeComponent();
            tbDNI.Focus();
            contadorEntradasErroneas = 0;
            this.frmPpal = frmPpal;
        }

        //Controlamos el Click sobre los botones funcionales(Aceptar, Cancelar)
        private void butFuncionales_Click(object sender, EventArgs e)
        {
            if (sender == butAceptar)
            {
                Usuario usuario = AccesoDatos.Logic.LogicaUsuario.getInstance().listadoUsuario().Where(x => x.DNI == tbDNI.Text).FirstOrDefault();
                if (usuario == null)
                {
                    aceptarCorrecto = false;
                    contadorEntradasErroneas++;
                    if (contadorEntradasErroneas >= 3)
                    {
                        MessageBox.Show("ERROR. El usuario no existe!!\nHas superado el limite de intentos. La aplicación se cerrará.", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        MessageBox.Show("ERROR. El usuario no existe!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                string passwordEncrypt = Password.getPassword(tbDNI.Text, tbPassword.Text);

                if (!passwordEncrypt.Equals(usuario.Salt))
                {
                    aceptarCorrecto = false;
                    contadorEntradasErroneas++;
                    if (contadorEntradasErroneas >= 3)
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("ERROR. La contraseña no coincide!!\nHas superado el limite de intentos. La aplicación se cerrará.", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("ERROR. La contraseña no coincide!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return;
                }

                if (!usuario.InicioSesion.GetValueOrDefault())
                {
                    aceptarCorrecto = false;
                    MessageBox.Show("ERROR. Usuario no tiene permisos de acceso!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.DialogResult = DialogResult.OK;

                Usuario usuarioIniciado = new Usuario();
                usuarioIniciado.DNI = tbDNI.Text;
                usuarioIniciado = AccesoDatos.Logic.LogicaUsuario.getInstance().getUsuario(usuarioIniciado);

                frmPpal.UsuarioIniciado = usuarioIniciado;
                this.Close();
            }
            else if (sender == butCancelar)
            {
                this.Close();
            }
        }


        //Controlamos las teclas de Aceptar y Escape para los TextBox
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (aceptarCorrecto)
                {
                    butAceptar.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                butCancelar.PerformClick();
            }
        }

        //Controlamos la tecla Escape para los botones funcionales
        private void btFuncionales_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                butCancelar.PerformClick();
            }
        }
    }
}
